Imports System.Net.Mail
Imports System.Text.RegularExpressions
Imports System.Threading
Imports System.ComponentModel

Public Class NewMessage

    Dim close_flag As Boolean 'φλαγκ μεταβλητη για την εμφανιση η οχι του μηνυματος dialog box στο κλεισιμο της φορμας

    Dim addresses As New List(Of String) ' περιέχει τις διευθύνσεις για αποστολή.

    Public Shared status_lst As New List(Of Object) 'περιέχει address,date and status για κάθε μαιλ που στάλθηκε (ή απέτυχε).
    Public Shared success As Integer 'πόσα στάλθηκαν με επιτυχία
    Public Shared fail As Integer 'πόσα απέτυχαν

    Public Shared contacts As String 'χρησιμοποιείτε από την ChooseReceivers_Form για ενημέρωση του SendTo tb.


    'Δημιουργια νεας φορμας NewMesage
    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        Dim NewForm As New NewMessage  'δημιουργω μια μεταβλητη στην οποια ουσιαστικα βαζω μια καινουρια ιδια φορμα NewMessage 
        NewForm.Show()                  'εδω την ανοιγω αυτη την φορμα
    End Sub

    'Κλεισιμο φορμας
    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close() 'εδω πατωντας το Χ για να κλεισει το παραθυρο ή με συντομευση (alt+f4)
    End Sub

    'ανοιγμα φορμας διαχειρισης Account και οι καταλληλες ρυθμισεις πανω σε αυτο σε σχεση με components
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchAccount_btn.Click

        Dim manager As Account_Manager
        manager = New Account_Manager
        manager.StartPosition = FormStartPosition.CenterParent
        manager.ShowDialog()
        manager = Nothing

        If (My.Settings.email <> "" And My.Settings.name <> "" And My.Settings.password <> "" And _
        My.Settings.port <> "" And My.Settings.server <> "" And My.Settings.security <> "") Then
            From_tb.Text = My.Settings.email
            From_tb.ReadOnly = True
            SearchAccount_btn.Visible = False
            From_tb.ReadOnly = True
        End If

    End Sub

    'Μενου tools Που εχει να κανει απευθειας με το manageraccount του ευθυμη
    Private Sub AccountSetupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccountSetupToolStripMenuItem.Click
        'ManagerAccount.Show()  Με το κουμπι διπλα απο το from == Εδώ μολις πατησει ο χρηστης αυτο το κουμπι καλώ την φόρμα του ευθύμη την ManagerAccount
    End Sub

    'Μενου insert σε συνεργασια με τον αργυρη
    Private Sub GroupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupToolStripMenuItem.Click
        ' Εδω θα παιρνω τα γκρουπ απο τον αργυρη
    End Sub

    'Μενου Help Που περιλαμβανει τα παρακατω
    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        ' Εδω θα ανοιγω την φορμα που εφτιαξε η φανη για το about του προγραμματος μας
    End Sub
    Private Sub HelpFormToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpFormToolStripMenuItem.Click
        ' επισης Εδω θα ανοιγω την φορμα που εφτιαξε η φανη για το about του προγραμματος μας
    End Sub

    'Koυμπι αποθηκευσης(save) υπο κατασκευη...
    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        'Dim Message As String = ""
        'Message = Message.Text + Message
    End Sub

    'μενου Edit που περιλαμβανει τα παρακατω
    Private Sub UndoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoToolStripMenuItem.Click
        MessageRichTextBox.Undo()
    End Sub
    Private Sub RedoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RedoToolStripMenuItem.Click
        MessageRichTextBox.Redo()
    End Sub
    Private Sub CutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CutToolStripMenuItem.Click
        MessageRichTextBox.Cut()
    End Sub
    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        MessageRichTextBox.Copy()
    End Sub
    Private Sub PasteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripMenuItem.Click
        MessageRichTextBox.Paste()
    End Sub
    Private Sub SelectAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectAllToolStripMenuItem.Click
        MessageRichTextBox.SelectAll()
    End Sub

    'dialog box με καταλληλο μηνυμα στο κλεισιμο της φορμας
    Private Sub NewMessage_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'If close_flag = False Then ' Μονο αν ειναι false θα εμφανιστει το παρακατω μηνυμα,αλλιως αν ειναι true δεν θα εμφανιστει και αυτο γινεται στην περιπτωση που σταλθει το μηνυμα μας και δεν θελουμε να εμφανιστει αυτο το μηνυμα
        '    If MessageBox.Show("Are you sure you want to close this message form ?", "Close Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
        '    Else
        '        e.Cancel = True
        '    End If
        'End If
    End Sub

    'μπαινουν οι ρυθμισεις του λογαριασμου του χρηστη στο textbox from,και αναλογως γινεται readonly το textfield ή ενεργοποιειται το κουμπακι(...) γιατο ανοιγμα της φορμας λογαριασμων
    Private Sub NewMessage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If (My.Settings.email <> "" And My.Settings.name <> "" And My.Settings.password <> "" And _
        My.Settings.port <> "" And My.Settings.server <> "" And My.Settings.security <> "") Then
            From_tb.Text = My.Settings.email
            From_tb.ReadOnly = True
        Else
            SearchAccount_btn.Visible = True
        End If

    End Sub

    'toolstripbutton για να κανει cut
    Private Sub CutStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CutStripButton3.Click
        MessageRichTextBox.Cut()
    End Sub

    'toolstripbutton για να κανει copy
    Private Sub CopyStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyStripButton4.Click
        MessageRichTextBox.Copy()
    End Sub

    'toolstripbutton για να κανει paste
    Private Sub PasteStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteStripButton5.Click
        MessageRichTextBox.Paste()
    End Sub





    ' έλεγος για σύνδεση στο internet
    Private Declare Function InternetGetConnectedState Lib "wininet" _
  (ByRef conn As Long, ByVal val As Long) As Boolean

    ' SearchGroupBtn_Click (Εισαγωγή emails από τη φόρμα ChooseReceivers)
    Private Sub SearchGroupBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchGroupBtn.Click

        Dim choose As New ChooseReceivers_Form()
        choose.StartPosition = FormStartPosition.CenterParent
        contacts = SendTo_tb.Text
        choose.ShowDialog()
        SendTo_tb.Text = contacts ' βάζω στο SendTo tb, τα εμαιλ χωρισμένα με ';'.
        contacts = ""
        choose = Nothing

    End Sub

    'SendTool_btn_Click (Από το toolbar)
    Private Sub SendTool_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SendTool_btn.Click

        Dim check As Boolean = PreSendingCheck()

        If (check) Then
            startSending()
            SendTool_btn.Enabled = False
            SendToolStripMenuItem.Enabled = False
        End If

    End Sub

    'SendToolStripMenuItem_Click (από το menu file)
    Private Sub SendToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SendToolStripMenuItem.Click

        Dim check As Boolean = PreSendingCheck()

        If (check) Then
            startSending()
            SendTool_btn.Enabled = False
            SendToolStripMenuItem.Enabled = False
        End If

    End Sub

    'PreSendingCheck (Έλεγχος αν τα μπορεί να γίνει αποστολή)
    Private Function PreSendingCheck() As Boolean

        'έλεγχος αν έχει ρυθμιστεί λογαριασμός
        If (My.Settings.email <> "" And My.Settings.name <> "" And My.Settings.password <> "" And _
        My.Settings.port <> "" And My.Settings.server <> "" And My.Settings.security <> "" And From_tb.Text <> "") Then

            If (SendTo_tb.Text <> "") Then

                Dim tmp_send_to_text As String = SendTo_tb.Text

                Dim start_index As Integer = 0
                Dim end_index As Integer = 0
                addresses.Clear()

                For i As Integer = 0 To tmp_send_to_text.Length - 1
                    If (tmp_send_to_text.Chars(i) = ";") Then
                        end_index = i
                        addresses.Add(tmp_send_to_text.Substring(start_index, end_index - start_index))
                        start_index = end_index + 1
                    End If
                Next
                Return True ' return true αν το sendTo textbox δεν είναι άδειο.
            End If
            Return False ' return false αν το sendTo textbox είναι άδειο.
        End If
        Return False 'return false αν δεν έχει ρυθμιστεί λογαριασμός.

    End Function


