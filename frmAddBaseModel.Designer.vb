<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddBaseModel
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmAddBaseModel))
        GroupBox1 = New GroupBox()
        grdBasismodellen = New DataGridView()
        colBasismodel = New DataGridViewTextBoxColumn()
        colVersion = New DataGridViewTextBoxColumn()
        grSeettings = New GroupBox()
        txtCaseNaam = New TextBox()
        btnConfigFile = New Button()
        txtConfigFile = New TextBox()
        Label9 = New Label()
        btnModelFolder = New Button()
        cmbCaseName = New ComboBox()
        Label8 = New Label()
        Label7 = New Label()
        txtDescription = New TextBox()
        txtVersion = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        txtModelDir = New TextBox()
        btnAddBaseModel = New Button()
        cmbCatchment = New ComboBox()
        Label4 = New Label()
        btnModelProject = New Button()
        Label3 = New Label()
        cmbModellingSoftware = New ComboBox()
        Label2 = New Label()
        txtModelName = New TextBox()
        Label1 = New Label()
        dlgFolder = New FolderBrowserDialog()
        dlgOpenFile = New OpenFileDialog()
        GroupBox1.SuspendLayout()
        CType(grdBasismodellen, ComponentModel.ISupportInitialize).BeginInit()
        grSeettings.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(grdBasismodellen)
        GroupBox1.Location = New Point(10, 10)
        GroupBox1.Margin = New Padding(3, 2, 3, 2)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 2, 3, 2)
        GroupBox1.Size = New Size(507, 365)
        GroupBox1.TabIndex = 9
        GroupBox1.TabStop = False
        GroupBox1.Text = "Reeds in de database"
        ' 
        ' grdBasismodellen
        ' 
        grdBasismodellen.AllowUserToAddRows = False
        grdBasismodellen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        grdBasismodellen.Columns.AddRange(New DataGridViewColumn() {colBasismodel, colVersion})
        grdBasismodellen.Location = New Point(15, 24)
        grdBasismodellen.Margin = New Padding(3, 2, 3, 2)
        grdBasismodellen.Name = "grdBasismodellen"
        grdBasismodellen.RowHeadersVisible = False
        grdBasismodellen.RowHeadersWidth = 51
        grdBasismodellen.RowTemplate.Height = 29
        grdBasismodellen.Size = New Size(474, 332)
        grdBasismodellen.TabIndex = 0
        ' 
        ' colBasismodel
        ' 
        colBasismodel.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        colBasismodel.HeaderText = "Basismodel"
        colBasismodel.MinimumWidth = 6
        colBasismodel.Name = "colBasismodel"
        ' 
        ' colVersion
        ' 
        colVersion.HeaderText = "Versie"
        colVersion.Name = "colVersion"
        ' 
        ' grSeettings
        ' 
        grSeettings.Controls.Add(txtCaseNaam)
        grSeettings.Controls.Add(btnConfigFile)
        grSeettings.Controls.Add(txtConfigFile)
        grSeettings.Controls.Add(Label9)
        grSeettings.Controls.Add(btnModelFolder)
        grSeettings.Controls.Add(cmbCaseName)
        grSeettings.Controls.Add(Label8)
        grSeettings.Controls.Add(Label7)
        grSeettings.Controls.Add(txtDescription)
        grSeettings.Controls.Add(txtVersion)
        grSeettings.Controls.Add(Label5)
        grSeettings.Controls.Add(Label6)
        grSeettings.Controls.Add(txtModelDir)
        grSeettings.Controls.Add(btnAddBaseModel)
        grSeettings.Controls.Add(cmbCatchment)
        grSeettings.Controls.Add(Label4)
        grSeettings.Controls.Add(btnModelProject)
        grSeettings.Controls.Add(Label3)
        grSeettings.Controls.Add(cmbModellingSoftware)
        grSeettings.Controls.Add(Label2)
        grSeettings.Controls.Add(txtModelName)
        grSeettings.Controls.Add(Label1)
        grSeettings.Location = New Point(522, 9)
        grSeettings.Margin = New Padding(3, 2, 3, 2)
        grSeettings.Name = "grSeettings"
        grSeettings.Padding = New Padding(3, 2, 3, 2)
        grSeettings.Size = New Size(574, 367)
        grSeettings.TabIndex = 8
        grSeettings.TabStop = False
        grSeettings.Text = "Settings"
        ' 
        ' txtCaseNaam
        ' 
        txtCaseNaam.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtCaseNaam.Location = New Point(159, 158)
        txtCaseNaam.Margin = New Padding(3, 2, 3, 2)
        txtCaseNaam.Name = "txtCaseNaam"
        txtCaseNaam.Size = New Size(409, 23)
        txtCaseNaam.TabIndex = 23
        ' 
        ' btnConfigFile
        ' 
        btnConfigFile.Location = New Point(534, 102)
        btnConfigFile.Name = "btnConfigFile"
        btnConfigFile.Size = New Size(34, 24)
        btnConfigFile.TabIndex = 22
        btnConfigFile.Text = ".."
        btnConfigFile.UseVisualStyleBackColor = True
        ' 
        ' txtConfigFile
        ' 
        txtConfigFile.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtConfigFile.Location = New Point(159, 102)
        txtConfigFile.Margin = New Padding(3, 2, 3, 2)
        txtConfigFile.Name = "txtConfigFile"
        txtConfigFile.Size = New Size(369, 23)
        txtConfigFile.TabIndex = 21
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(14, 107)
        Label9.Name = "Label9"
        Label9.Size = New Size(70, 15)
        Label9.TabIndex = 20
        Label9.Text = "Configfile: *"
        ' 
        ' btnModelFolder
        ' 
        btnModelFolder.Location = New Point(534, 74)
        btnModelFolder.Name = "btnModelFolder"
        btnModelFolder.Size = New Size(34, 24)
        btnModelFolder.TabIndex = 19
        btnModelFolder.Text = ".."
        btnModelFolder.UseVisualStyleBackColor = True
        ' 
        ' cmbCaseName
        ' 
        cmbCaseName.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbCaseName.FormattingEnabled = True
        cmbCaseName.Location = New Point(159, 131)
        cmbCaseName.Margin = New Padding(3, 2, 3, 2)
        cmbCaseName.Name = "cmbCaseName"
        cmbCaseName.Size = New Size(409, 23)
        cmbCaseName.TabIndex = 18
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(13, 134)
        Label8.Name = "Label8"
        Label8.Size = New Size(65, 15)
        Label8.TabIndex = 17
        Label8.Text = "Casenaam:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(14, 249)
        Label7.Name = "Label7"
        Label7.Size = New Size(81, 15)
        Label7.TabIndex = 15
        Label7.Text = "Omschrijving:"
        ' 
        ' txtDescription
        ' 
        txtDescription.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtDescription.Location = New Point(159, 246)
        txtDescription.Margin = New Padding(3, 2, 3, 2)
        txtDescription.Multiline = True
        txtDescription.Name = "txtDescription"
        txtDescription.Size = New Size(409, 76)
        txtDescription.TabIndex = 14
        ' 
        ' txtVersion
        ' 
        txtVersion.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtVersion.Location = New Point(160, 215)
        txtVersion.Margin = New Padding(3, 2, 3, 2)
        txtVersion.Name = "txtVersion"
        txtVersion.Size = New Size(409, 23)
        txtVersion.TabIndex = 13
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(14, 218)
        Label5.Name = "Label5"
        Label5.Size = New Size(74, 15)
        Label5.TabIndex = 12
        Label5.Text = "Versie: (x.x) *"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(14, 342)
        Label6.Name = "Label6"
        Label6.Size = New Size(147, 15)
        Label6.TabIndex = 11
        Label6.Text = "Velden met * zijn verplicht."
        ' 
        ' txtModelDir
        ' 
        txtModelDir.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtModelDir.Location = New Point(159, 75)
        txtModelDir.Margin = New Padding(3, 2, 3, 2)
        txtModelDir.Name = "txtModelDir"
        txtModelDir.Size = New Size(369, 23)
        txtModelDir.TabIndex = 3
        ' 
        ' btnAddBaseModel
        ' 
        btnAddBaseModel.Location = New Point(467, 326)
        btnAddBaseModel.Margin = New Padding(3, 2, 3, 2)
        btnAddBaseModel.Name = "btnAddBaseModel"
        btnAddBaseModel.Size = New Size(102, 36)
        btnAddBaseModel.TabIndex = 6
        btnAddBaseModel.Text = "Toevoegen"
        btnAddBaseModel.UseVisualStyleBackColor = True
        ' 
        ' cmbCatchment
        ' 
        cmbCatchment.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbCatchment.FormattingEnabled = True
        cmbCatchment.Location = New Point(159, 188)
        cmbCatchment.Margin = New Padding(3, 2, 3, 2)
        cmbCatchment.Name = "cmbCatchment"
        cmbCatchment.Size = New Size(409, 23)
        cmbCatchment.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(14, 191)
        Label4.Name = "Label4"
        Label4.Size = New Size(93, 15)
        Label4.TabIndex = 7
        Label4.Text = "Stroomgebied: *"
        ' 
        ' btnModelProject
        ' 
        btnModelProject.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnModelProject.Location = New Point(918, 73)
        btnModelProject.Margin = New Padding(3, 2, 3, 2)
        btnModelProject.Name = "btnModelProject"
        btnModelProject.Size = New Size(24, 22)
        btnModelProject.TabIndex = 8
        btnModelProject.Text = ".."
        btnModelProject.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(13, 52)
        Label3.Name = "Label3"
        Label3.Size = New Size(116, 15)
        Label3.TabIndex = 5
        Label3.Text = "Modelleersoftware: *"
        ' 
        ' cmbModellingSoftware
        ' 
        cmbModellingSoftware.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbModellingSoftware.FormattingEnabled = True
        cmbModellingSoftware.Location = New Point(159, 49)
        cmbModellingSoftware.Margin = New Padding(3, 2, 3, 2)
        cmbModellingSoftware.Name = "cmbModellingSoftware"
        cmbModellingSoftware.Size = New Size(409, 23)
        cmbModellingSoftware.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(13, 78)
        Label2.Name = "Label2"
        Label2.Size = New Size(76, 15)
        Label2.TabIndex = 2
        Label2.Text = "Modelmap: *"
        ' 
        ' txtModelName
        ' 
        txtModelName.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtModelName.Location = New Point(159, 22)
        txtModelName.Margin = New Padding(3, 2, 3, 2)
        txtModelName.Name = "txtModelName"
        txtModelName.Size = New Size(409, 23)
        txtModelName.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(13, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(113, 15)
        Label1.TabIndex = 0
        Label1.Text = "Naam basismodel: *"
        ' 
        ' dlgOpenFile
        ' 
        dlgOpenFile.FileName = "OpenFileDialog1"
        ' 
        ' frmAddBaseModel
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1107, 385)
        Controls.Add(GroupBox1)
        Controls.Add(grSeettings)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmAddBaseModel"
        Text = "Basismodel toevoegen"
        GroupBox1.ResumeLayout(False)
        CType(grdBasismodellen, ComponentModel.ISupportInitialize).EndInit()
        grSeettings.ResumeLayout(False)
        grSeettings.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents grdBasismodellen As DataGridView
    Friend WithEvents grSeettings As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnAddBaseModel As Button
    Friend WithEvents cmbCatchment As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnModelProject As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbModellingSoftware As ComboBox
    Friend WithEvents txtModelDir As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtModelName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents txtVersion As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbCaseName As ComboBox
    Friend WithEvents colBasismodel As DataGridViewTextBoxColumn
    Friend WithEvents colVersion As DataGridViewTextBoxColumn
    Friend WithEvents btnModelFolder As Button
    Friend WithEvents dlgFolder As FolderBrowserDialog
    Friend WithEvents btnConfigFile As Button
    Friend WithEvents txtConfigFile As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents dlgOpenFile As OpenFileDialog
    Friend WithEvents txtCaseNaam As TextBox
End Class
