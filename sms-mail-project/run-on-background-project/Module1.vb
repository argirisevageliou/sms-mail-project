Imports System.Net.Mail
Imports System.Data.OleDb
Imports System.Threading
Imports Microsoft.Win32.TaskScheduler
Imports System.IO

Module Module1

    Dim messages ' anonymous αντικείμενο.
    Dim arguments As String() ' πινακας που περιέχει τα arguments που περάστηκαν κατά την κλήση του παρόντος προγράμματος.
    Dim counter As Integer ' counter που μετράει πόσα threads έχουν εκτελεστεί.
    Dim addresses_count As Integer ' counter που μετράει το πλήθος των διευθύνσεων που θα γίνει αποστολή (στην ουσία το πλήθος των threads).

    ' έλεγος για σύνδεση στο internet
    Private Declare Function InternetGetConnectedState Lib "wininet" _
  (ByRef conn As Long, ByVal val As Long) As Boolean

    ' main method.
    Sub Main(ByVal args As String())

        ' διαγραφή του log file.

        If System.IO.File.Exists(AppDomain.CurrentDomain.BaseDirectory & "backgroundSending.log") = True Then
            System.IO.File.Delete(AppDomain.CurrentDomain.BaseDirectory & "backgroundSending.log")
        End If

        ' αρχικοποίηση μεταβλητών.
        While (System.Diagnostics.Trace.Listeners.Count > 0)
            System.Diagnostics.Trace.Listeners.RemoveAt(0)
        End While

        System.Diagnostics.Trace.Listeners.Add(New TextWriterTraceListener(AppDomain.CurrentDomain.BaseDirectory & "backgroundSending.log"))

        Trace.AutoFlush = True

        counter = 0
        messages = Nothing
        arguments = args
        Dim taskName As String = ""

        Trace.WriteLine("Sending....") ' εντολή debuging, γράφει το output σε log file.
        Trace.WriteLine(args.Length) ' εντολή debuging, γράφει το output σε log file.

        ' πρέπει να υπάρχουν ακριβώς 6 ορίσματα.
        If (args.Length = 6) Then

            taskName = args(0)
            taskName = taskName.Replace("_", " ") ' αλλάζω τη διαμόρφωση του taskName για να το συγκρίνω με το πεδίο sendingTask της βάσης.

            Trace.WriteLine("Task: " & taskName) ' εντολή debuging, γράφει το output σε log file.
            Trace.WriteLine("server: " & args(1)) ' εντολή debuging, γράφει το output σε log file.
            Trace.WriteLine("port: " & args(2)) ' εντολή debuging, γράφει το output σε log file.
            Trace.WriteLine("email: " & args(3)) ' εντολή debuging, γράφει το output σε log file.
            'Trace.WriteLine("pass: " & args(4)) ' εντολή debuging, γράφει το output σε log file.
            Trace.WriteLine("name: " & args(5)) ' εντολή debuging, γράφει το output σε log file.

            retrieveFromDB(taskName)

            'αν το αντικείμενο messages δεν είναι κενό καλώ σην startSending(), αλλιώς βγαίνω από το πρόγραμμα, διαγράφοντας το task.
            If (Not messages Is Nothing) Then

                Trace.WriteLine("Start sending...") ' εντολή debuging, γράφει το output σε log file.
                startSending()

            Else

                Trace.WriteLine("Sent_failed") ' εντολή debuging, γράφει το output σε log file.

                ' διαγραφή του task.
                Using ts As New TaskService()

                    Dim tmp_task As String = ""
                    tmp_task = arguments(0)
                    tmp_task = tmp_task.Replace("_", " ")

                    ts.RootFolder.DeleteTask(tmp_task)

                End Using

                Environment.Exit(0)
            End If
            Trace.WriteLine("Sent_ok") ' εντολή debuging, γράφει το output σε log file.
        Else
            Trace.WriteLine("Sent_failed_arguments_error") ' εντολή debuging, γράφει το output σε log file.
            Environment.Exit(0)
        End If

    End Sub

    ' πέρνω δεδομένα από τη βάση.
    Private Sub retrieveFromDB(ByVal taskName As String)

        Trace.WriteLine("In retrieveFromDB") ' εντολή debuging, γράφει το output σε log file.

        ' πέρνω όλες τις γραμμές του πίνακα pending
        Dim selectquery As String = "SELECT * FROM pending"
        Try
            Dim con_string As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & AppDomain.CurrentDomain.BaseDirectory & "test.accdb"
            Trace.WriteLine("Path to DB: " & con_string) ' εντολή debuging, γράφει το output σε log file.
            Using adapter As New OleDbDataAdapter(selectquery, _
              con_string)
                Dim ds As New DataSet
                adapter.Fill(ds, "table")
                adapter.UpdateCommand = New OleDbCommandBuilder(adapter).GetUpdateCommand ' πέρνω την UpdateCommand για να μπορώ να κάνω update τη βάση.

                Dim table As DataTable = ds.Tables("table")

                'για κάθε γραμμή του πίνακα ψάχνω τη γραμμή που το πεδίο στη στήλη sendingTask έχει την ίδια τιμή με το taskName.(κάθε task εκτελεί τη γραμμή για την οποία δημιουργήθηκε).
                For Each row As DataRow In table.Rows

                    If (row.Item(4).ToString.Trim = taskName) Then

                        Trace.WriteLine(row.Item(1)) ' εντολή debuging, γράφει το output σε log file.
                        Dim tmp_obj = New With {Key .address = row.Item(1), .subject = row.Item(2), .body = row.Item(3)} ' δίνω τιμή στο anonymous αντικείμενο
                        messages = tmp_obj
                        row.Delete() ' διαγράφω τη γραμμή από το πίνακα  pending

                    End If

                Next
                adapter.Update(ds, "table") ' κάνω ενημέρωση στη βάση
            End Using
        Catch ex As Exception
            Trace.WriteLine("Database Exception: " & ex.Message) ' εντολή debuging, γράφει το output σε log file.
        End Try

    End Sub

