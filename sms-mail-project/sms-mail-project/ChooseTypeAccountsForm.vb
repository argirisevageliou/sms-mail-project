Public Class ChooseTypeAccountsForm

    Private Sub EmailAccMngButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmailAccMngButton.Click
        Dim Account_ManagerVar As Account_Manager
        Account_ManagerVar = New Account_Manager()
        Account_ManagerVar.StartPosition = FormStartPosition.CenterParent
        Account_ManagerVar.ShowDialog()
        Account_ManagerVar = Nothing
        Me.Close()
    End Sub

    Private Sub SmsAccMngButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SmsAccMngButton.Click
        Dim SMS_Account_ManagerVar As SMS_Account_Manager
        SMS_Account_ManagerVar = New SMS_Account_Manager()
        SMS_Account_ManagerVar.StartPosition = FormStartPosition.CenterParent
        SMS_Account_ManagerVar.ShowDialog()
        SMS_Account_ManagerVar = Nothing
        Me.Close()
    End Sub
End Class