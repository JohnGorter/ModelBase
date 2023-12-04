<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddModelProject
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmAddModelProject))
        grSeettings = New GroupBox()
        Label5 = New Label()
        cmbProject = New ComboBox()
        cmbCatchment = New ComboBox()
        Label4 = New Label()
        btnModelProject = New Button()
        Label3 = New Label()
        cmbModellingSoftware = New ComboBox()
        txtprojectDir = New TextBox()
        Label2 = New Label()
        txtProjectName = New TextBox()
        Label1 = New Label()
        btnAddProject = New Button()
        dlgFolder = New FolderBrowserDialog()
        GroupBox1 = New GroupBox()
        grdProjecten = New DataGridView()
        colProjectNaam = New DataGridViewTextBoxColumn()
        grSeettings.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(grdProjecten, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' grSeettings
        ' 
        grSeettings.Controls.Add(Label5)
        grSeettings.Controls.Add(cmbProject)
        grSeettings.Controls.Add(cmbCatchment)
        grSeettings.Controls.Add(Label4)
        grSeettings.Controls.Add(btnModelProject)
        grSeettings.Controls.Add(Label3)
        grSeettings.Controls.Add(cmbModellingSoftware)
        grSeettings.Controls.Add(txtprojectDir)
        grSeettings.Controls.Add(Label2)
        grSeettings.Controls.Add(txtProjectName)
        grSeettings.Controls.Add(Label1)
        grSeettings.Location = New Point(597, 12)
        grSeettings.Name = "grSeettings"
        grSeettings.Size = New Size(656, 404)
        grSeettings.TabIndex = 0
        grSeettings.TabStop = False
        grSeettings.Text = "Settings"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(16, 169)
        Label5.Name = "Label5"
        Label5.Size = New Size(55, 20)
        Label5.TabIndex = 10
        Label5.Text = "Project"
        ' 
        ' cmbProject
        ' 
        cmbProject.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbProject.FormattingEnabled = True
        cmbProject.Location = New Point(156, 166)
        cmbProject.Name = "cmbProject"
        cmbProject.Size = New Size(494, 28)
        cmbProject.TabIndex = 5
        ' 
        ' cmbCatchment
        ' 
        cmbCatchment.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbCatchment.FormattingEnabled = True
        cmbCatchment.Location = New Point(156, 132)
        cmbCatchment.Name = "cmbCatchment"
        cmbCatchment.Size = New Size(494, 28)
        cmbCatchment.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(16, 135)
        Label4.Name = "Label4"
        Label4.Size = New Size(105, 20)
        Label4.TabIndex = 7
        Label4.Text = "Stroomgebied"
        ' 
        ' btnModelProject
        ' 
        btnModelProject.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnModelProject.Location = New Point(622, 98)
        btnModelProject.Name = "btnModelProject"
        btnModelProject.Size = New Size(28, 29)
        btnModelProject.TabIndex = 8
        btnModelProject.Text = ".."
        btnModelProject.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(16, 67)
        Label3.Name = "Label3"
        Label3.Size = New Size(134, 20)
        Label3.TabIndex = 5
        Label3.Text = "Modelleersoftware"
        ' 
        ' cmbModellingSoftware
        ' 
        cmbModellingSoftware.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbModellingSoftware.FormattingEnabled = True
        cmbModellingSoftware.Location = New Point(156, 64)
        cmbModellingSoftware.Name = "cmbModellingSoftware"
        cmbModellingSoftware.Size = New Size(494, 28)
        cmbModellingSoftware.TabIndex = 2
        ' 
        ' txtprojectDir
        ' 
        txtprojectDir.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtprojectDir.Location = New Point(156, 98)
        txtprojectDir.Name = "txtprojectDir"
        txtprojectDir.Size = New Size(460, 27)
        txtprojectDir.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(16, 101)
        Label2.Name = "Label2"
        Label2.Size = New Size(85, 20)
        Label2.TabIndex = 2
        Label2.Text = "Projectmap"
        ' 
        ' txtProjectName
        ' 
        txtProjectName.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtProjectName.Location = New Point(156, 31)
        txtProjectName.Name = "txtProjectName"
        txtProjectName.Size = New Size(494, 27)
        txtProjectName.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(15, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(92, 20)
        Label1.TabIndex = 0
        Label1.Text = "Projectnaam"
        ' 
        ' btnAddProject
        ' 
        btnAddProject.Location = New Point(1137, 453)
        btnAddProject.Name = "btnAddProject"
        btnAddProject.Size = New Size(116, 48)
        btnAddProject.TabIndex = 6
        btnAddProject.Text = "Toevoegen"
        btnAddProject.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(grdProjecten)
        GroupBox1.Location = New Point(12, 14)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(579, 402)
        GroupBox1.TabIndex = 7
        GroupBox1.TabStop = False
        GroupBox1.Text = "Reeds in de database"
        ' 
        ' grdProjecten
        ' 
        grdProjecten.AllowUserToAddRows = False
        grdProjecten.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        grdProjecten.Columns.AddRange(New DataGridViewColumn() {colProjectNaam})
        grdProjecten.Location = New Point(17, 32)
        grdProjecten.Name = "grdProjecten"
        grdProjecten.RowHeadersVisible = False
        grdProjecten.RowHeadersWidth = 51
        grdProjecten.RowTemplate.Height = 29
        grdProjecten.Size = New Size(542, 347)
        grdProjecten.TabIndex = 0
        ' 
        ' colProjectNaam
        ' 
        colProjectNaam.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        colProjectNaam.HeaderText = "Projectnaam"
        colProjectNaam.MinimumWidth = 6
        colProjectNaam.Name = "colProjectNaam"
        ' 
        ' frmAddModelProject
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1265, 513)
        Controls.Add(GroupBox1)
        Controls.Add(btnAddProject)
        Controls.Add(grSeettings)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmAddModelProject"
        Text = "Modelproject toevoegen"
        grSeettings.ResumeLayout(False)
        grSeettings.PerformLayout()
        GroupBox1.ResumeLayout(False)
        CType(grdProjecten, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents grSeettings As GroupBox
    Friend WithEvents btnAddProject As Button
    Friend WithEvents btnModelProject As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbModellingSoftware As ComboBox
    Friend WithEvents txtprojectDir As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtProjectName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbProject As ComboBox
    Friend WithEvents cmbCatchment As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dlgFolder As FolderBrowserDialog
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents grdProjecten As DataGridView
    Friend WithEvents colProjectNaam As DataGridViewTextBoxColumn
End Class
