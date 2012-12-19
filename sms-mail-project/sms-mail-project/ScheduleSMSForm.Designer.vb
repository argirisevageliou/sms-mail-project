<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScheduleSMSForm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.choose_panel = New System.Windows.Forms.Panel
        Me.warning_lb = New System.Windows.Forms.Label
        Me.timePicker = New System.Windows.Forms.DateTimePicker
        Me.datePicker = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.later_rbtn = New System.Windows.Forms.RadioButton
        Me.now_rbtn = New System.Windows.Forms.RadioButton
        Me.ok_btn = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.choose_panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.choose_panel)
        Me.GroupBox1.Controls.Add(Me.later_rbtn)
        Me.GroupBox1.Controls.Add(Me.now_rbtn)
        Me.GroupBox1.Font = New System.Drawing.Font("Miramonte", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(430, 213)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Choose Sending Method"
        '
        'choose_panel
        '
        Me.choose_panel.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.choose_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.choose_panel.Controls.Add(Me.warning_lb)
        Me.choose_panel.Controls.Add(Me.timePicker)
        Me.choose_panel.Controls.Add(Me.datePicker)
        Me.choose_panel.Controls.Add(Me.Label1)
        Me.choose_panel.Enabled = False
        Me.choose_panel.Location = New System.Drawing.Point(18, 65)
        Me.choose_panel.Name = "choose_panel"
        Me.choose_panel.Size = New System.Drawing.Size(396, 131)
        Me.choose_panel.TabIndex = 2
        '
        'warning_lb
        '
        Me.warning_lb.AutoSize = True
        Me.warning_lb.Font = New System.Drawing.Font("Miramonte", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.warning_lb.ForeColor = System.Drawing.Color.Red
        Me.warning_lb.Location = New System.Drawing.Point(10, 93)
        Me.warning_lb.Name = "warning_lb"
        Me.warning_lb.Size = New System.Drawing.Size(291, 19)
        Me.warning_lb.TabIndex = 3
        Me.warning_lb.Text = "The date must be greater than current date!!"
        Me.warning_lb.Visible = False
        '
        'timePicker
        '
        Me.timePicker.CustomFormat = ""
        Me.timePicker.Location = New System.Drawing.Point(219, 52)
        Me.timePicker.MinDate = New Date(2012, 12, 19, 0, 0, 0, 0)
        Me.timePicker.Name = "timePicker"
        Me.timePicker.Size = New System.Drawing.Size(149, 23)
        Me.timePicker.TabIndex = 2
        Me.timePicker.Value = New Date(2012, 12, 19, 14, 53, 35, 0)
        '
        'datePicker
        '
        Me.datePicker.Location = New System.Drawing.Point(13, 52)
        Me.datePicker.MinDate = New Date(2012, 12, 19, 0, 0, 0, 0)
        Me.datePicker.Name = "datePicker"
        Me.datePicker.Size = New System.Drawing.Size(186, 23)
        Me.datePicker.TabIndex = 1
        Me.datePicker.Value = New Date(2012, 12, 19, 14, 48, 4, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Handwriting", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(133, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Send on date:"
        '
        'later_rbtn
        '
        Me.later_rbtn.AutoSize = True
        Me.later_rbtn.Font = New System.Drawing.Font("Miramonte", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.later_rbtn.Location = New System.Drawing.Point(315, 36)
        Me.later_rbtn.Name = "later_rbtn"
        Me.later_rbtn.Size = New System.Drawing.Size(99, 23)
        Me.later_rbtn.TabIndex = 1
        Me.later_rbtn.Text = "Send Later"
        Me.later_rbtn.UseVisualStyleBackColor = True
        '
        'now_rbtn
        '
        Me.now_rbtn.AutoSize = True
        Me.now_rbtn.Checked = True
        Me.now_rbtn.Font = New System.Drawing.Font("Miramonte", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.now_rbtn.Location = New System.Drawing.Point(18, 36)
        Me.now_rbtn.Name = "now_rbtn"
        Me.now_rbtn.Size = New System.Drawing.Size(98, 23)
        Me.now_rbtn.TabIndex = 0
        Me.now_rbtn.TabStop = True
        Me.now_rbtn.Text = "Send Now"
        Me.now_rbtn.UseVisualStyleBackColor = True
        '
        'ok_btn
        '
        Me.ok_btn.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ok_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ok_btn.Location = New System.Drawing.Point(194, 239)
        Me.ok_btn.Name = "ok_btn"
        Me.ok_btn.Size = New System.Drawing.Size(66, 30)
        Me.ok_btn.TabIndex = 1
        Me.ok_btn.Text = "OK!"
        Me.ok_btn.UseVisualStyleBackColor = True
        '
        'ScheduleSMSForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(454, 280)
        Me.Controls.Add(Me.ok_btn)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ScheduleSMSForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "ScheduleSMSForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.choose_panel.ResumeLayout(False)
        Me.choose_panel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents later_rbtn As System.Windows.Forms.RadioButton
    Friend WithEvents now_rbtn As System.Windows.Forms.RadioButton
    Friend WithEvents choose_panel As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents datePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents timePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ok_btn As System.Windows.Forms.Button
    Friend WithEvents warning_lb As System.Windows.Forms.Label
End Class
