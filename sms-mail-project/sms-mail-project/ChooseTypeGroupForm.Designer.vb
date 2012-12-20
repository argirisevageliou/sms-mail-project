<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChooseTypeGroupForm
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
        Me.EmailGroupsBtn = New System.Windows.Forms.Button
        Me.SmsGroupsBtn = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'EmailGroupsBtn
        '
        Me.EmailGroupsBtn.Location = New System.Drawing.Point(82, 73)
        Me.EmailGroupsBtn.Name = "EmailGroupsBtn"
        Me.EmailGroupsBtn.Size = New System.Drawing.Size(103, 32)
        Me.EmailGroupsBtn.TabIndex = 0
        Me.EmailGroupsBtn.Text = "Email Groups"
        Me.EmailGroupsBtn.UseVisualStyleBackColor = True
        '
        'SmsGroupsBtn
        '
        Me.SmsGroupsBtn.Location = New System.Drawing.Point(82, 140)
        Me.SmsGroupsBtn.Name = "SmsGroupsBtn"
        Me.SmsGroupsBtn.Size = New System.Drawing.Size(103, 32)
        Me.SmsGroupsBtn.TabIndex = 1
        Me.SmsGroupsBtn.Text = "Sms Groups"
        Me.SmsGroupsBtn.UseVisualStyleBackColor = True
        '
        'ChooseTypeGroupForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(288, 266)
        Me.Controls.Add(Me.SmsGroupsBtn)
        Me.Controls.Add(Me.EmailGroupsBtn)
        Me.Name = "ChooseTypeGroupForm"
        Me.Text = "ChooseTypeGroupForm"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EmailGroupsBtn As System.Windows.Forms.Button
    Friend WithEvents SmsGroupsBtn As System.Windows.Forms.Button
End Class
