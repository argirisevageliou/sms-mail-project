Imports System.Net.Mail
Imports System.Data.OleDb

Public Class NewMessage

    Dim close_flag As Boolean 'φλαγκ μεταβλητη για την εμφανιση η οχι του μηνυματος dialog box στο κλεισιμο της φορμας

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

    'Κουμπί αποστολης(send) μηνυματος απο το μενου file (f5)
    Private Sub SendToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SendToolStripMenuItem.Click
        If (My.Settings.email <> "" And My.Settings.name <> "" And My.Settings.password <> "" And _
        My.Settings.port <> "" And My.Settings.server <> "" And My.Settings.security <> "") Then

            Dim Mail As New MailMessage 'φτιαχνω μια μεταβλητη-αντικειμενο τυπου Mailmessage ωστε να μας διευκολυνει για τα mail
            Mail.Subject = Subject.Text 'παιρνω απο το textbox που εγραψε ο χρηστης το θεμα και το βαζω στο mail.subject
            Mail.To.Add(SendTo_tb.Text)    'βαζω εδω τον παραληπτη του μηνυματος το οποιο πληκτρολογει ο χρηστης στο SendTo textbox
            Mail.From = New MailAddress(From_tb.Text, My.Settings.name)  'εδω φτιαχνω τον αποστολεα το μηνυματος και το παιρνω απο το From textbox οπου πληκτρολογει ο χρηστης 
            Mail.Body = MessageRichTextBox.Text    'εδω ειναι το μηνυμα του χρηστη
            ' εδω ακολουθει η συνδεση με τον SMTP Server Του Gmail ωστε να στελνει με λογαριασμο gmail
            Dim SMTP As New SmtpClient(My.Settings.server)
            If (My.Settings.port = "25") Then
                SMTP.EnableSsl = False
            Else
                SMTP.EnableSsl = True
            End If

            SMTP.Credentials = New System.Net.NetworkCredential(My.Settings.email, My.Settings.password)
            SMTP.Port = My.Settings.port
            'Εδω βαζουμε try catch εντολες ετσι ωστε να προλαβουμε το λαθος για να μην το δει ο χρηστης
            Try
                SMTP.Send(Mail)
                '''''''''''''''''''''''''''''''''''''''''''''''''''''
                Dim connection As OleDbConnection
                Dim command As OleDbCommand
                Dim timeStamp As DateTime = DateTime.Now
                Dim insertquery As String = "INSERT INTO sentemails(subject,senders,mail,hmer_wra) VALUES('" & Subject.Text & _
                    "','" & SendTo_tb.Text & "','" & MessageRichTextBox.Text & "','" & timeStamp & "');"

                Try
                    connection = New OleDbConnection(My.Settings.testConnectionString)
                    command = New OleDbCommand(insertquery, connection)
                    connection.Open()
                    command.ExecuteNonQuery()
                    MsgBox("Email saved to sentemails")
                    connection.Close()

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                ''''''''''''''''''''''''''''''''''''''''
                close_flag = True ' εδω βαζουμε μια μεταβλητη σημαια καταλληλη για να κλεινει η φορμα χωρις να μας βγαζει το μηνυμα για το αν ειμαστε σιγουροι να κλεισουμε το παραθυρο η οχι
                Me.Close()
                MsgBox("Message Sent!!!")
            Catch ex As SmtpException
                MsgBox("Message Sent Failed!!!")
            Catch ex1 As Exception
                MsgBox("Message Sent Failed!!!")
            End Try
        End If
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
        If close_flag = False Then ' Μονο αν ειναι false θα εμφανιστει το παρακατω μηνυμα,αλλιως αν ειναι true δεν θα εμφανιστει και αυτο γινεται στην περιπτωση που σταλθει το μηνυμα μας και δεν θελουμε να εμφανιστει αυτο το μηνυμα
            If MessageBox.Show("Are you sure you want to close this message form ?", "Close Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Else
                e.Cancel = True
            End If
        End If
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

    'Ακολουθουν οι μεθοδοι για την μπαρα των toolstripbutton μενου...ειναι οι ιδιες λειτουργιες με απο τα μενου file και edit απλως σε κουμπακι toolstripbutton
    'toolstripbutton για να κανει send
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SendStripButton1.Click
        'If (My.Settings.email <> "" And My.Settings.name <> "" And My.Settings.password <> "" And _
        'My.Settings.port <> "" And My.Settings.server <> "" And My.Settings.security <> "") Then

        Dim Mail As New MailMessage 'φτιαχνω μια μεταβλητη-αντικειμενο τυπου Mailmessage ωστε να μας διευκολυνει για τα mail
        Mail.Subject = Subject.Text 'παιρνω απο το textbox που εγραψε ο χρηστης το θεμα και το βαζω στο mail.subject
        Mail.To.Add(SendTo.Text)    'βαζω εδω τον παραληπτη του μηνυματος το οποιο πληκτρολογει ο χρηστης στο SendTo textbox
        Mail.From = New MailAddress(From_tb.Text)  'εδω φτιαχνω τον αποστολεα το μηνυματος και το παιρνω απο το From textbox οπου πληκτρολογει ο χρηστης 
        Mail.Body = MessageRichTextBox.Text    'εδω ειναι το μηνυμα του χρηστη
        ' εδω ακολουθει η συνδεση με τον SMTP Server Του Gmail ωστε να στελνει με λογαριασμο gmail
        'Dim SMTP As New SmtpClient(My.Settings.server)
        'If (My.Settings.port = "25") Then
        'SMTP.EnableSsl = False
        'Else
        'SMTP.EnableSsl = True
        'End If

        ' SMTP.Credentials = New System.Net.NetworkCredential(My.Settings.email, My.Settings.password)
        'SMTP.Port = My.Settings.port
        'Εδω βαζουμε try catch εντολες ετσι ωστε να προλαβουμε το λαθος για να μην το δει ο χρηστης
        Try
            ' SMTP.Send(Mail)
            close_flag = True ' εδω βαζουμε μια μεταβλητη σημαια καταλληλη για να κλεινει η φορμα χωρις να μας βγαζει το μηνυμα για το αν ειμαστε σιγουροι να κλεισουμε το παραθυρο η οχι
            Me.Close()
            MsgBox("Message Sent!!!")
        Catch ex As SmtpException
            MsgBox("Message Sent Failed!!!")
        Catch ex1 As Exception
            MsgBox("Message Sent Failed!!!")
        End Try
        'Else


        'End If
    End Sub

    'toolstripbutton για να κανει cut
    Private Sub CutStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CutStripButton3.Click
        MessageRichTextBox.Cut()
    End Sub

    ''toolstripbutton για να κανει copy
    Private Sub CopyStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyStripButton4.Click
        MessageRichTextBox.Copy()
    End Sub

    ''toolstripbutton για να κανει paste
    Private Sub PasteStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteStripButton5.Click
        MessageRichTextBox.Paste()
    End Sub


    Private Sub SaveStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveStripButton2.Click
        Dim connection As OleDbConnection
        Dim command As OleDbCommand
        Dim timeStamp As DateTime = DateTime.Now
        Dim insertquery As String = "INSERT INTO draftemails(subject,senders,mail,hmer_wra) VALUES('" & Subject.Text & _
            "','" & SendTo_tb.Text & "','" & MessageRichTextBox.Text & "','" & timeStamp & "');"

        Try
            connection = New OleDbConnection(My.Settings.testConnectionString)
            command = New OleDbCommand(insertquery, connection)
            connection.Open()
            command.ExecuteNonQuery()
            MsgBox("Email saved to draftemails")
            connection.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Me.Close()
    End Sub
End Class