Imports System.Data.OleDb
Imports Microsoft.Win32.TaskScheduler

Public Class Schedule_SendingForm

    ' disable 'X' (exit) button from form
    Private Const CP_NOCLOSE_BUTTON As Integer = &H200

    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim myCp As CreateParams = MyBase.CreateParams
            myCp.ClassStyle = myCp.ClassStyle Or CP_NOCLOSE_BUTTON
            Return myCp
        End Get
    End Property

    ' αλλαγή φορματ του datetimepicker control και ορισμό τιμής.
    Private Sub groupBox_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles groupBox.Enter

        chooseDate.CustomFormat = "dd-MM-yyyy HH.mm.ss tt"
        chooseDate.Value = Date.Now

    End Sub

    ' ενεργοποίηση - απενεργοποίηση panel
    Private Sub sendNow_rbtn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sendNow_rbtn.CheckedChanged

        If (sendNow_rbtn.Checked = False) Then
            choose_panel.Enabled = True
        Else
            choose_panel.Enabled = False
        End If

    End Sub

    '' ενεργοποίηση - απενεργοποίηση panel
    'Private Sub sendLater_rbtn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sendLater_rbtn.CheckedChanged

    '    If (sendNow_rbtn.Checked = False) Then
    '        choose_panel.Enabled = True
    '    Else
    '        choose_panel.Enabled = False
    '    End If

    'End Sub

    '' validate την τιμή του datetimepicker control
    'Private Sub chooseDate_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles chooseDate.Validating

    '    If (chooseDate.Value <= Date.Now) Then
    '        e.Cancel = True
    '        warning_lb.Visible = True
    '    Else
    '        warning_lb.Visible = False
    '    End If

    'End Sub

    ' ok_btn_Click

    Private Sub ok_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ok_btn.Click

        If (choose_panel.Enabled = True) Then

            Dim timeStamp As Date = Date.Now
            warning_lb.Visible = False

            ' αν η ημερομηνία-ώρα του chooseDate είναι μεγαλύτερη από τη τωρινή συνεχίζω.
            If (chooseDate.Value > timeStamp) Then

                If (sms_mail_project.NewMessage.sendto_content <> "") Then

                    ' flag για το ότι η αποστολή έχει προγραμματιστεί για αργότερα.
                    sms_mail_project.NewMessage.isScheduled = True

                    ' δημιουργία νέου task.
                    Using ts As New TaskService()
                        Dim td As TaskDefinition = ts.NewTask
                        td.RegistrationInfo.Description = "Sending scheduled email messages" ' περιγραφή task.

                        ' δημιοουργία ενώς timetrigger για το task. (ποιά χρονική στιγμή θα ξεκινήσει).
                        Dim time As New TimeTrigger()

                        'ορισμός χρονικής στιγμής εκκίνησης (τιμή από το chooseDate).
                        time.StartBoundary = chooseDate.Value
                        td.Triggers.Add(time) ' προσθήκη του trigger στο νέο task.
                        td.Settings.RunOnlyIfNetworkAvailable = True ' εκκίνηση του task μόνο αν υπάρχει δίκτυο.

                        ' ορισμός settings για το task.
                        td.Settings.StartWhenAvailable = startAfter_cb.Checked
                        td.Settings.WakeToRun = wake_cb.Checked
                        td.Settings.DisallowStartIfOnBatteries = battery_cb.Checked

                        ' td.Settings.Hidden = True ' επιλογή για να είναι κρυφό το task, επειδή, στις λεπτομέριες του εμφανίζονται και τα στοιχεία λογαριασμού.

                        ' ορισμός για το ποιό πρόγραμμα θα τρέξει το task, και ορισμός arguments για το πρόγραμμα.
                        td.Actions.Add(New ExecAction(AppDomain.CurrentDomain.BaseDirectory & "run-on-background-project.exe", _
                                                     String.Format("{0} {1} {2} {3} {4} {5}", timeStamp.ToString("dd-MM-yyyy_HH.mm.ss_tt"), _
                                                     My.Settings.server, My.Settings.port, My.Settings.email, My.Settings.password, My.Settings.name)))

                        ' κάνω register το task στο root folder και του δίνω ένα όνομα.(το όνομα χρησιμοποιείτε για να αναγνωρίσει το task ποιά δεδομένα από τη βάση θα εκτελέσει).
                        ts.RootFolder.RegisterTaskDefinition(timeStamp.ToString("dd-MM-yyyy HH.mm.ss tt"), td)

                    End Using

                    'εισαγωγή του μυνήματος στο πίνακα table. Τον πίνακα αυτό 'βλέπει' κάθε task όταν εκτελείτε
                    Dim connection As OleDbConnection
                    Dim command As OleDbCommand
                    'εισαγωγή νέας γραμμής με πεδία, τους παραλήπτες, το subject και το body του μυνήματος, επίσης το όνομα του task που δημιουργήθηκε για την εκτέλεση αυτής τη γραμμής.
                    Dim insertquery As String = "INSERT INTO pending(receivers,subject,mail,sendingTask) VALUES('" & sms_mail_project.NewMessage.sendto_content & _
                        "','" & sms_mail_project.NewMessage.subject_content & "','" & sms_mail_project.NewMessage.body_content & "','" & timeStamp.ToString("dd-MM-yyyy HH.mm.ss tt") & " ');"

                    Try
                        connection = New OleDbConnection(My.Settings.testConnectionString)
                        command = New OleDbCommand(insertquery, connection)
                        connection.Open()
                        command.ExecuteNonQuery()
                        connection.Close()

                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                End If
                Me.Close()
            Else
                warning_lb.Visible = True
            End If

        Else
            sms_mail_project.NewMessage.isScheduled = False
            Me.Close()
        End If

    End Sub

End Class