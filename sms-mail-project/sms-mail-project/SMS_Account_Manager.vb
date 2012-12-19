Imports System.Web.HttpUtility
Imports System.Text.RegularExpressions

Public Class SMS_Account_Manager

    ' έλεγχος σύνδεσης στο internet (δήλωση).
    Private Declare Function InternetGetConnectedState Lib "wininet" _
  (ByRef conn As Long, ByVal val As Long) As Boolean

    ' on load method.
    Private Sub SMS_Account_Manager_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        If (My.Settings.SMSsenderID <> "" And My.Settings.SMSusername <> "" And My.Settings.SMSpassword <> "") Then

            senderID_tb.Text = My.Settings.SMSsenderID
            user_tb.Text = My.Settings.SMSusername
            pass_tb.Text = My.Settings.SMSpassword

            user_tb.ReadOnly = True
            pass_tb.ReadOnly = True
            senderID_tb.ReadOnly = True
            test_btn.Visible = False
            delete_btn.Visible = True

        Else

            Dim tmp As CueBanner = New CueBanner
            tmp.SetCueBanner(senderID_tb, senderID_tb.Tag)
            tmp.SetCueBanner(pass_tb, pass_tb.Tag)
            tmp.SetCueBanner(user_tb, user_tb.Tag)

        End If

    End Sub

    ' senderID textbox, Leave event.
    Private Sub senderID_tb_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles senderID_tb.Leave

        If (senderID_tb.Text = "") Then

            error_pr.SetError(senderID_tb, "This is a required field")

        Else
            ' έλεγχος με regular expression.
            Dim correct_sender_Format As Boolean = Regex.IsMatch(senderID_tb.Text, "^[a-zA-Z]{1,11}$|^[0-9]{1,16}$")

            If (Not correct_sender_Format) Then

                error_pr.SetError(senderID_tb, "sender ID should contains up to 11 characters or up to 16 digits")

            Else

                error_pr.SetError(senderID_tb, "")

            End If

        End If


    End Sub

    ' user textbox, Leave event.
    Private Sub user_tb_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles user_tb.Leave

        If (user_tb.Text = "") Then

            error_pr.SetError(user_tb, "This is a required field")

        Else

            error_pr.SetError(user_tb, "")

        End If

    End Sub

    ' pass textbox, Leave event.
    Private Sub pass_tb_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pass_tb.Leave

        If (pass_tb.Text = "") Then

            error_pr.SetError(pass_tb, "This is a required field")

        Else

            error_pr.SetError(pass_tb, "")

        End If

    End Sub

    ' test account button, Click event.
    Private Sub test_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles test_btn.Click

        ' Αν το text του κουμιού είναι Save Settings!! αποθηκεύω τις ρυθμίσεις του λογαριασμού.
        If (test_btn.Text = "Save Settings!!") Then

            My.Settings.SMSsenderID = senderID_tb.Text
            My.Settings.SMSusername = user_tb.Text
            My.Settings.SMSpassword = pass_tb.Text
            My.Settings.Save()

            user_tb.ReadOnly = True
            pass_tb.ReadOnly = True
            senderID_tb.ReadOnly = True
            test_btn.Visible = False
            delete_btn.Visible = True

            test_btn.Text = "Test Account!!"

        Else

            If (senderID_tb.Text <> "" And user_tb.Text <> "" And pass_tb.Text <> "") Then
                error_pr.SetError(test_btn, "")

                ' έλεγχος σύνδεσης στο internet.
                Dim Out As Integer
                If InternetGetConnectedState(Out, 0) = True Then

                    user_tb.ReadOnly = True
                    pass_tb.ReadOnly = True
                    senderID_tb.ReadOnly = True
                    test_btn.Enabled = False

                    ' δημιουργία ενώς αντικειμένου τύπου SMS_Service.smsPortTypeClient για να ελέγξω το λογαριασμό.
                    Dim client As New SMS_Service.smsPortTypeClient()

                    ' κάνω μια αίτηση στο web service για να μου επιστρέψει το υπόλοιπο του λογαριασμού.
                    Try
                        client.credits(UrlEncode(user_tb.Text), UrlEncode(pass_tb.Text))
                        test_btn.Text = "Save Settings!!"

                        ' αν η αίτηση απτύχει, γράφω το exception message στον error provider.
                    Catch e1 As Exception

                        error_pr.SetError(test_btn, e1.Message)

                    Finally

                        user_tb.ReadOnly = False
                        pass_tb.ReadOnly = False
                        senderID_tb.ReadOnly = False
                        test_btn.Enabled = True

                    End Try

                Else

                    error_pr.SetError(test_btn, "Internet connection error!!")

                End If

            End If

        End If

    End Sub

    ' delete account button, Click event.
    Private Sub delete_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles delete_btn.Click

        My.Settings.SMSsenderID = ""
        My.Settings.SMSusername = ""
        My.Settings.SMSpassword = ""
        My.Settings.Save()

        user_tb.ReadOnly = False
        pass_tb.ReadOnly = False
        senderID_tb.ReadOnly = False
        test_btn.Visible = True
        delete_btn.Visible = False

    End Sub

End Class