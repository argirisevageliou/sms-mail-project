<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class confirm_box
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
        Me.msg_lb = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.yes_btn = New System.Windows.Forms.Button
        Me.no_btn = New System.Windows.Forms.Button
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'msg_lb
        '
        Me.msg_lb.AutoSize = True
        Me.msg_lb.Font = New System.Drawing.Font("Poor Richard", 12.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msg_lb.Location = New System.Drawing.Point(55, 23)
        Me.msg_lb.Name = "msg_lb"
        Me.msg_lb.Size = New System.Drawing.Size(0, 20)
        Me.msg_lb.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.sms_mail_project.My.Resources.Resources.help_img
        Me.PictureBox1.Location = New System.Drawing.Point(12, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 38)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'yes_btn
        '
        Me.yes_btn.Location = New System.Drawing.Point(59, 78)
        Me.yes_btn.Name = "yes_btn"
        Me.yes_btn.Size = New System.Drawing.Size(75, 23)
        Me.yes_btn.TabIndex = 2
        Me.yes_btn.Text = "Yes"
        Me.yes_btn.UseVisualStyleBackColor = True
        '
        'no_btn
        '
        Me.no_btn.Location = New System.Drawing.Point(188, 78)
        Me.no_btn.Name = "no_btn"
        Me.no_btn.Size = New System.Drawing.Size(75, 23)
        Me.no_btn.TabIndex = 3
        Me.no_btn.Text = "No"
        Me.no_btn.UseVisualStyleBackColor = True
        '
        'confirm_box
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(326, 117)
        Me.Controls.Add(Me.no_btn)
        Me.Controls.Add(Me.yes_btn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.msg_lb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "confirm_box"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Save Settings"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents msg_lb As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents yes_btn As System.Windows.Forms.Button
    Friend WithEvents no_btn As System.Windows.Forms.Button
End Class
