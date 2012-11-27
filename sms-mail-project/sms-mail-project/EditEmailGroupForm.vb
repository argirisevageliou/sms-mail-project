Imports System.IO
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Data.Common
Imports System.Text.RegularExpressions

Public Class EditEmailGroupForm

    Private Sub EditGroup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'when this form loads, DataSetFromOleDb function is called
        DataSetFromOleDb()
    End Sub

    Private Sub DataSetFromOleDb()
        'this function uses a select query to find all contacts from the emailgroup we had selected 
        'at the ShowGroupForm and then a datagridview is filled with them using dataSet
        Dim selectquery As String = "SELECT * FROM " & Form1.selectemailgroup & ";"
        Try
            Dim connection = New OleDbConnection(My.Settings.testConnectionString)
            Dim command = New OleDbDataAdapter(selectquery, connection)
            Dim ds As Data.DataSet = New Data.DataSet
            command.Fill(ds)
            ContactsGrid.DataSource = ds.Tables(0)
            connection.Close()
            connection.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub AddContactBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddContactBtn.Click
        If FirstNameTextBox.Text = "" Or EmailTextBox.Text = "" Or EmailTextBox.Text = "" Or _
        AlertEmail.Visible = True Then
            Alertlabel.Visible = True
        Else
            Dim con As OleDbConnection
            Dim com As OleDbCommand
            Dim strSQL As String = "INSERT INTO " & Form1.selectemailgroup & "(Email,FirstName,LastName) VALUES('" & EmailTextBox.Text & _
            "','" & FirstNameTextBox.Text & "','" & LastNameTextBox.Text & "');"

            Try
                con = New OleDbConnection(My.Settings.testConnectionString)
                com = New OleDbCommand(strSQL, con)
                con.Open()
                com.ExecuteNonQuery()
                MessageBox.Show("New contact added succesfully")
                Alertlabel.Visible = False
                con.Close()
            Catch
                MessageBox.Show("A problem occured")

            End Try
        End If
        EditGroup_Load(Me, New System.EventArgs)
    End Sub

    Private Sub DeleteContactBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteContactBtn.Click

        Dim con As OleDbConnection
        Dim com As OleDbCommand

        Form1.selectemail = ContactsGrid.CurrentRow.Cells("Email").Value
        Dim strSQL As String = "DELETE * FROM " & Form1.selectemailgroup _
        & "where Email='" & Form1.selectemail & "';"

        Try

            con = New OleDbConnection(My.Settings.testConnectionString)
            com = New OleDbCommand(strSQL, con)
            con.Open()
            com.ExecuteNonQuery()
            con.Close()

            MessageBox.Show("Contact deleted")

        Catch
            MessageBox.Show("A problem occured")

        End Try
        EditGroup_Load(Me, New System.EventArgs)
    End Sub
    Private Sub EmailTextBox_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmailTextBox.Leave
        Dim correct_mail_Format As Boolean = Regex.IsMatch(EmailTextBox.Text, "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$")
        If correct_mail_Format Then
            AlertEmail.Visible = False
        Else
            AlertEmail.Visible = True

        End If
    End Sub
End Class