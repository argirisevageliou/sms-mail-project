Public Class ChooseTypeGroupForm

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ShowEmailGroupsForm.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ShowSmsGroupsForm.Show()
        Me.Close()
    End Sub
End Class