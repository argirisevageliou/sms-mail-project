Public Class ResultsForm

    'on load
    Private Sub ResultsForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'ενημέρωση των labels με μεταβλητές απο την NewMessage Form.
        total_lb.Text = "Total Messages: " & sms_mail_project.NewMessage.status_lst.Count
        sent_lb.Text = "Sent: " & sms_mail_project.NewMessage.success
        failed_lb.Text = "Failed: " & sms_mail_project.NewMessage.fail

        Dim percent As Double = (sms_mail_project.NewMessage.success * 100) / sms_mail_project.NewMessage.status_lst.Count

        success_lb.Text = "Success Rate: " & Format(percent, "00.00") & "%"

        ' clear gridView
        details_gridview.Rows.Clear()
        details_gridview.Refresh()

        ' δημιουργεία 3 στηλών στο gridview και φόρτωση δεδομένων απο τη λιστα status_lst της NewMessage Form
        details_gridview.ColumnCount = 3
        details_gridview.Columns(0).Name = "Sent To:"
        details_gridview.Columns(1).Name = "Sent Date:"
        details_gridview.Columns(2).Name = "Sent Results:"

        details_gridview.Columns(0).Width = 155
        details_gridview.Columns(1).Width = 155
        details_gridview.Columns(2).Width = 155

        Dim row As String()

        ' for each object in status list, create a new line
        For Each obj As Object In sms_mail_project.NewMessage.status_lst

            row = New String() {obj.address, obj.time, obj.result}
            details_gridview.Rows.Add(row)

        Next

        details_gridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect

    End Sub

    'more_less_btn_Click (Εμφάνηση απόκρυψη του gridView με τις λεπτομέριες).
    Private Sub more_less_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles more_less_btn.Click

        If (Me.more_less_btn.Text = "show details") Then

            'ρύθμιση ύψους της φόρμας
            Me.Height = 486
            Me.more_less_btn.Text = "hide details"
            details_gridview.Visible = True

        ElseIf (Me.more_less_btn.Text = "hide details") Then

            'ρύθμιση ύψους της φόρμας
            Me.Height = 302
            Me.more_less_btn.Text = "show details"
            details_gridview.Visible = False

        End If

    End Sub

End Class