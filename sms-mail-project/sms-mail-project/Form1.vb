Imports System.Net.Mail

Public Class Form1
    'public variables, used at multiple forms
    Public selectemailgroup As String
    Public selectemail As String
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Dim answer As DialogResult
        answer = MessageBox.Show("Are you sure you want to exit?", "Form 1", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If answer = vbYes Then
            Application.Exit()
        End If
    End Sub
    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        'if groups is clicked, ShowEmailGroupsForm appears(contains user's emailgroups)
        ShowEmailGroupsForm.Show()
    End Sub
    Private Sub GerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GerToolStripMenuItem.Click
        'if NewGroup button is clicked, AddEmailGroupForm appears(user can add a new emailgroup)
        AddEmailGroupForm.Show()
    End Sub
End Class
