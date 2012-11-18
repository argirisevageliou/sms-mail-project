<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddEmailGroupForm
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
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupNameTextBox = New System.Windows.Forms.TextBox
        Me.Alertlabel = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(34, 147)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Create Email Group"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Group Name"
        '
        'GroupNameTextBox
        '
        Me.GroupNameTextBox.Location = New System.Drawing.Point(115, 85)
        Me.GroupNameTextBox.Name = "GroupNameTextBox"
        Me.GroupNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.GroupNameTextBox.TabIndex = 2
        '
        'Alertlabel
        '
        Me.Alertlabel.AutoSize = True
        Me.Alertlabel.ForeColor = System.Drawing.Color.Red
        Me.Alertlabel.Location = New System.Drawing.Point(175, 152)
        Me.Alertlabel.Name = "Alertlabel"
        Me.Alertlabel.Size = New System.Drawing.Size(126, 13)
        Me.Alertlabel.TabIndex = 3
        Me.Alertlabel.Text = "You have to give a name"
        Me.Alertlabel.Visible = False
        '
        'AddEmailGroupForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.Alertlabel)
        Me.Controls.Add(Me.GroupNameTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "AddEmailGroupForm"
        Me.Text = "Add Email Group"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Alertlabel As System.Windows.Forms.Label
End Class
