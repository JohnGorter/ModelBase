<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmModelBase
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmModelBase))
        MenuStrip1 = New MenuStrip()
        DatabaseToolStripMenuItem = New ToolStripMenuItem()
        OpenToolStripMenuItem = New ToolStripMenuItem()
        ImportToolStripMenuItem = New ToolStripMenuItem()
        AccessToolStripMenuItem = New ToolStripMenuItem()
        SplitContainer1 = New SplitContainer()
        txtDatabase = New TextBox()
        Label1 = New Label()
        dlgOpenFile = New OpenFileDialog()
        CreateNewToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {DatabaseToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1325, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' DatabaseToolStripMenuItem
        ' 
        DatabaseToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {OpenToolStripMenuItem, ImportToolStripMenuItem, CreateNewToolStripMenuItem})
        DatabaseToolStripMenuItem.Name = "DatabaseToolStripMenuItem"
        DatabaseToolStripMenuItem.Size = New Size(86, 24)
        DatabaseToolStripMenuItem.Text = "Database"
        ' 
        ' OpenToolStripMenuItem
        ' 
        OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        OpenToolStripMenuItem.Size = New Size(224, 26)
        OpenToolStripMenuItem.Text = "Open"
        ' 
        ' ImportToolStripMenuItem
        ' 
        ImportToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AccessToolStripMenuItem})
        ImportToolStripMenuItem.Name = "ImportToolStripMenuItem"
        ImportToolStripMenuItem.Size = New Size(224, 26)
        ImportToolStripMenuItem.Text = "Data"
        ' 
        ' AccessToolStripMenuItem
        ' 
        AccessToolStripMenuItem.Name = "AccessToolStripMenuItem"
        AccessToolStripMenuItem.Size = New Size(269, 26)
        AccessToolStripMenuItem.Text = "Import from Access (.mdb)"
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Dock = DockStyle.Fill
        SplitContainer1.Location = New Point(0, 28)
        SplitContainer1.Name = "SplitContainer1"
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.Controls.Add(txtDatabase)
        SplitContainer1.Panel1.Controls.Add(Label1)
        SplitContainer1.Size = New Size(1325, 498)
        SplitContainer1.SplitterDistance = 504
        SplitContainer1.TabIndex = 1
        ' 
        ' txtDatabase
        ' 
        txtDatabase.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtDatabase.Location = New Point(96, 20)
        txtDatabase.Name = "txtDatabase"
        txtDatabase.Size = New Size(386, 27)
        txtDatabase.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 20)
        Label1.TabIndex = 0
        Label1.Text = "Database:"
        ' 
        ' CreateNewToolStripMenuItem
        ' 
        CreateNewToolStripMenuItem.Name = "CreateNewToolStripMenuItem"
        CreateNewToolStripMenuItem.Size = New Size(224, 26)
        CreateNewToolStripMenuItem.Text = "Create new"
        ' 
        ' frmModelBase
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1325, 526)
        Controls.Add(SplitContainer1)
        Controls.Add(MenuStrip1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        Name = "frmModelBase"
        Text = "Modellenbeheer"
        WindowState = FormWindowState.Maximized
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel1.PerformLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DatabaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents dlgOpenFile As OpenFileDialog
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AccessToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtDatabase As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CreateNewToolStripMenuItem As ToolStripMenuItem
End Class
