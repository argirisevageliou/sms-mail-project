Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Public Class ChooseSMSReceivers_Form

    'onload
    Private Sub ChooseSMSReceivers_Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'TestDataSet.smsgroups' table. You can move, or remove it, as needed.
        Me.SmsgroupsTableAdapter.Fill(Me.TestDataSet.smsgroups)

        groups_lb.SelectedIndex = -1

        ' ορίζω το width του row header, απενεργοποιώ το resize.
        contacts_gv.RowHeadersWidth = 30
        contacts_gv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing

        ' ρυθμίζω το selection mode του grid view.
        contacts_gv.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        ' παίρνω από τη NewSMSMessage form το περιεχόμενο του SendTo textbox, εξάγω από το string τις τιμές (χωρισμένες με ';')

        Dim tmp_send_to_text As String = sms_mail_project.NewSmsMessage.contacts

        If (tmp_send_to_text <> "") Then

            Dim splitString As String()

            splitString = tmp_send_to_text.Split(";")

            For i As Integer = 0 To splitString.Length - 1
                selections_lb.Items.Add(splitString(i))
            Next

        End If

    End Sub

    'listbox-SelectedIndexChanged
    Private Sub groups_lb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles groups_lb.SelectedIndexChanged

        'παίρνω από το επιλεγμένο group τις εγγραφές και τις βάζω σε ένα gridView
        If (groups_lb.SelectedIndex >= 0) Then
            Dim selectquery As String = "SELECT * FROM " & Me.groups_lb.SelectedValue

            Try
                Using adapter As New OleDbDataAdapter(selectquery, _
                  My.Settings.testConnectionString)
                    Dim ds As New DataSet

                    adapter.Fill(ds, "contacts")
                    contacts_gv.DataSource = ds.Tables("contacts")
                    contacts_gv.Columns(0).Width = 115
                    contacts_gv.Columns(1).Width = 115
                    contacts_gv.Columns(2).Width = 115
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

    End Sub

    'new_phone_tb_Validating
    Private Sub new_phone_tb_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles new_phone_tb.Validating

        'ελέγχω με κανονική έκφραση το format του phone number.
        Dim correct_phone_Format As Boolean = Regex.IsMatch(new_phone_tb.Text, "^[6][9][0|3|4|5|7|8|9]{1}[0-9]{7}$")

        If (new_phone_tb.Text = "") Then
            error_provider.SetError(new_phone_tb, "")
        ElseIf (Not correct_phone_Format) Then
            error_provider.SetError(new_phone_tb, "Wrong phone number format") ' αν δεν είναι σωστό το format εμφανίζω τον errorprovider
            e.Cancel = True
        ElseIf (correct_phone_Format) Then
            error_provider.SetError(new_phone_tb, "")
        End If

    End Sub

    'add_one_btn_Click (εισαγωγή phone number από το gridView(μια εγγραφή))
    Private Sub add_one_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add_one_btn.Click

        error_provider.SetError(add_one_btn, "")
        error_provider.SetError(add_all_btn, "")
        error_provider.SetError(add_phone_btn, "")

        ' έλεγχος αν η εγγραφή υπάρχει ήδη στο listbox
        For Each item As DataGridViewRow In contacts_gv.SelectedRows

            Dim tmp_selection As String = item.Cells.Item(0).Value.ToString.Trim

            For Each line As String In selections_lb.Items

                If (line.ToString = tmp_selection) Then

                    error_provider.SetError(add_one_btn, "Contact exists in list")
                    Return
                End If

            Next

            selections_lb.Items.Add(tmp_selection) ' αν δεν υπάρχει εγγραφή στο listbox - εισαγωγή.

        Next

    End Sub

    'add_all_btn_Click (εισαγωγή phone number από το gridView(όλες οι εγγραφές))
    Private Sub add_all_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add_all_btn.Click

        error_provider.SetError(add_one_btn, "")
        error_provider.SetError(add_all_btn, "")
        error_provider.SetError(add_phone_btn, "")

        Dim flag_exists As Boolean = False

        ' έλεγχος αν οι εγγραφές υπάρχουν ήδη στο listbox ( εισάγονται μόνο όσες δεν υπάρχουν)
        For Each row As DataGridViewRow In contacts_gv.Rows

            Dim tmp_selection As String = row.Cells.Item(0).Value.ToString.Trim

            For Each line As String In selections_lb.Items

                If (line.ToString = tmp_selection) Then

                    error_provider.SetError(add_all_btn, "Some Contacts exists in list(not entered)") ' αν υπάρχει μια ήδη εμφάνιση error provider
                    flag_exists = True

                End If

            Next

            If (Not flag_exists) Then
                selections_lb.Items.Add(tmp_selection)
            End If
            flag_exists = False

        Next

    End Sub

    'add_phone_btn_Click (εισαγωγή phone number- όχι από group).
    Private Sub add_phone_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add_phone_btn.Click

        error_provider.SetError(add_one_btn, "")
        error_provider.SetError(add_all_btn, "")
        error_provider.SetError(add_phone_btn, "")

        Dim phone As String = new_phone_tb.Text

        ' Το phone number μπαίνει μόνο αν δεν υπάρχρει. Αλλιώς εμφανίζω error provider
        If (phone <> "") Then

            For Each line As String In selections_lb.Items

                If (line.ToString = phone) Then

                    error_provider.SetError(add_phone_btn, "Contact exists in list")
                    Return

                End If

            Next

            selections_lb.Items.Add(phone)
            Me.new_phone_tb.Text = ""

        End If

    End Sub

    'delete_btn_Click (Διαγραφή επιλεγμένων από το listbox)
    Private Sub delete_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles delete_btn.Click

        While (selections_lb.SelectedItems.Count > 0)

            selections_lb.Items.Remove(selections_lb.SelectedItems(0))

        End While

    End Sub

    'select_all_btn_Click (Επιλογή όλων από το listbox)
    Private Sub select_all_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles select_all_btn.Click

        For i = 0 To selections_lb.Items.Count - 1

            selections_lb.SetSelected(i, True)

        Next

    End Sub

    'submit_btn_Click ( Η φόρμα κλείνει οι επιλογές μεταφέρονει μέσω της (κοινής) μεταβλητής στο SendTo tb).
    Private Sub submit_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submit_btn.Click

        Dim tmp_contacts As String = ""

        For Each item As String In selections_lb.Items

            tmp_contacts += item & ";"

        Next

        If (tmp_contacts <> "") Then

            tmp_contacts = tmp_contacts.Remove(tmp_contacts.Length - 1, 1)

        End If

        sms_mail_project.NewSmsMessage.contacts = tmp_contacts
        Me.Close()


    End Sub

End Class