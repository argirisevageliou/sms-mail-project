Imports System.IO
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Data.Common
Public Class ShowEmailGroupsForm

    Private Sub ShowGroups_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'when this form loads, DataSetFromOleDb function is called
        DataSetFromOleDb()
    End Sub

    Private Sub DataSetFromOleDb()
        'this function uses a select query to find user's emailgroups and then 
        'a datagridview is filled with them using dataSet
        Dim selectquery As String = "SELECT * FROM emailgroups"
        Try
            Using adapter As New OleDbDataAdapter(selectquery, _
              My.Settings.testConnectionString)
                Dim ds As New DataSet
                adapter.Fill(ds, "name")
                EmailGroupsGrid.DataSource = ds.Tables("name")
            End Using
        Catch ex As Exception
            'if a problem occurs, an exception is throwed and appears what the problem is
            'for example the table already exists
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CreateGroupBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateGroupBtn.Click
        'if CreateGroupBtn is clicked, AddEmailGroupForm appears(user can add a new emailgroup)
        AddEmailGroupForm.Show()
        'this form closes after
        Me.Close()
    End Sub

    Private Sub EditGroupBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditGroupBtn.Click
        'this public variable stores the current cell of the datagridview(we will need this at EditEmailGroupForm)
        Form1.selectemailgroup = EmailGroupsGrid.CurrentRow.Cells("name").Value
        'EditEmailGroupForm appears and this form is closed
        EditEmailGroupForm.Show()
        Me.Close()
    End Sub

    Private Sub DeleteGroupBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteGroupBtn.Click
        'in this function the emailgroup we have selected from the datagridview is deleted from emailgroups table
        'and the corresponding table that contains the contacts, is dropped
        Dim connection As OleDbConnection
        Dim command As OleDbCommand
        'this public variable stores the current cell of the datagridview
        Form1.selectemailgroup = EmailGroupsGrid.CurrentRow.Cells("name").Value
        Dim deletequery As String = "DELETE * FROM emailgroups where name='" & Form1.selectemailgroup & "';"
        Dim droptablequery As String = "DROP TABLE " & Form1.selectemailgroup & ";"
        Try
            connection = New OleDbConnection(My.Settings.testConnectionString)
            command = New OleDbCommand(deletequery, connection)
            connection.Open()
            command.ExecuteNonQuery()
            connection.Close()

            command = New OleDbCommand(droptablequery, connection)
            connection.Open()
            command.ExecuteNonQuery()
            MessageBox.Show("Group deleted from emailgroups")
            connection.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'after that the form refreshes with the updated datagridview 
        ShowGroups_Load(Me, New System.EventArgs)
    End Sub
End Class