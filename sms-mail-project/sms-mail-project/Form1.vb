Imports System.Net.Mail

Public Class Form1

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Dim answer As DialogResult
        answer = MessageBox.Show("Are you sure you want to exit?", "Form 1", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If answer = vbYes Then
            Application.Exit()
        End If
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click

    End Sub


End Class
