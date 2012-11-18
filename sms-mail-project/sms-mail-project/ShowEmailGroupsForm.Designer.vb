<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShowEmailGroupsForm
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
        Me.CreateGroupBtn = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.EditGroupBtn = New System.Windows.Forms.Button
        Me.EmailGroupsGrid = New System.Windows.Forms.DataGridView
        Me.DeleteGroupBtn = New System.Windows.Forms.Button
        CType(Me.EmailGroupsGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CreateGroupBtn
        '
        Me.CreateGroupBtn.Location = New System.Drawing.Point(45, 236)
        Me.CreateGroupBtn.Name = "CreateGroupBtn"
        Me.CreateGroupBtn.Size = New System.Drawing.Size(147, 23)
        Me.CreateGroupBtn.TabIndex = 1
        Me.CreateGroupBtn.Text = "Create a new email group"
        Me.CreateGroupBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(42, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "To edit a group,select one and click edit button"
        '
        'EditGroupBtn
        '
        Me.EditGroupBtn.Location = New System.Drawing.Point(248, 139)
        Me.EditGroupBtn.Name = "EditGroupBtn"
        Me.EditGroupBtn.Size = New System.Drawing.Size(86, 23)
        Me.EditGroupBtn.TabIndex = 4
        Me.EditGroupBtn.Text = "Edit group"
        Me.EditGroupBtn.UseVisualStyleBackColor = True
        '
        'EmailGroupsGrid
        '
        Me.EmailGroupsGrid.AllowUserToAddRows = False
        Me.EmailGroupsGrid.AllowUserToDeleteRows = False
        Me.EmailGroupsGrid.AllowUserToOrderColumns = True
        Me.EmailGroupsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmailGroupsGrid.Location = New System.Drawing.Point(45, 66)
        Me.EmailGroupsGrid.Name = "EmailGroupsGrid"
        Me.EmailGroupsGrid.ReadOnly = True
        Me.EmailGroupsGrid.Size = New System.Drawing.Size(147, 150)
        Me.EmailGroupsGrid.TabIndex = 5
        '
        'DeleteGroupBtn
        '
        Me.DeleteGroupBtn.Location = New System.Drawing.Point(248, 75)
        Me.DeleteGroupBtn.Name = "DeleteGroupBtn"
        Me.DeleteGroupBtn.Size = New System.Drawing.Size(86, 23)
        Me.DeleteGroupBtn.TabIndex = 6
        Me.DeleteGroupBtn.Text = "Delete group"
        Me.DeleteGroupBtn.UseVisualStyleBackColor = True
        '
        'ShowEmailGroupsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 562)
        Me.Controls.Add(Me.DeleteGroupBtn)
        Me.Controls.Add(Me.EmailGroupsGrid)
        Me.Controls.Add(Me.EditGroupBtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CreateGroupBtn)
        Me.Name = "ShowEmailGroupsForm"
        Me.Text = "Show Email Groups"
        CType(Me.EmailGroupsGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CreateGroupBtn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents EditGroupBtn As System.Windows.Forms.Button
    Friend WithEvents EmailGroupsGrid As System.Windows.Forms.DataGridView
    Friend WithEvents DeleteGroupBtn As System.Windows.Forms.Button
End Class
