<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddProjectModel
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmAddProjectModel))
        grSeettings = New GroupBox()
        txtVersion = New TextBox()
        Label7 = New Label()
        cmbBasismodelVersie = New ComboBox()
        Label4 = New Label()
        Label3 = New Label()
        cmbBasisModel = New ComboBox()
        Label6 = New Label()
        btnAddProject = New Button()
        Label5 = New Label()
        cmbProject = New ComboBox()
        btnModelDir = New Button()
        txtModelDir = New TextBox()
        Label2 = New Label()
        txtProjectModelName = New TextBox()
        Label1 = New Label()
        dlgFolder = New FolderBrowserDialog()
        GroupBox1 = New GroupBox()
        grdProjectModels = New DataGridView()
        colProjectModelName = New DataGridViewTextBoxColumn()
        colVersion = New DataGridViewTextBoxColumn()
        colProject = New DataGridViewTextBoxColumn()
        grSeettings.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(grdProjectModels, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' grSeettings
        ' 
        grSeettings.Controls.Add(txtVersion)
        grSeettings.Controls.Add(Label7)
        grSeettings.Controls.Add(cmbBasismodelVersie)
        grSeettings.Controls.Add(Label4)
        grSeettings.Controls.Add(Label3)
        grSeettings.Controls.Add(cmbBasisModel)
        grSeettings.Controls.Add(Label6)
        grSeettings.Controls.Add(btnAddProject)
        grSeettings.Controls.Add(Label5)
        grSeettings.Controls.Add(cmbProject)
        grSeettings.Controls.Add(btnModelDir)
        grSeettings.Controls.Add(txtModelDir)
        grSeettings.Controls.Add(Label2)
        grSeettings.Controls.Add(txtProjectModelName)
        grSeettings.Controls.Add(Label1)
        grSeettings.Location = New Point(522, 9)
        grSeettings.Margin = New Padding(3, 2, 3, 2)
        grSeettings.Name = "grSeettings"
        grSeettings.Padding = New Padding(3, 2, 3, 2)
        grSeettings.Size = New Size(574, 367)
        grSeettings.TabIndex = 0
        grSeettings.TabStop = False
        grSeettings.Text = "Settings"
        ' 
        ' txtVersion
        ' 
        txtVersion.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtVersion.Location = New Point(159, 158)
        txtVersion.Margin = New Padding(3, 2, 3, 2)
        txtVersion.Name = "txtVersion"
        txtVersion.Size = New Size(409, 23)
        txtVersion.TabIndex = 17
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(14, 161)
        Label7.Name = "Label7"
        Label7.Size = New Size(83, 15)
        Label7.TabIndex = 16
        Label7.Text = "Versie (x.x.x): *"
        ' 
        ' cmbBasismodelVersie
        ' 
        cmbBasismodelVersie.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbBasismodelVersie.FormattingEnabled = True
        cmbBasismodelVersie.Location = New Point(159, 77)
        cmbBasismodelVersie.Margin = New Padding(3, 2, 3, 2)
        cmbBasismodelVersie.Name = "cmbBasismodelVersie"
        cmbBasismodelVersie.Size = New Size(410, 23)
        cmbBasismodelVersie.TabIndex = 15
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(14, 80)
        Label4.Name = "Label4"
        Label4.Size = New Size(111, 15)
        Label4.TabIndex = 14
        Label4.Text = "Versie basismodel: *"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(14, 53)
        Label3.Name = "Label3"
        Label3.Size = New Size(113, 15)
        Label3.TabIndex = 13
        Label3.Text = "Naam basismodel: *"
        ' 
        ' cmbBasisModel
        ' 
        cmbBasisModel.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbBasisModel.FormattingEnabled = True
        cmbBasisModel.Location = New Point(159, 50)
        cmbBasisModel.Margin = New Padding(3, 2, 3, 2)
        cmbBasisModel.Name = "cmbBasisModel"
        cmbBasisModel.Size = New Size(410, 23)
        cmbBasisModel.TabIndex = 12
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(14, 343)
        Label6.Name = "Label6"
        Label6.Size = New Size(147, 15)
        Label6.TabIndex = 11
        Label6.Text = "Velden met * zijn verplicht."
        ' 
        ' btnAddProject
        ' 
        btnAddProject.Location = New Point(467, 326)
        btnAddProject.Margin = New Padding(3, 2, 3, 2)
        btnAddProject.Name = "btnAddProject"
        btnAddProject.Size = New Size(102, 36)
        btnAddProject.TabIndex = 6
        btnAddProject.Text = "Toevoegen"
        btnAddProject.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(14, 134)
        Label5.Name = "Label5"
        Label5.Size = New Size(55, 15)
        Label5.TabIndex = 10
        Label5.Text = "Project: *"
        ' 
        ' cmbProject
        ' 
        cmbProject.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbProject.FormattingEnabled = True
        cmbProject.Location = New Point(159, 131)
        cmbProject.Margin = New Padding(3, 2, 3, 2)
        cmbProject.Name = "cmbProject"
        cmbProject.Size = New Size(410, 23)
        cmbProject.TabIndex = 5
        ' 
        ' btnModelDir
        ' 
        btnModelDir.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnModelDir.Location = New Point(544, 104)
        btnModelDir.Margin = New Padding(3, 2, 3, 2)
        btnModelDir.Name = "btnModelDir"
        btnModelDir.Size = New Size(24, 22)
        btnModelDir.TabIndex = 8
        btnModelDir.Text = ".."
        btnModelDir.UseVisualStyleBackColor = True
        ' 
        ' txtModelDir
        ' 
        txtModelDir.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtModelDir.Location = New Point(159, 104)
        txtModelDir.Margin = New Padding(3, 2, 3, 2)
        txtModelDir.Name = "txtModelDir"
        txtModelDir.Size = New Size(380, 23)
        txtModelDir.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(14, 106)
        Label2.Name = "Label2"
        Label2.Size = New Size(76, 15)
        Label2.TabIndex = 2
        Label2.Text = "Modelmap: *"
        ' 
        ' txtProjectModelName
        ' 
        txtProjectModelName.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtProjectModelName.Location = New Point(159, 23)
        txtProjectModelName.Margin = New Padding(3, 2, 3, 2)
        txtProjectModelName.Name = "txtProjectModelName"
        txtProjectModelName.Size = New Size(410, 23)
        txtProjectModelName.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(13, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(124, 15)
        Label1.TabIndex = 0
        Label1.Text = "Naam projectmodel: *"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(grdProjectModels)
        GroupBox1.Location = New Point(10, 10)
        GroupBox1.Margin = New Padding(3, 2, 3, 2)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 2, 3, 2)
        GroupBox1.Size = New Size(507, 365)
        GroupBox1.TabIndex = 7
        GroupBox1.TabStop = False
        GroupBox1.Text = "Reeds in de database"
        ' 
        ' grdProjectModels
        ' 
        grdProjectModels.AllowUserToAddRows = False
        grdProjectModels.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        grdProjectModels.Columns.AddRange(New DataGridViewColumn() {colProjectModelName, colVersion, colProject})
        grdProjectModels.Location = New Point(15, 24)
        grdProjectModels.Margin = New Padding(3, 2, 3, 2)
        grdProjectModels.Name = "grdProjectModels"
        grdProjectModels.RowHeadersVisible = False
        grdProjectModels.RowHeadersWidth = 51
        grdProjectModels.RowTemplate.Height = 29
        grdProjectModels.Size = New Size(474, 332)
        grdProjectModels.TabIndex = 0
        ' 
        ' colProjectModelName
        ' 
        colProjectModelName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        colProjectModelName.HeaderText = "Projectmodel"
        colProjectModelName.MinimumWidth = 6
        colProjectModelName.Name = "colProjectModelName"
        ' 
        ' colVersion
        ' 
        colVersion.HeaderText = "Versie"
        colVersion.Name = "colVersion"
        ' 
        ' colProject
        ' 
        colProject.HeaderText = "Project"
        colProject.Name = "colProject"
        ' 
        ' frmAddProjectModel
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1107, 385)
        Controls.Add(GroupBox1)
        Controls.Add(grSeettings)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 2, 3, 2)
        Name = "frmAddProjectModel"
        Text = "Projectmodel toevoegen"
        grSeettings.ResumeLayout(False)
        grSeettings.PerformLayout()
        GroupBox1.ResumeLayout(False)
        CType(grdProjectModels, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents grSeettings As GroupBox
    Friend WithEvents btnAddProject As Button
    Friend WithEvents btnModelDir As Button
    Friend WithEvents txtModelDir As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtProjectModelName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbProject As ComboBox
    Friend WithEvents dlgFolder As FolderBrowserDialog
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents grdProjectModels As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbBasisModel As ComboBox
    Friend WithEvents cmbBasismodelVersie As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtVersion As TextBox
    Friend WithEvents colProjectModelName As DataGridViewTextBoxColumn
    Friend WithEvents colVersion As DataGridViewTextBoxColumn
    Friend WithEvents colProject As DataGridViewTextBoxColumn
End Class
