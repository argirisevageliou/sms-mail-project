<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditEmailGroupForm
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
        Me.ContactsGrid = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox
        Me.LastNameTextBox = New System.Windows.Forms.TextBox
        Me.EmailTextBox = New System.Windows.Forms.TextBox
        Me.AddContactBtn = New System.Windows.Forms.Button
        Me.Alertlabel = New System.Windows.Forms.Label
        Me.DeleteContactBtn = New System.Windows.Forms.Button
        Me.AlertEmail = New System.Windows.Forms.Label
        Me.ModifyContactBtn = New System.Windows.Forms.Button
        CType(Me.ContactsGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContactsGrid
        '
        Me.ContactsGrid.AllowUserToAddRows = False
        Me.ContactsGrid.AllowUserToDeleteRows = False
        Me.ContactsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ContactsGrid.Location = New System.Drawing.Point(28, 52)
        Me.ContactsGrid.Name = "ContactsGrid"
        Me.ContactsGrid.ReadOnly = True
        Me.ContactsGrid.Size = New System.Drawing.Size(394, 150)
        Me.ContactsGrid.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 259)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(305, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Complete all texts and press add to add a new contact to group"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 306)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "FirstName"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 345)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "LastName"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(42, 384)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Email"
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Location = New System.Drawing.Point(129, 298)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(201, 20)
        Me.FirstNameTextBox.TabIndex = 5
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Location = New System.Drawing.Point(129, 337)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(201, 20)
        Me.LastNameTextBox.TabIndex = 6
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Location = New System.Drawing.Point(129, 377)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(201, 20)
        Me.EmailTextBox.TabIndex = 7
        '
        'AddContactBtn
        '
        Me.AddContactBtn.Location = New System.Drawing.Point(42, 441)
        Me.AddContactBtn.Name = "AddContactBtn"
        Me.AddContactBtn.Size = New System.Drawing.Size(75, 23)
        Me.AddContactBtn.TabIndex = 8
        Me.AddContactBtn.Text = "Add contact"
        Me.AddContactBtn.UseVisualStyleBackColor = True
        '
        'Alertlabel
        '
        Me.Alertlabel.AutoSize = True
        Me.Alertlabel.ForeColor = System.Drawing.Color.Red
        Me.Alertlabel.Location = New System.Drawing.Point(148, 446)
        Me.Alertlabel.Name = "Alertlabel"
        Me.Alertlabel.Size = New System.Drawing.Size(123, 13)
        Me.Alertlabel.TabIndex = 9
        Me.Alertlabel.Text = "Please complete all texts"
        Me.Alertlabel.Visible = False
        '
        'DeleteContactBtn
        '
        Me.DeleteContactBtn.Location = New System.Drawing.Point(448, 80)
        Me.DeleteContactBtn.Name = "DeleteContactBtn"
        Me.DeleteContactBtn.Size = New System.Drawing.Size(104, 23)
        Me.DeleteContactBtn.TabIndex = 10
        Me.DeleteContactBtn.Text = "Delete contact"
        Me.DeleteContactBtn.UseVisualStyleBackColor = True
        '
        'AlertEmail
        '
        Me.AlertEmail.AutoSize = True
        Me.AlertEmail.ForeColor = System.Drawing.Color.Red
        Me.AlertEmail.Location = New System.Drawing.Point(360, 384)
        Me.AlertEmail.Name = "AlertEmail"
        Me.AlertEmail.Size = New System.Drawing.Size(102, 13)
        Me.AlertEmail.TabIndex = 11
        Me.AlertEmail.Text = "Wrong Email Format"
        Me.AlertEmail.Visible = False
        '
        'ModifyContactBtn
        '
        Me.ModifyContactBtn.Location = New System.Drawing.Point(448, 122)
        Me.ModifyContactBtn.Name = "ModifyContactBtn"
        Me.ModifyContactBtn.Size = New System.Drawing.Size(104, 23)
        Me.ModifyContactBtn.TabIndex = 12
        Me.ModifyContactBtn.Text = "Modify contact"
        Me.ModifyContactBtn.UseVisualStyleBackColor = True
        '
        'EditEmailGroupForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 562)
        Me.Controls.Add(Me.ModifyContactBtn)
        Me.Controls.Add(Me.AlertEmail)
        Me.Controls.Add(Me.DeleteContactBtn)
        Me.Controls.Add(Me.Alertlabel)
        Me.Controls.Add(Me.AddContactBtn)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ContactsGrid)
        Me.Name = "EditEmailGroupForm"
        Me.Text = "Edit Email Group"
        CType(Me.ContactsGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContactsGrid As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents FirstNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LastNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddContactBtn As System.Windows.Forms.Button
    Friend WithEvents Alertlabel As System.Windows.Forms.Label
    Friend WithEvents DeleteContactBtn As System.Windows.Forms.Button
    Friend WithEvents AlertEmail As System.Windows.Forms.Label
    Friend WithEvents ModifyContactBtn As System.Windows.Forms.Button
End Class
