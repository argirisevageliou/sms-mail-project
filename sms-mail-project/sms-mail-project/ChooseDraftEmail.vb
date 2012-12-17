Imports System.Data.OleDb

Public Class ChooseDraftEmail

    Private Sub ChooseDraftEmail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Μόλις φορτώνει καλεί την DataSetFromOleDb
        DataSetFromOleDb()
    End Sub
    'Το GridView γεμίζει με ta drafts
    Private Sub DataSetFromOleDb()

        Dim selectquery As String = "SELECT * FROM draftemails"
        Try
            Dim connection = New OleDbConnection(My.Settings.testConnectionString)
            Dim command = New OleDbDataAdapter(selectquery, connection)
            Dim ds As Data.DataSet = New Data.DataSet
            command.Fill(ds)
            DraftEmailsGridView.DataSource = ds.Tables(0)
            connection.Close()
            connection.Dispose()
        Catch ex As Exception
            'Εμφανίζει το πρόβλημα που προέκυψε
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Όταν πατηθεί το Load Button τότε τα πεδία του NewMessage γεμίζουν με τα στοιχεία του draft που επιλέξαμε
    Private Sub LoadBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadBtn.Click
        sms_mail_project.NewMessage.subj = DraftEmailsGridView.CurrentRow.Cells("subject").Value
        sms_mail_project.NewMessage.send = DraftEmailsGridView.CurrentRow.Cells("senders").Value
        sms_mail_project.NewMessage.mail = DraftEmailsGridView.CurrentRow.Cells("mail").Value
 
        Me.Close()
    End Sub
End Class