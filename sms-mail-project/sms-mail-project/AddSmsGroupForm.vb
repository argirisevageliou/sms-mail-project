Imports System.Data.OleDb

Public Class AddSmsGroupForm

    'Σε αυτή τη μέθοδο προσθέτουμε ένα νέο γκρουπ με επαφές sms
    'Αφενός προστίθεται σαν εγγραφή στον πίνακα smsgroups και 
    'Αφετέρου δημιουργείται ο αντίστοιχος πίνακας με τις επαφές(αριθμός,όνομα, επώνυμο)
    Private Sub CreateGroupBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateGroupBtn.Click
        'Σε περίπτωση που το GroupNameTextBox είναι κενό, θα εμφανίζεται μια προειδοποίηση 
        If GroupNameTextBox.Text = "" Then
            AlertLabel.Visible = True
            'Αν δεν είναι κενό ,εκτελούνται τα παρακάτω
        Else
            AlertLabel.Visible = False
            Dim connection As OleDbConnection
            Dim command As OleDbCommand

            Dim insertquery As String = "INSERT INTO smsgroups(name) VALUES('" & GroupNameTextBox.Text & "');"
            Dim createquery As String = "CREATE TABLE " & GroupNameTextBox.Text _
            & "(PhoneNumber char(10) PRIMARY KEY,FirstName char(30), LastName char(30));"

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
            'Μόλις προστεθεί με επιτυχία το νέο γκρουπ, τότε εμφανίζεται η φόρμα ShowSmsGroupsForm
            'που περιέχει όλα μας τα γκρουπ
            ShowSmsGroupsForm.Show()
        End If
    End Sub
End Class