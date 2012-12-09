<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Schedule_SendingForm
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
        Me.groupBox = New System.Windows.Forms.GroupBox
        Me.choose_panel = New System.Windows.Forms.Panel
        Me.warning_lb = New System.Windows.Forms.Label
        Me.wake_cb = New System.Windows.Forms.CheckBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.startAfter_cb = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.chooseDate = New System.Windows.Forms.DateTimePicker
        Me.sendLater_rbtn = New System.Windows.Forms.RadioButton
        Me.sendNow_rbtn = New System.Windows.Forms.RadioButton
        Me.ok_btn = New System.Windows.Forms.Button
        Me.battery_cb = New System.Windows.Forms.CheckBox
        Me.groupBox.SuspendLayout()
        Me.choose_panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupBox
        '
        Me.groupBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.groupBox.Controls.Add(Me.choose_panel)
        Me.groupBox.Controls.Add(Me.sendLater_rbtn)
        Me.groupBox.Controls.Add(Me.sendNow_rbtn)
        Me.groupBox.Font = New System.Drawing.Font("Miramonte", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox.Location = New System.Drawing.Point(12, 12)
        Me.groupBox.Name = "groupBox"
        Me.groupBox.Size = New System.Drawing.Size(553, 287)
        Me.groupBox.TabIndex = 0
        Me.groupBox.TabStop = False
        Me.groupBox.Text = "Choose Sending Method"
        '
        'choose_panel
        '
        Me.choose_panel.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.choose_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.choose_panel.Controls.Add(Me.battery_cb)
        Me.choose_panel.Controls.Add(Me.warning_lb)
        Me.choose_panel.Controls.Add(Me.wake_cb)
        Me.choose_panel.Controls.Add(Me.Label2)
        Me.choose_panel.Controls.Add(Me.startAfter_cb)
        Me.choose_panel.Controls.Add(Me.Label1)
        Me.choose_panel.Controls.Add(Me.chooseDate)
        Me.choose_panel.Enabled = False
        Me.choose_panel.Location = New System.Drawing.Point(22, 77)
        Me.choose_panel.Name = "choose_panel"
        Me.choose_panel.Size = New System.Drawing.Size(509, 191)
        Me.choose_panel.TabIndex = 2
        '
        'warning_lb
        '
        Me.warning_lb.AutoSize = True
        Me.warning_lb.Font = New System.Drawing.Font("Miramonte", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.warning_lb.ForeColor = System.Drawing.Color.Red
        Me.warning_lb.Location = New System.Drawing.Point(4, 102)
        Me.warning_lb.Name = "warning_lb"
        Me.warning_lb.Size = New System.Drawing.Size(273, 16)
        Me.warning_lb.TabIndex = 5
        Me.warning_lb.Text = "The date must be greater than current date!!"
        Me.warning_lb.Visible = False
        '
        'wake_cb
        '
        Me.wake_cb.AutoSize = True
        Me.wake_cb.Location = New System.Drawing.Point(300, 99)
        Me.wake_cb.Name = "wake_cb"
        Me.wake_cb.Size = New System.Drawing.Size(172, 20)
        Me.wake_cb.TabIndex = 4
        Me.wake_cb.Text = "Wake the computer to run"
        Me.wake_cb.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Handwriting", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Location = New System.Drawing.Point(344, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Settings:"
        '
        'startAfter_cb
        '
        Me.startAfter_cb.AutoSize = True
        Me.startAfter_cb.Location = New System.Drawing.Point(300, 48)
        Me.startAfter_cb.Name = "startAfter_cb"
        Me.startAfter_cb.Size = New System.Drawing.Size(177, 36)
        Me.startAfter_cb.TabIndex = 2
        Me.startAfter_cb.Text = "Start task anytime after its" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " scheduled time has passed"
        Me.startAfter_cb.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Handwriting", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(68, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Send on date:"
        '
        'chooseDate
        '
        Me.chooseDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.chooseDate.Location = New System.Drawing.Point(30, 53)
        Me.chooseDate.Name = "chooseDate"
        Me.chooseDate.ShowUpDown = True
        Me.chooseDate.Size = New System.Drawing.Size(214, 23)
        Me.chooseDate.TabIndex = 0
        Me.chooseDate.Value = New Date(2012, 11, 30, 0, 0, 0, 0)
        '
        'sendLater_rbtn
        '
        Me.sendLater_rbtn.AutoSize = True
        Me.sendLater_rbtn.Font = New System.Drawing.Font("Miramonte", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sendLater_rbtn.Location = New System.Drawing.Point(432, 39)
        Me.sendLater_rbtn.Name = "sendLater_rbtn"
        Me.sendLater_rbtn.Size = New System.Drawing.Size(99, 23)
        Me.sendLater_rbtn.TabIndex = 1
        Me.sendLater_rbtn.Text = "Send Later"
        Me.sendLater_rbtn.UseVisualStyleBackColor = True
        '
        'sendNow_rbtn
        '
        Me.sendNow_rbtn.AutoSize = True
        Me.sendNow_rbtn.Checked = True
        Me.sendNow_rbtn.Font = New System.Drawing.Font("Miramonte", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sendNow_rbtn.Location = New System.Drawing.Point(22, 39)
        Me.sendNow_rbtn.Name = "sendNow_rbtn"
        Me.sendNow_rbtn.Size = New System.Drawing.Size(98, 23)
        Me.sendNow_rbtn.TabIndex = 0
        Me.sendNow_rbtn.TabStop = True
        Me.sendNow_rbtn.Text = "Send Now"
        Me.sendNow_rbtn.UseVisualStyleBackColor = True
        '
        'ok_btn
        '
        Me.ok_btn.BackColor = System.Drawing.SystemColors.Control
        Me.ok_btn.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ok_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ok_btn.Location = New System.Drawing.Point(259, 312)
        Me.ok_btn.Name = "ok_btn"
        Me.ok_btn.Size = New System.Drawing.Size(75, 35)
        Me.ok_btn.TabIndex = 1
        Me.ok_btn.Text = "OK!!"
        Me.ok_btn.UseVisualStyleBackColor = False
        '
        'battery_cb
        '
        Me.battery_cb.AutoSize = True
        Me.battery_cb.Location = New System.Drawing.Point(300, 135)
        Me.battery_cb.Name = "battery_cb"
        Me.battery_cb.Size = New System.Drawing.Size(187, 36)
        Me.battery_cb.TabIndex = 6
        Me.battery_cb.Text = "Disallow start if the computer" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " is running on battery power"
        Me.battery_cb.UseVisualStyleBackColor = True
        '
        'Schedule_SendingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(577, 357)
        Me.Controls.Add(Me.ok_btn)
        Me.Controls.Add(Me.groupBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Schedule_SendingForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Schedule Sending"
        Me.groupBox.ResumeLayout(False)
        Me.groupBox.PerformLayout()
        Me.choose_panel.ResumeLayout(False)
        Me.choose_panel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents groupBox As System.Windows.Forms.GroupBox
    Friend WithEvents sendLater_rbtn As System.Windows.Forms.RadioButton
    Friend WithEvents sendNow_rbtn As System.Windows.Forms.RadioButton
    Friend WithEvents choose_panel As System.Windows.Forms.Panel
    Friend WithEvents chooseDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents wake_cb As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents startAfter_cb As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ok_btn As System.Windows.Forms.Button
    Friend WithEvents warning_lb As System.Windows.Forms.Label
    Friend WithEvents battery_cb As System.Windows.Forms.CheckBox
End Class
