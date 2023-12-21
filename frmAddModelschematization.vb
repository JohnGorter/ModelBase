Imports System.Data.SQLite
Imports System.Text.RegularExpressions
Imports HYDROC01.General

Public Class frmAddModelschematization
    Private Setup As clsSetup

    Public Sub New(ByRef mySetup As clsSetup)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Setup = mySetup

    End Sub




    Private Sub frmAddCase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'populate the combobox with the availagble modelprojects
        Setup.GeneralFunctions.PopulateComboboxFromDatabaseQuery(Setup.SqliteCon, "SELECT DISTINCT COMBINATIENAAM FROM tblModelModules;", cmbModules)
        Setup.GeneralFunctions.PopulateComboboxFromDatabaseQuery(Setup.SqliteCon, "SELECT DISTINCT NAAM FROM tblKlimaatscenarios;", cmbClimateScenario)
        Setup.GeneralFunctions.PopulateComboboxFromDatabaseQuery(Setup.SqliteCon, "SELECT DISTINCT NAAM FROM tblOmgevingsscenarios;", cmbEnvironmentalScenario)
        Setup.GeneralFunctions.PopulateComboboxFromDatabaseQuery(Setup.SqliteCon, "SELECT DISTINCT NAAM FROM tblMedewerkers;", cmbEmployee)
        Setup.GeneralFunctions.PopulateComboboxFromDatabaseQuery(Setup.SqliteCon, "SELECT DISTINCT NAAM FROM tblIngenieursbureaus;", cmbConsultant)
        Setup.GeneralFunctions.PopulateComboboxFromDatabaseQuery(Setup.SqliteCon, "SELECT DISTINCT STROOMGEBIED FROM tblStroomgebieden;", cmbCatchment)
        Setup.GeneralFunctions.PopulateComboboxFromDatabaseQuery(Setup.SqliteCon, "SELECT DISTINCT PROJECTNAAM FROM tblProjecten;", cmbProjecten)
        Setup.GeneralFunctions.PopulateComboboxFromDatabaseQuery(Setup.SqliteCon, "SELECT DISTINCT NAAM FROM tblModelleersoftware;", cmbSoftware)

        Setup.GeneralFunctions.PopulateComboboxFromDatabaseQuery(Setup.SqliteCon, "SELECT DISTINCT NAAM FROM tblToepassingen;", cmbapplication)
        Setup.GeneralFunctions.PopulateComboboxFromDatabaseQuery(Setup.SqliteCon, "SELECT DISTINCT NAAM FROM tblModelbouwscripts;", cmbModelbuildscript)
        Setup.GeneralFunctions.PopulateComboboxFromDatabaseQuery(Setup.SqliteCon, "SELECT DISTINCT NAAM FROM tblHoogtedatabron;", cmbElevationData)
        Setup.GeneralFunctions.PopulateComboboxFromDatabaseQuery(Setup.SqliteCon, "SELECT DISTINCT NAAM FROM tblBodemsoortdatabron;", cmbSoilData)
        Setup.GeneralFunctions.PopulateComboboxFromDatabaseQuery(Setup.SqliteCon, "SELECT DISTINCT NAAM FROM tblLandgebruiksdatabron;", cmbLanduseData)
        Setup.GeneralFunctions.PopulateComboboxFromDatabaseQuery(Setup.SqliteCon, "SELECT DISTINCT NAAM FROM tblKweldatabron;", cmbSeepage)
        Setup.GeneralFunctions.PopulateComboboxFromDatabaseQuery(Setup.SqliteCon, "SELECT DISTINCT NAAM FROM tblNeerslagdatabron;", cmbPrecipitation)

        RefreshCases()
    End Sub


    Public Sub RefreshCases()

        Dim query As String = "SELECT NAAM, VERSIE, MODULES FROM tblModelschematisaties;"
        Dim dt As New DataTable

        Setup.GeneralFunctions.SQLiteQuery(Setup.SqliteCon, query, dt)

        grdModelschematizations.Rows.Clear()
        For i = 0 To dt.Rows.Count - 1

            'version is retrieved from the database as a concatenation of the version numbers for basemodel, projectmodel and modelcase
            Dim row As String() = New String() {dt.Rows(i).Item(0), dt.Rows(i).Item(1), dt.Rows(i).Item(2)}
            grdModelschematizations.Rows.Add(row)
        Next


    End Sub



    Private Sub btnConfigurationFile_Click(sender As Object, e As EventArgs) Handles btnConfigurationFile.Click
        dlgOpenFile.Filter = "Model configuration files|*.xml;caselist.cmt;*.toml"
        Dim res As New DialogResult
        res = dlgOpenFile.ShowDialog()
        If res = DialogResult.OK Then
            txtConfigurationFile.Text = dlgOpenFile.FileName

            Select Case Setup.GeneralFunctions.getExtensionFromFileName(dlgOpenFile.FileName).Trim.ToUpper
                Case "XML"
                    cmbModelCase.Hide()
                    txtCaseName.Show()
                Case "CMT"
                    cmbModelCase.Show()
                    txtCaseName.Hide()

                    'populate the combobox with the availagble modelcases. Since we're dealing with SOBEK, read the project and the caselist
                    Dim ProjectDir As String = Me.Setup.GeneralFunctions.DirFromFileName(txtConfigurationFile.Text)
                    Me.Setup.SetAddSobekProject(ProjectDir, ProjectDir, True, True)
                    Dim myCases As List(Of String) = Me.Setup.Model.ActiveProject.getListOfCaseNames()
                    Me.Setup.GeneralFunctions.populateComboBoxFromList(myCases, cmbModelCase)

            End Select


        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim ConfigurationFile As String = txtConfigurationFile.Text
        Dim ModelCaseName As String = ""
        Dim Modules As String = cmbModules.Text

        Select Case Setup.GeneralFunctions.getExtensionFromFileName(ConfigurationFile).Trim.ToUpper
            Case "XML"
                ModelCaseName = txtCaseName.Text
            Case "CMT"
                ModelCaseName = cmbModelCase.Text
        End Select

        Dim CreateDate As String = pckCreateDate.Value.ToString("yyyy-MM-dd")
        If ModelCaseName.Length = 0 Then
            MsgBox("Geef de naam van de nieuwe case op.")
        ElseIf Modules.Length = 0 Then
            MsgBox("Selecteer de modules die in de nieuwe case worden gebruikt.")
        Else
            Try
                Dim query As String = "INSERT INTO tblModelschematisaties (NAAM, VERSIE, SOFTWARE, MODELDIRECTORY, CONFIGURATIEBESTAND, ISBASISMODEL, BASISMODEL, STROOMGEBIED, PROJECT, MODULES, KLIMAATSCENARIO, OMGEVINGSSCENARIO, ONTWERPVARIANT, SIMULATIEPERIODE, HERHALINGSTIJD, AANMAAKDATUM, INGENIEURSBUREAU, MEDEWERKER, TOEPASSING, OMSCHRIJVING, NEERSLAGBRON, KWELKAART, LANDGEBRUIKSKAART, BODEMKAART, HOOGTEDATA, MODELBOUWSCRIPT, MODELBOUWDIRECTORY) VALUES (@Name, @Version, @Software, @ModelDirectory, @ConfigFile, @IsBaseModel, @BaseModel, @Catchment, @Project, @Modules, @ClimateScenario, @EnvironmentalScenario, @DesignScenario, @SimulationPeriod, @ReturnPeriod, @CreateDate, @Consultant, @Employee, @Application, @Description, @PrecipitationSource, @SeepageSource, @LanduseSource, @SoildataSource, @ElevationdataSource, @ModelBuildScript, @ModelBuildDir);"

                Using conn As New SQLiteConnection(Setup.SqliteCon)
                    Using command As New SQLiteCommand(query, conn)
                        command.Parameters.AddWithValue("@Name", ModelCaseName)
                        command.Parameters.AddWithValue("@Version", txtVersion.Text)
                        command.Parameters.AddWithValue("@Software", cmbSoftware.Text)
                        command.Parameters.AddWithValue("@ModelDirectory", txtModelDir.Text)
                        command.Parameters.AddWithValue("@ConfigFile", ConfigurationFile)
                        command.Parameters.AddWithValue("@IsBaseModel", chkIsBaseModel.checked)
                        command.Parameters.AddWithValue("@BaseModel", cmbBasemodel.Text)
                        command.Parameters.AddWithValue("@Catchment", cmbCatchment.Text)
                        command.Parameters.AddWithValue("@Project", cmbProjecten.Text)
                        command.Parameters.AddWithValue("@Modules", Modules)
                        command.Parameters.AddWithValue("@ClimateScenario", cmbClimateScenario.Text)
                        command.Parameters.AddWithValue("@EnvironmentalScenario", cmbEnvironmentalScenario.Text)
                        command.Parameters.AddWithValue("@DesignScenario", txtDesignScenario.Text)
                        command.Parameters.AddWithValue("@SimulationPeriod", txtSimulationPeriod.Text)
                        command.Parameters.AddWithValue("@ReturnPeriod", txtReturnPeriod.Text)
                        command.Parameters.AddWithValue("@CreateDate", CreateDate)
                        command.Parameters.AddWithValue("@Consultant", cmbConsultant.Text)
                        command.Parameters.AddWithValue("@Employee", cmbEmployee.Text)
                        command.Parameters.AddWithValue("@Application", cmbApplication.Text)
                        command.Parameters.AddWithValue("@Description", txtDescription.Text)
                        command.Parameters.AddWithValue("@PrecipitationSource", cmbPrecipitation.Text)
                        command.Parameters.AddWithValue("@SeepageSource", cmbSeepage.Text)
                        command.Parameters.AddWithValue("@LanduseSource", cmbLanduseData.Text)
                        command.Parameters.AddWithValue("@SoildataSource", cmbSoilData.Text)
                        command.Parameters.AddWithValue("@ElevationdataSource", cmbElevationData.Text)
                        command.Parameters.AddWithValue("@ModelBuildScript", cmbModelbuildscript.Text)
                        command.Parameters.AddWithValue("@ModelBuildDir", txtScriptDir.Text)

                        conn.Open()
                        command.ExecuteNonQuery()
                        conn.Close()
                    End Using
                End Using

                MsgBox("De case is met succes toegevoegd aan de database.")
            Catch ex As Exception
                MsgBox("Er is een fout opgetreden bij het toevoegen van de case aan de database: " & ex.Message)
            End Try
        End If



        RefreshCases()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Een configuratiebestand aanwijzen is verplicht voor het aanmaken van een case. Voor D-Hydro-DIMR, verwijs naar de DIMR_Config.xml; voor SOBEK, verwijs naar de caselist.cmt.")
    End Sub



    Private Sub cmbEmployee_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEmployee.SelectedIndexChanged
    End Sub

    Private Sub btnModelDir_Click(sender As Object, e As EventArgs) Handles btnModelDir.Click
        dlgFolder.ShowDialog()
        txtModelDir.Text = dlgFolder.SelectedPath
    End Sub
End Class