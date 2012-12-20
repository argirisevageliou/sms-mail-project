Imports System.Web.HttpUtility
Imports System.Data.OleDb

Public Class NewSmsMessage

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
            SmsFrom_tb.Text = My.Settings.email
            SmsFrom_tb.ReadOnly = True
            SmsSearchAccount_btn.Visible = False
            SmsFrom_tb.ReadOnly = True
        End If

    End Sub

    ' on load, αν υπάρχει ρυθμισμένος λογαριασμός, βάζω στο SmsFrom_tb το senderID
    Private Sub NewSmsMessage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If (My.Settings.SMSsenderID <> "" And My.Settings.SMSusername <> "" And My.Settings.SMSpassword <> "") Then
            SmsFrom_tb.Text = My.Settings.email
            SmsFrom_tb.ReadOnly = True
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
            SmsFrom_tb.Text = My.Settings.email
            SmsFrom_tb.ReadOnly = True
            SmsSearchAccount_btn.Visible = False
            SmsFrom_tb.ReadOnly = True
        Else ' αν έχει διαγραφεί - δεν έχει ρυθμιστεί ο λογαριασμός 'αδειάζω' το from text box.
            SmsFrom_tb.Text = ""
            SmsSearchAccount_btn.Visible = True
        End If

    End Sub

    ' εκτελείτε όταν η φόρμα ενεργοποιείτε (gain focus).
    Private Sub NewSmsMessage_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated

        ' αν μετά το κλείσιμο του dialog έχει ρυθμιστεί λογαριασμός τον εμφανίζουμε στο From text box.
        If (My.Settings.SMSsenderID <> "" And My.Settings.SMSusername <> "" And My.Settings.SMSpassword <> "") Then
            SmsFrom_tb.Text = My.Settings.email
            SmsFrom_tb.ReadOnly = True
            SmsSearchAccount_btn.Visible = False
            SmsFrom_tb.ReadOnly = True
        Else ' αν έχει διαγραφεί - δεν έχει ρυθμιστεί ο λογαριασμός 'αδειάζω' το from text box.
            SmsFrom_tb.Text = ""
            SmsSearchAccount_btn.Visible = True
        End If

    End Sub

    Private Sub SendToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SendToolStripMenuItem.Click

        ' αν δεν έχει ρυθμιστεί ο λογαριασμός εμφανίζω το dialog για ρύθμηση του λογαριασμού.
        If (My.Settings.SMSsenderID = "" Or My.Settings.SMSpassword = "" Or My.Settings.SMSpassword = "" Or SmsFrom_tb.Text = "") Then

            Dim manager As SMS_Account_Manager
            manager = New SMS_Account_Manager
            manager.StartPosition = FormStartPosition.CenterParent
            manager.ShowDialog()
            manager = Nothing

            ' αν ρυθμιστεί ο λογαριασμός, βάζω στο SmsFrom_tb το senderID
            If (My.Settings.SMSsenderID <> "" And My.Settings.SMSusername <> "" And My.Settings.SMSpassword <> "") Then
                SmsFrom_tb.Text = My.Settings.email
                SmsFrom_tb.ReadOnly = True
                SmsSearchAccount_btn.Visible = False
                SmsFrom_tb.ReadOnly = True
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
        ElseIf (My.Settings.SMSsenderID <> "" And My.Settings.SMSpassword <> "" And My.Settings.SMSpassword <> "" And SmsFrom_tb.Text <> "") Then

            ' εμφανίζω την φόρμα για επιλογή προγραμματισμού ή όχι της αποστολής.
            Dim sch As New ScheduleSMSForm()
            sch.StartPosition = FormStartPosition.CenterParent

            sch.ShowDialog()
            sch = Nothing

            ' αν ο χρήστης ζήτησε προγραμματισμό της αποστολής.
            If (isScheduled) Then

                ' δημιουργία ενώς αντικειμένου τύπου SMS_Service.smsPortTypeClient για να ελέγξω το λογαριασμό.
                Dim client As New SMS_Service.smsPortTypeClient()
                Dim _to As String()
                'χωρίζω το string με delimeter character το ; και βάζω τα phone numbers στο πίνακα.
                _to = SmsSendTo_tb.Text.Split(";")
                Dim ID As String = ""

                ' προσπάθεια αποστολής.
                Try
                    ID = client.send(UrlEncode(My.Settings.SMSusername), UrlEncode(My.Settings.SMSpassword), _
                    UrlEncode(My.Settings.SMSsenderID), _to, UrlEncode(SmsRichTextBox.Text), "GSM", False, UrlEncode(sendDate), "")
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                Me.Close()
                ' αν δεν έχει επιλεγεί προγραμματισμός αποστολής καλώ τη μέθοδο startSending() για άμεση αποστολή.
            Else

                startSending()
                SendToolStripMenuItem.Enabled = False
            End If

        End If

    End Sub

    'send sms method
    Private Sub startSending()

        ' δημιουργία ενώς αντικειμένου τύπου SMS_Service.smsPortTypeClient για να ελέγξω το λογαριασμό.
        Dim client As New SMS_Service.smsPortTypeClient()

        Dim _to As String()
        'χωρίζω το string με delimeter character το ; και βάζω τα phone numbers στο πίνακα.
        _to = SmsSendTo_tb.Text.Split(";")
        Dim ID As String = ""

        ' προσπάθεια αποστολής.
        Try
            ID = client.send(UrlEncode(My.Settings.SMSusername), UrlEncode(My.Settings.SMSpassword), _
            UrlEncode(My.Settings.SMSsenderID), _to, UrlEncode(SmsRichTextBox.Text), "GSM", False, "", "")
            SaveSentSms()
        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

        ' κάνω αίτηση στο web sevice, για να πάρω το status της αποστολής.
        Try
            Dim status As SMS_Service.recipientStatus() = client.multiple_query(UrlEncode(My.Settings.SMSusername), UrlEncode(My.Settings.SMSpassword), UrlEncode(ID), _to)

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

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

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
        Dim insertquery As String = "INSERT INTO sentsms(subject,senders,sms,hmer_wra) VALUES('" & SmsSubjectTb.Text & _
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

End Class