Public Class SMSResultsForm

    'details_btn_Click (Εμφάνηση απόκρυψη του gridView με τις λεπτομέριες).
    Private Sub details_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles details_btn.Click

        If (Me.details_btn.Text = "show details") Then

            'ρύθμιση ύψους της φόρμας
            Me.Height = 550
            Me.details_btn.Text = "hide details"
            results_gv.Visible = True

        ElseIf (Me.details_btn.Text = "hide details") Then

            'ρύθμιση ύψους της φόρμας
            Me.Height = 375
            Me.details_btn.Text = "show details"
            results_gv.Visible = False

        End If

    End Sub

    ' on load
    Private Sub SMSResultsForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'ενημέρωση των labels με μεταβλητές απο την NewMessage Form.
        total_lb.Text = "Total Messages: " & sms_mail_project.NewSmsMessage.sms_status_lst.Count
        delevered_lb.Text = "Delivered: " & sms_mail_project.NewSmsMessage.delivered
        failed_lb.Text = "Failed: " & sms_mail_project.NewSmsMessage.failed
        queued_lb.Text = "Queued: " & sms_mail_project.NewSmsMessage.queued
        pending_lb.Text = "Pending: " & sms_mail_project.NewSmsMessage.pending
        error_lb.Text = "Error: " & sms_mail_project.NewSmsMessage._error

        Dim percent As Double = (sms_mail_project.NewSmsMessage.delivered * 100) / sms_mail_project.NewSmsMessage.sms_status_lst.Count

        success_lb.Text = "Success Rate: " & Format(percent, "00.00") & "%"

        ' clear gridView
        results_gv.Rows.Clear()
        results_gv.Refresh()

        ' δημιουργεία 3 στηλών στο gridview και φόρτωση δεδομένων απο τη λιστα status_lst της NewMessage Form
        results_gv.ColumnCount = 3
        results_gv.Columns(0).Name = "Sent To:"
        results_gv.Columns(1).Name = "Sent Date:"
        results_gv.Columns(2).Name = "Sent Results:"

        results_gv.Columns(0).Width = 155
        results_gv.Columns(1).Width = 155
        results_gv.Columns(2).Width = 155

        Dim row As String()

        ' για κάθε αντικείμενο στο status list, δημιουργία νέας γραμμής στο gridView.
        For Each obj As Object In sms_mail_project.NewSmsMessage.sms_status_lst

            row = New String() {obj.recipient, obj.time, obj.result}
            results_gv.Rows.Add(row)

        Next

        results_gv.SelectionMode = DataGridViewSelectionMode.FullRowSelect

    End Sub

End Class