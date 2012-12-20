Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Public Class EditSmsGroupForm

    Private Sub EditSmsGroupForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Μόλις ανοίξει αυτή η φόρμα καλεί την ΄μέθοδο DataSetFromOleDb
        DataSetFromOleDb()
    End Sub
    Private Sub DataSetFromOleDb()
        'Η μέθοδος αυτή χρησιμοποιεί ένα query για να εμφανίσει όλες τις επαφές του γκρουπ που 
        'επιλέξαμε στην ShowEmailGroupsForm και γεμίζει ένα datagridview με αυτές
        'Η MainForm.selectemailgroup είναι μια public μεταβλητή που την ορίσαμε στην MainForm
        'και πήρε τιμή στην ShowEmailGroupsForm
        Dim selectquery As String = "SELECT * FROM " & MainForm.selectsmsgroup & ";"
        Try
            Dim connection = New OleDbConnection(My.Settings.testConnectionString)
            Dim command = New OleDbDataAdapter(selectquery, connection)
            Dim ds As Data.DataSet = New Data.DataSet
            command.Fill(ds)
            ContactsGrid.DataSource = ds.Tables(0)
            connection.Close()
            connection.Dispose()
        Catch ex As Exception
            'Εμφανίζει το πρόβλημα που προέκυψε
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub AddContactBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddContactBtn.Click
        'Η μέθοδος αυτή καλείται μόλις πατήσουμε το addcontact button και προσθέτει μια νέα επαφή
        'στο γκρουπ που επιλέξαμε στην ShowSmsGroupsForm με τα στοιχεία των textboxes
        If FirstNameTextBox.Text = "" Or LastNameTextBox.Text = "" Or NumberTextBox.Text = "" Then
            'αν κάποιο από τα labels δεν έχει συμπληρωθεί τότε εμφανίζει error message
            AlertEmail.Visible = False
            Alertlabel.Visible = True
        Else
            'Αλλιώς εκτελεί το query και προστίθεται η επαφή
            Dim con As OleDbConnection
            Dim com As OleDbCommand
            Dim strSQL As String = "INSERT INTO " & MainForm.selectsmsgroup & "(PhoneNumber,FirstName,LastName) VALUES('" & NumberTextBox.Text & _
            "','" & FirstNameTextBox.Text & "','" & LastNameTextBox.Text & "');"

            Try
                con = New OleDbConnection(My.Settings.testConnectionString)
                com = New OleDbCommand(strSQL, con)
                con.Open()
                com.ExecuteNonQuery()
                MessageBox.Show("New contact added succesfully")
                Alertlabel.Visible = False
                con.Close()
            Catch ex As Exception
                'Εμφανίζει το πρόβλημα που προέκυψε
                MessageBox.Show(ex.Message)

            End Try
        End If
        'Μόλις γίνει η προσθήκη ξαναφορτώνει την φόρμα ενημερωμένη
        EditSmsGroupForm_Load(Me, New System.EventArgs)
        FirstNameTextBox.Text = ""
        LastNameTextBox.Text = ""
        NumberTextBox.Text = ""

    End Sub

    Private Sub NumberTextBox_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumberTextBox.Leave
        'Η μέθοδος αυτή καλείται όταν κάνουμε unfocus το textbox του number και δεν έχουμε βάλει 
        'τον αριθμό στην κατάλληλη μορφή
        Dim correct_mail_Format As Boolean = Regex.IsMatch(NumberTextBox.Text, "^[6][9][0|3|4|5|7|8|9]{1}[0-9]{7}$")
        If correct_mail_Format Then
            AlertEmail.Visible = False
            AddContactBtn.Enabled = True
        Else
            AlertEmail.Visible = True
            AddContactBtn.Enabled = False
        End If
    End Sub

    Private Sub DeleteContactBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteContactBtn.Click
        'Η μέθοδος αυτή καλείται όταν πατήσουμε το delete button και διαγράφεται η επαφή που 
        'έχουμε επιλέξει από το datagridview
        Dim con As OleDbConnection
        Dim com As OleDbCommand

        'Σε αυτήν την public μεταβλητή που έχουμε ορίσει στην MainForm αποθηκεύουμε 
        'την επαφή που έχουμε επιλέξει από το datagridview την οποία θα την χρειαστούμε στο query

        MainForm.selectsms = ContactsGrid.CurrentRow.Cells("PhoneNumber").Value
        Dim strSQL As String = "DELETE * FROM " & MainForm.selectsmsgroup _
        & "where PhoneNumber='" & MainForm.selectsms & "';"

        Try

            con = New OleDbConnection(My.Settings.testConnectionString)
            com = New OleDbCommand(strSQL, con)
            con.Open()
            com.ExecuteNonQuery()
            con.Close()

            MessageBox.Show("Contact deleted")

        Catch ex As Exception
            'Εμφανίζει το πρόβλημα που προέκυψε
            MessageBox.Show(ex.Message)

        End Try
        'Μόλις γίνει η διαγραφή ξαναφορτώνει την φόρμα ενημερωμένη
        EditSmsGroupForm_Load(Me, New System.EventArgs)
    End Sub
End Class