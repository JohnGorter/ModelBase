<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddModelschematization
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmAddModelschematization))
        btnAdd = New Button()
        GroupBox1 = New GroupBox()
        grdModelschematizations = New DataGridView()
        pckCreateDate = New DateTimePicker()
        Label14 = New Label()
        Label4 = New Label()
        Label13 = New Label()
        cmbModules = New ComboBox()
        cmbClimateScenario = New ComboBox()
        Label12 = New Label()
        cmbEmployee = New ComboBox()
        Label10 = New Label()
        btnConfigurationFile = New Button()
        Label3 = New Label()
        txtCaseName = New TextBox()
        GroupBox2 = New GroupBox()
        Button3 = New Button()
        btnModelDir = New Button()
        txtModelDir = New TextBox()
        Button1 = New Button()
        txtConfigurationFile = New TextBox()
        Label6 = New Label()
        cmbModelCase = New ComboBox()
        txtSimulationPeriod = New TextBox()
        Label1 = New Label()
        cmbEnvironmentalScenario = New ComboBox()
        Label2 = New Label()
        Label11 = New Label()
        txtDesignScenario = New TextBox()
        Label7 = New Label()
        txtDescription = New TextBox()
        cmbConsultant = New ComboBox()
        Label16 = New Label()
        dlgOpenFile = New OpenFileDialog()
        GroupBox3 = New GroupBox()
        txtScriptDir = New TextBox()
        Label26 = New Label()
        Label5 = New Label()
        cmbModelbuildscript = New ComboBox()
        cmbPrecipitation = New ComboBox()
        cmbSeepage = New ComboBox()
        cmbLanduseData = New ComboBox()
        cmbSoilData = New ComboBox()
        Label18 = New Label()
        cmbElevationData = New ComboBox()
        Label17 = New Label()
        Label8 = New Label()
        Label15 = New Label()
        Label9 = New Label()
        GroupBox4 = New GroupBox()
        GroupBox5 = New GroupBox()
        Label25 = New Label()
        cmbSoftware = New ComboBox()
        Label24 = New Label()
        txtVersion = New TextBox()
        cmbCatchment = New ComboBox()
        Label23 = New Label()
        cmbProjecten = New ComboBox()
        Label22 = New Label()
        Label21 = New Label()
        cmbBasemodel = New ComboBox()
        chkIsBaseModel = New CheckBox()
        txtReturnPeriod = New TextBox()
        Label20 = New Label()
        Label19 = New Label()
        cmbApplication = New ComboBox()
        GroupBox6 = New GroupBox()
        dlgFolder = New FolderBrowserDialog()
        colModelCaseName = New DataGridViewTextBoxColumn()
        colVersion = New DataGridViewTextBoxColumn()
        colModules = New DataGridViewTextBoxColumn()
        GroupBox1.SuspendLayout()
        CType(grdModelschematizations, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        GroupBox5.SuspendLayout()
        GroupBox6.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(11, 27)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(117, 59)
        btnAdd.TabIndex = 0
        btnAdd.Text = "Toevoegen"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(grdModelschematizations)
        GroupBox1.Location = New Point(11, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(645, 790)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Reeds in de database"
        ' 
        ' grdModelschematizations
        ' 
        grdModelschematizations.AllowUserToAddRows = False
        grdModelschematizations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        grdModelschematizations.Columns.AddRange(New DataGridViewColumn() {colModelCaseName, colVersion, colModules})
        grdModelschematizations.Location = New Point(21, 29)
        grdModelschematizations.Name = "grdModelschematizations"
        grdModelschematizations.RowHeadersVisible = False
        grdModelschematizations.RowHeadersWidth = 51
        grdModelschematizations.RowTemplate.Height = 29
        grdModelschematizations.Size = New Size(610, 746)
        grdModelschematizations.TabIndex = 5
        ' 
        ' pckCreateDate
        ' 
        pckCreateDate.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pckCreateDate.Location = New Point(199, 176)
        pckCreateDate.Name = "pckCreateDate"
        pckCreateDate.Size = New Size(236, 27)
        pckCreateDate.TabIndex = 28
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(23, 181)
        Label14.Name = "Label14"
        Label14.Size = New Size(117, 20)
        Label14.TabIndex = 27
        Label14.Text = "Aanmaakdatum:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(14, 33)
        Label4.Name = "Label4"
        Label4.Size = New Size(114, 20)
        Label4.TabIndex = 23
        Label4.Text = "Modeldirectory:"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(19, 181)
        Label13.Name = "Label13"
        Label13.Size = New Size(79, 20)
        Label13.TabIndex = 22
        Label13.Text = "Modules: *"
        ' 
        ' cmbModules
        ' 
        cmbModules.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbModules.FormattingEnabled = True
        cmbModules.Location = New Point(197, 176)
        cmbModules.Name = "cmbModules"
        cmbModules.Size = New Size(240, 28)
        cmbModules.TabIndex = 21
        ' 
        ' cmbClimateScenario
        ' 
        cmbClimateScenario.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbClimateScenario.FormattingEnabled = True
        cmbClimateScenario.Location = New Point(198, 279)
        cmbClimateScenario.Name = "cmbClimateScenario"
        cmbClimateScenario.Size = New Size(240, 28)
        cmbClimateScenario.TabIndex = 20
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(19, 282)
        Label12.Name = "Label12"
        Label12.Size = New Size(118, 20)
        Label12.TabIndex = 19
        Label12.Text = "Klimaatscenario:"
        ' 
        ' cmbEmployee
        ' 
        cmbEmployee.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbEmployee.FormattingEnabled = True
        cmbEmployee.Location = New Point(199, 70)
        cmbEmployee.Name = "cmbEmployee"
        cmbEmployee.Size = New Size(237, 28)
        cmbEmployee.TabIndex = 18
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(23, 72)
        Label10.Name = "Label10"
        Label10.Size = New Size(94, 20)
        Label10.TabIndex = 17
        Label10.Text = "Medewerker:"
        ' 
        ' btnConfigurationFile
        ' 
        btnConfigurationFile.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnConfigurationFile.Location = New Point(836, 67)
        btnConfigurationFile.Name = "btnConfigurationFile"
        btnConfigurationFile.Size = New Size(26, 27)
        btnConfigurationFile.TabIndex = 16
        btnConfigurationFile.Text = ".."
        btnConfigurationFile.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(14, 107)
        Label3.Name = "Label3"
        Label3.Size = New Size(90, 20)
        Label3.TabIndex = 5
        Label3.Text = "Casenaam: *"
        ' 
        ' txtCaseName
        ' 
        txtCaseName.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtCaseName.Location = New Point(197, 103)
        txtCaseName.Name = "txtCaseName"
        txtCaseName.Size = New Size(697, 27)
        txtCaseName.TabIndex = 6
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Button3)
        GroupBox2.Controls.Add(btnModelDir)
        GroupBox2.Controls.Add(txtModelDir)
        GroupBox2.Controls.Add(Button1)
        GroupBox2.Controls.Add(btnConfigurationFile)
        GroupBox2.Controls.Add(txtConfigurationFile)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(cmbModelCase)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(txtCaseName)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Location = New Point(662, 12)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(908, 151)
        GroupBox2.TabIndex = 2
        GroupBox2.TabStop = False
        GroupBox2.Text = "Modelcase toevoegen"
        ' 
        ' Button3
        ' 
        Button3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button3.BackColor = Color.Gold
        Button3.Location = New Point(867, 29)
        Button3.Name = "Button3"
        Button3.Size = New Size(26, 27)
        Button3.TabIndex = 32
        Button3.Text = "?"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' btnModelDir
        ' 
        btnModelDir.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnModelDir.Location = New Point(836, 29)
        btnModelDir.Name = "btnModelDir"
        btnModelDir.Size = New Size(26, 27)
        btnModelDir.TabIndex = 31
        btnModelDir.Text = ".."
        btnModelDir.UseVisualStyleBackColor = True
        ' 
        ' txtModelDir
        ' 
        txtModelDir.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtModelDir.Location = New Point(197, 29)
        txtModelDir.Name = "txtModelDir"
        txtModelDir.Size = New Size(633, 27)
        txtModelDir.TabIndex = 30
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button1.BackColor = Color.Gold
        Button1.Location = New Point(868, 66)
        Button1.Name = "Button1"
        Button1.Size = New Size(26, 27)
        Button1.TabIndex = 29
        Button1.Text = "?"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' txtConfigurationFile
        ' 
        txtConfigurationFile.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtConfigurationFile.Location = New Point(197, 67)
        txtConfigurationFile.Name = "txtConfigurationFile"
        txtConfigurationFile.Size = New Size(633, 27)
        txtConfigurationFile.TabIndex = 12
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(14, 69)
        Label6.Name = "Label6"
        Label6.Size = New Size(157, 20)
        Label6.TabIndex = 11
        Label6.Text = "Configuratiebestand: *"
        ' 
        ' cmbModelCase
        ' 
        cmbModelCase.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbModelCase.FormattingEnabled = True
        cmbModelCase.Location = New Point(196, 104)
        cmbModelCase.Name = "cmbModelCase"
        cmbModelCase.Size = New Size(697, 28)
        cmbModelCase.TabIndex = 28
        ' 
        ' txtSimulationPeriod
        ' 
        txtSimulationPeriod.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtSimulationPeriod.Location = New Point(198, 380)
        txtSimulationPeriod.Name = "txtSimulationPeriod"
        txtSimulationPeriod.Size = New Size(241, 27)
        txtSimulationPeriod.TabIndex = 32
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(20, 383)
        Label1.Name = "Label1"
        Label1.Size = New Size(126, 20)
        Label1.TabIndex = 31
        Label1.Text = "Simulatieperiode:"
        ' 
        ' cmbEnvironmentalScenario
        ' 
        cmbEnvironmentalScenario.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbEnvironmentalScenario.FormattingEnabled = True
        cmbEnvironmentalScenario.Location = New Point(198, 313)
        cmbEnvironmentalScenario.Name = "cmbEnvironmentalScenario"
        cmbEnvironmentalScenario.Size = New Size(241, 28)
        cmbEnvironmentalScenario.TabIndex = 23
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(21, 316)
        Label2.Name = "Label2"
        Label2.Size = New Size(142, 20)
        Label2.TabIndex = 17
        Label2.Text = "Omgevingsscenario:"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(21, 350)
        Label11.Name = "Label11"
        Label11.Size = New Size(114, 20)
        Label11.TabIndex = 16
        Label11.Text = "Ontwerpvariant:"
        ' 
        ' txtDesignScenario
        ' 
        txtDesignScenario.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtDesignScenario.Location = New Point(198, 347)
        txtDesignScenario.Name = "txtDesignScenario"
        txtDesignScenario.Size = New Size(241, 27)
        txtDesignScenario.TabIndex = 15
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(6, 471)
        Label7.Name = "Label7"
        Label7.Size = New Size(185, 20)
        Label7.TabIndex = 30
        Label7.Text = "Velden met * zijn verplicht."
        ' 
        ' txtDescription
        ' 
        txtDescription.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtDescription.Location = New Point(20, 27)
        txtDescription.Multiline = True
        txtDescription.Name = "txtDescription"
        txtDescription.Size = New Size(710, 79)
        txtDescription.TabIndex = 25
        ' 
        ' cmbConsultant
        ' 
        cmbConsultant.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbConsultant.FormattingEnabled = True
        cmbConsultant.Location = New Point(199, 36)
        cmbConsultant.Name = "cmbConsultant"
        cmbConsultant.Size = New Size(237, 28)
        cmbConsultant.TabIndex = 21
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(23, 39)
        Label16.Name = "Label16"
        Label16.Size = New Size(126, 20)
        Label16.TabIndex = 33
        Label16.Text = "Ingenieursbureau:"
        ' 
        ' dlgOpenFile
        ' 
        dlgOpenFile.FileName = "OpenFileDialog1"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        GroupBox3.Controls.Add(txtScriptDir)
        GroupBox3.Controls.Add(Label26)
        GroupBox3.Controls.Add(Label5)
        GroupBox3.Controls.Add(cmbModelbuildscript)
        GroupBox3.Controls.Add(cmbConsultant)
        GroupBox3.Controls.Add(Label16)
        GroupBox3.Controls.Add(cmbPrecipitation)
        GroupBox3.Controls.Add(cmbEmployee)
        GroupBox3.Controls.Add(cmbSeepage)
        GroupBox3.Controls.Add(Label10)
        GroupBox3.Controls.Add(cmbLanduseData)
        GroupBox3.Controls.Add(pckCreateDate)
        GroupBox3.Controls.Add(cmbSoilData)
        GroupBox3.Controls.Add(Label14)
        GroupBox3.Controls.Add(Label18)
        GroupBox3.Controls.Add(cmbElevationData)
        GroupBox3.Controls.Add(Label17)
        GroupBox3.Controls.Add(Label8)
        GroupBox3.Controls.Add(Label15)
        GroupBox3.Controls.Add(Label9)
        GroupBox3.Location = New Point(1120, 169)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(450, 506)
        GroupBox3.TabIndex = 3
        GroupBox3.TabStop = False
        GroupBox3.Text = "Modelbouw"
        ' 
        ' txtScriptDir
        ' 
        txtScriptDir.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtScriptDir.Location = New Point(200, 139)
        txtScriptDir.Name = "txtScriptDir"
        txtScriptDir.Size = New Size(235, 27)
        txtScriptDir.TabIndex = 58
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.Location = New Point(23, 146)
        Label26.Name = "Label26"
        Label26.Size = New Size(100, 20)
        Label26.TabIndex = 43
        Label26.Text = "Locatie script:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(21, 107)
        Label5.Name = "Label5"
        Label5.Size = New Size(128, 20)
        Label5.TabIndex = 35
        Label5.Text = "Modelbouwscript:"
        ' 
        ' cmbModelbuildscript
        ' 
        cmbModelbuildscript.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbModelbuildscript.FormattingEnabled = True
        cmbModelbuildscript.Location = New Point(199, 104)
        cmbModelbuildscript.Name = "cmbModelbuildscript"
        cmbModelbuildscript.Size = New Size(236, 28)
        cmbModelbuildscript.TabIndex = 34
        ' 
        ' cmbPrecipitation
        ' 
        cmbPrecipitation.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbPrecipitation.FormattingEnabled = True
        cmbPrecipitation.Location = New Point(201, 345)
        cmbPrecipitation.Name = "cmbPrecipitation"
        cmbPrecipitation.Size = New Size(235, 28)
        cmbPrecipitation.TabIndex = 42
        ' 
        ' cmbSeepage
        ' 
        cmbSeepage.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbSeepage.FormattingEnabled = True
        cmbSeepage.Location = New Point(200, 311)
        cmbSeepage.Name = "cmbSeepage"
        cmbSeepage.Size = New Size(235, 28)
        cmbSeepage.TabIndex = 41
        ' 
        ' cmbLanduseData
        ' 
        cmbLanduseData.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbLanduseData.FormattingEnabled = True
        cmbLanduseData.Location = New Point(200, 277)
        cmbLanduseData.Name = "cmbLanduseData"
        cmbLanduseData.Size = New Size(236, 28)
        cmbLanduseData.TabIndex = 40
        ' 
        ' cmbSoilData
        ' 
        cmbSoilData.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbSoilData.FormattingEnabled = True
        cmbSoilData.Location = New Point(199, 243)
        cmbSoilData.Name = "cmbSoilData"
        cmbSoilData.Size = New Size(235, 28)
        cmbSoilData.TabIndex = 39
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Location = New Point(22, 348)
        Label18.Name = "Label18"
        Label18.Size = New Size(136, 20)
        Label18.TabIndex = 38
        Label18.Text = "Herkomst neerslag:"
        ' 
        ' cmbElevationData
        ' 
        cmbElevationData.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbElevationData.FormattingEnabled = True
        cmbElevationData.Location = New Point(200, 209)
        cmbElevationData.Name = "cmbElevationData"
        cmbElevationData.Size = New Size(235, 28)
        cmbElevationData.TabIndex = 34
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Location = New Point(23, 314)
        Label17.Name = "Label17"
        Label17.Size = New Size(110, 20)
        Label17.TabIndex = 37
        Label17.Text = "Herkomst kwel:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(23, 214)
        Label8.Name = "Label8"
        Label8.Size = New Size(158, 20)
        Label8.TabIndex = 33
        Label8.Text = "Herkomst hoogtedata:"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(23, 280)
        Label15.Name = "Label15"
        Label15.Size = New Size(159, 20)
        Label15.TabIndex = 36
        Label15.Text = "Herkomst landgebruik:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(22, 246)
        Label9.Name = "Label9"
        Label9.Size = New Size(158, 20)
        Label9.TabIndex = 35
        Label9.Text = "Herkomst bodemdata:"
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox4.Controls.Add(txtDescription)
        GroupBox4.Location = New Point(662, 681)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(736, 121)
        GroupBox4.TabIndex = 4
        GroupBox4.TabStop = False
        GroupBox4.Text = "Omschrijving"
        ' 
        ' GroupBox5
        ' 
        GroupBox5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox5.Controls.Add(Label25)
        GroupBox5.Controls.Add(cmbSoftware)
        GroupBox5.Controls.Add(Label24)
        GroupBox5.Controls.Add(txtVersion)
        GroupBox5.Controls.Add(cmbCatchment)
        GroupBox5.Controls.Add(Label23)
        GroupBox5.Controls.Add(cmbProjecten)
        GroupBox5.Controls.Add(Label22)
        GroupBox5.Controls.Add(Label21)
        GroupBox5.Controls.Add(cmbBasemodel)
        GroupBox5.Controls.Add(chkIsBaseModel)
        GroupBox5.Controls.Add(txtReturnPeriod)
        GroupBox5.Controls.Add(Label20)
        GroupBox5.Controls.Add(Label19)
        GroupBox5.Controls.Add(cmbApplication)
        GroupBox5.Controls.Add(txtSimulationPeriod)
        GroupBox5.Controls.Add(cmbClimateScenario)
        GroupBox5.Controls.Add(Label7)
        GroupBox5.Controls.Add(Label1)
        GroupBox5.Controls.Add(cmbModules)
        GroupBox5.Controls.Add(txtDesignScenario)
        GroupBox5.Controls.Add(Label13)
        GroupBox5.Controls.Add(Label11)
        GroupBox5.Controls.Add(Label12)
        GroupBox5.Controls.Add(Label2)
        GroupBox5.Controls.Add(cmbEnvironmentalScenario)
        GroupBox5.Location = New Point(662, 169)
        GroupBox5.Name = "GroupBox5"
        GroupBox5.Size = New Size(452, 506)
        GroupBox5.TabIndex = 5
        GroupBox5.TabStop = False
        GroupBox5.Text = "Modelgegevens"
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Location = New Point(20, 146)
        Label25.Name = "Label25"
        Label25.Size = New Size(81, 20)
        Label25.TabIndex = 57
        Label25.Text = "Software: *"
        ' 
        ' cmbSoftware
        ' 
        cmbSoftware.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbSoftware.FormattingEnabled = True
        cmbSoftware.Location = New Point(194, 143)
        cmbSoftware.Name = "cmbSoftware"
        cmbSoftware.Size = New Size(240, 28)
        cmbSoftware.TabIndex = 56
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Location = New Point(19, 114)
        Label24.Name = "Label24"
        Label24.Size = New Size(51, 20)
        Label24.TabIndex = 55
        Label24.Text = "Versie:"
        ' 
        ' txtVersion
        ' 
        txtVersion.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtVersion.Location = New Point(194, 107)
        txtVersion.Name = "txtVersion"
        txtVersion.Size = New Size(241, 27)
        txtVersion.TabIndex = 54
        ' 
        ' cmbCatchment
        ' 
        cmbCatchment.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbCatchment.FormattingEnabled = True
        cmbCatchment.Location = New Point(197, 211)
        cmbCatchment.Name = "cmbCatchment"
        cmbCatchment.Size = New Size(240, 28)
        cmbCatchment.TabIndex = 53
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Location = New Point(20, 216)
        Label23.Name = "Label23"
        Label23.Size = New Size(108, 20)
        Label23.TabIndex = 52
        Label23.Text = "Stroomgebied:"
        ' 
        ' cmbProjecten
        ' 
        cmbProjecten.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbProjecten.FormattingEnabled = True
        cmbProjecten.Location = New Point(197, 245)
        cmbProjecten.Name = "cmbProjecten"
        cmbProjecten.Size = New Size(240, 28)
        cmbProjecten.TabIndex = 51
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Location = New Point(19, 248)
        Label22.Name = "Label22"
        Label22.Size = New Size(58, 20)
        Label22.TabIndex = 50
        Label22.Text = "Project:"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Location = New Point(20, 73)
        Label21.Name = "Label21"
        Label21.Size = New Size(88, 20)
        Label21.TabIndex = 49
        Label21.Text = "Basismodel:"
        ' 
        ' cmbBasemodel
        ' 
        cmbBasemodel.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbBasemodel.FormattingEnabled = True
        cmbBasemodel.Location = New Point(195, 64)
        cmbBasemodel.Name = "cmbBasemodel"
        cmbBasemodel.Size = New Size(240, 28)
        cmbBasemodel.TabIndex = 48
        ' 
        ' chkIsBaseModel
        ' 
        chkIsBaseModel.AutoSize = True
        chkIsBaseModel.Location = New Point(20, 35)
        chkIsBaseModel.Name = "chkIsBaseModel"
        chkIsBaseModel.Size = New Size(173, 24)
        chkIsBaseModel.TabIndex = 47
        chkIsBaseModel.Text = "Dit is een basismodel"
        chkIsBaseModel.UseVisualStyleBackColor = True
        ' 
        ' txtReturnPeriod
        ' 
        txtReturnPeriod.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtReturnPeriod.Location = New Point(196, 413)
        txtReturnPeriod.Name = "txtReturnPeriod"
        txtReturnPeriod.Size = New Size(241, 27)
        txtReturnPeriod.TabIndex = 46
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Location = New Point(21, 416)
        Label20.Name = "Label20"
        Label20.Size = New Size(102, 20)
        Label20.TabIndex = 45
        Label20.Text = "herhalingstijd:"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Location = New Point(21, 450)
        Label19.Name = "Label19"
        Label19.Size = New Size(133, 20)
        Label19.TabIndex = 44
        Label19.Text = "Toepassing model:"
        ' 
        ' cmbApplication
        ' 
        cmbApplication.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbApplication.FormattingEnabled = True
        cmbApplication.Location = New Point(196, 447)
        cmbApplication.Name = "cmbApplication"
        cmbApplication.Size = New Size(241, 28)
        cmbApplication.TabIndex = 43
        ' 
        ' GroupBox6
        ' 
        GroupBox6.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        GroupBox6.Controls.Add(btnAdd)
        GroupBox6.Location = New Point(1404, 681)
        GroupBox6.Name = "GroupBox6"
        GroupBox6.Size = New Size(170, 121)
        GroupBox6.TabIndex = 6
        GroupBox6.TabStop = False
        GroupBox6.Text = "Acties"
        ' 
        ' colModelCaseName
        ' 
        colModelCaseName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        colModelCaseName.HeaderText = "Naam"
        colModelCaseName.MinimumWidth = 6
        colModelCaseName.Name = "colModelCaseName"
        ' 
        ' colVersion
        ' 
        colVersion.HeaderText = "Versie"
        colVersion.MinimumWidth = 6
        colVersion.Name = "colVersion"
        colVersion.Width = 125
        ' 
        ' colModules
        ' 
        colModules.HeaderText = "Modules"
        colModules.MinimumWidth = 6
        colModules.Name = "colModules"
        colModules.Width = 125
        ' 
        ' frmAddModelschematization
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1582, 853)
        Controls.Add(GroupBox6)
        Controls.Add(GroupBox5)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmAddModelschematization"
        Text = "Modelschematisatie toevoegen"
        GroupBox1.ResumeLayout(False)
        CType(grdModelschematizations, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        GroupBox5.ResumeLayout(False)
        GroupBox5.PerformLayout()
        GroupBox6.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtCaseName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmbEmployee As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnConfigurationFile As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents txtDesignScenario As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents cmbModules As ComboBox
    Friend WithEvents cmbClimateScenario As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents cmbEnvironmentalScenario As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbModelCase As ComboBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents pckCreateDate As DateTimePicker
    Friend WithEvents Label14 As Label
    Friend WithEvents grdModelschematizations As DataGridView
    Friend WithEvents dlgOpenFile As OpenFileDialog
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtConfigurationFile As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtSimulationPeriod As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbConsultant As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbModelbuildscript As ComboBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents cmbElevationData As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents cmbPrecipitation As ComboBox
    Friend WithEvents cmbSeepage As ComboBox
    Friend WithEvents cmbLanduseData As ComboBox
    Friend WithEvents cmbSoilData As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtReturnPeriod As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents cmbApplication As ComboBox
    Friend WithEvents txtModelDir As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents btnModelDir As Button
    Friend WithEvents dlgFolder As FolderBrowserDialog
    Friend WithEvents cmbProjecten As ComboBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents cmbBasemodel As ComboBox
    Friend WithEvents chkIsBaseModel As CheckBox
    Friend WithEvents cmbCatchment As ComboBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents txtVersion As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents cmbSoftware As ComboBox
    Friend WithEvents txtScriptDir As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents colModelCaseName As DataGridViewTextBoxColumn
    Friend WithEvents colVersion As DataGridViewTextBoxColumn
    Friend WithEvents colModules As DataGridViewTextBoxColumn
End Class