#Region "send multithreading"

    'startSending
    Private Sub startSending()

        ' Έλεγχος αν υπάρχει σύνδεση στο internet
        Dim Out As Integer
        If InternetGetConnectedState(Out, 0) = True Then

            'Δημιουργία threadpool με 300 threads. 50 περιμένουν για νέα requests.
            'ThreadPool.SetMaxThreads(300, 300)
            'ThreadPool.SetMinThreads(50, 50)

            Dim addresses As String()
            Trace.WriteLine("In sending...") ' εντολή debuging, γράφει το output σε log file.

            Dim tmp As String = messages.address

            'χωρίζω το string με delimeter character το ; και βάζω τις διευθύνσεις στο πίνακα.
            addresses = tmp.Split(";")
            addresses_count = addresses.Length

            '  ManualResetEvent για να περιμένει το πρόγραμμα να τελειώσουν τα threads και μετά να κλείσει.

            Dim manualEvents(addresses_count - 1) As ManualResetEvent

            For i As Integer = 0 To addresses.Length - 1

                manualEvents(i) = New ManualResetEvent(False)

                'δημιουργία ενώς anonymous object με πεδία  (to address, subject text , body text)
                Dim mydata_obj = New With {Key .address = addresses(i), .subject = messages.subject, .body = messages.body}
                ThreadPool.QueueUserWorkItem(AddressOf SendMail, mydata_obj) ' βάζω στην ουρά tasks.

            Next

            ' το κεντρικό thread δεν κλείνει μέχρι να ολοκληρωθούν όλα τα threads.
            For Each e In manualEvents
                e.WaitOne()
            Next

            Environment.Exit(0)

        Else ' αν δεν υπάρχει σύνδεση το πρόγραμμα κλείνει και διαγράφεται το task.

            Trace.WriteLine("No internet") ' εντολή debuging, γράφει το output σε log file.

            ' διαγραφή του task.
            Using ts As New TaskService()

                Dim tmp_task As String = ""
                tmp_task = arguments(0)
                tmp_task = tmp_task.Replace("_", " ")

                ts.RootFolder.DeleteTask(tmp_task)

            End Using

            Environment.Exit(0)

        End If

    End Sub

    'SendMail
    Private Sub SendMail(ByVal mydata_obj As Object)

        Trace.WriteLine("In sendMail()")

        If mydata_obj Is Nothing Then
            Throw New ArgumentException("Empty arg!!")
            Trace.WriteLine("Exception_empty_arg") ' εντολή debuging, γράφει το output σε log file.
        End If

        ' δημιουργία και αρχικοποίηση smtp client.
        Dim client As SmtpClient = New SmtpClient()
        Trace.WriteLine("Client Created..") ' εντολή debuging, γράφει το output σε log file.

        client.Host = arguments(1)
        client.Port = arguments(2)

        Trace.WriteLine("Port,Host..") ' εντολή debuging, γράφει το output σε log file.

        If (arguments(2) = "25") Then
            client.EnableSsl = False
        Else
            client.EnableSsl = True
        End If

        Trace.WriteLine("SSL") ' εντολή debuging, γράφει το output σε log file.

        client.Credentials = New System.Net.NetworkCredential(arguments(3), arguments(4))

        Trace.WriteLine("Pass,mail") ' εντολή debuging, γράφει το output σε log file.

        ' δημιουργία μηνήματος
        Using Mail As New MailMessage

            Trace.WriteLine("New message") ' εντολή debuging, γράφει το output σε log file.

            Mail.Subject = mydata_obj.subject
            Mail.To.Add(mydata_obj.address)
            Mail.From = New MailAddress(arguments(3), arguments(5))
            Mail.Body = mydata_obj.body
            client.ServicePoint.MaxIdleTime = 1 ' η σύνδεση στο server κλείνει μετά από 1 sec idle. 

            Trace.WriteLine("Call send...") ' εντολή debuging, γράφει το output σε log file.

            Try
                client.Send(Mail)
                Trace.WriteLine("in try...") ' εντολή debuging, γράφει το output σε log file.
            Catch ex As SmtpException
                Trace.WriteLine("Exception..." & ex.Message) ' εντολή debuging, γράφει το output σε log file.
            Finally
                SendCompleted() ' μετά το τέλος καλείτε η SendCompleted
                Trace.WriteLine("Call completed")
                If (counter = addresses_count) Then ' αν τα threads που εκτελέστηκαν είναι ίσα με το σύνολο των διευθύνσεων(threads) το πρόγραμμα κλείνει.
                    Environment.Exit(0)
                End If
            End Try
        End Using

    End Sub

    'SendCompleted
    Private Sub SendCompleted()

        Trace.WriteLine("Completed..") ' εντολή debuging, γράφει το output σε log file.
        Trace.WriteLine(counter) ' εντολή debuging, γράφει το output σε log file.
        Trace.WriteLine(addresses_count) ' εντολή debuging, γράφει το output σε log file.

        counter += 1 ' οταν το thread ολοκληρωθεί αύξηση του counter.

        ' όταν ολοκληρωθεί η αποστολή όλων αποθηκεύω τη γραμμή που πηρα απο το πίνακα pending στο πίνακα sent.
        If (counter = addresses_count) Then

            '''''''''''''''''''''''''''''''''''''''''''''''''''''
            Dim con_string As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & AppDomain.CurrentDomain.BaseDirectory & "test.accdb"
            Trace.WriteLine("Path to DB: " & con_string) ' εντολή debuging, γράφει το output σε log file.

            Dim connection As OleDbConnection
            Dim command As OleDbCommand
            Dim timeStamp As DateTime = DateTime.Now
            Dim insertquery As String = "INSERT INTO sentemails(subject,senders,mail,hmer_wra) VALUES('" & messages.subject & _
                "','" & messages.address & "','" & messages.body & "','" & timeStamp & "');"

            Try
                connection = New OleDbConnection(con_string)
                command = New OleDbCommand(insertquery, connection)
                connection.Open()
                command.ExecuteNonQuery()
                connection.Close()

            Catch ex As Exception
                Trace.WriteLine(ex.Message) ' εντολή debuging, γράφει το output σε log file.
            End Try
            ''''''''''''''''''''''''''''''''''''''''
            Trace.WriteLine("Send Completed") ' εντολή debuging, γράφει το output σε log file.

            ' διαγραφή του task.
            Using ts As New TaskService()

                Dim tmp_task As String = ""
                tmp_task = arguments(0)
                tmp_task = tmp_task.Replace("_", " ")

                ts.RootFolder.DeleteTask(tmp_task)

            End Using
            Trace.WriteLine("Done!!") ' εντολή debuging, γράφει το output σε log file.

        End If
    End Sub

#End Region

End Module
