Public Class confirm_box

    ' disable 'X' (exit) button from form
    Private Const CP_NOCLOSE_BUTTON As Integer = &H200

    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim myCp As CreateParams = MyBase.CreateParams
            myCp.ClassStyle = myCp.ClassStyle Or CP_NOCLOSE_BUTTON
            Return myCp
        End Get
    End Property

    ' onload εμφάνση μηνύματος στο label.
    Private Sub Save_Settings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        msg_lb.Text = "Your account seems to works fine, " & vbCrLf & "do you want to save the settings and exit?"
    End Sub

    ' έξοδος χωρίς save (click 'no').
    Private Sub no_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles no_btn.Click
        Me.Close()
    End Sub

    ' αποθήκευση των ρυθμίσεων click 'yes'
    Private Sub yes_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles yes_btn.Click

        My.Settings.email = Account_Manager.email_tb_value
        My.Settings.name = Account_Manager.name_tb_value
        My.Settings.password = Account_Manager.pass_tb_value
        My.Settings.server = Account_Manager.server
        My.Settings.port = Account_Manager.port
        My.Settings.security = Account_Manager.ssl
        My.Settings.Save()
        Me.Close()

    End Sub

End Class