<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Account_Manager
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.email_tb = New System.Windows.Forms.TextBox
        Me.pass_tb = New System.Windows.Forms.TextBox
        Me.name_tb = New System.Windows.Forms.TextBox
        Me.checkName_lb = New System.Windows.Forms.Label
        Me.next_btn = New System.Windows.Forms.Button
        Me.cancel_btn = New System.Windows.Forms.Button
        Me.checkMail_lb = New System.Windows.Forms.Label
        Me.checkPass_lb = New System.Windows.Forms.Label
        Me.settings_Panel = New System.Windows.Forms.Panel
        Me.panelTest_btn = New System.Windows.Forms.Button
        Me.portConf_lb = New System.Windows.Forms.Label
        Me.serverConf_lb = New System.Windows.Forms.Label
        Me.portConf_tb = New System.Windows.Forms.TextBox
        Me.serverConf_tb = New System.Windows.Forms.TextBox
        Me.server_info_lb = New System.Windows.Forms.Label
        Me.settings_info_lb = New System.Windows.Forms.Label
        Me.manualConf_btn = New System.Windows.Forms.Button
        Me.testAccount_btn = New System.Windows.Forms.Button
        Me.deleleAc_btn = New System.Windows.Forms.Button
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.status_lb = New System.Windows.Forms.ToolStripStatusLabel
        Me.Worker = New System.ComponentModel.BackgroundWorker
        Me.nextFinish_pictbox = New System.Windows.Forms.PictureBox
        Me.sent_pictbox = New System.Windows.Forms.PictureBox
        Me.settings_Panel.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.nextFinish_pictbox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sent_pictbox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Your E-mail Address:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Your Password:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Your Name:"
        '
        'email_tb
        '
        Me.email_tb.ForeColor = System.Drawing.SystemColors.WindowText
        Me.email_tb.Location = New System.Drawing.Point(145, 20)
        Me.email_tb.Name = "email_tb"
        Me.email_tb.Size = New System.Drawing.Size(143, 20)
        Me.email_tb.TabIndex = 3
        Me.email_tb.Tag = "name@example.com"
        '
        'pass_tb
        '
        Me.pass_tb.Location = New System.Drawing.Point(145, 60)
        Me.pass_tb.Name = "pass_tb"
        Me.pass_tb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(46)
        Me.pass_tb.Size = New System.Drawing.Size(143, 20)
        Me.pass_tb.TabIndex = 4
        Me.pass_tb.Tag = "email's password"
        Me.pass_tb.UseSystemPasswordChar = True
        '
        'name_tb
        '
        Me.name_tb.Location = New System.Drawing.Point(145, 100)
        Me.name_tb.Name = "name_tb"
        Me.name_tb.Size = New System.Drawing.Size(143, 20)
        Me.name_tb.TabIndex = 5
        Me.name_tb.Tag = "Name Surname"
        '
        'checkName_lb
        '
        Me.checkName_lb.AutoSize = True
        Me.checkName_lb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.checkName_lb.ForeColor = System.Drawing.SystemColors.GrayText
        Me.checkName_lb.Location = New System.Drawing.Point(294, 103)
        Me.checkName_lb.Name = "checkName_lb"
        Me.checkName_lb.Size = New System.Drawing.Size(182, 15)
        Me.checkName_lb.TabIndex = 6
        Me.checkName_lb.Text = "It will be visible from the receiver"
        '
        'next_btn
        '
        Me.next_btn.Location = New System.Drawing.Point(316, 306)
        Me.next_btn.Name = "next_btn"
        Me.next_btn.Size = New System.Drawing.Size(75, 23)
        Me.next_btn.TabIndex = 7
        Me.next_btn.Text = "Next"
        Me.next_btn.UseVisualStyleBackColor = True
        '
        'cancel_btn
        '
        Me.cancel_btn.Location = New System.Drawing.Point(448, 306)
        Me.cancel_btn.Name = "cancel_btn"
        Me.cancel_btn.Size = New System.Drawing.Size(75, 23)
        Me.cancel_btn.TabIndex = 8
        Me.cancel_btn.Text = "Exit"
        Me.cancel_btn.UseVisualStyleBackColor = True
        '
        'checkMail_lb
        '
        Me.checkMail_lb.AutoSize = True
        Me.checkMail_lb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.checkMail_lb.ForeColor = System.Drawing.Color.Red
        Me.checkMail_lb.Location = New System.Drawing.Point(294, 23)
        Me.checkMail_lb.Name = "checkMail_lb"
        Me.checkMail_lb.Size = New System.Drawing.Size(259, 13)
        Me.checkMail_lb.TabIndex = 9
        Me.checkMail_lb.Text = "The E-mail Address field must not be empty!!"
        Me.checkMail_lb.Visible = False
        '
        'checkPass_lb
        '
        Me.checkPass_lb.AutoSize = True
        Me.checkPass_lb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.checkPass_lb.ForeColor = System.Drawing.Color.Red
        Me.checkPass_lb.Location = New System.Drawing.Point(294, 63)
        Me.checkPass_lb.Name = "checkPass_lb"
        Me.checkPass_lb.Size = New System.Drawing.Size(229, 13)
        Me.checkPass_lb.TabIndex = 10
        Me.checkPass_lb.Text = "The password field must not be empty!!"
        Me.checkPass_lb.Visible = False
        '
        'settings_Panel
        '
        Me.settings_Panel.BackColor = System.Drawing.SystemColors.Control
        Me.settings_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.settings_Panel.Controls.Add(Me.panelTest_btn)
        Me.settings_Panel.Controls.Add(Me.portConf_lb)
        Me.settings_Panel.Controls.Add(Me.serverConf_lb)
        Me.settings_Panel.Controls.Add(Me.portConf_tb)
        Me.settings_Panel.Controls.Add(Me.serverConf_tb)
        Me.settings_Panel.Controls.Add(Me.server_info_lb)
        Me.settings_Panel.Location = New System.Drawing.Point(35, 167)
        Me.settings_Panel.Name = "settings_Panel"
        Me.settings_Panel.Size = New System.Drawing.Size(488, 111)
        Me.settings_Panel.TabIndex = 11
        Me.settings_Panel.Visible = False
        '
        'panelTest_btn
        '
        Me.panelTest_btn.Location = New System.Drawing.Point(209, 78)
        Me.panelTest_btn.Name = "panelTest_btn"
        Me.panelTest_btn.Size = New System.Drawing.Size(75, 23)
        Me.panelTest_btn.TabIndex = 5
        Me.panelTest_btn.Text = "Test Again"
        Me.panelTest_btn.UseVisualStyleBackColor = True
        '
        'portConf_lb
        '
        Me.portConf_lb.AutoSize = True
        Me.portConf_lb.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.portConf_lb.Location = New System.Drawing.Point(415, 14)
        Me.portConf_lb.Name = "portConf_lb"
        Me.portConf_lb.Size = New System.Drawing.Size(28, 13)
        Me.portConf_lb.TabIndex = 4
        Me.portConf_lb.Text = " port"
        Me.portConf_lb.Visible = False
        '
        'serverConf_lb
        '
        Me.serverConf_lb.AutoSize = True
        Me.serverConf_lb.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.serverConf_lb.Location = New System.Drawing.Point(228, 14)
        Me.serverConf_lb.Name = "serverConf_lb"
        Me.serverConf_lb.Size = New System.Drawing.Size(116, 13)
        Me.serverConf_lb.TabIndex = 3
        Me.serverConf_lb.Text = "Domain name of server"
        Me.serverConf_lb.Visible = False
        '
        'portConf_tb
        '
        Me.portConf_tb.Location = New System.Drawing.Point(412, 45)
        Me.portConf_tb.Name = "portConf_tb"
        Me.portConf_tb.Size = New System.Drawing.Size(41, 20)
        Me.portConf_tb.TabIndex = 2
        Me.portConf_tb.Visible = False
        '
        'serverConf_tb
        '
        Me.serverConf_tb.Location = New System.Drawing.Point(209, 45)
        Me.serverConf_tb.Name = "serverConf_tb"
        Me.serverConf_tb.Size = New System.Drawing.Size(165, 20)
        Me.serverConf_tb.TabIndex = 1
        Me.serverConf_tb.Visible = False
        '
        'server_info_lb
        '
        Me.server_info_lb.AutoSize = True
        Me.server_info_lb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.server_info_lb.Location = New System.Drawing.Point(15, 46)
        Me.server_info_lb.Name = "server_info_lb"
        Me.server_info_lb.Size = New System.Drawing.Size(15, 15)
        Me.server_info_lb.TabIndex = 0
        Me.server_info_lb.Text = "  "
        '
        'settings_info_lb
        '
        Me.settings_info_lb.AutoSize = True
        Me.settings_info_lb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.settings_info_lb.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.settings_info_lb.Location = New System.Drawing.Point(32, 137)
        Me.settings_info_lb.Name = "settings_info_lb"
        Me.settings_info_lb.Size = New System.Drawing.Size(0, 16)
        Me.settings_info_lb.TabIndex = 12
        Me.settings_info_lb.Visible = False
        '
        'manualConf_btn
        '
        Me.manualConf_btn.Location = New System.Drawing.Point(35, 306)
        Me.manualConf_btn.Name = "manualConf_btn"
        Me.manualConf_btn.Size = New System.Drawing.Size(115, 23)
        Me.manualConf_btn.TabIndex = 13
        Me.manualConf_btn.Text = "Manual Configuration"
        Me.manualConf_btn.UseVisualStyleBackColor = True
        Me.manualConf_btn.Visible = False
        '
        'testAccount_btn
        '
        Me.testAccount_btn.Location = New System.Drawing.Point(178, 306)
        Me.testAccount_btn.Name = "testAccount_btn"
        Me.testAccount_btn.Size = New System.Drawing.Size(83, 23)
        Me.testAccount_btn.TabIndex = 14
        Me.testAccount_btn.Text = "Test Account"
        Me.testAccount_btn.UseVisualStyleBackColor = True
        Me.testAccount_btn.Visible = False
        '
        'deleleAc_btn
        '
        Me.deleleAc_btn.Location = New System.Drawing.Point(35, 306)
        Me.deleleAc_btn.Name = "deleleAc_btn"
        Me.deleleAc_btn.Size = New System.Drawing.Size(115, 23)
        Me.deleleAc_btn.TabIndex = 15
        Me.deleleAc_btn.Text = "Delete Account"
        Me.deleleAc_btn.UseVisualStyleBackColor = True
        Me.deleleAc_btn.Visible = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.status_lb})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 338)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(563, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 16
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'status_lb
        '
        Me.status_lb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.status_lb.Name = "status_lb"
        Me.status_lb.Size = New System.Drawing.Size(60, 17)
        Me.status_lb.Text = "status: OK"
        '
        'Worker
        '
        Me.Worker.WorkerSupportsCancellation = True
        '
        'nextFinish_pictbox
        '
        Me.nextFinish_pictbox.Image = Global.sms_mail_project.My.Resources.Resources.wheel1
        Me.nextFinish_pictbox.Location = New System.Drawing.Point(397, 306)
        Me.nextFinish_pictbox.Name = "nextFinish_pictbox"
        Me.nextFinish_pictbox.Size = New System.Drawing.Size(33, 23)
        Me.nextFinish_pictbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.nextFinish_pictbox.TabIndex = 17
        Me.nextFinish_pictbox.TabStop = False
        Me.nextFinish_pictbox.Visible = False
        '
        'sent_pictbox
        '
        Me.sent_pictbox.Image = Global.sms_mail_project.My.Resources.Resources.wheel1
        Me.sent_pictbox.Location = New System.Drawing.Point(267, 306)
        Me.sent_pictbox.Name = "sent_pictbox"
        Me.sent_pictbox.Size = New System.Drawing.Size(33, 23)
        Me.sent_pictbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.sent_pictbox.TabIndex = 18
        Me.sent_pictbox.TabStop = False
        Me.sent_pictbox.Visible = False
        '
        'Account_Manager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 360)
        Me.Controls.Add(Me.sent_pictbox)
        Me.Controls.Add(Me.nextFinish_pictbox)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.deleleAc_btn)
        Me.Controls.Add(Me.testAccount_btn)
        Me.Controls.Add(Me.manualConf_btn)
        Me.Controls.Add(Me.settings_info_lb)
        Me.Controls.Add(Me.settings_Panel)
        Me.Controls.Add(Me.checkPass_lb)
        Me.Controls.Add(Me.checkMail_lb)
        Me.Controls.Add(Me.cancel_btn)
        Me.Controls.Add(Me.next_btn)
        Me.Controls.Add(Me.checkName_lb)
        Me.Controls.Add(Me.name_tb)
        Me.Controls.Add(Me.pass_tb)
        Me.Controls.Add(Me.email_tb)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Account_Manager"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Account Manager"
        Me.settings_Panel.ResumeLayout(False)
        Me.settings_Panel.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.nextFinish_pictbox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sent_pictbox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents email_tb As System.Windows.Forms.TextBox
    Friend WithEvents pass_tb As System.Windows.Forms.TextBox
    Friend WithEvents name_tb As System.Windows.Forms.TextBox
    Friend WithEvents checkName_lb As System.Windows.Forms.Label
    Friend WithEvents next_btn As System.Windows.Forms.Button
    Friend WithEvents cancel_btn As System.Windows.Forms.Button
    Friend WithEvents checkMail_lb As System.Windows.Forms.Label
    Friend WithEvents checkPass_lb As System.Windows.Forms.Label
    Friend WithEvents settings_Panel As System.Windows.Forms.Panel
    Friend WithEvents settings_info_lb As System.Windows.Forms.Label
    Friend WithEvents server_info_lb As System.Windows.Forms.Label
    Friend WithEvents manualConf_btn As System.Windows.Forms.Button
    Friend WithEvents portConf_tb As System.Windows.Forms.TextBox
    Friend WithEvents serverConf_tb As System.Windows.Forms.TextBox
    Friend WithEvents portConf_lb As System.Windows.Forms.Label
    Friend WithEvents serverConf_lb As System.Windows.Forms.Label
    Friend WithEvents panelTest_btn As System.Windows.Forms.Button
    Friend WithEvents testAccount_btn As System.Windows.Forms.Button
    Friend WithEvents deleleAc_btn As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents status_lb As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Worker As System.ComponentModel.BackgroundWorker
    Friend WithEvents nextFinish_pictbox As System.Windows.Forms.PictureBox
    Friend WithEvents sent_pictbox As System.Windows.Forms.PictureBox
End Class
