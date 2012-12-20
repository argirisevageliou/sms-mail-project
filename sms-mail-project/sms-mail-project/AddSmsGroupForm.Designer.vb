<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddSmsGroupForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddSmsGroupForm))
        Me.AlertLabel = New System.Windows.Forms.Label
        Me.GroupNameTextBox = New System.Windows.Forms.TextBox
        Me.GroupNameLabel = New System.Windows.Forms.Label
        Me.CreateGroupBtn = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'AlertLabel
        '
        Me.AlertLabel.AutoSize = True
        Me.AlertLabel.BackColor = System.Drawing.Color.AliceBlue
        Me.AlertLabel.ForeColor = System.Drawing.Color.Red
        Me.AlertLabel.Location = New System.Drawing.Point(194, 254)
        Me.AlertLabel.Name = "AlertLabel"
        Me.AlertLabel.Size = New System.Drawing.Size(126, 13)
        Me.AlertLabel.TabIndex = 7
        Me.AlertLabel.Text = "You have to give a name"
        Me.AlertLabel.Visible = False
        '
        'GroupNameTextBox
        '
        Me.GroupNameTextBox.Location = New System.Drawing.Point(203, 105)
        Me.GroupNameTextBox.Name = "GroupNameTextBox"
        Me.GroupNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.GroupNameTextBox.TabIndex = 6
        '
        'GroupNameLabel
        '
        Me.GroupNameLabel.AutoSize = True
        Me.GroupNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupNameLabel.Location = New System.Drawing.Point(109, 108)
        Me.GroupNameLabel.Name = "GroupNameLabel"
        Me.GroupNameLabel.Size = New System.Drawing.Size(88, 15)
        Me.GroupNameLabel.TabIndex = 5
        Me.GroupNameLabel.Text = "Group Name"
        '
        'CreateGroupBtn
        '
        Me.CreateGroupBtn.Image = CType(resources.GetObject("CreateGroupBtn.Image"), System.Drawing.Image)
        Me.CreateGroupBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CreateGroupBtn.Location = New System.Drawing.Point(203, 131)
        Me.CreateGroupBtn.Name = "CreateGroupBtn"
        Me.CreateGroupBtn.Size = New System.Drawing.Size(100, 78)
        Me.CreateGroupBtn.TabIndex = 4
        Me.CreateGroupBtn.Text = "Create Sms Group"
        Me.CreateGroupBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CreateGroupBtn.UseVisualStyleBackColor = True
        '
        'AddSmsGroupForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 368)
        Me.Controls.Add(Me.AlertLabel)
        Me.Controls.Add(Me.GroupNameTextBox)
        Me.Controls.Add(Me.GroupNameLabel)
        Me.Controls.Add(Me.CreateGroupBtn)
        Me.Name = "AddSmsGroupForm"
        Me.Text = "AddSmsGroupForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AlertLabel As System.Windows.Forms.Label
    Friend WithEvents GroupNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupNameLabel As System.Windows.Forms.Label
    Friend WithEvents CreateGroupBtn As System.Windows.Forms.Button
End Class
