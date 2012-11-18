Imports System.IO
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Data.Common
Public Class AddEmailGroupForm

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'in case GroupNameTextBox is null alert label appears
        If GroupNameTextBox.Text = "" Then
            Alertlabel.Visible = True
            'else, these are below executed
        Else
            Alertlabel.Visible = False
            Dim connection As OleDbConnection
            Dim command As OleDbCommand
            'in this function is added an emailgroup (named from the textbox), to the emailgroups table
            'and the corresponding table that contains the contacts, is created

            Dim insertquery As String = "INSERT INTO emailgroups(name) VALUES('" & GroupNameTextBox.Text & "');"
            Dim createquery As String = "CREATE TABLE " & GroupNameTextBox.Text _
            & "(Email char(30) PRIMARY KEY,FirstName char(30), LastName char(30));"

            Try
                connection = New OleDbConnection(My.Settings.OleDbConnectionString)
                command = New OleDbCommand(createquery, connection)
                connection.Open()
                command.ExecuteNonQuery()
                connection.Close()

                command = New OleDbCommand(insertquery, connection)
                connection.Open()
                command.ExecuteNonQuery()
                MsgBox("Group added succesfully")
                connection.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            Me.Close()
            'after that ShowEmailGroupsForm appears(contains user's emailgroups)
            ShowEmailGroupsForm.Show()
        End If
    End Sub
End Class