Public Class ChooseTypeEmailMessagesForm

    Private Sub SentMessagesButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SentMessagesButton.Click
        MainForm.SentMessages()
        Me.Close()
    End Sub

    Private Sub DraftsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DraftsButton.Click
        MainForm.Drafts()
        Me.Close()
    End Sub
End Class