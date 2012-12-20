Imports System.Net.Mail
Imports System.IO
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Data.Common
Imports System.Text.RegularExpressions




Public Class MainForm
    'Χρησιμοποιούμε αυτές τις δύο public μεταβλητές για να κρατήσουμε μόνιμα αποθηκευμένα δεδομένα
    'που θα χειριστούμε σε κάποιες φόρμες όπως η EditEmailGroupForm, η AddEmailGroupForm κτλ
    Public selectemailgroup As String
    Public selectemail As String
    Public selectsmsgroup As String
    Public selectsms As String


    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click

        Dim answer As DialogResult
        answer = MessageBox.Show("Are you sure you want to exit?", "Form 1", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If answer = vbYes Then
            Application.Exit()
        End If
    End Sub



    Private Sub NewMessageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewMessageToolStripMenuItem.Click
        Draft_Panel.Visible = False
        Sent_Panel.Visible = False
        Create_Panel.Visible = False
        ShowEmailGroups_Panel.Visible = False
        EditEmailGroup_Panel.Visible = False
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

    'Εμφανίζει την ShowEmailGroupsForm
    Private Sub GroupsBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupsBtn.Click
        Draft_Panel.Visible = False
        Sent_Panel.Visible = False
        Create_Panel.Visible = False
        ShowEmailGroups_Panel.Visible = False
        EditEmailGroup_Panel.Visible = False

        Dim ChooseTypeGroupVar As ChooseTypeGroupForm
        ChooseTypeGroupVar = New ChooseTypeGroupForm()
        ChooseTypeGroupVar.StartPosition = FormStartPosition.CenterParent
        ChooseTypeGroupVar.ShowDialog()
        ChooseTypeGroupVar = Nothing
    End Sub
    'Η μεθοδος αυτη καλειται οταν πατησουμε στο treeview την επιλογη Drafts
    Public Sub Drafts()
        Sent_Panel.Visible = False
        Draft_Panel.Visible = True
        Create_Panel.Visible = False
        ShowEmailGroups_Panel.Visible = False
        EditEmailGroup_Panel.Visible = False
        'Γεμίζει το ListBox των DraftEmails
        Me.DraftemailsTableAdapter.Fill(Me.TestDataSet1.draftemails)
        DraftListBox.SelectedIndex = -1
    End Sub
    'Η μεθοδος αυτη καλειται οταν πατησουμε στο treeview την επιλογη SentMessages
    Public Sub SentMessages()
        Sent_Panel.Visible = True
        Draft_Panel.Visible = False
        Create_Panel.Visible = False
        ShowEmailGroups_Panel.Visible = False
        EditEmailGroup_Panel.Visible = False
        'Γεμίζει το ListBox των SentEmails
        Me.SentemailsTableAdapter.Fill(Me.TestDataSet2.sentemails)
        SentListBox.SelectedIndex = -1
    End Sub
    'Επιλέγουμε στοιχείο από το TreeView
    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        'Εμφανίζει το Draft Panel και αποκρύπτει τα υπόλοιπα Panels
        If (TreeView1.SelectedNode.Text = "Drafts") Then
            Drafts()
        End If
        'Εμφανίζει το Sent Panel και αποκρύπτει τα υπόλοιπα Panels
        If (TreeView1.SelectedNode.Text = "Sent Messages") Then
            SentMessages()
        End If
        If (TreeView1.SelectedNode.Text = "Add Group") Then
            Create_Panel.Visible = True
            Sent_Panel.Visible = False
            Draft_Panel.Visible = False
            ShowEmailGroups_Panel.Visible = False
            EditEmailGroup_Panel.Visible = False
        End If
        If (TreeView1.SelectedNode.Text = "View Groups") Then
            ShowEmailGroups_Panel.Visible = True
            Create_Panel.Visible = False
            Sent_Panel.Visible = False
            Draft_Panel.Visible = False
            EditEmailGroup_Panel.Visible = False
            'Όταν φορτώνει αυτή η φόρμα καλείται η μέθοδος DataSetFromOleDb
            DataSetFromOleDb1()
        End If
    End Sub

    'Aποκρύπτει όλα τα Panels
    Private Sub HomeBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HomeBtn.Click
        Draft_Panel.Visible = False
        Sent_Panel.Visible = False
        Create_Panel.Visible = False
        ShowEmailGroups_Panel.Visible = False
        EditEmailGroup_Panel.Visible = False
    End Sub

#Region "Load Draft's or Sent's Emails information at the Panels"
    'Όταν επιλεγεί ένα Draft από το ListBox φορτώνονται τα στοιχεία του στα πεδία του Draft Panel
    Private Sub DraftListBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DraftListBox.SelectedIndexChanged

        Dim temp As String = DraftListBox.Text

        Dim connetionString As String
        Dim oledbCnn As OleDbConnection
        Dim oledbCmd As OleDbCommand
        Dim sql As String

        connetionString = My.Settings.testConnectionString
        sql = "SELECT * FROM draftemails WHERE subject = '" & temp & "'"

        oledbCnn = New OleDbConnection(connetionString)
        Try
            oledbCnn.Open()
            oledbCmd = New OleDbCommand(sql, oledbCnn)
            Dim oledbReader As OleDbDataReader = oledbCmd.ExecuteReader()
            While oledbReader.Read
                DraftSubject_TxtBox.Text = oledbReader.Item(1)
                DraftSendTo_TxtBox.Text = oledbReader.Item(2)
                DraftMailTextBox.Text = oledbReader.Item(3)
                DraftDate_TxtBox.Text = oledbReader.Item(4)
            End While
            oledbReader.Close()
            oledbCmd.Dispose()
            oledbCnn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Όταν επιλεγεί ένα Sent από το ListBox φορτώνονται τα στοιχεία του στα πεδία του Sent Panel
    Private Sub SentListBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SentListBox.SelectedIndexChanged
        Dim temp As String = SentListBox.Text

        Dim connetionString As String
        Dim oledbCnn As OleDbConnection
        Dim oledbCmd As OleDbCommand
        Dim sql As String

        connetionString = My.Settings.testConnectionString
        sql = "SELECT * FROM sentemails WHERE subject = '" & temp & "'"

        oledbCnn = New OleDbConnection(connetionString)
        Try
            oledbCnn.Open()
            oledbCmd = New OleDbCommand(sql, oledbCnn)
            Dim oledbReader As OleDbDataReader = oledbCmd.ExecuteReader()
            While oledbReader.Read
                SentSubject_TxtBox.Text = oledbReader.Item(1)
                SentSendTo_TxtBox.Text = oledbReader.Item(2)
                SentMailTextBox.Text = oledbReader.Item(3)
                SentDate_TxtBox.Text = oledbReader.Item(4)
            End While
            oledbReader.Close()
            oledbCmd.Dispose()
            oledbCnn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "RightClickMenu"
    'Εμφανίζει ένα right click menu για κάθε ένα από τα draft emails
    Private Sub DraftListBox_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DraftListBox.MouseUp

        If e.Button = MouseButtons.Right Then

            Dim n As Integer = Me.DraftListBox.IndexFromPoint(e.X, e.Y)
            If n <> ListBox.NoMatches Then
                Me.DraftListBox.SelectedIndex = n

                Dim cMenu = New ContextMenu()

                'Add a button to the menu

                cMenu.MenuItems.Add("Forward")
                cMenu.MenuItems.Add("Delete")



                'Show the menu at click position

                cMenu.Show(sender, New Point(e.X, e.Y))
            End If
        End If
    End Sub

    'Εμφανίζει ένα right click menu για κάθε ένα από τα sent emails
    Private Sub SentListBox_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles SentListBox.MouseUp
        If e.Button = MouseButtons.Right Then

            Dim n As Integer = Me.SentListBox.IndexFromPoint(e.X, e.Y)
            If n <> ListBox.NoMatches Then
                Me.SentListBox.SelectedIndex = n

                Dim cMenu = New ContextMenu()

                'Add a button to the menu

                cMenu.MenuItems.Add("Forward")
                cMenu.MenuItems.Add("Delete")

                'Show the menu at click position

                cMenu.Show(sender, New Point(e.X, e.Y))
            End If
        End If
    End Sub
#End Region

#Region "Create Group Panel"
    Private Sub CreateGroupBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateGroupBtn.Click
        'Σε περίπτωση που το GroupNameTextBox είναι κενό, θα εμφανίζεται μια προειδοποίηση 
        If GroupNameTextBox.Text = "" Then
            Alertlabel.Visible = True
            'Αν δεν είναι κενό ,εκτελούνται τα παρακάτω
        Else
            Alertlabel.Visible = False
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
        End If
        GroupNameTextBox.Text = ""
    End Sub
#End Region

#Region "Show Email Groups"
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


    Private Sub DeleteGroupBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteGroupBtn.Click
        'Αυτή η μέθοδος καλείται όταν πατήσουμε το delete button και διαγράφει το γκρουπ 
        'αφενός την εγγραφή που υπάρχει στον πίνακα emailgroups
        'και αφετέρου τον αντίστοιχο πίνακα με τις εγγραφές
        Dim connection As OleDbConnection
        Dim command As OleDbCommand
        'Αυτή η public μεταβλητή που έχουμε ορίσει στην Form1 αποθηκεύει το γκρουπ που 
        'έχουμε επιλέξει από το datagridview το οποίο θα την χρειαστούμε στο query
        selectemailgroup = EmailGroupsGrid.CurrentRow.Cells("name").Value
        Dim deletequery As String = "DELETE * FROM emailgroups where name='" & selectemailgroup & "';"
        Dim droptablequery As String = "DROP TABLE " & selectemailgroup & ";"
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
        DataSetFromOleDb1()
    End Sub
#End Region


    Private Sub EditGroupBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditGroupBtn.Click
        selectemailgroup = EmailGroupsGrid.CurrentRow.Cells("name").Value
        EditEmailGroup_Panel.Visible = True
        ShowEmailGroups_Panel.Visible = False
        DataSetFromOleDb()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        ShowEmailGroups_Panel.Visible = False
        Create_Panel.Visible = True
    End Sub
    Private Sub DataSetFromOleDb()
        'Η μέθοδος αυτή χρησιμοποιεί ένα query για να εμφανίσει όλες τις επαφές του γκρουπ που 
        'επιλέξαμε στην ShowEmailGroupsForm και γεμίζει ένα datagridview με αυτές
        'Η Form1.selectemailgroup είναι μια public μεταβλητή που την ορίσαμε στην Form1
        'και πήρε τιμή στην ShowEmailGroupsForm
        Dim selectquery As String = "SELECT * FROM " & selectemailgroup & ";"
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
        'στο γκρουπ που επιλέξαμε στην ShowEmailGroupsForm με τα στοιχεία των textboxes
        If FirstNameTextBox.Text = "" Or EmailTextBox.Text = "" Or EmailTextBox.Text = "" Then
            'αν κάποιο από τα labels δεν έχει συμπληρωθεί τότε εμφανίζει error message
            AlertEmail.Visible = True
            Alertlabel.Visible = True
        Else
            'Αλλιώς εκτελεί το query και προστίθεται η επαφή
            Dim con As OleDbConnection
            Dim com As OleDbCommand
            Dim strSQL As String = "INSERT INTO " & selectemailgroup & "(Email,FirstName,LastName) VALUES('" & EmailTextBox.Text & _
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
        'Μόλις γίνει η διαγραφή ξαναφορτώνει την φόρμα ενημερωμένη
        DataSetFromOleDb()
        FirstNameTextBox.Text = ""
        LastNameTextBox.Text = ""
        EmailTextBox.Text = ""
    End Sub

    Private Sub DeleteContactBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteContactBtn.Click
        'Η μέθοδος αυτή καλείται όταν πατήσουμε το delete button και διαγράφεται η επαφή που 
        'έχουμε επιλέξει από το datagridview
        Dim con As OleDbConnection
        Dim com As OleDbCommand

        'Σε αυτήν την public μεταβλητή που έχουμε ορίσει στην Form1 αποθηκεύουμε 
        'την επαφή που έχουμε επιλέξει από το datagridview την οποία θα την χρειαστούμε στο query

        selectemail = ContactsGrid.CurrentRow.Cells("Email").Value
        Dim strSQL As String = "DELETE * FROM " & Me.selectemailgroup _
        & "where Email='" & selectemail & "';"

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
        DataSetFromOleDb()
    End Sub

    Private Sub EmailTextBox_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmailTextBox.Leave
        'Η μέθοδος αυτή καλείται όταν κάνουμε unfocus το textbox του email και δεν έχουμε βάλει 
        'τη διεύθυνση στην κατάλληλη μορφή
        Dim correct_mail_Format As Boolean = Regex.IsMatch(EmailTextBox.Text, "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$")
        If correct_mail_Format Then
            AlertEmail.Visible = False
            AddContactBtn.Enabled = True
        Else
            AlertEmail.Visible = True
            AddContactBtn.Enabled = False
        End If
    End Sub


    Private Sub SMSAccountManager_menu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SMSAccountManager_menu.Click

        Dim sms_account_manager As SMS_Account_Manager
        sms_account_manager = New SMS_Account_Manager()
        sms_account_manager.StartPosition = FormStartPosition.CenterParent
        sms_account_manager.ShowDialog()
        sms_account_manager = Nothing

    End Sub

    Private Sub NewSmsMessageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewSmsMessageToolStripMenuItem.Click
        Draft_Panel.Visible = False
        Sent_Panel.Visible = False
        Create_Panel.Visible = False
        ShowEmailGroups_Panel.Visible = False
        EditEmailGroup_Panel.Visible = False

        Dim SmsMessage As NewSmsMessage
        SmsMessage = New NewSmsMessage()
        SmsMessage.StartPosition = FormStartPosition.CenterParent
        SmsMessage.ShowDialog()
        SmsMessage = Nothing
    End Sub

    Private Sub GerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GerToolStripMenuItem.Click
        Draft_Panel.Visible = False
        Sent_Panel.Visible = False
        Create_Panel.Visible = False
        ShowEmailGroups_Panel.Visible = False
        EditEmailGroup_Panel.Visible = False

        Dim AddEmailGroupVar As AddEmailGroupForm
        AddEmailGroupVar = New AddEmailGroupForm()
        AddEmailGroupVar.StartPosition = FormStartPosition.CenterParent
        AddEmailGroupVar.ShowDialog()
        AddEmailGroupVar = Nothing
    End Sub

    Private Sub NewSmsGroupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewSmsGroupToolStripMenuItem.Click
        Draft_Panel.Visible = False
        Sent_Panel.Visible = False
        Create_Panel.Visible = False
        ShowEmailGroups_Panel.Visible = False
        EditEmailGroup_Panel.Visible = False

        Dim AddSmsGroupVar As AddSmsGroupForm
        AddSmsGroupVar = New AddSmsGroupForm()
        AddSmsGroupVar.StartPosition = FormStartPosition.CenterParent
        AddSmsGroupVar.ShowDialog()
        AddSmsGroupVar = Nothing
    End Sub

    Private Sub MessagesBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MessagesBtn.Click
        Draft_Panel.Visible = False
        Sent_Panel.Visible = False
        Create_Panel.Visible = False
        ShowEmailGroups_Panel.Visible = False
        EditEmailGroup_Panel.Visible = False

        Dim ChooseTypeEmailMessagesVar As ChooseTypeEmailMessagesForm
        ChooseTypeEmailMessagesVar = New ChooseTypeEmailMessagesForm()
        ChooseTypeEmailMessagesVar.StartPosition = FormStartPosition.CenterParent
        ChooseTypeEmailMessagesVar.ShowDialog()
        ChooseTypeEmailMessagesVar = Nothing
    End Sub

    Private Sub AccountsBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccountsBtn.Click
        Draft_Panel.Visible = False
        Sent_Panel.Visible = False
        Create_Panel.Visible = False
        ShowEmailGroups_Panel.Visible = False
        EditEmailGroup_Panel.Visible = False

        Dim ChooseTypeAccountsVar As ChooseTypeAccountsForm
        ChooseTypeAccountsVar = New ChooseTypeAccountsForm()
        ChooseTypeAccountsVar.StartPosition = FormStartPosition.CenterParent
        ChooseTypeAccountsVar.ShowDialog()
        ChooseTypeAccountsVar = Nothing
    End Sub
End Class
