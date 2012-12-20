<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShowSmsGroupsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ShowSmsGroupsForm))
        Me.SmsGroupsGrid = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.DeleteGroupBtn = New System.Windows.Forms.Button
        Me.EditGroupBtn = New System.Windows.Forms.Button
        Me.CreateGroupBtn = New System.Windows.Forms.Button
        CType(Me.SmsGroupsGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SmsGroupsGrid
        '
        Me.SmsGroupsGrid.AllowUserToAddRows = False
        Me.SmsGroupsGrid.AllowUserToDeleteRows = False
        Me.SmsGroupsGrid.AllowUserToOrderColumns = True
        Me.SmsGroupsGrid.BackgroundColor = System.Drawing.Color.GreenYellow
        Me.SmsGroupsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SmsGroupsGrid.Location = New System.Drawing.Point(78, 81)
        Me.SmsGroupsGrid.Name = "SmsGroupsGrid"
        Me.SmsGroupsGrid.ReadOnly = True
        Me.SmsGroupsGrid.Size = New System.Drawing.Size(147, 161)
        Me.SmsGroupsGrid.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(75, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(307, 15)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "To edit a group,select one and click edit button"
        '
        'DeleteGroupBtn
        '
        Me.DeleteGroupBtn.BackgroundImage = CType(resources.GetObject("DeleteGroupBtn.BackgroundImage"), System.Drawing.Image)
        Me.DeleteGroupBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.DeleteGroupBtn.Location = New System.Drawing.Point(260, 81)
        Me.DeleteGroupBtn.Name = "DeleteGroupBtn"
        Me.DeleteGroupBtn.Size = New System.Drawing.Size(86, 76)
        Me.DeleteGroupBtn.TabIndex = 11
        Me.DeleteGroupBtn.Text = "Delete group"
        Me.DeleteGroupBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.DeleteGroupBtn.UseVisualStyleBackColor = True
        '
        'EditGroupBtn
        '
        Me.EditGroupBtn.BackgroundImage = CType(resources.GetObject("EditGroupBtn.BackgroundImage"), System.Drawing.Image)
        Me.EditGroupBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.EditGroupBtn.Location = New System.Drawing.Point(260, 172)
        Me.EditGroupBtn.Name = "EditGroupBtn"
        Me.EditGroupBtn.Size = New System.Drawing.Size(86, 70)
        Me.EditGroupBtn.TabIndex = 9
        Me.EditGroupBtn.Text = "Edit group"
        Me.EditGroupBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.EditGroupBtn.UseVisualStyleBackColor = True
        '
        'CreateGroupBtn
        '
        Me.CreateGroupBtn.BackgroundImage = CType(resources.GetObject("CreateGroupBtn.BackgroundImage"), System.Drawing.Image)
        Me.CreateGroupBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CreateGroupBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CreateGroupBtn.Location = New System.Drawing.Point(78, 269)
        Me.CreateGroupBtn.Name = "CreateGroupBtn"
        Me.CreateGroupBtn.Size = New System.Drawing.Size(137, 80)
        Me.CreateGroupBtn.TabIndex = 7
        Me.CreateGroupBtn.Text = "Create a new sms group"
        Me.CreateGroupBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CreateGroupBtn.UseVisualStyleBackColor = True
        '
        'ShowSmsGroupsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 386)
        Me.Controls.Add(Me.DeleteGroupBtn)
        Me.Controls.Add(Me.SmsGroupsGrid)
        Me.Controls.Add(Me.EditGroupBtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CreateGroupBtn)
        Me.Name = "ShowSmsGroupsForm"
        Me.Text = "ShowSmsGroupsForm"
        CType(Me.SmsGroupsGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DeleteGroupBtn As System.Windows.Forms.Button
    Friend WithEvents SmsGroupsGrid As System.Windows.Forms.DataGridView
    Friend WithEvents EditGroupBtn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CreateGroupBtn As System.Windows.Forms.Button
End Class
