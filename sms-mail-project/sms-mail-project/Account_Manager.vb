Imports HtmlAgilityPack
Imports System.Net
Imports System.Net.Mail
Imports System.Text.RegularExpressions


Public Class Account_Manager

    Public Shared server As String = ""
    Public Shared port As String = ""
    Public Shared ssl As String = ""
    Public Shared authedication As String = ""

    Dim pressed As String = "" ' Help variable in order to determine the background worker action
    Dim sent_flag As Boolean = False ' (finish button) if email sent show dialog for saving account settings

    'Store values from three textboxes in order to have access from confirm_box form
    Public Shared email_tb_value As String = ""
    Public Shared name_tb_value As String = ""
    Public Shared pass_tb_value As String = ""

    ' internet connection check
    Private Declare Function InternetGetConnectedState Lib "wininet" _
  (ByRef conn As Long, ByVal val As Long) As Boolean

    ' Check if the email text box is empty OR if the email format is wrong
    Private Sub email_tb_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles email_tb.Leave

        ' check with regular expression if email format is correct
        Dim correct_mail_Format As Boolean = Regex.IsMatch(email_tb.Text, "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$")
        If (email_tb.Text = "") Then ' visible = true for warning label
            checkMail_lb.Visible = True
            checkMail_lb.Text = "The E-mail Address field must not be empty!!"
        ElseIf (correct_mail_Format = False) Then
            checkMail_lb.Visible = True
            checkMail_lb.Text = "Please insert a correct e-mail format!!"
        Else
            checkMail_lb.Visible = False
        End If

    End Sub

    ' Check if the password text box is empty
    Private Sub pass_tb_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pass_tb.Leave

        If (pass_tb.Text = "") Then
            checkPass_lb.Visible = True
        Else
            checkPass_lb.Visible = False
        End If

    End Sub

    ' Check if the name text box is empty
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

    ' Exit from manager account form
    Private Sub cancel_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancel_btn.Click

        Me.Close()

    End Sub

    ' on load check if there are stored settings. If there are display details about the account. if not create new account
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

    ' next button pressed, check for default settings
    Private Sub next_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles next_btn.Click

        If (next_btn.Text = "Next") Then

            ' next button pressed, if all fields have correct values i search for default setting
            If (checkMail_lb.Visible = False And checkPass_lb.Visible = False And name_tb.Text <> "") Then

                email_tb.ReadOnly = True
                pass_tb.ReadOnly = True
                name_tb.ReadOnly = True
                Dim url As String = "https://autoconfig-live.mozillamessaging.com/autoconfig/v1.1/"
                ' concat url with domain name of account e.g url/gmail.com
                Dim tmp_name_address As String = email_tb.Text
                Dim index As Integer = tmp_name_address.IndexOf("@")
                Dim domain As String = tmp_name_address.Substring(index + 1)
                url = String.Concat(url, domain)

                parseMozillaISPDB(url, domain)
                next_btn.Text = "Finish"

            End If

        ElseIf (next_btn.Text = "Finish") Then

            ' start background worker with an argument
            next_btn.Enabled = False
            testAccount_btn.Enabled = False

            pressed = "finishPressed"
            nextFinish_pictbox.Visible = True ' picture box with loading gif graphic
            Worker.RunWorkerAsync(pressed)

        End If

    End Sub

    ' parse htlm file for taking info about default settings
    Private Sub parseMozillaISPDB(ByVal url As String, ByVal domain As String)

        next_btn.Enabled = False

        ' Check if an internet connection exists
        Dim Out As Integer
        If InternetGetConnectedState(Out, 0) = True Then
            status_lb.Text = "status: OK"
            Dim webClient As New System.Net.WebClient
            Try
                Dim result As String = webClient.DownloadString(url)

                ' using HtmlAgilityPack library for parsing the html (xml).
                Dim htmldoc As New HtmlAgilityPack.HtmlDocument

                htmldoc.LoadHtml(result)

                ' looking for a node with attribute 'type = smtp' in order to locate outgoing server
                Dim nodes As HtmlNodeCollection = htmldoc.DocumentNode.SelectNodes("//*[@type='smtp']")

                ' iterate all returning nodes. Normally should return on node.
                For Each node As HtmlNode In nodes

                    'if the name of node is outgoingserver, i iterate the sub-nodes in order to get details like hostname,port etc
                    If (node.Name = "outgoingserver") Then
                        Dim nodes_in_outgoing As HtmlNodeCollection = node.ChildNodes
                        For Each tmpnode As HtmlNode In nodes_in_outgoing
                            If (tmpnode.Name = "hostname") Then
                                server = tmpnode.InnerHtml
                            ElseIf (tmpnode.Name = "port") Then
                                port = tmpnode.InnerHtml
                                If (port = "465") Then
                                    port = "587" ' System.Net.Mail only supports “Explicit SSL” (587) not Implicit SSL (SMTPS - 465) :-(
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

                ' if server returns error 404 i activate manual settings
                If (e2.Message = "The remote server returned an error: (404) Not Found.") Then

                    'MsgBox("server Not Found")
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

                ' Here i catch the general exception and update status label
            Catch e1 As Exception

                status_lb.Text = "status: There is a problem with this action :" & e1.Message

            End Try

            If (server <> "" And port <> "" And ssl <> "" And authedication <> "") Then

                ' successfull parsing with manual settings enabled (Test Again is pressed)
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

                    '  successfull parsing, display details
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

    ' Manual settings for account
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

    ' test again button, testing for default settings again
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

    ' Test account with sending an email.
    Private Sub testAccount_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles testAccount_btn.Click

        ' start background worker for senting test mail
        next_btn.Enabled = False
        testAccount_btn.Enabled = False
        pressed = "testAccount"
        sent_pictbox.Visible = True ' picture box with loading gif graphic
        Worker.RunWorkerAsync(pressed)

    End Sub

    ' sent mail if manual settings are not in use
    Private Function testAccount(ByVal server As String, ByVal port As String) As Boolean

        ' Check if an internet connection exists
        Dim Out As Integer
        If InternetGetConnectedState(Out, 0) = True Then

            status_lb.Text = "status: OK"

            Dim MyMailMessage As New MailMessage()
            MyMailMessage.From = New MailAddress(email_tb.Text, name_tb.Text)
            MyMailMessage.To.Add(email_tb.Text)

            MyMailMessage.Subject = "Test"
            MyMailMessage.Body = "This is the test text email"

            Dim SMTPServer As New SmtpClient(server)
            SMTPServer.Port = port
            SMTPServer.Credentials = New System.Net.NetworkCredential(email_tb.Text, pass_tb.Text)
            If (port = "25") Then
                SMTPServer.EnableSsl = False
            Else
                SMTPServer.EnableSsl = True
            End If

            Try
                SMTPServer.Send(MyMailMessage)
                status_lb.Text = "status: Email Sent (The test succeeded)"
                Return True
            Catch ex As SmtpException
                status_lb.Text = "status: Email sent failed (" & ex.StatusCode.ToString & ")"
                Return False
            Catch ex1 As Exception
                status_lb.Text = "status: Email sent failed"
                Return False
            End Try
        Else
            status_lb.Text = "status: There is a problem with nerwork, email sent failed"
            Return False
        End If

    End Function

    ' sent mail if manual settings are in use
    Private Function testAccount() As Boolean

        ' Check if an internet connection exists
        Dim Out As Integer
        If InternetGetConnectedState(Out, 0) = True Then

            status_lb.Text = "status: OK"

            Dim MyMailMessage As New MailMessage()
            MyMailMessage.From = New MailAddress(email_tb.Text, name_tb.Text)
            MyMailMessage.To.Add(email_tb.Text)

            MyMailMessage.Subject = "Test"
            MyMailMessage.Body = "This is the test text email"

            Dim SMTPServer As New SmtpClient(serverConf_tb.Text)
            If (portConf_tb.Text = "465") Then
                SMTPServer.Port = CInt("587") ' System.Net.Mail only supports “Explicit SSL” (587) not Implicit SSL (SMTPS - 465) :-(
            Else
                SMTPServer.Port = CInt(portConf_tb.Text)
            End If
            SMTPServer.Credentials = New System.Net.NetworkCredential(email_tb.Text, pass_tb.Text)
            If (CInt(portConf_tb.Text) = 25) Then
                SMTPServer.EnableSsl = False
            Else
                SMTPServer.EnableSsl = True
            End If

            Try
                SMTPServer.Send(MyMailMessage)
                status_lb.Text = "status: Email Sent (The test succeeded)"
                Return True
            Catch ex As SmtpException
                status_lb.Text = "status: Email sent failed (" & ex.StatusCode.ToString & ")"
                Return False
            Catch ex1 As Exception
                status_lb.Text = "status: Email sent failed"
                Return False
            End Try
        Else
            status_lb.Text = "status: There is a problem with nerwork, email sent failed"
            Return False
        End If

    End Function

    ' delete the current account
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

    ' if pressed finish button - try to send a sample mail, and ability to save(create) one account
    Private Sub finishBtn()

        ' check if manual settigs are in use
        If (manualConf_btn.Enabled = True) Then
            Dim flag As Boolean = testAccount(server, port) ' sent sample email
            If (flag) Then
                status_lb.Text = "status: OK"

                email_tb_value = email_tb.Text
                pass_tb_value = pass_tb.Text
                name_tb_value = name_tb.Text

                sent_flag = True ' the mail sent successfully (it used in on Worker_RunWorkerCompleted)

            Else
                status_lb.Text = "status: Your account seems has problem, please check the settings"
            End If

        Else
            ' check if there are empty fields or fields with illegal values
            If (serverConf_tb.Text <> "" And portConf_tb.Text <> "") Then
                status_lb.Text = "status: OK"
                If (IsNumeric(portConf_tb.Text) = False) Then
                    portConf_tb.Text = ""
                    status_lb.Text = "status: Only numbers are permitted in 'port' field"
                Else
                    status_lb.Text = "status: OK"
                    Dim flag As Boolean = testAccount() ' sent sample email
                    If (flag) Then
                        status_lb.Text = "status: OK"

                        email_tb_value = email_tb.Text
                        pass_tb_value = pass_tb.Text
                        name_tb_value = name_tb.Text

                        sent_flag = True ' the mail sent successfully (it used in on Worker_RunWorkerCompleted)

                    Else
                        status_lb.Text = "status: Your account seems has problem, please check the settings"
                    End If
                End If
            Else
                status_lb.Text = "'Domain name of server' field and 'port' field must have a value"
            End If
        End If

    End Sub

    ' backgroundworker's DoWork method.
    Private Sub Worker_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles Worker.DoWork

        ' take the argument and check the value
        If (DirectCast(e.Argument(), String) = "testAccount") Then
            ' check when account is already configured
            If (manualConf_btn.Visible = False) Then
                testAccount(server, port)
                ' check manual settigs are used
            ElseIf (manualConf_btn.Enabled = True) Then
                testAccount(server, port)
            Else
                ' check if there are emty fields or fields with illegal values
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

    ' backgroundworker's RunWorkerCompleted method.
    Private Sub Worker_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles Worker.RunWorkerCompleted

        ' pictures boxes visible = false
        sent_pictbox.Visible = False
        nextFinish_pictbox.Visible = False

        next_btn.Enabled = True
        testAccount_btn.Enabled = True

        ' check flag. If true, sample mail sent successfully. I display dialog for saving the settings
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