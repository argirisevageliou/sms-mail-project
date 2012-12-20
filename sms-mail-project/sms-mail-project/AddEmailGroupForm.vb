Imports System.IO
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Data.Common
Public Class AddEmailGroupForm

    'Σε αυτή τη μέθοδο προσθέτουμε ένα νέο γκρουπ με email διευθύνσεις
    'Αφενός προστίθεται σαν εγγραφή στον πίνακα emailgroups και 
    'Αφετέρου δημιουργείται ο αντίστοιχος πίνακας με τις επαφέ(email,όνομα, επώνυμο)
    Private Sub CreateGroupBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateGroupBtn.Click
        'Σε περίπτωση που το GroupNameTextBox είναι κενό, θα εμφανίζεται μια προειδοποίηση 
        If GroupNameTextBox.Text = "" Then
            AlertLabel.Visible = True
            'Αν δεν είναι κενό ,εκτελούνται τα παρακάτω
        Else
            AlertLabel.Visible = False
            Dim connection As OleDbConnection
            Dim command As OleDbCommand

            Dim insertquery As String = "INSERT INTO emailgroups(name) VALUES('" & GroupNameTextBox.Text & "');"
            Dim createquery As String = "CREATE TABLE " & GroupNameTextBox.Text _
            & "(Email char(30) PRIMARY KEY,FirstName char(30), LastName char(30));"

            Try
                connection = New OleDbConnection(My.Settings.testConnectionString)
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
                'Εμφανίζει το πρόβλημα που προέκυψε
                MessageBox.Show(ex.Message)
            End Try
            Me.Close()
            'Μόλις προστεθεί με επιτυχία το νέο γκρουπ, τότε εμφανίζεται η φόρμα ShowEmailGroupsForm
            'που περιέχει όλα μας τα γκρουπ
            Dim ShowEmailGroupsFormVar As ShowEmailGroupsForm
            ShowEmailGroupsFormVar = New ShowEmailGroupsForm()
            ShowEmailGroupsFormVar.StartPosition = FormStartPosition.CenterParent
            ShowEmailGroupsFormVar.ShowDialog()
            ShowEmailGroupsFormVar = Nothing
        End If
    End Sub
End Class