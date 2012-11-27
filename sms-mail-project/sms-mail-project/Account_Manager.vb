Imports HtmlAgilityPack
Imports System.Net
Imports System.Net.Mail
Imports System.Text.RegularExpressions


Public Class Account_Manager

    Public Shared server As String = ""
    Public Shared port As String = ""
    Public Shared ssl As String = ""
    Public Shared authedication As String = ""

    Dim pressed As String = "" ' βοηθητική μεταβλητή για να καθορίζω τι θα εκτελεί ο background worker.
    Dim sent_flag As Boolean = False ' (finish button) flag για το αν αποστάλθηκε το email ελέγχου.

    'αποθήκευση της τιμής των 3 tb για να έχω πρόσβαση από την confirm_box φόρμα.
    Public Shared email_tb_value As String = ""
    Public Shared name_tb_value As String = ""
    Public Shared pass_tb_value As String = ""

    ' έλεγχος σύνδεσης στο internet (δήλωση).
    Private Declare Function InternetGetConnectedState Lib "wininet" _
  (ByRef conn As Long, ByVal val As Long) As Boolean

    ' έλεγχος περιεχομένου του tb.
    Private Sub email_tb_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles email_tb.Leave

        ' έλεγχος αν το περιεχόμενο έχει τη σωστή μορφή (email)
        Dim correct_mail_Format As Boolean = Regex.IsMatch(email_tb.Text, "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$")
        If (email_tb.Text = "") Then '
            checkMail_lb.Visible = True
            checkMail_lb.Text = "The E-mail Address field must not be empty!!"
        ElseIf (correct_mail_Format = False) Then
            checkMail_lb.Visible = True
            checkMail_lb.Text = "Please insert a correct e-mail format!!"
        Else
            checkMail_lb.Visible = False
        End If

    End Sub

    ' έλεγχος περιεχομένου του tb.
    Private Sub pass_tb_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pass_tb.Leave

        If (pass_tb.Text = "") Then
            checkPass_lb.Visible = True
        Else
            checkPass_lb.Visible = False
        End If

    End Sub

    ' έλεγχος περιεχομένου του tb.
    Private Sub name_tb_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles name_tb.Leave

        If (name_tb.Text = "") Then
            checkName_lb.Text = "The Name field must not be empty!!!!"
            checkName_lb.ForeColor = Color.Red
            checkName_lb.Font = New Font(checkName_lb.Font, FontStyle.Bold)
        Else
            checkName_lb.Text = "It will be visible from the receiver"
            checkName_lb.ForeColor = Color.Gray
            checkName_lb.Font = New Font(checkName_lb.Font, FontStyle.Italic)
        End If

    End Sub

    ' έξοδος από τη φόρμα με πάτημα του cancel.
    Private Sub cancel_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancel_btn.Click

        Me.Close()

    End Sub

    ' κατά τη φόρτωση της φόρμας έλεγχος για το αν υπάρχει ήση ρυθμισμένος λογαριασμός.
    Private Sub Account_Manager_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If (My.Settings.email <> "" And My.Settings.name <> "" And My.Settings.password <> "" And _
           My.Settings.port <> "" And My.Settings.server <> "" And My.Settings.security <> "") Then

            email_tb.Text = My.Settings.email
            pass_tb.Text = My.Settings.password
            name_tb.Text = My.Settings.name
            email_tb.ReadOnly = True
            pass_tb.ReadOnly = True
            name_tb.ReadOnly = True
            settings_Panel.Visible = True
            panelTest_btn.Visible = False
            next_btn.Visible = False
            deleleAc_btn.Visible = True
            testAccount_btn.Visible = True
            server = My.Settings.server
            port = My.Settings.port
            server_info_lb.Text = "  Outgoing Server:   SMTP, " & My.Settings.server & ", " & My.Settings.port & ", " & My.Settings.security

        Else

            My.Settings.email = ""
            My.Settings.password = ""
            My.Settings.name = ""
            My.Settings.server = ""
            My.Settings.port = ""
            My.Settings.security = ""
            My.Settings.Save()
            Dim tmp As CueBanner = New CueBanner
            tmp.SetCueBanner(email_tb, email_tb.Tag)
            tmp.SetCueBanner(pass_tb, pass_tb.Tag)
            tmp.SetCueBanner(name_tb, name_tb.Tag)

        End If

    End Sub

    ' κουμπί next ή finish.
    Private Sub next_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles next_btn.Click

        If (next_btn.Text = "Next") Then

            ' αν όλα τα text boxes έχουν σωστές τιμές ψάχνω για default ρυθμίσεις του λογαριασμού.
            If (checkMail_lb.Visible = False And checkPass_lb.Visible = False And name_tb.Text <> "") Then

                email_tb.ReadOnly = True
                pass_tb.ReadOnly = True
                name_tb.ReadOnly = True
                Dim url As String = "https://autoconfig-live.mozillamessaging.com/autoconfig/v1.1/"

                ' βάζω πίσω από το url το domain name του λογαριασμού.
                Dim tmp_name_address As String = email_tb.Text
                Dim index As Integer = tmp_name_address.IndexOf("@")
                Dim domain As String = tmp_name_address.Substring(index + 1)
                url = String.Concat(url, domain)

                'αναζήτηση default ρυθμίσεων, αλλαγή του κουμπιού σε finish.
                parseMozillaISPDB(url, domain)
                next_btn.Text = "Finish"

            End If

        ElseIf (next_btn.Text = "Finish") Then

            ' εκκίνηση του background worker με ένα argument
            next_btn.Enabled = False
            testAccount_btn.Enabled = False

            pressed = "finishPressed"
            nextFinish_pictbox.Visible = True ' εμφάνηση του picture box με το loading gif graphic
            Worker.RunWorkerAsync(pressed)

        End If

    End Sub

    ' μέθοδος για parse του htlm για εξαγωγή των default ρυθμίσεων του λογαρισμού.
    Private Sub parseMozillaISPDB(ByVal url As String, ByVal domain As String)

        next_btn.Enabled = False

        ' ελέγχω αν υπάρχει σύνδεση στο internet.
        Dim Out As Integer
        If InternetGetConnectedState(Out, 0) = True Then
            status_lb.Text = "status: OK"
            Dim webClient As New System.Net.WebClient
            Try
                Dim result As String = webClient.DownloadString(url)

                ' χρήση του HtmlAgilityPack για να κάνω parse το html(xml).
                Dim htmldoc As New HtmlAgilityPack.HtmlDocument

                htmldoc.LoadHtml(result)

                ' αναζήτηση για τον κόμβο με attribute 'type = smtp' για να εντοπίσω τον outgoing server
                Dim nodes As HtmlNodeCollection = htmldoc.DocumentNode.SelectNodes("//*[@type='smtp']")

                ' ελέγχω όλους τους κόμβους που μου επιστράφησαν. Κανινικά γίνεται επιστροφή ενός κόμβου.
                For Each node As HtmlNode In nodes

                    'αν το όνομα του κόμβου είναι outgoingserver, ελέγχω τους 'υποκόμβους' του για να πάρω τις ρυθμίσεις που χρειάζομαι.
                    If (node.Name = "outgoingserver") Then
                        Dim nodes_in_outgoing As HtmlNodeCollection = node.ChildNodes
                        For Each tmpnode As HtmlNode In nodes_in_outgoing
                            If (tmpnode.Name = "hostname") Then
                                server = tmpnode.InnerHtml
                            ElseIf (tmpnode.Name = "port") Then
                                port = tmpnode.InnerHtml
                                If (port = "465") Then
                                    port = "587" ' Αν η πόρτα είναι η 465 την αλλάζω σε 587 επέιδή το System.Net.Mail υποστιρίζει μόνο 
                                    '“Explicit SSL” (587) και όχι Implicit SSL (SMTPS - 465) :-(
                                End If
                            ElseIf (tmpnode.Name = "sockettype") Then
                                ssl = tmpnode.InnerHtml
                            ElseIf (tmpnode.Name = "authentication") Then
                                authedication = tmpnode.InnerHtml
                            End If
                        Next
                    End If
                Next

            Catch e2 As WebException

                ' Αν ο server επιστρέψει error 404 τότε ενεργοποιώ αυτόματα τα manual settings.
                If (e2.Message = "The remote server returned an error: (404) Not Found.") Then

                    settings_info_lb.Text = "The program could not find default settings for your account:"
                    manualConf_btn.Visible = True
                    testAccount_btn.Visible = True
                    manualConf_btn.Enabled = False
                    settings_info_lb.Visible = True
                    settings_Panel.Visible = True
                    serverConf_tb.Visible = True
                    portConf_tb.Visible = True
                    portConf_lb.Visible = True
                    serverConf_lb.Visible = True
                    serverConf_tb.Text = "smtp." & domain
                    portConf_tb.Text = "25"
                    server_info_lb.Text = "  Outgoing Server:   SMTP"

                End If

                ' κάνω catch οποιοδήποτε exception δεν έχει πιαστεί παραπάνω.
            Catch e1 As Exception

                status_lb.Text = "status: There is a problem with this action :" & e1.Message

            End Try

            If (server <> "" And port <> "" And ssl <> "" And authedication <> "") Then

                ' αν πάρω τις ρυθμίσεις και είμαι σε manual mode (Test Again button)
                If (manualConf_btn.Enabled = False) Then

                    serverConf_tb.Visible = True
                    portConf_tb.Visible = True
                    portConf_lb.Visible = True
                    serverConf_lb.Visible = True
                    serverConf_tb.Text = server
                    portConf_tb.Text = port
                    manualConf_btn.Visible = True
                    testAccount_btn.Visible = True
                    server_info_lb.Text = "  Outgoing Server:   SMTP"

                    ' εμφανίζω τις λεπτομέριες του λογαριασμού.
                Else

                    settings_Panel.Visible = True
                    settings_info_lb.Visible = True
                    manualConf_btn.Visible = True
                    testAccount_btn.Visible = True
                    settings_info_lb.Text = "The program has found these default setting for your account:"
                    server_info_lb.Text = "  Outgoing Server:   SMTP, " & server & ", " & port & ", " & ssl

                End If
            End If
        Else
            status_lb.Text = "status: There is a problem with nerwork-cannot retrieve default settings"
        End If

        next_btn.Enabled = True

    End Sub

    ' manual ρυθμίσεις για το λογαριασμό
    Private Sub manualConf_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles manualConf_btn.Click

        manualConf_btn.Enabled = False
        serverConf_tb.Visible = True
        portConf_tb.Visible = True
        portConf_lb.Visible = True
        serverConf_lb.Visible = True
        serverConf_tb.Text = server
        portConf_tb.Text = port
        server_info_lb.Text = "  Outgoing Server:   SMTP"

    End Sub

    ' test again button, έλεγχος για ρυθμίσεις ξανά.
    Private Sub panelTest_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles panelTest_btn.Click

        panelTest_btn.Enabled = False
        Dim url As String = "https://autoconfig-live.mozillamessaging.com/autoconfig/v1.1/"
        Dim tmp_name_address As String = email_tb.Text
        Dim index As Integer = tmp_name_address.IndexOf("@")
        Dim domain As String = tmp_name_address.Substring(index + 1)
        url = String.Concat(url, domain)
        parseMozillaISPDB(url, domain)
        panelTest_btn.Enabled = True

    End Sub

    ' κουμπί test account
    Private Sub testAccount_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles testAccount_btn.Click

        ' εκκίνηση background worker για αποστολή του μηνύματος
        next_btn.Enabled = False
        testAccount_btn.Enabled = False
        pressed = "testAccount"
        sent_pictbox.Visible = True ' picture box με το loading gif graphic
        Worker.RunWorkerAsync(pressed)

    End Sub

    ' έλεγχος λογαριασμού μέσω αποστολής email (normal mode).
    Private Function testAccount(ByVal server As String, ByVal port As String) As Boolean

        ' ελέγχω αν υπάρχει σύνδεση στο internet.
        Dim Out As Integer
        If InternetGetConnectedState(Out, 0) = True Then

            status_lb.Text = "status: OK"

            'δημιουργία smtp client
            Dim SMTPServer As New SmtpClient(server)
            SMTPServer.Port = port
            SMTPServer.Credentials = New System.Net.NetworkCredential(email_tb.Text, pass_tb.Text)
            If (port = "25") Then
                SMTPServer.EnableSsl = False
            Else
                SMTPServer.EnableSsl = True
            End If

            ' δημιουργία μηνύματος

            Using Mail As New MailMessage
                Mail.Subject = "Test"
                Mail.To.Add(email_tb.Text)
                Mail.From = New MailAddress(email_tb.Text, name_tb.Text)
                Mail.Body = "This is the test text email"
                SMTPServer.ServicePoint.MaxIdleTime = 1 ' η σύνδεση στο server κλείνει μετά από 1 sec idle. 

                Try
                    SMTPServer.Send(Mail)
                    status_lb.Text = "status: Email Sent (The test succeeded)"
                    Return True
                Catch ex As SmtpException
                    status_lb.Text = "status: Email sent failed (" & ex.StatusCode.ToString & ")"
                    Return False
                Catch ex1 As Exception
                    status_lb.Text = "status: Email sent failed"
                    Return False
                End Try
            End Using

        Else
            status_lb.Text = "status: There is a problem with nerwork, email sent failed"
            Return False
        End If

    End Function

    ' έλεγχος λογαριασμού μέσω αποστολής email (manual mode).
    Private Function testAccount() As Boolean

        ' Check if an internet connection exists
        Dim Out As Integer
        If InternetGetConnectedState(Out, 0) = True Then

            status_lb.Text = "status: OK"

            'δημιουργία smtp client
            Dim SMTPServer As New SmtpClient(serverConf_tb.Text)

            If (portConf_tb.Text = "465") Then
                SMTPServer.Port = CInt("587") 'Αν η πόρτα είναι η 465 την αλλάζω σε 587 επέιδή το System.Net.Mail υποστιρίζει μόνο 
                '“Explicit SSL” (587) και όχι Implicit SSL (SMTPS - 465) :-(
            Else
                SMTPServer.Port = CInt(portConf_tb.Text)
            End If

            SMTPServer.Credentials = New System.Net.NetworkCredential(email_tb.Text, pass_tb.Text)
            If (port = "25") Then
                SMTPServer.EnableSsl = False
            Else
                SMTPServer.EnableSsl = True
            End If

            ' δημιουργία μηνύματος

            Using Mail As New MailMessage
                Mail.Subject = "Test"
                Mail.To.Add(email_tb.Text)
                Mail.From = New MailAddress(email_tb.Text, name_tb.Text)
                Mail.Body = "This is the test text email"
                SMTPServer.ServicePoint.MaxIdleTime = 1 ' η σύνδεση στο server κλείνει μετά από 1 sec idle. 

                Try
                    SMTPServer.Send(Mail)
                    status_lb.Text = "status: Email Sent (The test succeeded)"
                    Return True
                Catch ex As SmtpException
                    status_lb.Text = "status: Email sent failed (" & ex.StatusCode.ToString & ")"
                    Return False
                Catch ex1 As Exception
                    status_lb.Text = "status: Email sent failed"
                    Return False
                End Try
            End Using

        Else
            status_lb.Text = "status: There is a problem with nerwork, email sent failed"
            Return False
        End If

    End Function

    ' διαγραφή λογαριασμού
    Private Sub deleleAc_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deleleAc_btn.Click

        My.Settings.email = ""
        My.Settings.password = ""
        My.Settings.name = ""
        My.Settings.server = ""
        My.Settings.port = ""
        My.Settings.security = ""
        My.Settings.Save()

        Dim tmp As CueBanner = New CueBanner
        tmp.SetCueBanner(email_tb, email_tb.Tag)
        tmp.SetCueBanner(pass_tb, pass_tb.Tag)
        tmp.SetCueBanner(name_tb, name_tb.Tag)

        email_tb.Text = ""
        pass_tb.Text = ""
        name_tb.Text = ""
        email_tb.ReadOnly = False
        pass_tb.ReadOnly = False
        name_tb.ReadOnly = False
        settings_Panel.Visible = False
        panelTest_btn.Visible = True
        next_btn.Visible = True
        deleleAc_btn.Visible = False
        server_info_lb.Text = ""
        server = ""
        port = ""
        testAccount_btn.Visible = False

        status_lb.Text = "status: OK"

    End Sub

    ' αν πατηθεί το finish button - προσπάθεια αποστολής email - δυνατότητα δημιουργίας λογαριασμού
    Private Sub finishBtn()

        ' ελέγχω αν οι manual ρυθμίσεις χρησιμοποιούνται.
        If (manualConf_btn.Enabled = True) Then
            Dim flag As Boolean = testAccount(server, port) ' αποστολή εμαιλ
            If (flag) Then
                status_lb.Text = "status: OK"

                email_tb_value = email_tb.Text
                pass_tb_value = pass_tb.Text
                name_tb_value = name_tb.Text

                sent_flag = True ' το mail στάλθηκε με επιτυχία (χρησιμοποιείτε στο Worker_RunWorkerCompleted)

            Else
                status_lb.Text = "status: Your account seems has problem, please check the settings"
            End If

        Else
            ' ελέγχω αν τα πεδία περιέχουν λάθος τιμές ή είναι άδεια
            If (serverConf_tb.Text <> "" And portConf_tb.Text <> "") Then
                status_lb.Text = "status: OK"
                If (IsNumeric(portConf_tb.Text) = False) Then
                    portConf_tb.Text = ""
                    status_lb.Text = "status: Only numbers are permitted in 'port' field"
                Else
                    status_lb.Text = "status: OK"
                    Dim flag As Boolean = testAccount() ' αποστολή εμαιλ
                    If (flag) Then
                        status_lb.Text = "status: OK"

                        email_tb_value = email_tb.Text
                        pass_tb_value = pass_tb.Text
                        name_tb_value = name_tb.Text

                        sent_flag = True ' το mail στάλθηκε με επιτυχία (χρησιμοποιείτε στο Worker_RunWorkerCompleted))

                    Else
                        status_lb.Text = "status: Your account seems has problem, please check the settings"
                    End If
                End If
            Else
                status_lb.Text = "'Domain name of server' field and 'port' field must have a value"
            End If
        End If

    End Sub

    ' η DoWork μέθοδος του background worker.
    Private Sub Worker_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles Worker.DoWork

        ' παίρνω το argument και ελέγχω τη τιμή
        If (DirectCast(e.Argument(), String) = "testAccount") Then
            ' ελέγχω αν ο λογαριασμός έχει ήση ρυθμιστεί.
            If (manualConf_btn.Visible = False) Then
                testAccount(server, port)
                ' ελέγχω αν χρησιμοποιούνται οι default ρυθμίσεις
            ElseIf (manualConf_btn.Enabled = True) Then
                testAccount(server, port)
            Else
                ' ελέγχω αν τα πεδία περιέχουν λάθος τιμές ή είναι άδεια
                If (serverConf_tb.Text <> "" And portConf_tb.Text <> "") Then
                    status_lb.Text = "status: OK"
                    If (IsNumeric(portConf_tb.Text) = False) Then
                        portConf_tb.Text = ""
                        status_lb.Text = "Only numbers are permitted in 'port' field"
                    Else
                        status_lb.Text = "status: OK"
                        testAccount()
                    End If
                Else
                    status_lb.Text = "'Domain name of server' field and 'port' field must have a value"
                End If
            End If

        ElseIf (DirectCast(e.Argument(), String) = "finishPressed") Then

            finishBtn()

        End If


    End Sub

    ' η RunWorkerCompleted μέθοδος του background worker.
    Private Sub Worker_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles Worker.RunWorkerCompleted

        ' pictures boxes visible = false
        sent_pictbox.Visible = False
        nextFinish_pictbox.Visible = False

        next_btn.Enabled = True
        testAccount_btn.Enabled = True

        ' έλεγχος του flag. αν είναι true, το sample mail στάλθηκε επιτυχώς. Εμφανίζω το dialog για την αποθήκευση του λογαριασμού.
        If (sent_flag) Then

            next_btn.Enabled = True
            testAccount_btn.Enabled = True

            Dim box As confirm_box
            box = New confirm_box()
            box.StartPosition = FormStartPosition.CenterParent
            box.ShowDialog()
            box = Nothing
            Me.Close()

        End If


    End Sub

End Class