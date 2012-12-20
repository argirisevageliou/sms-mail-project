<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChooseDraftEmail
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.DraftDate_TxtBox = New System.Windows.Forms.TextBox
        Me.DraftSendTo_TxtBox = New System.Windows.Forms.TextBox
        Me.DraftSubject_TxtBox = New System.Windows.Forms.TextBox
        Me.DateLabel = New System.Windows.Forms.Label
        Me.SendToLabel = New System.Windows.Forms.Label
        Me.SubjectLabel = New System.Windows.Forms.Label
        Me.DraftMailTextBox = New System.Windows.Forms.RichTextBox
        Me.Draft_Label = New System.Windows.Forms.Label
        Me.DraftListBox = New System.Windows.Forms.ListBox
        Me.DraftemailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TestDataSet1 = New sms_mail_project.testDataSet1
        Me.DraftemailsTableAdapter = New sms_mail_project.testDataSet1TableAdapters.draftemailsTableAdapter
        Me.ForwardBtn = New System.Windows.Forms.Button
        Me.DeleteBtn = New System.Windows.Forms.Button
        CType(Me.DraftemailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DraftDate_TxtBox
        '
        Me.DraftDate_TxtBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DraftDate_TxtBox.Enabled = False
        Me.DraftDate_TxtBox.Location = New System.Drawing.Point(287, 82)
        Me.DraftDate_TxtBox.Name = "DraftDate_TxtBox"
        Me.DraftDate_TxtBox.Size = New System.Drawing.Size(351, 20)
        Me.DraftDate_TxtBox.TabIndex = 26
        '
        'DraftSendTo_TxtBox
        '
        Me.DraftSendTo_TxtBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DraftSendTo_TxtBox.Enabled = False
        Me.DraftSendTo_TxtBox.Location = New System.Drawing.Point(288, 56)
        Me.DraftSendTo_TxtBox.Name = "DraftSendTo_TxtBox"
        Me.DraftSendTo_TxtBox.Size = New System.Drawing.Size(351, 20)
        Me.DraftSendTo_TxtBox.TabIndex = 25
        '
        'DraftSubject_TxtBox
        '
        Me.DraftSubject_TxtBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DraftSubject_TxtBox.Enabled = False
        Me.DraftSubject_TxtBox.Location = New System.Drawing.Point(287, 27)
        Me.DraftSubject_TxtBox.Name = "DraftSubject_TxtBox"
        Me.DraftSubject_TxtBox.Size = New System.Drawing.Size(351, 20)
        Me.DraftSubject_TxtBox.TabIndex = 24
        '
        'DateLabel
        '
        Me.DateLabel.AutoSize = True
        Me.DateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.DateLabel.Location = New System.Drawing.Point(180, 76)
        Me.DateLabel.Name = "DateLabel"
        Me.DateLabel.Size = New System.Drawing.Size(63, 25)
        Me.DateLabel.TabIndex = 23
        Me.DateLabel.Text = "Date:"
        '
        'SendToLabel
        '
        Me.SendToLabel.AutoSize = True
        Me.SendToLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.SendToLabel.Location = New System.Drawing.Point(180, 51)
        Me.SendToLabel.Name = "SendToLabel"
        Me.SendToLabel.Size = New System.Drawing.Size(99, 25)
        Me.SendToLabel.TabIndex = 22
        Me.SendToLabel.Text = "Send To:"
        '
        'SubjectLabel
        '
        Me.SubjectLabel.AutoSize = True
        Me.SubjectLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.SubjectLabel.Location = New System.Drawing.Point(180, 23)
        Me.SubjectLabel.Name = "SubjectLabel"
        Me.SubjectLabel.Size = New System.Drawing.Size(90, 25)
        Me.SubjectLabel.TabIndex = 21
        Me.SubjectLabel.Text = "Subject:"
        '
        'DraftMailTextBox
        '
        Me.DraftMailTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DraftMailTextBox.Enabled = False
        Me.DraftMailTextBox.Location = New System.Drawing.Point(173, 127)
        Me.DraftMailTextBox.Name = "DraftMailTextBox"
        Me.DraftMailTextBox.Size = New System.Drawing.Size(493, 348)
        Me.DraftMailTextBox.TabIndex = 20
        Me.DraftMailTextBox.Text = ""
        '
        'Draft_Label
        '
        Me.Draft_Label.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Draft_Label.AutoSize = True
        Me.Draft_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Draft_Label.ForeColor = System.Drawing.Color.Blue
        Me.Draft_Label.Location = New System.Drawing.Point(8, 25)
        Me.Draft_Label.Name = "Draft_Label"
        Me.Draft_Label.Size = New System.Drawing.Size(144, 31)
        Me.Draft_Label.TabIndex = 19
        Me.Draft_Label.Text = "Draft Mails"
        '
        'DraftListBox
        '
        Me.DraftListBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DraftListBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DraftListBox.DataSource = Me.DraftemailsBindingSource
        Me.DraftListBox.DisplayMember = "subject"
        Me.DraftListBox.FormattingEnabled = True
        Me.DraftListBox.Location = New System.Drawing.Point(3, 71)
        Me.DraftListBox.Name = "DraftListBox"
        Me.DraftListBox.Size = New System.Drawing.Size(151, 407)
        Me.DraftListBox.TabIndex = 18
        Me.DraftListBox.ValueMember = "subject"
        '
        'DraftemailsBindingSource
        '
        Me.DraftemailsBindingSource.DataMember = "draftemails"
        Me.DraftemailsBindingSource.DataSource = Me.TestDataSet1
        '
        'TestDataSet1
        '
        Me.TestDataSet1.DataSetName = "testDataSet1"
        Me.TestDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DraftemailsTableAdapter
        '
        Me.DraftemailsTableAdapter.ClearBeforeFill = True
        '
        'ForwardBtn
        '
        Me.ForwardBtn.Location = New System.Drawing.Point(204, 505)
        Me.ForwardBtn.Name = "ForwardBtn"
        Me.ForwardBtn.Size = New System.Drawing.Size(75, 23)
        Me.ForwardBtn.TabIndex = 27
        Me.ForwardBtn.Text = "Forward Draft"
        Me.ForwardBtn.UseVisualStyleBackColor = True
        '
        'DeleteBtn
        '
        Me.DeleteBtn.Location = New System.Drawing.Point(341, 505)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(75, 23)
        Me.DeleteBtn.TabIndex = 28
        Me.DeleteBtn.Text = "Delete Draft"
        Me.DeleteBtn.UseVisualStyleBackColor = True
        '
        'ChooseDraftEmail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 540)
        Me.Controls.Add(Me.DeleteBtn)
        Me.Controls.Add(Me.ForwardBtn)
        Me.Controls.Add(Me.DraftDate_TxtBox)
        Me.Controls.Add(Me.DraftSendTo_TxtBox)
        Me.Controls.Add(Me.DraftSubject_TxtBox)
        Me.Controls.Add(Me.DateLabel)
        Me.Controls.Add(Me.SendToLabel)
        Me.Controls.Add(Me.SubjectLabel)
        Me.Controls.Add(Me.DraftMailTextBox)
        Me.Controls.Add(Me.Draft_Label)
        Me.Controls.Add(Me.DraftListBox)
        Me.Name = "ChooseDraftEmail"
        Me.Text = "ChooseDraftEmail2"
        CType(Me.DraftemailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DraftDate_TxtBox As System.Windows.Forms.TextBox
    Friend WithEvents DraftSendTo_TxtBox As System.Windows.Forms.TextBox
    Friend WithEvents DraftSubject_TxtBox As System.Windows.Forms.TextBox
    Friend WithEvents DateLabel As System.Windows.Forms.Label
    Friend WithEvents SendToLabel As System.Windows.Forms.Label
    Friend WithEvents SubjectLabel As System.Windows.Forms.Label
    Friend WithEvents DraftMailTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents Draft_Label As System.Windows.Forms.Label
    Friend WithEvents DraftListBox As System.Windows.Forms.ListBox
    Friend WithEvents TestDataSet1 As sms_mail_project.testDataSet1
    Friend WithEvents DraftemailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DraftemailsTableAdapter As sms_mail_project.testDataSet1TableAdapters.draftemailsTableAdapter
    Friend WithEvents ForwardBtn As System.Windows.Forms.Button
    Friend WithEvents DeleteBtn As System.Windows.Forms.Button
End Class
