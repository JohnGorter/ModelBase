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
        CreateNewToolStripMenuItem = New ToolStripMenuItem()
        IngenieursbureausToolStripMenuItem = New ToolStripMenuItem()
        ToevoegenToolStripMenuItem8 = New ToolStripMenuItem()
        MedewerkersToolStripMenuItem = New ToolStripMenuItem()
        ToevoegenToolStripMenuItem1 = New ToolStripMenuItem()
        StroomgebiedenToolStripMenuItem = New ToolStripMenuItem()
        ToevoegenToolStripMenuItem2 = New ToolStripMenuItem()
        ModelleersoftwareToolStripMenuItem = New ToolStripMenuItem()
        ToevoegenToolStripMenuItem3 = New ToolStripMenuItem()
        SoftwareToolStripMenuItem = New ToolStripMenuItem()
        CombinatieVanModulesToolStripMenuItem = New ToolStripMenuItem()
        ProjectenToolStripMenuItem = New ToolStripMenuItem()
        ToevoegenToolStripMenuItem4 = New ToolStripMenuItem()
        ScenariosToolStripMenuItem = New ToolStripMenuItem()
        KlimaatscenariosToolStripMenuItem = New ToolStripMenuItem()
        ToevoegenToolStripMenuItem5 = New ToolStripMenuItem()
        OmgevingsscenariosToolStripMenuItem = New ToolStripMenuItem()
        ToevoegenToolStripMenuItem6 = New ToolStripMenuItem()
        ModellenToolStripMenuItem = New ToolStripMenuItem()
        ToevoegenToolStripMenuItem = New ToolStripMenuItem()
        BasisModelToolStripMenuItem = New ToolStripMenuItem()
        ProjectToolStripMenuItem = New ToolStripMenuItem()
        CaseToolStripMenuItem = New ToolStripMenuItem()
        VerwijderenToolStripMenuItem = New ToolStripMenuItem()
        OverToolStripMenuItem = New ToolStripMenuItem()
        SplitContainer1 = New SplitContainer()
        grdModelSchematizations = New DataGridView()
        colCaseNaam = New DataGridViewTextBoxColumn()
        colStroomgebied = New DataGridViewTextBoxColumn()
        colModelType = New DataGridViewTextBoxColumn()
        grFilters = New GroupBox()
        cmbModelleersoftware = New ComboBox()
        Label2 = New Label()
        Label1 = New Label()
        cmbStroomgebieden = New ComboBox()
        txtDatabase = New TextBox()
        lblProgress = New Label()
        prProgress = New ProgressBar()
        lblDatabase = New Label()
        SplitContainer2 = New SplitContainer()
        Map = New GMap.NET.WindowsForms.GMapControl()
        lblPad = New Label()
        lblPadlbl = New Label()
        dlgOpenFile = New OpenFileDialog()
        dlgSaveFile = New SaveFileDialog()
        MenuStrip1.SuspendLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        CType(grdModelSchematizations, ComponentModel.ISupportInitialize).BeginInit()
        grFilters.SuspendLayout()
        CType(SplitContainer2, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer2.Panel1.SuspendLayout()
        SplitContainer2.Panel2.SuspendLayout()
        SplitContainer2.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {DatabaseToolStripMenuItem, IngenieursbureausToolStripMenuItem, MedewerkersToolStripMenuItem, StroomgebiedenToolStripMenuItem, ModelleersoftwareToolStripMenuItem, ProjectenToolStripMenuItem, ScenariosToolStripMenuItem, ModellenToolStripMenuItem, OverToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(5, 2, 0, 2)
        MenuStrip1.Size = New Size(1219, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' DatabaseToolStripMenuItem
        ' 
        DatabaseToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {OpenToolStripMenuItem, ImportToolStripMenuItem, CreateNewToolStripMenuItem})
        DatabaseToolStripMenuItem.Name = "DatabaseToolStripMenuItem"
        DatabaseToolStripMenuItem.Size = New Size(67, 20)
        DatabaseToolStripMenuItem.Text = "Database"
        ' 
        ' OpenToolStripMenuItem
        ' 
        OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        OpenToolStripMenuItem.Size = New Size(127, 22)
        OpenToolStripMenuItem.Text = "Verbinden"
        ' 
        ' ImportToolStripMenuItem
        ' 
        ImportToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AccessToolStripMenuItem})
        ImportToolStripMenuItem.Name = "ImportToolStripMenuItem"
        ImportToolStripMenuItem.Size = New Size(127, 22)
        ImportToolStripMenuItem.Text = "Data"
        ' 
        ' AccessToolStripMenuItem
        ' 
        AccessToolStripMenuItem.Name = "AccessToolStripMenuItem"
        AccessToolStripMenuItem.Size = New Size(228, 22)
        AccessToolStripMenuItem.Text = "Importeren uit Access (.mdb)"
        ' 
        ' CreateNewToolStripMenuItem
        ' 
        CreateNewToolStripMenuItem.Name = "CreateNewToolStripMenuItem"
        CreateNewToolStripMenuItem.Size = New Size(127, 22)
        CreateNewToolStripMenuItem.Text = "Nieuw"
        ' 
        ' IngenieursbureausToolStripMenuItem
        ' 
        IngenieursbureausToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ToevoegenToolStripMenuItem8})
        IngenieursbureausToolStripMenuItem.Name = "IngenieursbureausToolStripMenuItem"
        IngenieursbureausToolStripMenuItem.Size = New Size(116, 20)
        IngenieursbureausToolStripMenuItem.Text = "Ingenieursbureaus"
        ' 
        ' ToevoegenToolStripMenuItem8
        ' 
        ToevoegenToolStripMenuItem8.Name = "ToevoegenToolStripMenuItem8"
        ToevoegenToolStripMenuItem8.Size = New Size(131, 22)
        ToevoegenToolStripMenuItem8.Text = "Toevoegen"
        ' 
        ' MedewerkersToolStripMenuItem
        ' 
        MedewerkersToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ToevoegenToolStripMenuItem1})
        MedewerkersToolStripMenuItem.Name = "MedewerkersToolStripMenuItem"
        MedewerkersToolStripMenuItem.Size = New Size(89, 20)
        MedewerkersToolStripMenuItem.Text = "Medewerkers"
        ' 
        ' ToevoegenToolStripMenuItem1
        ' 
        ToevoegenToolStripMenuItem1.Name = "ToevoegenToolStripMenuItem1"
        ToevoegenToolStripMenuItem1.Size = New Size(131, 22)
        ToevoegenToolStripMenuItem1.Text = "Toevoegen"
        ' 
        ' StroomgebiedenToolStripMenuItem
        ' 
        StroomgebiedenToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ToevoegenToolStripMenuItem2})
        StroomgebiedenToolStripMenuItem.Name = "StroomgebiedenToolStripMenuItem"
        StroomgebiedenToolStripMenuItem.Size = New Size(107, 20)
        StroomgebiedenToolStripMenuItem.Text = "Stroomgebieden"
        ' 
        ' ToevoegenToolStripMenuItem2
        ' 
        ToevoegenToolStripMenuItem2.Name = "ToevoegenToolStripMenuItem2"
        ToevoegenToolStripMenuItem2.Size = New Size(131, 22)
        ToevoegenToolStripMenuItem2.Text = "Toevoegen"
        ' 
        ' ModelleersoftwareToolStripMenuItem
        ' 
        ModelleersoftwareToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ToevoegenToolStripMenuItem3})
        ModelleersoftwareToolStripMenuItem.Name = "ModelleersoftwareToolStripMenuItem"
        ModelleersoftwareToolStripMenuItem.Size = New Size(117, 20)
        ModelleersoftwareToolStripMenuItem.Text = "Modelleersoftware"
        ' 
        ' ToevoegenToolStripMenuItem3
        ' 
        ToevoegenToolStripMenuItem3.DropDownItems.AddRange(New ToolStripItem() {SoftwareToolStripMenuItem, CombinatieVanModulesToolStripMenuItem})
        ToevoegenToolStripMenuItem3.Name = "ToevoegenToolStripMenuItem3"
        ToevoegenToolStripMenuItem3.Size = New Size(131, 22)
        ToevoegenToolStripMenuItem3.Text = "Toevoegen"
        ' 
        ' SoftwareToolStripMenuItem
        ' 
        SoftwareToolStripMenuItem.Name = "SoftwareToolStripMenuItem"
        SoftwareToolStripMenuItem.Size = New Size(207, 22)
        SoftwareToolStripMenuItem.Text = "Software"
        ' 
        ' CombinatieVanModulesToolStripMenuItem
        ' 
        CombinatieVanModulesToolStripMenuItem.Name = "CombinatieVanModulesToolStripMenuItem"
        CombinatieVanModulesToolStripMenuItem.Size = New Size(207, 22)
        CombinatieVanModulesToolStripMenuItem.Text = "Combinatie van modules"
        ' 
        ' ProjectenToolStripMenuItem
        ' 
        ProjectenToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ToevoegenToolStripMenuItem4})
        ProjectenToolStripMenuItem.Name = "ProjectenToolStripMenuItem"
        ProjectenToolStripMenuItem.Size = New Size(69, 20)
        ProjectenToolStripMenuItem.Text = "Projecten"
        ' 
        ' ToevoegenToolStripMenuItem4
        ' 
        ToevoegenToolStripMenuItem4.Name = "ToevoegenToolStripMenuItem4"
        ToevoegenToolStripMenuItem4.Size = New Size(131, 22)
        ToevoegenToolStripMenuItem4.Text = "Toevoegen"
        ' 
        ' ScenariosToolStripMenuItem
        ' 
        ScenariosToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {KlimaatscenariosToolStripMenuItem, OmgevingsscenariosToolStripMenuItem})
        ScenariosToolStripMenuItem.Name = "ScenariosToolStripMenuItem"
        ScenariosToolStripMenuItem.Size = New Size(140, 20)
        ScenariosToolStripMenuItem.Text = "Scenario's en Varianten"
        ' 
        ' KlimaatscenariosToolStripMenuItem
        ' 
        KlimaatscenariosToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ToevoegenToolStripMenuItem5})
        KlimaatscenariosToolStripMenuItem.Name = "KlimaatscenariosToolStripMenuItem"
        KlimaatscenariosToolStripMenuItem.Size = New Size(187, 22)
        KlimaatscenariosToolStripMenuItem.Text = "Klimaatscenario's"
        ' 
        ' ToevoegenToolStripMenuItem5
        ' 
        ToevoegenToolStripMenuItem5.Name = "ToevoegenToolStripMenuItem5"
        ToevoegenToolStripMenuItem5.Size = New Size(131, 22)
        ToevoegenToolStripMenuItem5.Text = "Toevoegen"
        ' 
        ' OmgevingsscenariosToolStripMenuItem
        ' 
        OmgevingsscenariosToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ToevoegenToolStripMenuItem6})
        OmgevingsscenariosToolStripMenuItem.Name = "OmgevingsscenariosToolStripMenuItem"
        OmgevingsscenariosToolStripMenuItem.Size = New Size(187, 22)
        OmgevingsscenariosToolStripMenuItem.Text = "Omgevingsscenario's"
        ' 
        ' ToevoegenToolStripMenuItem6
        ' 
        ToevoegenToolStripMenuItem6.Name = "ToevoegenToolStripMenuItem6"
        ToevoegenToolStripMenuItem6.Size = New Size(131, 22)
        ToevoegenToolStripMenuItem6.Text = "Toevoegen"
        ' 
        ' ModellenToolStripMenuItem
        ' 
        ModellenToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ToevoegenToolStripMenuItem, VerwijderenToolStripMenuItem})
        ModellenToolStripMenuItem.Name = "ModellenToolStripMenuItem"
        ModellenToolStripMenuItem.Size = New Size(69, 20)
        ModellenToolStripMenuItem.Text = "Modellen"
        ' 
        ' ToevoegenToolStripMenuItem
        ' 
        ToevoegenToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {BasisModelToolStripMenuItem, ProjectToolStripMenuItem, CaseToolStripMenuItem})
        ToevoegenToolStripMenuItem.Name = "ToevoegenToolStripMenuItem"
        ToevoegenToolStripMenuItem.Size = New Size(180, 22)
        ToevoegenToolStripMenuItem.Text = "Toevoegen"
        ' 
        ' BasisModelToolStripMenuItem
        ' 
        BasisModelToolStripMenuItem.Name = "BasisModelToolStripMenuItem"
        BasisModelToolStripMenuItem.Size = New Size(180, 22)
        BasisModelToolStripMenuItem.Text = "BasisModel"
        ' 
        ' ProjectToolStripMenuItem
        ' 
        ProjectToolStripMenuItem.Name = "ProjectToolStripMenuItem"
        ProjectToolStripMenuItem.Size = New Size(180, 22)
        ProjectToolStripMenuItem.Text = "ProjectModel"
        ' 
        ' CaseToolStripMenuItem
        ' 
        CaseToolStripMenuItem.Name = "CaseToolStripMenuItem"
        CaseToolStripMenuItem.Size = New Size(180, 22)
        CaseToolStripMenuItem.Text = "ModelCase"
        ' 
        ' VerwijderenToolStripMenuItem
        ' 
        VerwijderenToolStripMenuItem.Name = "VerwijderenToolStripMenuItem"
        VerwijderenToolStripMenuItem.Size = New Size(180, 22)
        VerwijderenToolStripMenuItem.Text = "Verwijderen"
        ' 
        ' OverToolStripMenuItem
        ' 
        OverToolStripMenuItem.Name = "OverToolStripMenuItem"
        OverToolStripMenuItem.Size = New Size(44, 20)
        OverToolStripMenuItem.Text = "Over"
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Dock = DockStyle.Fill
        SplitContainer1.Location = New Point(0, 24)
        SplitContainer1.Margin = New Padding(3, 2, 3, 2)
        SplitContainer1.Name = "SplitContainer1"
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.Controls.Add(grdModelSchematizations)
        SplitContainer1.Panel1.Controls.Add(grFilters)
        SplitContainer1.Panel1.Controls.Add(txtDatabase)
        SplitContainer1.Panel1.Controls.Add(lblProgress)
        SplitContainer1.Panel1.Controls.Add(prProgress)
        SplitContainer1.Panel1.Controls.Add(lblDatabase)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.Controls.Add(SplitContainer2)
        SplitContainer1.Size = New Size(1219, 423)
        SplitContainer1.SplitterDistance = 468
        SplitContainer1.TabIndex = 1
        ' 
        ' grdModelSchematizations
        ' 
        grdModelSchematizations.AllowUserToAddRows = False
        grdModelSchematizations.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        grdModelSchematizations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        grdModelSchematizations.Columns.AddRange(New DataGridViewColumn() {colCaseNaam, colStroomgebied, colModelType})
        grdModelSchematizations.Location = New Point(19, 214)
        grdModelSchematizations.Margin = New Padding(3, 2, 3, 2)
        grdModelSchematizations.Name = "grdModelSchematizations"
        grdModelSchematizations.RowHeadersVisible = False
        grdModelSchematizations.RowHeadersWidth = 51
        grdModelSchematizations.RowTemplate.Height = 29
        grdModelSchematizations.Size = New Size(437, 141)
        grdModelSchematizations.TabIndex = 5
        ' 
        ' colCaseNaam
        ' 
        colCaseNaam.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        colCaseNaam.HeaderText = "Casenaam"
        colCaseNaam.MinimumWidth = 6
        colCaseNaam.Name = "colCaseNaam"
        ' 
        ' colStroomgebied
        ' 
        colStroomgebied.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        colStroomgebied.HeaderText = "Stroomgebied"
        colStroomgebied.MinimumWidth = 6
        colStroomgebied.Name = "colStroomgebied"
        ' 
        ' colModelType
        ' 
        colModelType.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        colModelType.HeaderText = "Modeltype"
        colModelType.MinimumWidth = 6
        colModelType.Name = "colModelType"
        ' 
        ' grFilters
        ' 
        grFilters.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        grFilters.Controls.Add(cmbModelleersoftware)
        grFilters.Controls.Add(Label2)
        grFilters.Controls.Add(Label1)
        grFilters.Controls.Add(cmbStroomgebieden)
        grFilters.Location = New Point(19, 48)
        grFilters.Margin = New Padding(3, 2, 3, 2)
        grFilters.Name = "grFilters"
        grFilters.Padding = New Padding(3, 2, 3, 2)
        grFilters.Size = New Size(437, 153)
        grFilters.TabIndex = 4
        grFilters.TabStop = False
        grFilters.Text = "Filters"
        ' 
        ' cmbModelleersoftware
        ' 
        cmbModelleersoftware.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbModelleersoftware.FormattingEnabled = True
        cmbModelleersoftware.Location = New Point(152, 49)
        cmbModelleersoftware.Margin = New Padding(3, 2, 3, 2)
        cmbModelleersoftware.Name = "cmbModelleersoftware"
        cmbModelleersoftware.Size = New Size(269, 23)
        cmbModelleersoftware.TabIndex = 7
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(30, 51)
        Label2.Name = "Label2"
        Label2.Size = New Size(105, 15)
        Label2.TabIndex = 6
        Label2.Text = "Modelleersoftware"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(30, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(82, 15)
        Label1.TabIndex = 5
        Label1.Text = "Stroomgebied"
        ' 
        ' cmbStroomgebieden
        ' 
        cmbStroomgebieden.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbStroomgebieden.FormattingEnabled = True
        cmbStroomgebieden.Location = New Point(152, 23)
        cmbStroomgebieden.Margin = New Padding(3, 2, 3, 2)
        cmbStroomgebieden.Name = "cmbStroomgebieden"
        cmbStroomgebieden.Size = New Size(269, 23)
        cmbStroomgebieden.TabIndex = 0
        ' 
        ' txtDatabase
        ' 
        txtDatabase.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtDatabase.Location = New Point(103, 11)
        txtDatabase.Margin = New Padding(3, 2, 3, 2)
        txtDatabase.Name = "txtDatabase"
        txtDatabase.Size = New Size(353, 23)
        txtDatabase.TabIndex = 3
        ' 
        ' lblProgress
        ' 
        lblProgress.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        lblProgress.AutoSize = True
        lblProgress.Location = New Point(19, 368)
        lblProgress.Name = "lblProgress"
        lblProgress.Size = New Size(71, 15)
        lblProgress.TabIndex = 2
        lblProgress.Text = "Voortgang..."
        ' 
        ' prProgress
        ' 
        prProgress.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        prProgress.Location = New Point(19, 392)
        prProgress.Margin = New Padding(3, 2, 3, 2)
        prProgress.Name = "prProgress"
        prProgress.Size = New Size(437, 22)
        prProgress.TabIndex = 1
        ' 
        ' lblDatabase
        ' 
        lblDatabase.AutoSize = True
        lblDatabase.Location = New Point(19, 14)
        lblDatabase.Name = "lblDatabase"
        lblDatabase.Size = New Size(55, 15)
        lblDatabase.TabIndex = 0
        lblDatabase.Text = "Database"
        ' 
        ' SplitContainer2
        ' 
        SplitContainer2.Dock = DockStyle.Fill
        SplitContainer2.Location = New Point(0, 0)
        SplitContainer2.Margin = New Padding(3, 2, 3, 2)
        SplitContainer2.Name = "SplitContainer2"
        SplitContainer2.Orientation = Orientation.Horizontal
        ' 
        ' SplitContainer2.Panel1
        ' 
        SplitContainer2.Panel1.Controls.Add(Map)
        ' 
        ' SplitContainer2.Panel2
        ' 
        SplitContainer2.Panel2.Controls.Add(lblPad)
        SplitContainer2.Panel2.Controls.Add(lblPadlbl)
        SplitContainer2.Size = New Size(747, 423)
        SplitContainer2.SplitterDistance = 303
        SplitContainer2.SplitterWidth = 3
        SplitContainer2.TabIndex = 0
        ' 
        ' Map
        ' 
        Map.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Map.Bearing = 0F
        Map.CanDragMap = True
        Map.EmptyTileColor = Color.Navy
        Map.GrayScaleMode = False
        Map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow
        Map.LevelsKeepInMemory = 5
        Map.Location = New Point(0, 0)
        Map.Margin = New Padding(3, 2, 3, 2)
        Map.MarkersEnabled = True
        Map.MaxZoom = 15
        Map.MinZoom = 2
        Map.MouseWheelZoomEnabled = True
        Map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter
        Map.Name = "Map"
        Map.NegativeMode = False
        Map.PolygonsEnabled = True
        Map.RetryLoadTile = 0
        Map.RoutesEnabled = True
        Map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer
        Map.SelectedAreaFillColor = Color.FromArgb(CByte(33), CByte(65), CByte(105), CByte(225))
        Map.ShowTileGridLines = False
        Map.Size = New Size(747, 301)
        Map.TabIndex = 0
        Map.Zoom = 0R
        ' 
        ' lblPad
        ' 
        lblPad.AutoSize = True
        lblPad.Location = New Point(85, 14)
        lblPad.Name = "lblPad"
        lblPad.Size = New Size(13, 15)
        lblPad.TabIndex = 8
        lblPad.Text = ".."
        ' 
        ' lblPadlbl
        ' 
        lblPadlbl.AutoSize = True
        lblPadlbl.Location = New Point(22, 14)
        lblPadlbl.Name = "lblPadlbl"
        lblPadlbl.Size = New Size(30, 15)
        lblPadlbl.TabIndex = 0
        lblPadlbl.Text = "Pad:"
        ' 
        ' frmModelBase
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1219, 447)
        Controls.Add(SplitContainer1)
        Controls.Add(MenuStrip1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        Margin = New Padding(3, 2, 3, 2)
        Name = "frmModelBase"
        Text = "De Modellenbeheerder"
        WindowState = FormWindowState.Maximized
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel1.PerformLayout()
        SplitContainer1.Panel2.ResumeLayout(False)
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        CType(grdModelSchematizations, ComponentModel.ISupportInitialize).EndInit()
        grFilters.ResumeLayout(False)
        grFilters.PerformLayout()
        SplitContainer2.Panel1.ResumeLayout(False)
        SplitContainer2.Panel2.ResumeLayout(False)
        SplitContainer2.Panel2.PerformLayout()
        CType(SplitContainer2, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer2.ResumeLayout(False)
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
    Friend WithEvents CreateNewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblDatabase As Label
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents dlgSaveFile As SaveFileDialog
    Friend WithEvents prProgress As ProgressBar
    Friend WithEvents ModellenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToevoegenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerwijderenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblProgress As Label
    Friend WithEvents txtDatabase As TextBox
    Friend WithEvents grFilters As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbStroomgebieden As ComboBox
    Friend WithEvents cmbModelleersoftware As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents grdModelSchematizations As DataGridView
    Friend WithEvents lblPad As Label
    Friend WithEvents lblPadlbl As Label
    Friend WithEvents ProjectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MedewerkersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToevoegenToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents StroomgebiedenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToevoegenToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ModelleersoftwareToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToevoegenToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents SoftwareToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CombinatieVanModulesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProjectenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToevoegenToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents colCaseNaam As DataGridViewTextBoxColumn
    Friend WithEvents colStroomgebied As DataGridViewTextBoxColumn
    Friend WithEvents colModelType As DataGridViewTextBoxColumn
    Friend WithEvents Map As GMap.NET.WindowsForms.GMapControl
    Friend WithEvents ScenariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KlimaatscenariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToevoegenToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents OmgevingsscenariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToevoegenToolStripMenuItem6 As ToolStripMenuItem
    Friend WithEvents OverToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IngenieursbureausToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToevoegenToolStripMenuItem8 As ToolStripMenuItem
    Friend WithEvents cmbProject As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BasisModelToolStripMenuItem As ToolStripMenuItem
End Class
