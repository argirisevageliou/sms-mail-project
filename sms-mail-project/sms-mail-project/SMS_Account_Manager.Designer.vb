<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SMS_Account_Manager
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SMS_Account_Manager))
        Me.Label1 = New System.Windows.Forms.Label
        Me.senderID_tb = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.user_tb = New System.Windows.Forms.TextBox
        Me.pass_tb = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.error_pr = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.delete_btn = New System.Windows.Forms.Button
        Me.test_btn = New System.Windows.Forms.Button
        CType(Me.error_pr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Tag = "Type your 'sender id'"
        Me.Label1.Text = "Your 'Sender ID':"
        '
        'senderID_tb
        '
        Me.senderID_tb.Location = New System.Drawing.Point(139, 25)
        Me.senderID_tb.Name = "senderID_tb"
        Me.senderID_tb.Size = New System.Drawing.Size(182, 20)
        Me.senderID_tb.TabIndex = 1
        Me.senderID_tb.Tag = "type your 'sender ID'"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Your Username:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Your Password:"
        '
        'user_tb
        '
        Me.user_tb.Location = New System.Drawing.Point(139, 75)
        Me.user_tb.Name = "user_tb"
        Me.user_tb.Size = New System.Drawing.Size(182, 20)
        Me.user_tb.TabIndex = 4
        Me.user_tb.Tag = "type your username"
        '
        'pass_tb
        '
        Me.pass_tb.Location = New System.Drawing.Point(139, 124)
        Me.pass_tb.Name = "pass_tb"
        Me.pass_tb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(46)
        Me.pass_tb.Size = New System.Drawing.Size(182, 20)
        Me.pass_tb.TabIndex = 5
        Me.pass_tb.Tag = "type your password"
        Me.pass_tb.UseSystemPasswordChar = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(12, 230)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(206, 39)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "- Note: If you want to use the SMS feature" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "you should have a valid account on th" & _
            "e" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & """http://www.bulksmsn.gr"" web service."
        '
        'error_pr
        '
        Me.error_pr.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.error_pr.ContainerControl = Me
        '
        'delete_btn
        '
        Me.delete_btn.BackgroundImage = CType(resources.GetObject("delete_btn.BackgroundImage"), System.Drawing.Image)
        Me.delete_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.delete_btn.Location = New System.Drawing.Point(15, 154)
        Me.delete_btn.Name = "delete_btn"
        Me.delete_btn.Size = New System.Drawing.Size(92, 73)
        Me.delete_btn.TabIndex = 7
        Me.delete_btn.Text = "Delete Account"
        Me.delete_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.delete_btn.UseVisualStyleBackColor = True
        Me.delete_btn.Visible = False
        '
        'test_btn
        '
        Me.test_btn.Location = New System.Drawing.Point(139, 173)
        Me.test_btn.Name = "test_btn"
        Me.test_btn.Size = New System.Drawing.Size(182, 33)
        Me.test_btn.TabIndex = 6
        Me.test_btn.Text = "Test Account!!"
        Me.test_btn.UseVisualStyleBackColor = True
        '
        'SMS_Account_Manager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(385, 283)
        Me.Controls.Add(Me.delete_btn)
        Me.Controls.Add(Me.test_btn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.pass_tb)
        Me.Controls.Add(Me.user_tb)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.senderID_tb)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SMS_Account_Manager"
        Me.Text = "SMS-Account Manager"
        CType(Me.error_pr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents senderID_tb As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents user_tb As System.Windows.Forms.TextBox
    Friend WithEvents pass_tb As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents error_pr As System.Windows.Forms.ErrorProvider
    Friend WithEvents delete_btn As System.Windows.Forms.Button
    Friend WithEvents test_btn As System.Windows.Forms.Button
End Class
