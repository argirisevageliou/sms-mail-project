<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChooseTypeEmailMessagesForm
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
        Me.DraftsButton = New System.Windows.Forms.Button
        Me.SentMessagesButton = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'DraftsButton
        '
        Me.DraftsButton.Location = New System.Drawing.Point(88, 141)
        Me.DraftsButton.Name = "DraftsButton"
        Me.DraftsButton.Size = New System.Drawing.Size(103, 32)
        Me.DraftsButton.TabIndex = 3
        Me.DraftsButton.Text = "Drafts"
        Me.DraftsButton.UseVisualStyleBackColor = True
        '
        'SentMessagesButton
        '
        Me.SentMessagesButton.Location = New System.Drawing.Point(88, 74)
        Me.SentMessagesButton.Name = "SentMessagesButton"
        Me.SentMessagesButton.Size = New System.Drawing.Size(103, 32)
        Me.SentMessagesButton.TabIndex = 2
        Me.SentMessagesButton.Text = "Sent Messages"
        Me.SentMessagesButton.UseVisualStyleBackColor = True
        '
        'ChooseTypeEmailMessagesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(301, 266)
        Me.Controls.Add(Me.DraftsButton)
        Me.Controls.Add(Me.SentMessagesButton)
        Me.Name = "ChooseTypeEmailMessagesForm"
        Me.Text = "ChooseTypeEmailMessagesForm"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DraftsButton As System.Windows.Forms.Button
    Friend WithEvents SentMessagesButton As System.Windows.Forms.Button
End Class
