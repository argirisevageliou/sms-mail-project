<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditSmsGroupForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditSmsGroupForm))
        Me.ModifyContactBtn = New System.Windows.Forms.Button
        Me.AlertEmail = New System.Windows.Forms.Label
        Me.DeleteContactBtn = New System.Windows.Forms.Button
        Me.Alertlabel = New System.Windows.Forms.Label
        Me.AddContactBtn = New System.Windows.Forms.Button
        Me.NumberTextBox = New System.Windows.Forms.TextBox
        Me.LastNameTextBox = New System.Windows.Forms.TextBox
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox
        Me.NumberLabel = New System.Windows.Forms.Label
        Me.LastNameLabel = New System.Windows.Forms.Label
        Me.FirstNameLabel = New System.Windows.Forms.Label
        Me.InfoLabel = New System.Windows.Forms.Label
        Me.ContactsGrid = New System.Windows.Forms.DataGridView
        CType(Me.ContactsGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ModifyContactBtn
        '
        Me.ModifyContactBtn.Image = CType(resources.GetObject("ModifyContactBtn.Image"), System.Drawing.Image)
        Me.ModifyContactBtn.Location = New System.Drawing.Point(466, 127)
        Me.ModifyContactBtn.Name = "ModifyContactBtn"
        Me.ModifyContactBtn.Size = New System.Drawing.Size(104, 74)
        Me.ModifyContactBtn.TabIndex = 25
        Me.ModifyContactBtn.Text = "Modify contact"
        Me.ModifyContactBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ModifyContactBtn.UseVisualStyleBackColor = True
        '
        'AlertEmail
        '
        Me.AlertEmail.AutoSize = True
        Me.AlertEmail.ForeColor = System.Drawing.Color.Red
        Me.AlertEmail.Location = New System.Drawing.Point(378, 383)
        Me.AlertEmail.Name = "AlertEmail"
        Me.AlertEmail.Size = New System.Drawing.Size(114, 13)
        Me.AlertEmail.TabIndex = 24
        Me.AlertEmail.Text = "Wrong Number Format"
        Me.AlertEmail.Visible = False
        '
        'DeleteContactBtn
        '
        Me.DeleteContactBtn.Image = CType(resources.GetObject("DeleteContactBtn.Image"), System.Drawing.Image)
        Me.DeleteContactBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.DeleteContactBtn.Location = New System.Drawing.Point(466, 51)
        Me.DeleteContactBtn.Name = "DeleteContactBtn"
        Me.DeleteContactBtn.Size = New System.Drawing.Size(104, 70)
        Me.DeleteContactBtn.TabIndex = 23
        Me.DeleteContactBtn.Text = "Delete contact"
        Me.DeleteContactBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.DeleteContactBtn.UseVisualStyleBackColor = True
        '
        'Alertlabel
        '
        Me.Alertlabel.AutoSize = True
        Me.Alertlabel.ForeColor = System.Drawing.Color.Red
        Me.Alertlabel.Location = New System.Drawing.Point(194, 440)
        Me.Alertlabel.Name = "Alertlabel"
        Me.Alertlabel.Size = New System.Drawing.Size(123, 13)
        Me.Alertlabel.TabIndex = 22
        Me.Alertlabel.Text = "Please complete all texts"
        Me.Alertlabel.Visible = False
        '
        'AddContactBtn
        '
        Me.AddContactBtn.Image = CType(resources.GetObject("AddContactBtn.Image"), System.Drawing.Image)
        Me.AddContactBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.AddContactBtn.Location = New System.Drawing.Point(60, 440)
        Me.AddContactBtn.Name = "AddContactBtn"
        Me.AddContactBtn.Size = New System.Drawing.Size(83, 71)
        Me.AddContactBtn.TabIndex = 21
        Me.AddContactBtn.Text = "Add contact"
        Me.AddContactBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.AddContactBtn.UseVisualStyleBackColor = True
        '
        'NumberTextBox
        '
        Me.NumberTextBox.Location = New System.Drawing.Point(147, 376)
        Me.NumberTextBox.Name = "NumberTextBox"
        Me.NumberTextBox.Size = New System.Drawing.Size(201, 20)
        Me.NumberTextBox.TabIndex = 20
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Location = New System.Drawing.Point(147, 336)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(201, 20)
        Me.LastNameTextBox.TabIndex = 19
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Location = New System.Drawing.Point(147, 297)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(201, 20)
        Me.FirstNameTextBox.TabIndex = 18
        '
        'NumberLabel
        '
        Me.NumberLabel.AutoSize = True
        Me.NumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumberLabel.Location = New System.Drawing.Point(60, 379)
        Me.NumberLabel.Name = "NumberLabel"
        Me.NumberLabel.Size = New System.Drawing.Size(50, 13)
        Me.NumberLabel.TabIndex = 17
        Me.NumberLabel.Text = "Number"
        '
        'LastNameLabel
        '
        Me.LastNameLabel.AutoSize = True
        Me.LastNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastNameLabel.Location = New System.Drawing.Point(60, 339)
        Me.LastNameLabel.Name = "LastNameLabel"
        Me.LastNameLabel.Size = New System.Drawing.Size(63, 13)
        Me.LastNameLabel.TabIndex = 16
        Me.LastNameLabel.Text = "LastName"
        '
        'FirstNameLabel
        '
        Me.FirstNameLabel.AutoSize = True
        Me.FirstNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstNameLabel.Location = New System.Drawing.Point(60, 300)
        Me.FirstNameLabel.Name = "FirstNameLabel"
        Me.FirstNameLabel.Size = New System.Drawing.Size(63, 13)
        Me.FirstNameLabel.TabIndex = 15
        Me.FirstNameLabel.Text = "FirstName"
        '
        'InfoLabel
        '
        Me.InfoLabel.AutoSize = True
        Me.InfoLabel.BackColor = System.Drawing.Color.DodgerBlue
        Me.InfoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InfoLabel.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.InfoLabel.Location = New System.Drawing.Point(57, 258)
        Me.InfoLabel.Name = "InfoLabel"
        Me.InfoLabel.Size = New System.Drawing.Size(410, 15)
        Me.InfoLabel.TabIndex = 14
        Me.InfoLabel.Text = "Complete all texts and press add to add a new contact to group"
        '
        'ContactsGrid
        '
        Me.ContactsGrid.AllowUserToAddRows = False
        Me.ContactsGrid.AllowUserToDeleteRows = False
        Me.ContactsGrid.AllowUserToResizeRows = False
        Me.ContactsGrid.BackgroundColor = System.Drawing.Color.GreenYellow
        Me.ContactsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ContactsGrid.Location = New System.Drawing.Point(46, 51)
        Me.ContactsGrid.MultiSelect = False
        Me.ContactsGrid.Name = "ContactsGrid"
        Me.ContactsGrid.ReadOnly = True
        Me.ContactsGrid.Size = New System.Drawing.Size(394, 150)
        Me.ContactsGrid.TabIndex = 13
        '
        'EditSmsGroupForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 562)
        Me.Controls.Add(Me.ModifyContactBtn)
        Me.Controls.Add(Me.AlertEmail)
        Me.Controls.Add(Me.DeleteContactBtn)
        Me.Controls.Add(Me.Alertlabel)
        Me.Controls.Add(Me.AddContactBtn)
        Me.Controls.Add(Me.NumberTextBox)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Controls.Add(Me.NumberLabel)
        Me.Controls.Add(Me.LastNameLabel)
        Me.Controls.Add(Me.FirstNameLabel)
        Me.Controls.Add(Me.InfoLabel)
        Me.Controls.Add(Me.ContactsGrid)
        Me.Name = "EditSmsGroupForm"
        Me.Text = "EditSmsGroupForm"
        CType(Me.ContactsGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ModifyContactBtn As System.Windows.Forms.Button
    Friend WithEvents AlertEmail As System.Windows.Forms.Label
    Friend WithEvents DeleteContactBtn As System.Windows.Forms.Button
    Friend WithEvents Alertlabel As System.Windows.Forms.Label
    Friend WithEvents AddContactBtn As System.Windows.Forms.Button
    Friend WithEvents NumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LastNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FirstNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NumberLabel As System.Windows.Forms.Label
    Friend WithEvents LastNameLabel As System.Windows.Forms.Label
    Friend WithEvents FirstNameLabel As System.Windows.Forms.Label
    Friend WithEvents InfoLabel As System.Windows.Forms.Label
    Friend WithEvents ContactsGrid As System.Windows.Forms.DataGridView
End Class
