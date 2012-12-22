<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sent Messages")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Drafts")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Messages", New System.Windows.Forms.TreeNode() {TreeNode7, TreeNode8})
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Add Group")
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("View Groups")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Groups", New System.Windows.Forms.TreeNode() {TreeNode10, TreeNode11})
        Me.HomeBtn = New System.Windows.Forms.Button
        Me.MessagesBtn = New System.Windows.Forms.Button
        Me.GroupsBtn = New System.Windows.Forms.Button
        Me.AccountsBtn = New System.Windows.Forms.Button
        Me.TreeView1 = New System.Windows.Forms.TreeView
        Me.Label1 = New System.Windows.Forms.Label
        Me.Draft_Panel = New System.Windows.Forms.Panel
        Me.DraftDate_TxtBox = New System.Windows.Forms.TextBox
        Me.DraftSendTo_TxtBox = New System.Windows.Forms.TextBox
        Me.DraftSubject_TxtBox = New System.Windows.Forms.TextBox
        Me.Date_Label1 = New System.Windows.Forms.Label
        Me.SendTo_Label1 = New System.Windows.Forms.Label
        Me.Subject_Label1 = New System.Windows.Forms.Label
        Me.DraftMailTextBox = New System.Windows.Forms.RichTextBox
        Me.Drafts_Label = New System.Windows.Forms.Label
        Me.DraftListBox = New System.Windows.Forms.ListBox
        Me.DraftemailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TestDataSet1 = New sms_mail_project.testDataSet1
        Me.Sent_Panel = New System.Windows.Forms.Panel
        Me.SentDate_TxtBox = New System.Windows.Forms.TextBox
        Me.SentSendTo_TxtBox = New System.Windows.Forms.TextBox
        Me.SentSubject_TxtBox = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.SentMailTextBox = New System.Windows.Forms.RichTextBox
        Me.Sent_Label = New System.Windows.Forms.Label
        Me.SentListBox = New System.Windows.Forms.ListBox
        Me.SentemailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TestDataSet2 = New sms_mail_project.testDataSet2
        Me.ShowEmailGroups_Panel = New System.Windows.Forms.Panel
        Me.DeleteGroupBtn = New System.Windows.Forms.Button
        Me.EmailGroupsGrid = New System.Windows.Forms.DataGridView
        Me.EditGroupBtn = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NewSmsGroupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NewMessageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NewSmsMessageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ManagerAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SMSAccountManager_menu = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpContentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.DraftemailsTableAdapter = New sms_mail_project.testDataSet1TableAdapters.draftemailsTableAdapter
        Me.SentemailsTableAdapter = New sms_mail_project.testDataSet2TableAdapters.sentemailsTableAdapter
        Me.Events = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Forward = New System.Windows.Forms.ToolStripTextBox
        Me.Create_Panel = New System.Windows.Forms.Panel
        Me.Label6 = New System.Windows.Forms.Label
        Me.Alertlabel = New System.Windows.Forms.Label
        Me.GroupNameTextBox = New System.Windows.Forms.TextBox
        Me.GroupNameLabel = New System.Windows.Forms.Label
        Me.CreateGroupBtn = New System.Windows.Forms.Button
        Me.EditEmailGroup_Panel = New System.Windows.Forms.Panel
        Me.ModifyContactBtn = New System.Windows.Forms.Button
        Me.AlertEmail = New System.Windows.Forms.Label
        Me.DeleteContactBtn = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.AddContactBtn = New System.Windows.Forms.Button
        Me.EmailTextBox = New System.Windows.Forms.TextBox
        Me.LastNameTextBox = New System.Windows.Forms.TextBox
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.ContactsGrid = New System.Windows.Forms.DataGridView
        Me.Draft_Panel.SuspendLayout()
        CType(Me.DraftemailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Sent_Panel.SuspendLayout()
        CType(Me.SentemailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ShowEmailGroups_Panel.SuspendLayout()
        CType(Me.EmailGroupsGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.Events.SuspendLayout()
        Me.Create_Panel.SuspendLayout()
        Me.EditEmailGroup_Panel.SuspendLayout()
        CType(Me.ContactsGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HomeBtn
        '
        Me.HomeBtn.BackColor = System.Drawing.Color.Lavender
        Me.HomeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.HomeBtn.Image = CType(resources.GetObject("HomeBtn.Image"), System.Drawing.Image)
        Me.HomeBtn.Location = New System.Drawing.Point(12, 27)
        Me.HomeBtn.Name = "HomeBtn"
        Me.HomeBtn.Size = New System.Drawing.Size(54, 67)
        Me.HomeBtn.TabIndex = 1
        Me.HomeBtn.Text = "Home"
        Me.HomeBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.HomeBtn.UseVisualStyleBackColor = False
        '
        'MessagesBtn
        '
        Me.MessagesBtn.BackgroundImage = CType(resources.GetObject("MessagesBtn.BackgroundImage"), System.Drawing.Image)
        Me.MessagesBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.MessagesBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.MessagesBtn.Location = New System.Drawing.Point(72, 27)
        Me.MessagesBtn.Name = "MessagesBtn"
        Me.MessagesBtn.Size = New System.Drawing.Size(63, 67)
        Me.MessagesBtn.TabIndex = 2
        Me.MessagesBtn.Text = "Messages"
        Me.MessagesBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.MessagesBtn.UseVisualStyleBackColor = True
        '
        'GroupsBtn
        '
        Me.GroupsBtn.BackgroundImage = CType(resources.GetObject("GroupsBtn.BackgroundImage"), System.Drawing.Image)
        Me.GroupsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.GroupsBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.GroupsBtn.Location = New System.Drawing.Point(141, 27)
        Me.GroupsBtn.Name = "GroupsBtn"
        Me.GroupsBtn.Size = New System.Drawing.Size(52, 67)
        Me.GroupsBtn.TabIndex = 3
        Me.GroupsBtn.Text = "Groups"
        Me.GroupsBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.GroupsBtn.UseVisualStyleBackColor = True
        '
        'AccountsBtn
        '
        Me.AccountsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.AccountsBtn.Image = CType(resources.GetObject("AccountsBtn.Image"), System.Drawing.Image)
        Me.AccountsBtn.Location = New System.Drawing.Point(199, 27)
        Me.AccountsBtn.Name = "AccountsBtn"
        Me.AccountsBtn.Size = New System.Drawing.Size(61, 67)
        Me.AccountsBtn.TabIndex = 4
        Me.AccountsBtn.Text = "Accounts"
        Me.AccountsBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.AccountsBtn.UseVisualStyleBackColor = True
        '
        'TreeView1
        '
        Me.TreeView1.BackColor = System.Drawing.Color.DodgerBlue
        Me.TreeView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TreeView1.ItemHeight = 25
        Me.TreeView1.LineColor = System.Drawing.Color.DeepSkyBlue
        Me.TreeView1.Location = New System.Drawing.Point(0, 150)
        Me.TreeView1.Name = "TreeView1"
        TreeNode7.BackColor = System.Drawing.Color.Chartreuse
        TreeNode7.Name = "Node1"
        TreeNode7.Text = "Sent Messages"
        TreeNode8.BackColor = System.Drawing.Color.Chartreuse
        TreeNode8.Name = "Node2"
        TreeNode8.Text = "Drafts"
        TreeNode9.BackColor = System.Drawing.Color.BlueViolet
        TreeNode9.Name = "Node0"
        TreeNode9.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode9.Text = "Messages"
        TreeNode10.BackColor = System.Drawing.Color.Chartreuse
        TreeNode10.Name = "Node4"
        TreeNode10.Text = "Add Group"
        TreeNode11.BackColor = System.Drawing.Color.Chartreuse
        TreeNode11.Name = "Node5"
        TreeNode11.Text = "View Groups"
        TreeNode12.BackColor = System.Drawing.Color.BlueViolet
        TreeNode12.Name = "Node3"
        TreeNode12.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode12.Text = "Groups"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode9, TreeNode12})
        Me.TreeView1.Scrollable = False
        Me.TreeView1.Size = New System.Drawing.Size(135, 223)
        Me.TreeView1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DarkViolet
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-3, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Home"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Draft_Panel
        '
        Me.Draft_Panel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Draft_Panel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Draft_Panel.Controls.Add(Me.DraftDate_TxtBox)
        Me.Draft_Panel.Controls.Add(Me.DraftSendTo_TxtBox)
        Me.Draft_Panel.Controls.Add(Me.DraftSubject_TxtBox)
        Me.Draft_Panel.Controls.Add(Me.Date_Label1)
        Me.Draft_Panel.Controls.Add(Me.SendTo_Label1)
        Me.Draft_Panel.Controls.Add(Me.Subject_Label1)
        Me.Draft_Panel.Controls.Add(Me.DraftMailTextBox)
        Me.Draft_Panel.Controls.Add(Me.Drafts_Label)
        Me.Draft_Panel.Controls.Add(Me.DraftListBox)
        Me.Draft_Panel.Location = New System.Drawing.Point(160, 147)
        Me.Draft_Panel.Name = "Draft_Panel"
        Me.Draft_Panel.Size = New System.Drawing.Size(694, 391)
        Me.Draft_Panel.TabIndex = 7
        Me.Draft_Panel.Visible = False
        '
        'DraftDate_TxtBox
        '
        Me.DraftDate_TxtBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DraftDate_TxtBox.Enabled = False
        Me.DraftDate_TxtBox.Location = New System.Drawing.Point(287, 67)
        Me.DraftDate_TxtBox.Name = "DraftDate_TxtBox"
        Me.DraftDate_TxtBox.Size = New System.Drawing.Size(359, 20)
        Me.DraftDate_TxtBox.TabIndex = 8
        '
        'DraftSendTo_TxtBox
        '
        Me.DraftSendTo_TxtBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DraftSendTo_TxtBox.Enabled = False
        Me.DraftSendTo_TxtBox.Location = New System.Drawing.Point(288, 41)
        Me.DraftSendTo_TxtBox.Name = "DraftSendTo_TxtBox"
        Me.DraftSendTo_TxtBox.Size = New System.Drawing.Size(359, 20)
        Me.DraftSendTo_TxtBox.TabIndex = 7
        '
        'DraftSubject_TxtBox
        '
        Me.DraftSubject_TxtBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DraftSubject_TxtBox.Enabled = False
        Me.DraftSubject_TxtBox.Location = New System.Drawing.Point(287, 12)
        Me.DraftSubject_TxtBox.Name = "DraftSubject_TxtBox"
        Me.DraftSubject_TxtBox.Size = New System.Drawing.Size(359, 20)
        Me.DraftSubject_TxtBox.TabIndex = 6
        '
        'Date_Label1
        '
        Me.Date_Label1.AutoSize = True
        Me.Date_Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Date_Label1.Location = New System.Drawing.Point(180, 61)
        Me.Date_Label1.Name = "Date_Label1"
        Me.Date_Label1.Size = New System.Drawing.Size(63, 25)
        Me.Date_Label1.TabIndex = 5
        Me.Date_Label1.Text = "Date:"
        '
        'SendTo_Label1
        '
        Me.SendTo_Label1.AutoSize = True
        Me.SendTo_Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.SendTo_Label1.Location = New System.Drawing.Point(180, 36)
        Me.SendTo_Label1.Name = "SendTo_Label1"
        Me.SendTo_Label1.Size = New System.Drawing.Size(99, 25)
        Me.SendTo_Label1.TabIndex = 4
        Me.SendTo_Label1.Text = "Send To:"
        '
        'Subject_Label1
        '
        Me.Subject_Label1.AutoSize = True
        Me.Subject_Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Subject_Label1.Location = New System.Drawing.Point(180, 8)
        Me.Subject_Label1.Name = "Subject_Label1"
        Me.Subject_Label1.Size = New System.Drawing.Size(90, 25)
        Me.Subject_Label1.TabIndex = 3
        Me.Subject_Label1.Text = "Subject:"
        '
        'DraftMailTextBox
        '
        Me.DraftMailTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DraftMailTextBox.Enabled = False
        Me.DraftMailTextBox.Location = New System.Drawing.Point(173, 112)
        Me.DraftMailTextBox.Name = "DraftMailTextBox"
        Me.DraftMailTextBox.Size = New System.Drawing.Size(501, 270)
        Me.DraftMailTextBox.TabIndex = 2
        Me.DraftMailTextBox.Text = ""
        '
        'Drafts_Label
        '
        Me.Drafts_Label.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Drafts_Label.AutoSize = True
        Me.Drafts_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Drafts_Label.ForeColor = System.Drawing.Color.Blue
        Me.Drafts_Label.Location = New System.Drawing.Point(35, 9)
        Me.Drafts_Label.Name = "Drafts_Label"
        Me.Drafts_Label.Size = New System.Drawing.Size(88, 31)
        Me.Drafts_Label.TabIndex = 1
        Me.Drafts_Label.Text = "Drafts"
        '
        'DraftListBox
        '
        Me.DraftListBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DraftListBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DraftListBox.DataSource = Me.DraftemailsBindingSource
        Me.DraftListBox.DisplayMember = "subject"
        Me.DraftListBox.FormattingEnabled = True
        Me.DraftListBox.Location = New System.Drawing.Point(3, 56)
        Me.DraftListBox.Name = "DraftListBox"
        Me.DraftListBox.Size = New System.Drawing.Size(151, 316)
        Me.DraftListBox.TabIndex = 0
        Me.DraftListBox.ValueMember = "subject"
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
        'Sent_Panel
        '
        Me.Sent_Panel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Sent_Panel.Controls.Add(Me.SentDate_TxtBox)
        Me.Sent_Panel.Controls.Add(Me.SentSendTo_TxtBox)
        Me.Sent_Panel.Controls.Add(Me.SentSubject_TxtBox)
        Me.Sent_Panel.Controls.Add(Me.Label2)
        Me.Sent_Panel.Controls.Add(Me.Label3)
        Me.Sent_Panel.Controls.Add(Me.Label4)
        Me.Sent_Panel.Controls.Add(Me.SentMailTextBox)
        Me.Sent_Panel.Controls.Add(Me.Sent_Label)
        Me.Sent_Panel.Controls.Add(Me.SentListBox)
        Me.Sent_Panel.Location = New System.Drawing.Point(157, 150)
        Me.Sent_Panel.Name = "Sent_Panel"
        Me.Sent_Panel.Size = New System.Drawing.Size(694, 391)
        Me.Sent_Panel.TabIndex = 9
        Me.Sent_Panel.Visible = False
        '
        'SentDate_TxtBox
        '
        Me.SentDate_TxtBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SentDate_TxtBox.Enabled = False
        Me.SentDate_TxtBox.Location = New System.Drawing.Point(298, 66)
        Me.SentDate_TxtBox.Name = "SentDate_TxtBox"
        Me.SentDate_TxtBox.Size = New System.Drawing.Size(354, 20)
        Me.SentDate_TxtBox.TabIndex = 17
        '
        'SentSendTo_TxtBox
        '
        Me.SentSendTo_TxtBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SentSendTo_TxtBox.Enabled = False
        Me.SentSendTo_TxtBox.Location = New System.Drawing.Point(299, 40)
        Me.SentSendTo_TxtBox.Name = "SentSendTo_TxtBox"
        Me.SentSendTo_TxtBox.Size = New System.Drawing.Size(354, 20)
        Me.SentSendTo_TxtBox.TabIndex = 16
        '
        'SentSubject_TxtBox
        '
        Me.SentSubject_TxtBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SentSubject_TxtBox.Enabled = False
        Me.SentSubject_TxtBox.Location = New System.Drawing.Point(298, 11)
        Me.SentSubject_TxtBox.Name = "SentSubject_TxtBox"
        Me.SentSubject_TxtBox.Size = New System.Drawing.Size(354, 20)
        Me.SentSubject_TxtBox.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label2.Location = New System.Drawing.Point(191, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 25)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Date:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label3.Location = New System.Drawing.Point(191, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 25)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Send To:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label4.Location = New System.Drawing.Point(191, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 25)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Subject:"
        '
        'SentMailTextBox
        '
        Me.SentMailTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SentMailTextBox.Enabled = False
        Me.SentMailTextBox.Location = New System.Drawing.Point(184, 111)
        Me.SentMailTextBox.Name = "SentMailTextBox"
        Me.SentMailTextBox.Size = New System.Drawing.Size(496, 273)
        Me.SentMailTextBox.TabIndex = 11
        Me.SentMailTextBox.Text = ""
        '
        'Sent_Label
        '
        Me.Sent_Label.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Sent_Label.AutoSize = True
        Me.Sent_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Sent_Label.ForeColor = System.Drawing.Color.Blue
        Me.Sent_Label.Location = New System.Drawing.Point(19, 9)
        Me.Sent_Label.Name = "Sent_Label"
        Me.Sent_Label.Size = New System.Drawing.Size(140, 31)
        Me.Sent_Label.TabIndex = 10
        Me.Sent_Label.Text = "Sent Mails"
        '
        'SentListBox
        '
        Me.SentListBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SentListBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SentListBox.DataSource = Me.SentemailsBindingSource
        Me.SentListBox.DisplayMember = "subject"
        Me.SentListBox.FormattingEnabled = True
        Me.SentListBox.Location = New System.Drawing.Point(14, 55)
        Me.SentListBox.Name = "SentListBox"
        Me.SentListBox.Size = New System.Drawing.Size(151, 329)
        Me.SentListBox.TabIndex = 9
        Me.SentListBox.ValueMember = "subject"
        '
        'SentemailsBindingSource
        '
        Me.SentemailsBindingSource.DataMember = "sentemails"
        Me.SentemailsBindingSource.DataSource = Me.TestDataSet2
        '
        'TestDataSet2
        '
        Me.TestDataSet2.DataSetName = "testDataSet2"
        Me.TestDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ShowEmailGroups_Panel
        '
        Me.ShowEmailGroups_Panel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ShowEmailGroups_Panel.BackColor = System.Drawing.Color.DodgerBlue
        Me.ShowEmailGroups_Panel.Controls.Add(Me.DeleteGroupBtn)
        Me.ShowEmailGroups_Panel.Controls.Add(Me.EmailGroupsGrid)
        Me.ShowEmailGroups_Panel.Controls.Add(Me.EditGroupBtn)
        Me.ShowEmailGroups_Panel.Controls.Add(Me.Label5)
        Me.ShowEmailGroups_Panel.Controls.Add(Me.Button1)
        Me.ShowEmailGroups_Panel.Location = New System.Drawing.Point(163, 143)
        Me.ShowEmailGroups_Panel.Name = "ShowEmailGroups_Panel"
        Me.ShowEmailGroups_Panel.Size = New System.Drawing.Size(694, 391)
        Me.ShowEmailGroups_Panel.TabIndex = 11
        Me.ShowEmailGroups_Panel.Visible = False
        '
        'DeleteGroupBtn
        '
        Me.DeleteGroupBtn.BackgroundImage = CType(resources.GetObject("DeleteGroupBtn.BackgroundImage"), System.Drawing.Image)
        Me.DeleteGroupBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.DeleteGroupBtn.Location = New System.Drawing.Point(250, 66)
        Me.DeleteGroupBtn.Name = "DeleteGroupBtn"
        Me.DeleteGroupBtn.Size = New System.Drawing.Size(86, 68)
        Me.DeleteGroupBtn.TabIndex = 11
        Me.DeleteGroupBtn.Text = "Delete group"
        Me.DeleteGroupBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.DeleteGroupBtn.UseVisualStyleBackColor = True
        '
        'EmailGroupsGrid
        '
        Me.EmailGroupsGrid.AllowUserToAddRows = False
        Me.EmailGroupsGrid.AllowUserToDeleteRows = False
        Me.EmailGroupsGrid.AllowUserToOrderColumns = True
        Me.EmailGroupsGrid.BackgroundColor = System.Drawing.Color.GreenYellow
        Me.EmailGroupsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmailGroupsGrid.Location = New System.Drawing.Point(47, 67)
        Me.EmailGroupsGrid.Name = "EmailGroupsGrid"
        Me.EmailGroupsGrid.ReadOnly = True
        Me.EmailGroupsGrid.Size = New System.Drawing.Size(147, 150)
        Me.EmailGroupsGrid.TabIndex = 10
        '
        'EditGroupBtn
        '
        Me.EditGroupBtn.BackgroundImage = CType(resources.GetObject("EditGroupBtn.BackgroundImage"), System.Drawing.Image)
        Me.EditGroupBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.EditGroupBtn.Location = New System.Drawing.Point(250, 140)
        Me.EditGroupBtn.Name = "EditGroupBtn"
        Me.EditGroupBtn.Size = New System.Drawing.Size(86, 67)
        Me.EditGroupBtn.TabIndex = 9
        Me.EditGroupBtn.Text = "Edit group"
        Me.EditGroupBtn.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(44, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(230, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "To edit a group,select one and click edit button"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Lavender
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.Location = New System.Drawing.Point(47, 233)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 83)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Create a new email group"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GerToolStripMenuItem, Me.NewSmsGroupToolStripMenuItem, Me.NewMessageToolStripMenuItem, Me.NewSmsMessageToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.FileToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'GerToolStripMenuItem
        '
        Me.GerToolStripMenuItem.Name = "GerToolStripMenuItem"
        Me.GerToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.GerToolStripMenuItem.Text = "New Email Group"
        '
        'NewSmsGroupToolStripMenuItem
        '
        Me.NewSmsGroupToolStripMenuItem.Name = "NewSmsGroupToolStripMenuItem"
        Me.NewSmsGroupToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.NewSmsGroupToolStripMenuItem.Text = "New Sms Group"
        '
        'NewMessageToolStripMenuItem
        '
        Me.NewMessageToolStripMenuItem.Name = "NewMessageToolStripMenuItem"
        Me.NewMessageToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.NewMessageToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.NewMessageToolStripMenuItem.Text = "New Email Message"
        '
        'NewSmsMessageToolStripMenuItem
        '
        Me.NewSmsMessageToolStripMenuItem.Name = "NewSmsMessageToolStripMenuItem"
        Me.NewSmsMessageToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.NewSmsMessageToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.NewSmsMessageToolStripMenuItem.Text = "New Sms Message"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(209, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManagerAccountToolStripMenuItem, Me.SMSAccountManager_menu})
        Me.ToolsToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.ToolsToolStripMenuItem.Text = "&Tools"
        '
        'ManagerAccountToolStripMenuItem
        '
        Me.ManagerAccountToolStripMenuItem.Name = "ManagerAccountToolStripMenuItem"
        Me.ManagerAccountToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.ManagerAccountToolStripMenuItem.Text = "Email Account Manager"
        '
        'SMSAccountManager_menu
        '
        Me.SMSAccountManager_menu.Name = "SMSAccountManager_menu"
        Me.SMSAccountManager_menu.Size = New System.Drawing.Size(217, 22)
        Me.SMSAccountManager_menu.Text = "SMS Account Manager"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpContentsToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'HelpContentsToolStripMenuItem
        '
        Me.HelpContentsToolStripMenuItem.Image = CType(resources.GetObject("HelpContentsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.HelpContentsToolStripMenuItem.Name = "HelpContentsToolStripMenuItem"
        Me.HelpContentsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.HelpContentsToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.HelpContentsToolStripMenuItem.Text = "Help Contents"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.DarkViolet
        Me.MenuStrip1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(885, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DraftemailsTableAdapter
        '
        Me.DraftemailsTableAdapter.ClearBeforeFill = True
        '
        'SentemailsTableAdapter
        '
        Me.SentemailsTableAdapter.ClearBeforeFill = True
        '
        'Events
        '
        Me.Events.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Forward})
        Me.Events.Name = "Events"
        Me.Events.Size = New System.Drawing.Size(161, 127)
        '
        'Forward
        '
        Me.Forward.Enabled = False
        Me.Forward.Margin = New System.Windows.Forms.Padding(50)
        Me.Forward.Name = "Forward"
        Me.Forward.Size = New System.Drawing.Size(100, 23)
        Me.Forward.Text = "Forward"
        '
        'Create_Panel
        '
        Me.Create_Panel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Create_Panel.BackgroundImage = CType(resources.GetObject("Create_Panel.BackgroundImage"), System.Drawing.Image)
        Me.Create_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Create_Panel.Controls.Add(Me.Label6)
        Me.Create_Panel.Controls.Add(Me.Alertlabel)
        Me.Create_Panel.Controls.Add(Me.GroupNameTextBox)
        Me.Create_Panel.Controls.Add(Me.GroupNameLabel)
        Me.Create_Panel.Controls.Add(Me.CreateGroupBtn)
        Me.Create_Panel.Location = New System.Drawing.Point(169, 135)
        Me.Create_Panel.Name = "Create_Panel"
        Me.Create_Panel.Size = New System.Drawing.Size(694, 391)
        Me.Create_Panel.TabIndex = 10
        Me.Create_Panel.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label6.Location = New System.Drawing.Point(52, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(217, 20)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Create New Email Group"
        '
        'Alertlabel
        '
        Me.Alertlabel.AutoSize = True
        Me.Alertlabel.ForeColor = System.Drawing.Color.Red
        Me.Alertlabel.Location = New System.Drawing.Point(318, 319)
        Me.Alertlabel.Name = "Alertlabel"
        Me.Alertlabel.Size = New System.Drawing.Size(126, 13)
        Me.Alertlabel.TabIndex = 7
        Me.Alertlabel.Text = "You have to give a name"
        Me.Alertlabel.Visible = False
        '
        'GroupNameTextBox
        '
        Me.GroupNameTextBox.Location = New System.Drawing.Point(316, 183)
        Me.GroupNameTextBox.Name = "GroupNameTextBox"
        Me.GroupNameTextBox.Size = New System.Drawing.Size(117, 20)
        Me.GroupNameTextBox.TabIndex = 6
        '
        'GroupNameLabel
        '
        Me.GroupNameLabel.AutoSize = True
        Me.GroupNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupNameLabel.Location = New System.Drawing.Point(222, 186)
        Me.GroupNameLabel.Name = "GroupNameLabel"
        Me.GroupNameLabel.Size = New System.Drawing.Size(88, 15)
        Me.GroupNameLabel.TabIndex = 5
        Me.GroupNameLabel.Text = "Group Name"
        '
        'CreateGroupBtn
        '
        Me.CreateGroupBtn.Image = CType(resources.GetObject("CreateGroupBtn.Image"), System.Drawing.Image)
        Me.CreateGroupBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CreateGroupBtn.Location = New System.Drawing.Point(321, 214)
        Me.CreateGroupBtn.Name = "CreateGroupBtn"
        Me.CreateGroupBtn.Size = New System.Drawing.Size(112, 67)
        Me.CreateGroupBtn.TabIndex = 4
        Me.CreateGroupBtn.Text = "Create Email Group"
        Me.CreateGroupBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CreateGroupBtn.UseVisualStyleBackColor = True
        '
        'EditEmailGroup_Panel
        '
        Me.EditEmailGroup_Panel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EditEmailGroup_Panel.BackColor = System.Drawing.Color.DodgerBlue
        Me.EditEmailGroup_Panel.Controls.Add(Me.ModifyContactBtn)
        Me.EditEmailGroup_Panel.Controls.Add(Me.AlertEmail)
        Me.EditEmailGroup_Panel.Controls.Add(Me.DeleteContactBtn)
        Me.EditEmailGroup_Panel.Controls.Add(Me.Label7)
        Me.EditEmailGroup_Panel.Controls.Add(Me.AddContactBtn)
        Me.EditEmailGroup_Panel.Controls.Add(Me.EmailTextBox)
        Me.EditEmailGroup_Panel.Controls.Add(Me.LastNameTextBox)
        Me.EditEmailGroup_Panel.Controls.Add(Me.FirstNameTextBox)
        Me.EditEmailGroup_Panel.Controls.Add(Me.Label8)
        Me.EditEmailGroup_Panel.Controls.Add(Me.Label9)
        Me.EditEmailGroup_Panel.Controls.Add(Me.Label10)
        Me.EditEmailGroup_Panel.Controls.Add(Me.Label11)
        Me.EditEmailGroup_Panel.Controls.Add(Me.ContactsGrid)
        Me.EditEmailGroup_Panel.Location = New System.Drawing.Point(166, 138)
        Me.EditEmailGroup_Panel.Name = "EditEmailGroup_Panel"
        Me.EditEmailGroup_Panel.Size = New System.Drawing.Size(694, 391)
        Me.EditEmailGroup_Panel.TabIndex = 12
        Me.EditEmailGroup_Panel.Visible = False
        '
        'ModifyContactBtn
        '
        Me.ModifyContactBtn.BackgroundImage = CType(resources.GetObject("ModifyContactBtn.BackgroundImage"), System.Drawing.Image)
        Me.ModifyContactBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ModifyContactBtn.Location = New System.Drawing.Point(455, 95)
        Me.ModifyContactBtn.Name = "ModifyContactBtn"
        Me.ModifyContactBtn.Size = New System.Drawing.Size(94, 72)
        Me.ModifyContactBtn.TabIndex = 25
        Me.ModifyContactBtn.Text = "Modify contact"
        Me.ModifyContactBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ModifyContactBtn.UseVisualStyleBackColor = True
        '
        'AlertEmail
        '
        Me.AlertEmail.AutoSize = True
        Me.AlertEmail.ForeColor = System.Drawing.Color.Red
        Me.AlertEmail.Location = New System.Drawing.Point(367, 355)
        Me.AlertEmail.Name = "AlertEmail"
        Me.AlertEmail.Size = New System.Drawing.Size(102, 13)
        Me.AlertEmail.TabIndex = 24
        Me.AlertEmail.Text = "Wrong Email Format"
        Me.AlertEmail.Visible = False
        '
        'DeleteContactBtn
        '
        Me.DeleteContactBtn.BackgroundImage = CType(resources.GetObject("DeleteContactBtn.BackgroundImage"), System.Drawing.Image)
        Me.DeleteContactBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.DeleteContactBtn.Location = New System.Drawing.Point(455, 23)
        Me.DeleteContactBtn.Name = "DeleteContactBtn"
        Me.DeleteContactBtn.Size = New System.Drawing.Size(94, 67)
        Me.DeleteContactBtn.TabIndex = 23
        Me.DeleteContactBtn.Text = "Delete contact"
        Me.DeleteContactBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.DeleteContactBtn.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(155, 417)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(123, 13)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Please complete all texts"
        Me.Label7.Visible = False
        '
        'AddContactBtn
        '
        Me.AddContactBtn.Location = New System.Drawing.Point(49, 412)
        Me.AddContactBtn.Name = "AddContactBtn"
        Me.AddContactBtn.Size = New System.Drawing.Size(75, 23)
        Me.AddContactBtn.TabIndex = 21
        Me.AddContactBtn.Text = "Add contact"
        Me.AddContactBtn.UseVisualStyleBackColor = True
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Location = New System.Drawing.Point(136, 348)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(201, 20)
        Me.EmailTextBox.TabIndex = 20
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Location = New System.Drawing.Point(136, 308)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(201, 20)
        Me.LastNameTextBox.TabIndex = 19
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Location = New System.Drawing.Point(136, 269)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(201, 20)
        Me.FirstNameTextBox.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(49, 355)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Email"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(49, 316)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "LastName"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(49, 277)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 13)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "FirstName"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(46, 230)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(305, 13)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Complete all texts and press add to add a new contact to group"
        '
        'ContactsGrid
        '
        Me.ContactsGrid.AllowUserToAddRows = False
        Me.ContactsGrid.AllowUserToDeleteRows = False
        Me.ContactsGrid.AllowUserToResizeRows = False
        Me.ContactsGrid.BackgroundColor = System.Drawing.Color.GreenYellow
        Me.ContactsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ContactsGrid.Location = New System.Drawing.Point(35, 23)
        Me.ContactsGrid.MultiSelect = False
        Me.ContactsGrid.Name = "ContactsGrid"
        Me.ContactsGrid.ReadOnly = True
        Me.ContactsGrid.Size = New System.Drawing.Size(394, 150)
        Me.ContactsGrid.TabIndex = 15
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(885, 568)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.AccountsBtn)
        Me.Controls.Add(Me.GroupsBtn)
        Me.Controls.Add(Me.MessagesBtn)
        Me.Controls.Add(Me.HomeBtn)
        Me.Controls.Add(Me.EditEmailGroup_Panel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Sent_Panel)
        Me.Controls.Add(Me.Create_Panel)
        Me.Controls.Add(Me.Draft_Panel)
        Me.Controls.Add(Me.ShowEmailGroups_Panel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = "Sms & Email Application Center -  Free Edition"
        Me.Draft_Panel.ResumeLayout(False)
        Me.Draft_Panel.PerformLayout()
        CType(Me.DraftemailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Sent_Panel.ResumeLayout(False)
        Me.Sent_Panel.PerformLayout()
        CType(Me.SentemailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ShowEmailGroups_Panel.ResumeLayout(False)
        Me.ShowEmailGroups_Panel.PerformLayout()
        CType(Me.EmailGroupsGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Events.ResumeLayout(False)
        Me.Events.PerformLayout()
        Me.Create_Panel.ResumeLayout(False)
        Me.Create_Panel.PerformLayout()
        Me.EditEmailGroup_Panel.ResumeLayout(False)
        Me.EditEmailGroup_Panel.PerformLayout()
        CType(Me.ContactsGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HomeBtn As System.Windows.Forms.Button
    Friend WithEvents MessagesBtn As System.Windows.Forms.Button
    Friend WithEvents GroupsBtn As System.Windows.Forms.Button
    Friend WithEvents AccountsBtn As System.Windows.Forms.Button
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Draft_Panel As System.Windows.Forms.Panel
    Friend WithEvents DraftListBox As System.Windows.Forms.ListBox
    Friend WithEvents Drafts_Label As System.Windows.Forms.Label
    Friend WithEvents Subject_Label1 As System.Windows.Forms.Label
    Friend WithEvents DraftMailTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents Date_Label1 As System.Windows.Forms.Label
    Friend WithEvents SendTo_Label1 As System.Windows.Forms.Label
    Friend WithEvents DraftSubject_TxtBox As System.Windows.Forms.TextBox
    Friend WithEvents DraftDate_TxtBox As System.Windows.Forms.TextBox
    Friend WithEvents DraftSendTo_TxtBox As System.Windows.Forms.TextBox
    Friend WithEvents Sent_Panel As System.Windows.Forms.Panel
    Friend WithEvents SentDate_TxtBox As System.Windows.Forms.TextBox
    Friend WithEvents SentSendTo_TxtBox As System.Windows.Forms.TextBox
    Friend WithEvents SentSubject_TxtBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SentMailTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents Sent_Label As System.Windows.Forms.Label
    Friend WithEvents SentListBox As System.Windows.Forms.ListBox
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewMessageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManagerAccountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents TestDataSet1 As sms_mail_project.testDataSet1
    Friend WithEvents DraftemailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DraftemailsTableAdapter As sms_mail_project.testDataSet1TableAdapters.draftemailsTableAdapter
    Friend WithEvents TestDataSet2 As sms_mail_project.testDataSet2
    Friend WithEvents SentemailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SentemailsTableAdapter As sms_mail_project.testDataSet2TableAdapters.sentemailsTableAdapter
    Friend WithEvents Events As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents Forward As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents Create_Panel As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Alertlabel As System.Windows.Forms.Label
    Friend WithEvents GroupNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupNameLabel As System.Windows.Forms.Label
    Friend WithEvents CreateGroupBtn As System.Windows.Forms.Button
    Friend WithEvents ShowEmailGroups_Panel As System.Windows.Forms.Panel
    Friend WithEvents DeleteGroupBtn As System.Windows.Forms.Button
    Friend WithEvents EmailGroupsGrid As System.Windows.Forms.DataGridView
    Friend WithEvents EditGroupBtn As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents EditEmailGroup_Panel As System.Windows.Forms.Panel
    Friend WithEvents ModifyContactBtn As System.Windows.Forms.Button
    Friend WithEvents AlertEmail As System.Windows.Forms.Label
    Friend WithEvents DeleteContactBtn As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents SMSAccountManager_menu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddContactBtn As System.Windows.Forms.Button
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LastNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FirstNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ContactsGrid As System.Windows.Forms.DataGridView
    Friend WithEvents HelpContentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewSmsMessageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewSmsGroupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
