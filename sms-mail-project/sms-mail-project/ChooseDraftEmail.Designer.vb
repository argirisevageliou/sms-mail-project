<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChooseDraftEmail
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
        Me.DraftEmailsGridView = New System.Windows.Forms.DataGridView
        Me.DraftemailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TestDataSet1 = New sms_mail_project.testDataSet1
        Me.DraftemailsTableAdapter = New sms_mail_project.testDataSet1TableAdapters.draftemailsTableAdapter
        Me.LoadBtn = New System.Windows.Forms.Button
        CType(Me.DraftEmailsGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DraftemailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DraftEmailsGridView
        '
        Me.DraftEmailsGridView.AllowUserToAddRows = False
        Me.DraftEmailsGridView.AllowUserToDeleteRows = False
        Me.DraftEmailsGridView.AllowUserToOrderColumns = True
        Me.DraftEmailsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DraftEmailsGridView.Location = New System.Drawing.Point(82, 68)
        Me.DraftEmailsGridView.Name = "DraftEmailsGridView"
        Me.DraftEmailsGridView.ReadOnly = True
        Me.DraftEmailsGridView.Size = New System.Drawing.Size(240, 150)
        Me.DraftEmailsGridView.TabIndex = 0
        '
        'DraftemailsBindingSource
        '
        Me.DraftemailsBindingSource.DataMember = "draftemails"
        Me.DraftemailsBindingSource.DataSource = Me.TestDataSet1
        '
        'TestDataSet1
        '
        Me.TestDataSet1.DataSetName = "testDataSet1"
        Me.TestDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DraftemailsTableAdapter
        '
        Me.DraftemailsTableAdapter.ClearBeforeFill = True
        '
        'LoadBtn
        '
        Me.LoadBtn.Location = New System.Drawing.Point(175, 254)
        Me.LoadBtn.Name = "LoadBtn"
        Me.LoadBtn.Size = New System.Drawing.Size(75, 23)
        Me.LoadBtn.TabIndex = 1
        Me.LoadBtn.Text = "Load"
        Me.LoadBtn.UseVisualStyleBackColor = True
        '
        'ChooseDraftEmail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 327)
        Me.Controls.Add(Me.LoadBtn)
        Me.Controls.Add(Me.DraftEmailsGridView)
        Me.Name = "ChooseDraftEmail"
        Me.Text = "ChooseDraftEmail"
        CType(Me.DraftEmailsGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DraftemailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DraftEmailsGridView As System.Windows.Forms.DataGridView
    Friend WithEvents TestDataSet1 As sms_mail_project.testDataSet1
    Friend WithEvents DraftemailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DraftemailsTableAdapter As sms_mail_project.testDataSet1TableAdapters.draftemailsTableAdapter
    Friend WithEvents LoadBtn As System.Windows.Forms.Button
End Class
