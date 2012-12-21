Public Class ScheduleSMSForm

    ' disable 'X' (exit) button from form
    Private Const CP_NOCLOSE_BUTTON As Integer = &H200

    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim myCp As CreateParams = MyBase.CreateParams
            myCp.ClassStyle = myCp.ClassStyle Or CP_NOCLOSE_BUTTON
            Return myCp
        End Get
    End Property

    ' ενεργοποιώ-απενεργοποιώ το panel ανάλογα με τα radio buttons.
    Private Sub now_rbtn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles now_rbtn.CheckedChanged

        If (now_rbtn.Checked = False) Then
            choose_panel.Enabled = True
        Else
            choose_panel.Enabled = False
        End If

    End Sub

    ' on load αρχικοποιώ τα datetime picker controls
    Private Sub ScheduleSMSForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'timePicker.Format = DateTimePickerFormat.Time
        'timePicker.ShowUpDown = True

        'datePicker.Format = DateTimePickerFormat.Long

        timePicker.MinDate = Date.Now
        datePicker.MinDate = Date.Now

        timePicker.Value = Now
        datePicker.Value = Now

    End Sub

    ' ok_btn_Click
    Private Sub ok_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ok_btn.Click

        ' αν είναι επιλεγμένο το send later, προγραμματίζω την αποστολή.
        If (later_rbtn.Checked) Then

            Dim _date As String = datePicker.Value.Date.ToString("yyyy-MM-dd") ' παίρνω την ημερομηνία 
            Dim tmptime As TimeSpan = timePicker.Value.TimeOfDay ' παίρνω την ώρα
            Dim _time As String = String.Format("{0:00}:{1:00}", CInt(tmptime.TotalHours), tmptime.Minutes) ' μετατρέπω την ώρα για να εμφανίζεται ως ώρα:λεπτά.
            _date = _date & " " & _time ' ενώνω την ημερομηνία και την ώρα.

            ' μετατρέπω την ολοκληρωμένη ημερομηνία σε DateTime για να την συγκρίνω.
            Dim MyDateTime As New DateTime
            MyDateTime = DateTime.ParseExact(_date, "yyyy-MM-dd HH:mm", Nothing)

            ' Συγκρίνω την ολοκληρωμένη ημερομηνία με την τωρινή ημερομηνία.
            Dim result As Integer = DateTime.Compare(MyDateTime, Date.Now.ToString("yyyy-MM-dd HH:mm"))

            warning_lb.Visible = False
            ' αν το result είναι > 0, η ημερομηνία που επέλεξε ο χρήστης είναι μεγαλύτερη από την τωρινή, άρα προχωράω στον προγραμματισμό της αποστολής.
            If (result > 0) Then
                sms_mail_project.NewSmsMessage.isScheduled = True
                sms_mail_project.NewSmsMessage.sendDate = _date
                Me.Close()
            Else
                warning_lb.Visible = True
            End If
            ' αν είναι επιλεγμένο το Send Now radio button.
        Else
            sms_mail_project.NewSmsMessage.isScheduled = False
            Me.Close()
        End If

    End Sub

End Class