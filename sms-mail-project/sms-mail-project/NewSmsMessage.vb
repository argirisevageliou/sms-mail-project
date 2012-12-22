Imports System.Web.HttpUtility
Imports System.Data.OleDb
Imports System.Threading

Public Class NewSmsMessage

    ' έλεγχος σύνδεσης στο internet (δήλωση).
    Private Declare Function InternetGetConnectedState Lib "wininet" _
  (ByRef conn As Long, ByVal val As Long) As Boolean

    Private charCounter As Integer = 0 ' πλήθος χαρακτήρων στο rich text box.
    Private smsCounter As Integer = 1 ' αριθμός sms, ανάλογα με τον αριθμό των χαρακτήρων.

    Public Shared contacts As String 'χρησιμοποιείτε από την ChooseSMSReceivers_Form για ενημέρωση του SmsSendTo tb.

    Public Shared sms_status_lst As New List(Of Object) 'περιέχει address,date and status για κάθε sms που στάλθηκε (ή απέτυχε).
    Public Shared queued As Integer 'πόσα περιμένουν στην ουρά.
    Public Shared failed As Integer 'πόσα απέτυχαν.
    Public Shared delivered As Integer 'πόσα στάλθηκαν με επιτυχία
    Public Shared pending As Integer 'πόσα εκκρεμούν.
    Public Shared _error As Integer 'αν δεν βρέθηκε κανένας αποδέκτης

    Public Shared isScheduled As Boolean 'αν η αποστολή έχει γίνει τώρα ή έχει προγραμματιστεί για αργότερα.
    Public Shared sendDate As String ' η ημερομηνία αποστολής του προγραμματισμένου SMS.

    Private isSent As Boolean = False ' αν το sms στάλθηκε, στην onComplete του backgroundWorker, γίνεται αποθήκευση.
    Private errorOccured As Boolean = False ' αν συμβεί exception στην do_work δεν εκτελώ τον κώδικα στην nComplete.

    'μενου Edit που περιλαμβανει τα παρακατω
    Private Sub UndoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoToolStripMenuItem.Click
        SmsRichTextBox.Undo()
    End Sub

    Private Sub RedoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RedoToolStripMenuItem.Click
        SmsRichTextBox.Redo()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CutToolStripMenuItem.Click
        SmsRichTextBox.Cut()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        SmsRichTextBox.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripMenuItem.Click
        SmsRichTextBox.Paste()
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectAllToolStripMenuItem.Click
        SmsRichTextBox.SelectAll()
    End Sub

    ' SmsSearchGroupBtn_Click, ανοίγει η φόρμα ChooseSMSReceivers_Form για επιλογή παραληπτών.
    Private Sub SmsSearchGroupBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SmsSearchGroupBtn.Click

        Dim choose As New ChooseSMSReceivers_Form()
        choose.StartPosition = FormStartPosition.CenterParent
        contacts = SmsSendTo_tb.Text
        choose.ShowDialog()
        SmsSendTo_tb.Text = contacts ' βάζω στο SendTo tb, τα εμαιλ χωρισμένα με ';'.
        contacts = ""
        choose = Nothing

    End Sub

    ' SmsSearchAccount_btn_Click, ανοίγει η φόρμα SMS_Account_Manager, για ρύθμιση λογαριασμού.
    Private Sub SmsSearchAccount_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SmsSearchAccount_btn.Click

        Dim manager As SMS_Account_Manager
        manager = New SMS_Account_Manager
        manager.StartPosition = FormStartPosition.CenterParent
        manager.ShowDialog()
        manager = Nothing

        ' αν ρυθμιστεί ο λογαριασμός, βάζω στο SmsFrom_tb το senderID
        If (My.Settings.SMSsenderID <> "" And My.Settings.SMSusername <> "" And My.Settings.SMSpassword <> "") Then
            SmSFrom_tb.Text = My.Settings.SMSsenderID
            SmSFrom_tb.ReadOnly = True
            SmsSearchAccount_btn.Visible = False
        End If

    End Sub

    ' on load, αν υπάρχει ρυθμισμένος λογαριασμός, βάζω στο SmsFrom_tb το senderID
    Private Sub NewSmsMessage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If (My.Settings.SMSsenderID <> "" And My.Settings.SMSusername <> "" And My.Settings.SMSpassword <> "") Then
            SmSFrom_tb.Text = My.Settings.SMSsenderID
            SmSFrom_tb.ReadOnly = True
            balance_btn.Enabled = True
        Else
            SmsSearchAccount_btn.Visible = True
        End If

    End Sub

    ' άνοιγμα account manager από το menu-tools.
    Private Sub SmsAccountManagerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SmsAccountManagerToolStripMenuItem.Click

        Dim manager As SMS_Account_Manager
        manager = New SMS_Account_Manager
        manager.StartPosition = FormStartPosition.CenterParent
        manager.ShowDialog()
        manager = Nothing

        ' αν μετά το κλείσιμο του dialog έχει ρυθμιστεί λογαριασμός τον εμφανίζουμε στο From text box.
        If (My.Settings.SMSsenderID <> "" And My.Settings.SMSusername <> "" And My.Settings.SMSpassword <> "") Then
            SmSFrom_tb.Text = My.Settings.SMSsenderID
            SmSFrom_tb.ReadOnly = True
            SmsSearchAccount_btn.Visible = False
        Else ' αν έχει διαγραφεί - δεν έχει ρυθμιστεί ο λογαριασμός 'αδειάζω' το from text box.
            SmSFrom_tb.Text = ""
            SmsSearchAccount_btn.Visible = True
        End If

    End Sub

    ' εκτελείτε όταν η φόρμα ενεργοποιείτε (gain focus).
    Private Sub NewSmsMessage_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated

        ' αν μετά το κλείσιμο του dialog έχει ρυθμιστεί λογαριασμός τον εμφανίζουμε στο From text box.
        If (My.Settings.SMSsenderID <> "" And My.Settings.SMSusername <> "" And My.Settings.SMSpassword <> "") Then
            SmSFrom_tb.Text = My.Settings.SMSsenderID
            SmSFrom_tb.ReadOnly = True
            SmsSearchAccount_btn.Visible = False
            balance_btn.Enabled = True
        Else ' αν έχει διαγραφεί - δεν έχει ρυθμιστεί ο λογαριασμός 'αδειάζω' το from text box.
            SmSFrom_tb.Text = ""
            SmsSearchAccount_btn.Visible = True
            balance_btn.Enabled = False
        End If

    End Sub

    ' Click event του κουμιού Send.
    Private Sub SendToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SendToolStripMenuItem.Click

        ' αν δεν έχει ρυθμιστεί ο λογαριασμός εμφανίζω το dialog για ρύθμηση του λογαριασμού.
        If (My.Settings.SMSsenderID = "" Or My.Settings.SMSpassword = "" Or My.Settings.SMSpassword = "" Or SmSFrom_tb.Text = "") Then

            Dim manager As SMS_Account_Manager
            manager = New SMS_Account_Manager
            manager.StartPosition = FormStartPosition.CenterParent
            manager.ShowDialog()
            manager = Nothing

            ' αν ρυθμιστεί ο λογαριασμός, βάζω στο SmsFrom_tb το senderID
            If (My.Settings.SMSsenderID <> "" And My.Settings.SMSusername <> "" And My.Settings.SMSpassword <> "") Then
                SmSFrom_tb.Text = My.Settings.SMSsenderID
                SmSFrom_tb.ReadOnly = True
                SmsSearchAccount_btn.Visible = False
            End If

            ' αν το πεδίο με τους παραλείπτες είναι κενό, εμφανίζω το dialog για εισαγωγή παραληπτών.
        ElseIf (SmsSendTo_tb.Text = "") Then

            Dim choose As New ChooseSMSReceivers_Form()
            choose.StartPosition = FormStartPosition.CenterParent
            contacts = SmsSendTo_tb.Text
            choose.ShowDialog()
            SmsSendTo_tb.Text = contacts ' βάζω στο SendTo tb, τα phone numbers χωρισμένα με ';'.
            contacts = ""
            choose = Nothing

            ' αν έχει ρυθμιστεί λογαριασμός, εμφανίζω το dialog για άμεση αποστολή ή προγραμματισμό της αποστολής.
        ElseIf (My.Settings.SMSsenderID <> "" And My.Settings.SMSpassword <> "" And My.Settings.SMSpassword <> "" And SmSFrom_tb.Text <> "") Then

            ' εμφανίζω την φόρμα για επιλογή προγραμματισμού ή όχι της αποστολής.
            Dim sch As New ScheduleSMSForm()
            sch.StartPosition = FormStartPosition.CenterParent

            sch.ShowDialog()
            sch = Nothing

            ' αν ο χρήστης ζήτησε προγραμματισμό της αποστολής.
            If (isScheduled) Then

                'έλεγχος σύνδεσης στο internet.
                Dim Out As Integer
                If InternetGetConnectedState(Out, 0) = True Then
                    Me.Text += " (Sending....)" ' Αρχίζει η διαδικασία της αποστολής και βάζω το (Sending....) στον τίτλο της φόρμας για ενημέρωση του χρήστη.
                    SendToolStripMenuItem.Enabled = False

                    Dim _to As String()
                    'χωρίζω το string με delimeter character το ; και βάζω τα phone numbers στο πίνακα.
                    _to = SmsSendTo_tb.Text.Split(";")

                    Dim parameter_obj = New With {Key .recipents = _to, .text = SmsRichTextBox.Text} ' αποθήκευση αντικειμένου στη λίστα (χρησιμοποιείτε από τη SMSresults form).
                    worker.RunWorkerAsync(parameter_obj)

                    ' Αν δεν υπάρχει σύνδεση στο internet.
                Else
                    MsgBox("Internet connection error!!")
                End If

                ' αν δεν έχει επιλεγεί προγραμματισμός αποστολής καλώ τη μέθοδο startSending() για άμεση αποστολή.
            Else

                startSending()
                SendToolStripMenuItem.Enabled = False
            End If

        End If

    End Sub

    'send sms method
    Private Sub startSending()

        ' έλεγχος σύνδεσης στο internet.
        Dim Out As Integer
        If InternetGetConnectedState(Out, 0) = True Then
            Me.Text += " (Sending....)" ' Αρχίζει η διαδικασία της αποστολής και βάζω το (Sending....) στον τίτλο της φόρμας για ενημέρωση του χρήστη.
            Dim _to As String()
            'χωρίζω το string με delimeter character το ; και βάζω τα phone numbers στο πίνακα.
            _to = SmsSendTo_tb.Text.Split(";")

            Dim parameter_obj = New With {Key .recipents = _to, .text = SmsRichTextBox.Text} ' αποθήκευση αντικειμένου στη λίστα (χρησιμοποιείτε από τη SMSresults form).

            worker.RunWorkerAsync(parameter_obj)

            ' Αν δεν υπάρχει σύνδεση στο internet.
        Else
            MsgBox("Internet connection error!!")
        End If

    End Sub

    'SmsRichTextBox_KeyPress
    Private Sub SmsRichTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles SmsRichTextBox.KeyPress

        ' αν το πλήκτρο που πατήθηκε ήτανε το backspase(διαγραφή),ενημερώνω τους counters.
        If (e.KeyChar = ChrW(Keys.Back)) Then
            If (charCounter = 0) Then
                Exit Sub
            End If
            charCounter = SmsRichTextBox.TextLength
            charCount_lb.ForeColor = Color.Black
            charCount_lb.Text = charCounter

            UpdateSmsCounter() ' ενημέρωση του smsCounter.

            ' αν το κείμενο ξεπεράσει τους 1224 χαρακτήρες, το label που μετράει χαρακτήρες γίνεται κόκκινο, και δεν επιτρέπεται επιπλέον εισαγωγή χαρακτήρων. 
        Else

            charCounter = SmsRichTextBox.TextLength + 1
            If (charCounter > 1224) Then
                e.Handled = True ' ακύρωση εισαγωγής χαρακτήρα στο rich text box.
                charCount_lb.ForeColor = Color.Red
            Else
                charCount_lb.ForeColor = Color.Black
                charCount_lb.Text = charCounter
            End If

            UpdateSmsCounter() ' ενημέρωση του smsCounter.

        End If

    End Sub

    'SmsRichTextBox_KeyDown
    Private Sub SmsRichTextBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles SmsRichTextBox.KeyDown
        ' ακυρώνω τη λειτουργία των πλήκτρων enter και delete.
        If (e.KeyCode = Keys.Delete Or e.KeyCode = Keys.Enter) Then
            e.Handled = True
            e.SuppressKeyPress = True ' δεν καλείτε το event keypress
        End If

    End Sub

    ' ενημέρωση του smsCounter ανάλογα με τον αριθμό των χαρακτήρων στο rich text box.
    Private Sub UpdateSmsCounter()

        If (charCounter <= 160) Then
            smsCounter = 1
            smsCount_lb.Text = smsCounter
        ElseIf (charCounter <= 306) Then
            smsCounter = 2
            smsCount_lb.Text = smsCounter
        ElseIf (charCounter <= 459) Then
            smsCounter = 3
            smsCount_lb.Text = smsCounter
        ElseIf (charCounter <= 612) Then
            smsCounter = 4
            smsCount_lb.Text = smsCounter
        ElseIf (charCounter <= 765) Then
            smsCounter = 5
            smsCount_lb.Text = smsCounter
        ElseIf (charCounter <= 918) Then
            smsCounter = 6
            smsCount_lb.Text = smsCounter
        ElseIf (charCounter <= 1071) Then
            smsCounter = 7
            smsCount_lb.Text = smsCounter
        ElseIf (charCounter <= 1224) Then
            smsCounter = 8
            smsCount_lb.Text = smsCounter
        End If

    End Sub

    Private Sub SaveSentSms()
        Dim connection As OleDbConnection
        Dim command As OleDbCommand
        Dim timeStamp As DateTime = DateTime.Now
        Dim insertquery As String = "INSERT INTO sentsms(subject,senders,sms,hmer_wra) VALUES('" & "" & _
            "','" & SmsSendTo_tb.Text & "','" & SmsRichTextBox.Text & "','" & timeStamp & "');"

        Try
            connection = New OleDbConnection(My.Settings.testConnectionString)
            command = New OleDbCommand(insertquery, connection)
            connection.Open()
            command.ExecuteNonQuery()
            connection.Close()

        Catch ex1 As Exception
            MessageBox.Show(ex1.Message)
        End Try
    End Sub

    ' worker (Do_Work)
    Private Sub worker_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles worker.DoWork

        If (isScheduled) Then

            ' δημιουργία ενώς αντικειμένου τύπου SMS_Service.smsPortTypeClient για να ελέγξω το λογαριασμό.
            Dim client1 As New SMS_Service.smsPortTypeClient()
            Dim ID1 As String = ""

            Dim par_obj1 As New Object
            par_obj1 = e.Argument

            Dim _to1 As String() = par_obj1.recipents
            Dim smsText1 As String = par_obj1.text

            ' προσπάθεια αποστολής.
            Try
                ID1 = client1.send(My.Settings.SMSusername, My.Settings.SMSpassword, _
                My.Settings.SMSsenderID, _to1, smsText1, "GSM", False, sendDate, "")
                errorOccured = False
            Catch ex As Exception
                MsgBox(ex.Message)
                errorOccured = True
            End Try

        Else

            ' δημιουργία ενώς αντικειμένου τύπου SMS_Service.smsPortTypeClient για να ελέγξω το λογαριασμό.
            Dim client As New SMS_Service.smsPortTypeClient()

            Dim par_obj As New Object
            par_obj = e.Argument

            Dim _to As String() = par_obj.recipents
            Dim smsText As String = par_obj.text

            Dim ID As String = ""

            ' προσπάθεια αποστολής.
            Try
                ID = client.send(My.Settings.SMSusername, My.Settings.SMSpassword, _
                My.Settings.SMSsenderID, _to, smsText, "GSM", False, "", "")

                isSent = True
                errorOccured = False

            Catch ex As Exception

                MsgBox(ex.Message)
                errorOccured = True

            End Try

            Thread.Sleep(7500) 'Περιμένω 'κάποιο' χρονικό διάστημα (7.5 sec) μέχρι να γίνει αποστολή, για να πάρω όσο το δυνατόν πιο πολύ αντιπροσωπευτικά αποτελέσματα. 

            ' κάνω αίτηση στο web sevice, για να πάρω το status της αποστολής.
            Try
                Dim status As SMS_Service.recipientStatus() = client.multiple_query(My.Settings.SMSusername, My.Settings.SMSpassword, ID, _to)

                ' για κάθε παραλήπτη(phone number) , εμφανίζει το status(Queued,Failed,Delivered,Pending,Error)
                For Each stat As SMS_Service.recipientStatus In status

                    ' για κάθε παραλήπτη δημιουργώ ένα αντικείμενο με το phone number,status και την τωρινή ημερομηνία.
                    ' Επίσης αυξάνεται ο εκάστοτε counter.
                    If (stat.status = "Queued") Then
                        Dim stutus_obj = New With {Key .number = stat.recipient, .time = Date.Now, .result = "Queued"} ' αποθήκευση αντικειμένου στη λίστα (χρησιμοποιείτε από τη SMSresults form).
                        sms_status_lst.Add(stutus_obj)
                        queued += 1
                    ElseIf (stat.status = "Failed") Then
                        Dim stutus_obj = New With {Key .number = stat.recipient, .time = Date.Now, .result = "Failed"} ' αποθήκευση αντικειμένου στη λίστα (χρησιμοποιείτε από τη SMSresults form).
                        sms_status_lst.Add(stutus_obj)
                        failed += 1
                    ElseIf (stat.status = "Delivered") Then
                        Dim stutus_obj = New With {Key .number = stat.recipient, .time = Date.Now, .result = "Delivered"} ' αποθήκευση αντικειμένου στη λίστα (χρησιμοποιείτε από τη SMSresults form).
                        sms_status_lst.Add(stutus_obj)
                        delivered += 1
                    ElseIf (stat.status = "Pending") Then
                        Dim stutus_obj = New With {Key .number = stat.recipient, .time = Date.Now, .result = "Pending"} ' αποθήκευση αντικειμένου στη λίστα (χρησιμοποιείτε από τη SMSresults form).
                        sms_status_lst.Add(stutus_obj)
                        pending += 1
                    ElseIf (stat.status = "Error") Then
                        Dim stutus_obj = New With {Key .number = stat.recipient, .time = Date.Now, .result = "Error"} ' αποθήκευση αντικειμένου στη λίστα (χρησιμοποιείτε από τη SMSresults form).
                        sms_status_lst.Add(stutus_obj)
                        _error += 1
                    End If
                Next
                errorOccured = False
            Catch ex As Exception

                MsgBox(ex.Message)

                errorOccured = True

            End Try

        End If

    End Sub

    'worker (Completed)
    Private Sub worker_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles worker.RunWorkerCompleted

        Me.Text = Me.Text.Replace(" (Sending....)", "") ' Η διαδικασία της αποστολής τελείωσε, βγάζω το (Sending....) από τον τίτλο της φόρμας.

        If (isScheduled) Then
            If (Not errorOccured) Then
                Me.Close()
            Else
                SendToolStripMenuItem.Enabled = True
            End If
        Else

            If (Not errorOccured) Then

                If (isSent) Then
                    SaveSentSms() ' αποθήκευση στα sent.
                    isSent = False
                End If

                ' εμφανίζω τη φόρμα SMSResultsForm, που περιέχει τα αποτελέσματα της αποστολής. Μετά κλείνει η φόρμα.
                Dim results As New SMSResultsForm()
                results.StartPosition = FormStartPosition.CenterParent
                results.ShowDialog()
                results = Nothing

                delivered = 0
                failed = 0
                queued = 0
                pending = 0
                _error = 0
                sms_status_lst.Clear()

                Me.Close()

            Else

                SendToolStripMenuItem.Enabled = True

            End If
        End If

    End Sub

    ' balance_btn_Click, έλεγχος του λογαριασμού.
    Private Sub balance_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles balance_btn.Click

        ' δημιουργία ενώς αντικειμένου τύπου SMS_Service.smsPortTypeClient για να ελέγξω το λογαριασμό.
        Dim client As New SMS_Service.smsPortTypeClient()

        ' κάνω μια αίτηση στο web service για να μου επιστρέψει το υπόλοιπο του λογαριασμού.
        Try
            Dim credits As Decimal = client.credits(My.Settings.SMSusername, My.Settings.SMSpassword)
            MsgBox("You have " & CDbl(credits) & " credits on your account")

            ' αν η αίτηση απτύχει, γράφω το exception message στον error provider.
        Catch e1 As Exception
            MsgBox(e1.Message)
        End Try

    End Sub

End Class