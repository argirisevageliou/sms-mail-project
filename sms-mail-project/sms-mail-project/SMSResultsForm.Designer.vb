<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SMSResultsForm
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.total_lb = New System.Windows.Forms.Label
        Me.delevered_lb = New System.Windows.Forms.Label
        Me.failed_lb = New System.Windows.Forms.Label
        Me.queued_lb = New System.Windows.Forms.Label
        Me.pending_lb = New System.Windows.Forms.Label
        Me.error_lb = New System.Windows.Forms.Label
        Me.success_lb = New System.Windows.Forms.Label
        Me.details_btn = New System.Windows.Forms.Button
        Me.results_gv = New System.Windows.Forms.DataGridView
        Me.Panel1.SuspendLayout()
        CType(Me.results_gv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.success_lb)
        Me.Panel1.Controls.Add(Me.error_lb)
        Me.Panel1.Controls.Add(Me.pending_lb)
        Me.Panel1.Controls.Add(Me.queued_lb)
        Me.Panel1.Controls.Add(Me.failed_lb)
        Me.Panel1.Controls.Add(Me.delevered_lb)
        Me.Panel1.Controls.Add(Me.total_lb)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 33)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(482, 247)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("News Gothic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(137, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(206, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Status: Sending SMS Over"
        '
        'total_lb
        '
        Me.total_lb.AutoSize = True
        Me.total_lb.Font = New System.Drawing.Font("Miramonte", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total_lb.Location = New System.Drawing.Point(176, 42)
        Me.total_lb.Name = "total_lb"
        Me.total_lb.Size = New System.Drawing.Size(120, 19)
        Me.total_lb.TabIndex = 1
        Me.total_lb.Text = "Total Messages: 0"
        '
        'delevered_lb
        '
        Me.delevered_lb.AutoSize = True
        Me.delevered_lb.Font = New System.Drawing.Font("Miramonte", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delevered_lb.ForeColor = System.Drawing.Color.Green
        Me.delevered_lb.Location = New System.Drawing.Point(193, 69)
        Me.delevered_lb.Name = "delevered_lb"
        Me.delevered_lb.Size = New System.Drawing.Size(87, 19)
        Me.delevered_lb.TabIndex = 2
        Me.delevered_lb.Text = "Delivered: 0"
        '
        'failed_lb
        '
        Me.failed_lb.AutoSize = True
        Me.failed_lb.Font = New System.Drawing.Font("Miramonte", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.failed_lb.ForeColor = System.Drawing.Color.Maroon
        Me.failed_lb.Location = New System.Drawing.Point(202, 95)
        Me.failed_lb.Name = "failed_lb"
        Me.failed_lb.Size = New System.Drawing.Size(63, 19)
        Me.failed_lb.TabIndex = 3
        Me.failed_lb.Text = "Failed: 0"
        '
        'queued_lb
        '
        Me.queued_lb.AutoSize = True
        Me.queued_lb.Font = New System.Drawing.Font("Miramonte", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.queued_lb.ForeColor = System.Drawing.Color.Chocolate
        Me.queued_lb.Location = New System.Drawing.Point(195, 121)
        Me.queued_lb.Name = "queued_lb"
        Me.queued_lb.Size = New System.Drawing.Size(75, 19)
        Me.queued_lb.TabIndex = 4
        Me.queued_lb.Text = "Queued: 0"
        '
        'pending_lb
        '
        Me.pending_lb.AutoSize = True
        Me.pending_lb.Font = New System.Drawing.Font("Miramonte", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pending_lb.ForeColor = System.Drawing.Color.Chocolate
        Me.pending_lb.Location = New System.Drawing.Point(194, 149)
        Me.pending_lb.Name = "pending_lb"
        Me.pending_lb.Size = New System.Drawing.Size(75, 19)
        Me.pending_lb.TabIndex = 5
        Me.pending_lb.Text = "Pending: 0"
        '
        'error_lb
        '
        Me.error_lb.AutoSize = True
        Me.error_lb.Font = New System.Drawing.Font("Miramonte", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.error_lb.ForeColor = System.Drawing.Color.Red
        Me.error_lb.Location = New System.Drawing.Point(201, 177)
        Me.error_lb.Name = "error_lb"
        Me.error_lb.Size = New System.Drawing.Size(55, 19)
        Me.error_lb.TabIndex = 6
        Me.error_lb.Text = "Error: 0"
        '
        'success_lb
        '
        Me.success_lb.AutoSize = True
        Me.success_lb.Font = New System.Drawing.Font("Miramonte", 12.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.success_lb.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.success_lb.Location = New System.Drawing.Point(171, 208)
        Me.success_lb.Name = "success_lb"
        Me.success_lb.Size = New System.Drawing.Size(133, 21)
        Me.success_lb.TabIndex = 7
        Me.success_lb.Text = "Success Rate: 0%"
        '
        'details_btn
        '
        Me.details_btn.Location = New System.Drawing.Point(210, 304)
        Me.details_btn.Name = "details_btn"
        Me.details_btn.Size = New System.Drawing.Size(90, 23)
        Me.details_btn.TabIndex = 1
        Me.details_btn.Text = "show details"
        Me.details_btn.UseVisualStyleBackColor = True
        '
        'results_gv
        '
        Me.results_gv.AllowUserToAddRows = False
        Me.results_gv.AllowUserToDeleteRows = False
        Me.results_gv.AllowUserToResizeRows = False
        Me.results_gv.BackgroundColor = System.Drawing.SystemColors.InactiveCaption
        Me.results_gv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.results_gv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal
        Me.results_gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.results_gv.Location = New System.Drawing.Point(15, 348)
        Me.results_gv.MultiSelect = False
        Me.results_gv.Name = "results_gv"
        Me.results_gv.ReadOnly = True
        Me.results_gv.RowHeadersVisible = False
        Me.results_gv.Size = New System.Drawing.Size(482, 150)
        Me.results_gv.TabIndex = 2
        Me.results_gv.Visible = False
        '
        'SMSResultsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(509, 343)
        Me.Controls.Add(Me.results_gv)
        Me.Controls.Add(Me.details_btn)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SMSResultsForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Results"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.results_gv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents total_lb As System.Windows.Forms.Label
    Friend WithEvents failed_lb As System.Windows.Forms.Label
    Friend WithEvents delevered_lb As System.Windows.Forms.Label
    Friend WithEvents error_lb As System.Windows.Forms.Label
    Friend WithEvents pending_lb As System.Windows.Forms.Label
    Friend WithEvents queued_lb As System.Windows.Forms.Label
    Friend WithEvents success_lb As System.Windows.Forms.Label
    Friend WithEvents details_btn As System.Windows.Forms.Button
    Friend WithEvents results_gv As System.Windows.Forms.DataGridView
End Class
