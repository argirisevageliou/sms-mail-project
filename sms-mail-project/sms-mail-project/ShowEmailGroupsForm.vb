Imports System.IO
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Data.Common
Public Class ShowEmailGroupsForm

    Private Sub ShowEmailGroups_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Όταν φορτώνει αυτή η φόρμα καλείται η μέθοδος DataSetFromOleDb
        DataSetFromOleDb1()
    End Sub

    Private Sub DataSetFromOleDb1()
        'Σε αυτή τη μέθοδο υποβάλλουμε ένα query στη βάση δεδομένων για να βρούμε τα emailgroups
        'και τα αποτελέσματα γεμίζουν ένα datagridview με χρήση dataSet
        Dim selectquery As String = "SELECT * FROM emailgroups"
        Try
            Using adapter As New OleDbDataAdapter(selectquery, _
              My.Settings.testConnectionString)
                Dim ds As New DataSet
                adapter.Fill(ds, "name")
                EmailGroupsGrid.DataSource = ds.Tables("name")
            End Using
        Catch ex As Exception
            'Εμφανίζει το πρόβλημα που προέκυψε
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CreateGroupBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateGroupBtn.Click
        'H μέθοδος αυτή καλείται όταν πατήσουμε το createGroup button 
        'η οποία μας μεταφέρει στην AddEmailGroupForm(ο χρήστης μπορεί να προσθέσει νέο γκρουπ)
        Dim AddEmailGroupFormVar As AddEmailGroupForm
        AddEmailGroupFormVar = New AddEmailGroupForm()
        AddEmailGroupFormVar.StartPosition = FormStartPosition.CenterParent
        AddEmailGroupFormVar.ShowDialog()
        AddEmailGroupFormVar = Nothing
        'Μετά αυτή η φόρμα κλείνει
        Me.Close()
    End Sub

    Private Sub EditGroupBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditGroupBtn.Click
        'Σε αυτή την public μεταβλητή που έχουμε ορίσει στην MainForm αποθηκεύουμε ποιο γκρουπ έχουμε
        'επιλέξει να επεξεργαστούμε από το datagridview(θα το χρειαστούμε στην EditEmailGroupForm)
        MainForm.selectemailgroup = EmailGroupsGrid.CurrentRow.Cells("name").Value
        'Εμφανίζεται η EditEmailGroupForm και αυτή η φόρμα κλέινει
        Dim EditEmailGroupFormVar As EditEmailGroupForm
        EditEmailGroupFormVar = New EditEmailGroupForm()
        EditEmailGroupFormVar.StartPosition = FormStartPosition.CenterParent
        EditEmailGroupFormVar.ShowDialog()
        EditEmailGroupFormVar = Nothing
        Me.Close()
    End Sub

    Private Sub DeleteGroupBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteGroupBtn.Click
        'Αυτή η μέθοδος καλείται όταν πατήσουμε το delete button και διαγράφει το γκρουπ 
        'αφενός την εγγραφή που υπάρχει στον πίνακα emailgroups
        'και αφετέρου τον αντίστοιχο πίνακα με τις εγγραφές
        Dim connection As OleDbConnection
        Dim command As OleDbCommand
        'Αυτή η public μεταβλητή που έχουμε ορίσει στην MainForm αποθηκεύει το γκρουπ που 
        'έχουμε επιλέξει από το datagridview το οποίο θα την χρειαστούμε στο query
        MainForm.selectemailgroup = EmailGroupsGrid.CurrentRow.Cells("name").Value
        Dim deletequery As String = "DELETE * FROM emailgroups where name='" & MainForm.selectemailgroup & "';"
        Dim droptablequery As String = "DROP TABLE " & MainForm.selectemailgroup & ";"
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
        'Μόλις γίνει η διαγραφή ξαναφορτώνει την φόρμα ενημερωμένη
        ShowEmailGroups_Load(Me, New System.EventArgs)
    End Sub
End Class