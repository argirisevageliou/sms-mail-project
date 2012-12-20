<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChooseTypeAccountsForm
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
        Me.SmsAccMngButton = New System.Windows.Forms.Button
        Me.EmailAccMngButton = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'SmsAccMngButton
        '
        Me.SmsAccMngButton.Location = New System.Drawing.Point(88, 139)
        Me.SmsAccMngButton.Name = "SmsAccMngButton"
        Me.SmsAccMngButton.Size = New System.Drawing.Size(103, 41)
        Me.SmsAccMngButton.TabIndex = 5
        Me.SmsAccMngButton.Text = "Sms Account Manager"
        Me.SmsAccMngButton.UseVisualStyleBackColor = True
        '
        'EmailAccMngButton
        '
        Me.EmailAccMngButton.Location = New System.Drawing.Point(88, 61)
        Me.EmailAccMngButton.Name = "EmailAccMngButton"
        Me.EmailAccMngButton.Size = New System.Drawing.Size(103, 43)
        Me.EmailAccMngButton.TabIndex = 4
        Me.EmailAccMngButton.Text = "Email Account Manager"
        Me.EmailAccMngButton.UseVisualStyleBackColor = True
        '
        'ChooseTypeAccountsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.SmsAccMngButton)
        Me.Controls.Add(Me.EmailAccMngButton)
        Me.Name = "ChooseTypeAccountsForm"
        Me.Text = "ChooseTypeAccountsForm"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SmsAccMngButton As System.Windows.Forms.Button
    Friend WithEvents EmailAccMngButton As System.Windows.Forms.Button
End Class
