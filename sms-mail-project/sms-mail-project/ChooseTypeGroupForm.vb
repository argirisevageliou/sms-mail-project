Public Class ChooseTypeGroupForm

    Private Sub EmailGroupsBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmailGroupsBtn.Click

        Dim ShowEmailGroupsFormVar As ShowEmailGroupsForm
        ShowEmailGroupsFormVar = New ShowEmailGroupsForm()
        ShowEmailGroupsFormVar.StartPosition = FormStartPosition.CenterParent
        ShowEmailGroupsFormVar.ShowDialog()
        ShowEmailGroupsFormVar = Nothing
        Me.Close()
    End Sub

    Private Sub SmsGroupsBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SmsGroupsBtn.Click

        Dim ShowSmsGroupsFormVar As ShowSmsGroupsForm
        ShowSmsGroupsFormVar = New ShowSmsGroupsForm()
        ShowSmsGroupsFormVar.StartPosition = FormStartPosition.CenterParent
        ShowSmsGroupsFormVar.ShowDialog()
        ShowSmsGroupsFormVar = Nothing
        Me.Close()
    End Sub
End Class