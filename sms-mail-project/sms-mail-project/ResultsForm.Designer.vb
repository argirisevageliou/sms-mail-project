<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResultsForm
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.success_lb = New System.Windows.Forms.Label
        Me.failed_lb = New System.Windows.Forms.Label
        Me.sent_lb = New System.Windows.Forms.Label
        Me.total_lb = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.more_less_btn = New System.Windows.Forms.Button
        Me.details_gridview = New System.Windows.Forms.DataGridView
        Me.Panel1.SuspendLayout()
        CType(Me.details_gridview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.success_lb)
        Me.Panel1.Controls.Add(Me.failed_lb)
        Me.Panel1.Controls.Add(Me.sent_lb)
        Me.Panel1.Controls.Add(Me.total_lb)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Location = New System.Drawing.Point(12, 33)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(482, 171)
        Me.Panel1.TabIndex = 0
        '
        'success_lb
        '
        Me.success_lb.AutoSize = True
        Me.success_lb.Font = New System.Drawing.Font("Miramonte", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.success_lb.ForeColor = System.Drawing.SystemColors.Highlight
        Me.success_lb.Location = New System.Drawing.Point(168, 136)
        Me.success_lb.Name = "success_lb"
        Me.success_lb.Size = New System.Drawing.Size(125, 19)
        Me.success_lb.TabIndex = 4
        Me.success_lb.Text = "Success Rate: 0%"
        '
        'failed_lb
        '
        Me.failed_lb.AutoSize = True
        Me.failed_lb.Font = New System.Drawing.Font("Miramonte", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.failed_lb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.failed_lb.Location = New System.Drawing.Point(198, 106)
        Me.failed_lb.Name = "failed_lb"
        Me.failed_lb.Size = New System.Drawing.Size(63, 19)
        Me.failed_lb.TabIndex = 3
        Me.failed_lb.Text = "Failed: 0"
        '
        'sent_lb
        '
        Me.sent_lb.AutoSize = True
        Me.sent_lb.Font = New System.Drawing.Font("Miramonte", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sent_lb.ForeColor = System.Drawing.Color.Green
        Me.sent_lb.Location = New System.Drawing.Point(205, 75)
        Me.sent_lb.Name = "sent_lb"
        Me.sent_lb.Size = New System.Drawing.Size(51, 19)
        Me.sent_lb.TabIndex = 2
        Me.sent_lb.Text = "Sent: 0"
        '
        'total_lb
        '
        Me.total_lb.AutoSize = True
        Me.total_lb.Font = New System.Drawing.Font("Miramonte", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total_lb.Location = New System.Drawing.Point(170, 45)
        Me.total_lb.Name = "total_lb"
        Me.total_lb.Size = New System.Drawing.Size(120, 19)
        Me.total_lb.TabIndex = 1
        Me.total_lb.Text = "Total Messages: 0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("News Gothic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(128, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Status:Sending Email Over"
        '
        'more_less_btn
        '
        Me.more_less_btn.Location = New System.Drawing.Point(195, 225)
        Me.more_less_btn.Name = "more_less_btn"
        Me.more_less_btn.Size = New System.Drawing.Size(116, 26)
        Me.more_less_btn.TabIndex = 1
        Me.more_less_btn.Text = "show details"
        Me.more_less_btn.UseVisualStyleBackColor = True
        '
        'details_gridview
        '
        Me.details_gridview.AllowUserToAddRows = False
        Me.details_gridview.AllowUserToDeleteRows = False
        Me.details_gridview.AllowUserToResizeRows = False
        Me.details_gridview.BackgroundColor = System.Drawing.SystemColors.InactiveCaption
        Me.details_gridview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.details_gridview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal
        Me.details_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.details_gridview.Location = New System.Drawing.Point(12, 276)
        Me.details_gridview.MultiSelect = False
        Me.details_gridview.Name = "details_gridview"
        Me.details_gridview.ReadOnly = True
        Me.details_gridview.RowHeadersVisible = False
        Me.details_gridview.Size = New System.Drawing.Size(482, 150)
        Me.details_gridview.TabIndex = 2
        Me.details_gridview.Visible = False
        '
        'ResultsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(506, 270)
        Me.Controls.Add(Me.details_gridview)
        Me.Controls.Add(Me.more_less_btn)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ResultsForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Results"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.details_gridview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents more_less_btn As System.Windows.Forms.Button
    Friend WithEvents details_gridview As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents sent_lb As System.Windows.Forms.Label
    Friend WithEvents total_lb As System.Windows.Forms.Label
    Friend WithEvents failed_lb As System.Windows.Forms.Label
    Friend WithEvents success_lb As System.Windows.Forms.Label
End Class
