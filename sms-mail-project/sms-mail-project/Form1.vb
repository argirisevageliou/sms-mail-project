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



    Private Sub NewMessageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewMessageToolStripMenuItem.Click

        Dim newmsg As NewMessage
        newmsg = New NewMessage()
        newmsg.Show()
        newmsg.Location = New Point(Me.Left + (Me.Width / 2 - newmsg.Width / 2), Me.Top + (Me.Height / 2 - newmsg.Height / 2))


    End Sub

    Private Sub ManagerAccountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManagerAccountToolStripMenuItem.Click

        Dim account_manager As Account_Manager
        account_manager = New Account_Manager()
        account_manager.StartPosition = FormStartPosition.CenterParent
        account_manager.ShowDialog()
        account_manager = Nothing

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ShowEmailGroupsForm.Show()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub HelpContentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpContentsToolStripMenuItem.Click
        System.Windows.Forms.Help.ShowHelp(Me, "MyHelpContents.chm", HelpNavigator.AssociateIndex, ParentForm)
    End Sub

    Private Sub GerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GerToolStripMenuItem.Click
        AddEmailGroupForm.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Account_Manager.Show()
    End Sub

    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        If (TreeView1.SelectedNode.Text = "View Groups") Then
            ShowEmailGroupsForm.Show()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Show()
    End Sub
End Class
