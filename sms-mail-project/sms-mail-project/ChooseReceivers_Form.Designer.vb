<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChooseReceivers_Form
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
        Me.groups_lb = New System.Windows.Forms.ListBox
        Me.EmailgroupsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TestDataSet = New sms_mail_project.testDataSet
        Me.Label1 = New System.Windows.Forms.Label
        Me.contacts_gv = New System.Windows.Forms.DataGridView
        Me.EmailgroupsTableAdapter = New sms_mail_project.testDataSetTableAdapters.emailgroupsTableAdapter
        Me.Label2 = New System.Windows.Forms.Label
        Me.add_all_btn = New System.Windows.Forms.Button
        Me.selections_lb = New System.Windows.Forms.ListBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.add_one_btn = New System.Windows.Forms.Button
        Me.delete_btn = New System.Windows.Forms.Button
        Me.new_mail_tb = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.add_mail_btn = New System.Windows.Forms.Button
        Me.error_provider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.select_all_btn = New System.Windows.Forms.Button
        Me.submit_btn = New System.Windows.Forms.Button
        CType(Me.EmailgroupsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.contacts_gv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.error_provider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'groups_lb
        '
        Me.groups_lb.BackColor = System.Drawing.SystemColors.Control
        Me.groups_lb.DataSource = Me.EmailgroupsBindingSource
        Me.groups_lb.DisplayMember = "name"
        Me.groups_lb.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groups_lb.FormattingEnabled = True
        Me.groups_lb.HorizontalScrollbar = True
        Me.groups_lb.ItemHeight = 21
        Me.groups_lb.Location = New System.Drawing.Point(25, 68)
        Me.groups_lb.Name = "groups_lb"
        Me.groups_lb.Size = New System.Drawing.Size(176, 214)
        Me.groups_lb.Sorted = True
        Me.groups_lb.TabIndex = 0
        Me.groups_lb.ValueMember = "name"
        '
        'EmailgroupsBindingSource
        '
        Me.EmailgroupsBindingSource.DataMember = "emailgroups"
        Me.EmailgroupsBindingSource.DataSource = Me.TestDataSet
        '
        'TestDataSet
        '
        Me.TestDataSet.DataSetName = "testDataSet"
        Me.TestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Miramonte", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(33, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Available Groups:"
        '
        'contacts_gv
        '
        Me.contacts_gv.AllowUserToAddRows = False
        Me.contacts_gv.AllowUserToDeleteRows = False
        Me.contacts_gv.AllowUserToResizeRows = False
        Me.contacts_gv.BackgroundColor = System.Drawing.SystemColors.Control
        Me.contacts_gv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.contacts_gv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal
        Me.contacts_gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.contacts_gv.Location = New System.Drawing.Point(242, 68)
        Me.contacts_gv.MultiSelect = False
        Me.contacts_gv.Name = "contacts_gv"
        Me.contacts_gv.ReadOnly = True
        Me.contacts_gv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.contacts_gv.Size = New System.Drawing.Size(391, 214)
        Me.contacts_gv.TabIndex = 2
        '
        'EmailgroupsTableAdapter
        '
        Me.EmailgroupsTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Miramonte", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Location = New System.Drawing.Point(389, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Contacts:"
        '
        'add_all_btn
        '
        Me.add_all_btn.Location = New System.Drawing.Point(660, 188)
        Me.add_all_btn.Name = "add_all_btn"
        Me.add_all_btn.Size = New System.Drawing.Size(41, 23)
        Me.add_all_btn.TabIndex = 4
        Me.add_all_btn.Text = ">>"
        Me.add_all_btn.UseVisualStyleBackColor = True
        '
        'selections_lb
        '
        Me.selections_lb.BackColor = System.Drawing.SystemColors.Control
        Me.selections_lb.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selections_lb.ForeColor = System.Drawing.Color.Black
        Me.selections_lb.FormattingEnabled = True
        Me.selections_lb.HorizontalScrollbar = True
        Me.selections_lb.ItemHeight = 18
        Me.selections_lb.Location = New System.Drawing.Point(729, 68)
        Me.selections_lb.Name = "selections_lb"
        Me.selections_lb.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.selections_lb.Size = New System.Drawing.Size(186, 346)
        Me.selections_lb.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Miramonte", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label3.Location = New System.Drawing.Point(738, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 24)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Selected Contacts:"
        '
        'add_one_btn
        '
        Me.add_one_btn.Location = New System.Drawing.Point(660, 142)
        Me.add_one_btn.Name = "add_one_btn"
        Me.add_one_btn.Size = New System.Drawing.Size(41, 23)
        Me.add_one_btn.TabIndex = 7
        Me.add_one_btn.Text = ">"
        Me.add_one_btn.UseVisualStyleBackColor = True
        '
        'delete_btn
        '
        Me.delete_btn.Location = New System.Drawing.Point(810, 434)
        Me.delete_btn.Name = "delete_btn"
        Me.delete_btn.Size = New System.Drawing.Size(105, 27)
        Me.delete_btn.TabIndex = 8
        Me.delete_btn.Text = "Delete Selected"
        Me.delete_btn.UseVisualStyleBackColor = True
        '
        'new_mail_tb
        '
        Me.new_mail_tb.Location = New System.Drawing.Point(300, 362)
        Me.new_mail_tb.Name = "new_mail_tb"
        Me.new_mail_tb.Size = New System.Drawing.Size(261, 20)
        Me.new_mail_tb.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Miramonte", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label4.Location = New System.Drawing.Point(341, 312)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(185, 24)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Add Contact (E-mail):"
        '
        'add_mail_btn
        '
        Me.add_mail_btn.Location = New System.Drawing.Point(660, 359)
        Me.add_mail_btn.Name = "add_mail_btn"
        Me.add_mail_btn.Size = New System.Drawing.Size(41, 23)
        Me.add_mail_btn.TabIndex = 11
        Me.add_mail_btn.Text = ">"
        Me.add_mail_btn.UseVisualStyleBackColor = True
        '
        'error_provider
        '
        Me.error_provider.ContainerControl = Me
        '
        'select_all_btn
        '
        Me.select_all_btn.Location = New System.Drawing.Point(729, 434)
        Me.select_all_btn.Name = "select_all_btn"
        Me.select_all_btn.Size = New System.Drawing.Size(75, 27)
        Me.select_all_btn.TabIndex = 12
        Me.select_all_btn.Text = "Select All"
        Me.select_all_btn.UseVisualStyleBackColor = True
        '
        'submit_btn
        '
        Me.submit_btn.Location = New System.Drawing.Point(338, 434)
        Me.submit_btn.Name = "submit_btn"
        Me.submit_btn.Size = New System.Drawing.Size(191, 27)
        Me.submit_btn.TabIndex = 13
        Me.submit_btn.Text = "Submit Selections"
        Me.submit_btn.UseVisualStyleBackColor = True
        '
        'ChooseReceivers_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(942, 487)
        Me.Controls.Add(Me.submit_btn)
        Me.Controls.Add(Me.select_all_btn)
        Me.Controls.Add(Me.add_mail_btn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.new_mail_tb)
        Me.Controls.Add(Me.delete_btn)
        Me.Controls.Add(Me.add_one_btn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.selections_lb)
        Me.Controls.Add(Me.add_all_btn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.contacts_gv)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.groups_lb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ChooseReceivers_Form"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Choose Receivers"
        CType(Me.EmailgroupsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.contacts_gv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.error_provider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents groups_lb As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents contacts_gv As System.Windows.Forms.DataGridView
    Friend WithEvents TestDataSet As sms_mail_project.testDataSet
    Friend WithEvents EmailgroupsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmailgroupsTableAdapter As sms_mail_project.testDataSetTableAdapters.emailgroupsTableAdapter
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents add_all_btn As System.Windows.Forms.Button
    Friend WithEvents selections_lb As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents add_one_btn As System.Windows.Forms.Button
    Friend WithEvents delete_btn As System.Windows.Forms.Button
    Friend WithEvents new_mail_tb As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents add_mail_btn As System.Windows.Forms.Button
    Friend WithEvents error_provider As System.Windows.Forms.ErrorProvider
    Friend WithEvents select_all_btn As System.Windows.Forms.Button
    Friend WithEvents submit_btn As System.Windows.Forms.Button
End Class
