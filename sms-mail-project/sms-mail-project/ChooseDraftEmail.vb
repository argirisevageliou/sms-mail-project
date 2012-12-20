Imports System.Data.OleDb

Public Class ChooseDraftEmail

    Private Sub ChooseDraftEmail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TestDataSet1.draftemails' table. You can move, or remove it, as needed.
        Me.DraftemailsTableAdapter.Fill(Me.TestDataSet1.draftemails)
        


    End Sub

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

    Private Sub ForwardBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ForwardBtn.Click
        sms_mail_project.NewMessage.subj = DraftSubject_TxtBox.Text
        sms_mail_project.NewMessage.send = DraftSendTo_TxtBox.Text
        sms_mail_project.NewMessage.mail = DraftMailTextBox.Text
        Me.Close()
    End Sub

    Private Sub DeleteBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteBtn.Click
        'Η μέθοδος αυτή καλείται όταν πατήσουμε το delete button και διαγράφεται το draft mail
        'έχουμε επιλέξει από το listbox
        Dim con As OleDbConnection
        Dim com As OleDbCommand

        Dim strSQL As String = "DELETE * FROM draftemails where subject='" & DraftSubject_TxtBox.Text & "';"

        Try

            con = New OleDbConnection(My.Settings.testConnectionString)
            com = New OleDbCommand(strSQL, con)
            con.Open()
            com.ExecuteNonQuery()
            con.Close()

            DraftSubject_TxtBox.Text = ""
            DraftMailTextBox.Text = ""
            DraftSendTo_TxtBox.Text = ""
            DraftDate_TxtBox.Text = ""
        Catch ex As Exception
            'Εμφανίζει το πρόβλημα που προέκυψε
            MessageBox.Show(ex.Message)

        End Try
        

        'Μόλις γίνει η διαγραφή ξαναφορτώνει την φόρμα ενημερωμένη
        ChooseDraftEmail_Load(Me, New System.EventArgs)
    End Sub
End Class