#Region "SendingMail_Multithreading"

    'startSending (Αποστολή μηνημάτων με multi-threading)
    Private Sub startSending()

        ' Έλεγχος αν υπάρχει σύνδεση στο internet
        Dim Out As Integer
        If InternetGetConnectedState(Out, 0) = True Then

            'Δημιουργία threadpool με 300 frames. 50 περιμένουν για νέα requests.
            ThreadPool.SetMaxThreads(300, 300)
            ThreadPool.SetMinThreads(50, 50)

            status_lst.Clear()
            success = 0
            fail = 0

            'Το max της progressbar είναι ίσο με το πλήθος των διευθύνσεων στις οποίες θα γίνει αποστολή.
            Me.status_pb.Maximum = addresses.Count
            Me.status_pb.Step = 1

            For Each to_address As Object In addresses

                'δημιουργία ενώς anonymous object με πεδία  (to address, subject text , body text)
                Dim mydata_obj = New With {Key .address = to_address, .subject = Subject.Text, .body = MessageRichTextBox.Text}
                ThreadPool.QueueUserWorkItem(AddressOf SendMail, mydata_obj) ' βάζω στην ουρά tasks.

            Next

        End If

    End Sub

    'SendMail
    Private Sub SendMail(ByVal mydata_obj As Object)

        If mydata_obj Is Nothing Then
            Throw New ArgumentException("Empty arg!!")
        End If

        ' δημιουργία και αρχικοποίηση smtp client.
        Dim client As SmtpClient = New SmtpClient()
        client.Host = My.Settings.server
        If (My.Settings.port = "25") Then
            client.EnableSsl = False
        Else
            client.EnableSsl = True
        End If

        client.Credentials = New System.Net.NetworkCredential(My.Settings.email, My.Settings.password)

        ' δημιουργία μηνήματος
        Using Mail As New MailMessage
            Mail.Subject = mydata_obj.subject
            Mail.To.Add(mydata_obj.address)
            Mail.From = New MailAddress(My.Settings.email, My.Settings.name)
            Mail.Body = mydata_obj.body
            client.ServicePoint.MaxIdleTime = 1 ' η σύνδεση στο server κλείνει μετά από 1 sec idle. 

            Try
                client.Send(Mail)
                Dim stutus_obj = New With {Key .address = mydata_obj.address, .time = Date.Now, .result = "Sent OK"} ' αποθήκευση αντικειμένου στη λίστα (χρησιμοποιείτε από τη results form).
                status_lst.Add(stutus_obj)
                success += 1
            Catch ex As SmtpException
                'MsgBox(ex.Message)
                Dim stutus_obj = New With {Key .address = mydata_obj.address, .time = Date.Now, .result = "Sent Failed"}
                status_lst.Add(stutus_obj)
                fail += 1
            Finally
                SendCompleted() ' μετά το τέλος καλείτε η SendCompleted
            End Try
        End Using

    End Sub

    'SendCompleted
    Private Sub SendCompleted()

        If Me.InvokeRequired Then
            Me.Invoke(New Action(AddressOf SendCompleted))
            Return
        End If

        'ενημέρωση του progress bar.
        Me.status_pb.Value = Me.status_pb.Value + 1

        ' αν η progressbar έχει γεμίσει εμαφανίζω τη φόρμα results.
        If (Me.status_pb.Value = Me.status_pb.Maximum) Then

            SendTool_btn.Enabled = True
            SendToolStripMenuItem.Enabled = True

            Dim res As New ResultsForm()
            res.StartPosition = FormStartPosition.CenterParent
            res.ShowDialog()
            res = Nothing

            fail = 0
            success = 0
            addresses.Clear()
            status_lst.Clear()

            Me.Close()

        End If

    End Sub

#End Region


End Class