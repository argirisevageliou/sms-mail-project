<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewSmsMessage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewSmsMessage))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DraftsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SendToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RedoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SmsAccountManagerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SmsSendTo_tb = New System.Windows.Forms.TextBox
        Me.SmsSearchGroupBtn = New System.Windows.Forms.Button
        Me.SmsSearchAccount_btn = New System.Windows.Forms.Button
        Me.SmsRichTextBox = New System.Windows.Forms.RichTextBox
        Me.SmsSubjectTb = New System.Windows.Forms.TextBox
        Me.SmsFrom_tb = New System.Windows.Forms.TextBox
        Me.SmsSubjectLabel = New System.Windows.Forms.Label
        Me.SmsFromLabel = New System.Windows.Forms.Label
        Me.SmsSendToLabel = New System.Windows.Forms.Label
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(568, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.SaveToolStripMenuItem, Me.DraftsToolStripMenuItem, Me.SendToolStripMenuItem, Me.ToolStripSeparator4, Me.CloseToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Image = CType(resources.GetObject("NewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Image = CType(resources.GetObject("SaveToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'DraftsToolStripMenuItem
        '
        Me.DraftsToolStripMenuItem.Image = Global.sms_mail_project.My.Resources.Resources.add_button
        Me.DraftsToolStripMenuItem.Name = "DraftsToolStripMenuItem"
        Me.DraftsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.DraftsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DraftsToolStripMenuItem.Text = "Drafts"
        '
        'SendToolStripMenuItem
        '
        Me.SendToolStripMenuItem.Image = CType(resources.GetObject("SendToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SendToolStripMenuItem.Name = "SendToolStripMenuItem"
        Me.SendToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6
        Me.SendToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SendToolStripMenuItem.Text = "Send"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(149, 6)
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoToolStripMenuItem, Me.RedoToolStripMenuItem, Me.ToolStripSeparator2, Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem, Me.ToolStripSeparator3, Me.SelectAllToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.Image = CType(resources.GetObject("UndoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.UndoToolStripMenuItem.Text = "Undo"
        '
        'RedoToolStripMenuItem
        '
        Me.RedoToolStripMenuItem.Image = CType(resources.GetObject("RedoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        Me.RedoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.RedoToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.RedoToolStripMenuItem.Text = "Redo"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(164, 6)
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Image = CType(resources.GetObject("CutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.CutToolStripMenuItem.Text = "Cut"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Image = CType(resources.GetObject("CopyToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Image = CType(resources.GetObject("PasteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.PasteToolStripMenuItem.Text = "Paste"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(164, 6)
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.SelectAllToolStripMenuItem.Text = "Select All"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SmsAccountManagerToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'SmsAccountManagerToolStripMenuItem
        '
        Me.SmsAccountManagerToolStripMenuItem.Name = "SmsAccountManagerToolStripMenuItem"
        Me.SmsAccountManagerToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.SmsAccountManagerToolStripMenuItem.Text = "Sms Account Manager"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpFormToolStripMenuItem, Me.ToolStripSeparator1, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'HelpFormToolStripMenuItem
        '
        Me.HelpFormToolStripMenuItem.Name = "HelpFormToolStripMenuItem"
        Me.HelpFormToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.HelpFormToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.HelpFormToolStripMenuItem.Text = "Help Form"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'SmsSendTo_tb
        '
        Me.SmsSendTo_tb.Enabled = False
        Me.SmsSendTo_tb.Location = New System.Drawing.Point(87, 61)
        Me.SmsSendTo_tb.Name = "SmsSendTo_tb"
        Me.SmsSendTo_tb.Size = New System.Drawing.Size(423, 20)
        Me.SmsSendTo_tb.TabIndex = 21
        '
        'SmsSearchGroupBtn
        '
        Me.SmsSearchGroupBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SmsSearchGroupBtn.Location = New System.Drawing.Point(527, 61)
        Me.SmsSearchGroupBtn.Name = "SmsSearchGroupBtn"
        Me.SmsSearchGroupBtn.Size = New System.Drawing.Size(25, 20)
        Me.SmsSearchGroupBtn.TabIndex = 16
        Me.SmsSearchGroupBtn.Text = "..."
        Me.SmsSearchGroupBtn.UseVisualStyleBackColor = True
        '
        'SmsSearchAccount_btn
        '
        Me.SmsSearchAccount_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SmsSearchAccount_btn.Location = New System.Drawing.Point(527, 90)
        Me.SmsSearchAccount_btn.Name = "SmsSearchAccount_btn"
        Me.SmsSearchAccount_btn.Size = New System.Drawing.Size(25, 20)
        Me.SmsSearchAccount_btn.TabIndex = 17
        Me.SmsSearchAccount_btn.Text = "..."
        Me.SmsSearchAccount_btn.UseVisualStyleBackColor = True
        Me.SmsSearchAccount_btn.Visible = False
        '
        'SmsRichTextBox
        '
        Me.SmsRichTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SmsRichTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SmsRichTextBox.Location = New System.Drawing.Point(36, 162)
        Me.SmsRichTextBox.Name = "SmsRichTextBox"
        Me.SmsRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.SmsRichTextBox.Size = New System.Drawing.Size(502, 273)
        Me.SmsRichTextBox.TabIndex = 14
        Me.SmsRichTextBox.Text = ""
        '
        'SmsSubjectTb
        '
        Me.SmsSubjectTb.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SmsSubjectTb.Location = New System.Drawing.Point(87, 117)
        Me.SmsSubjectTb.Multiline = True
        Me.SmsSubjectTb.Name = "SmsSubjectTb"
        Me.SmsSubjectTb.Size = New System.Drawing.Size(423, 20)
        Me.SmsSubjectTb.TabIndex = 13
        '
        'SmsFrom_tb
        '
        Me.SmsFrom_tb.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SmsFrom_tb.Enabled = False
        Me.SmsFrom_tb.Location = New System.Drawing.Point(87, 90)
        Me.SmsFrom_tb.Multiline = True
        Me.SmsFrom_tb.Name = "SmsFrom_tb"
        Me.SmsFrom_tb.Size = New System.Drawing.Size(423, 20)
        Me.SmsFrom_tb.TabIndex = 15
        '
        'SmsSubjectLabel
        '
        Me.SmsSubjectLabel.AutoSize = True
        Me.SmsSubjectLabel.Location = New System.Drawing.Point(17, 120)
        Me.SmsSubjectLabel.Name = "SmsSubjectLabel"
        Me.SmsSubjectLabel.Size = New System.Drawing.Size(46, 13)
        Me.SmsSubjectLabel.TabIndex = 20
        Me.SmsSubjectLabel.Text = "Subject:"
        '
        'SmsFromLabel
        '
        Me.SmsFromLabel.AutoSize = True
        Me.SmsFromLabel.Location = New System.Drawing.Point(17, 93)
        Me.SmsFromLabel.Name = "SmsFromLabel"
        Me.SmsFromLabel.Size = New System.Drawing.Size(33, 13)
        Me.SmsFromLabel.TabIndex = 19
        Me.SmsFromLabel.Text = "From:"
        '
        'SmsSendToLabel
        '
        Me.SmsSendToLabel.AutoSize = True
        Me.SmsSendToLabel.Location = New System.Drawing.Point(17, 63)
        Me.SmsSendToLabel.Name = "SmsSendToLabel"
        Me.SmsSendToLabel.Size = New System.Drawing.Size(51, 13)
        Me.SmsSendToLabel.TabIndex = 18
        Me.SmsSendToLabel.Text = "Send To:"
        '
        'NewSmsMessage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(568, 496)
        Me.Controls.Add(Me.SmsSendTo_tb)
        Me.Controls.Add(Me.SmsSearchGroupBtn)
        Me.Controls.Add(Me.SmsSearchAccount_btn)
        Me.Controls.Add(Me.SmsRichTextBox)
        Me.Controls.Add(Me.SmsSubjectTb)
        Me.Controls.Add(Me.SmsFrom_tb)
        Me.Controls.Add(Me.SmsSubjectLabel)
        Me.Controls.Add(Me.SmsFromLabel)
        Me.Controls.Add(Me.SmsSendToLabel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "NewSmsMessage"
        Me.Text = "New Sms Message"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpFormToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SmsAccountManagerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UndoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SelectAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DraftsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SendToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SmsSendTo_tb As System.Windows.Forms.TextBox
    Friend WithEvents SmsSearchGroupBtn As System.Windows.Forms.Button
    Friend WithEvents SmsSearchAccount_btn As System.Windows.Forms.Button
    Friend WithEvents SmsRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents SmsSubjectTb As System.Windows.Forms.TextBox
    Friend WithEvents SmsFrom_tb As System.Windows.Forms.TextBox
    Friend WithEvents SmsSubjectLabel As System.Windows.Forms.Label
    Friend WithEvents SmsFromLabel As System.Windows.Forms.Label
    Friend WithEvents SmsSendToLabel As System.Windows.Forms.Label
End Class
