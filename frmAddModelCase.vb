Imports HYDROC01.General

Public Class frmAddModelCase
    Private Setup As clsSetup

    Public Sub New(ByRef mySetup As clsSetup)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Setup = mySetup

    End Sub
    Private Sub frmAddCase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'populate the combobox with the availagble modelprojects
        Setup.GeneralFunctions.PopulateComboboxFromDatabaseQuery(Setup.SqliteCon, "SELECT DISTINCT MODELPROJECTNAAM FROM tblModelProjecten;", cmbModelProject)
        Setup.GeneralFunctions.PopulateComboboxFromDatabaseQuery(Setup.SqliteCon, "SELECT DISTINCT COMBINATIENAAM FROM tblModelModules;", cmbModules)
        Setup.GeneralFunctions.PopulateComboboxFromDatabaseQuery(Setup.SqliteCon, "SELECT DISTINCT NAAM FROM tblClimateScenario;", cmbClimateScenario)
        Setup.GeneralFunctions.PopulateComboboxFromDatabaseQuery(Setup.SqliteCon, "SELECT DISTINCT NAAM FROM tblMedewerkers;", cmbEmployee)
        Setup.GeneralFunctions.PopulateComboboxFromDatabaseQuery(Setup.SqliteCon, "SELECT DISTINCT MODELPROJECTNAAM FROM tblModelProjecten;", cmbParentProject)
        Setup.GeneralFunctions.PopulateComboboxFromDatabaseQuery(Setup.SqliteCon, "SELECT DISTINCT MODELCASENAAM FROM tblModelCases;", cmbParentCase)
        RefreshCases()

    End Sub

    Private Sub cmbModelProject_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbModelProject.SelectedIndexChanged

    End Sub

    Public Sub RefreshCases()

        If cmbModelProject.Text.Length > 0 Then
            Dim query As String = "SELECT MODELCASENAAM, MODULES, VERSIE FROM tblModelCases WHERE MODELPROJECTNAAM = '" & cmbModelProject.Text & "';"
            Dim dt As New DataTable

            Setup.GeneralFunctions.SQLiteQuery(Setup.SqliteCon, query, dt)

            grdModelCases.Rows.Clear()
            For i = 0 To dt.Rows.Count - 1
                Dim row As String() = New String() {dt.Rows(i).Item(0), dt.Rows(i).Item(1), dt.Rows(i).Item(2)}
                grdModelCases.Rows.Add(row)
            Next

        End If

    End Sub

    Private Sub cmbModelProject_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbModelProject.SelectedValueChanged
        RefreshCases()
    End Sub

    Private Sub btnConfigurationFile_Click(sender As Object, e As EventArgs) Handles btnConfigurationFile.Click
        dlgOpenFile.Filter = "Model configuration files|*.xml;*.cmt"
        Dim res As New DialogResult
        res = dlgOpenFile.ShowDialog()
        If res = DialogResult.OK Then
            txtConfigurationFile.Text = dlgOpenFile.FileName

            Select Case Setup.GeneralFunctions.getExtensionFromFileName(dlgOpenFile.FileName).Trim.ToUpper
                Case "XML"
                    txtCaseName.Enabled = True
                    cmbModelCase.Enabled = False
                Case "CMT"
                    txtCaseName.Enabled = False
                    cmbModelCase.Enabled = True

                    'populate the combobox with the availagble modelcases. Since we're dealing with SOBEK, read the project and the caselist
                    Dim ProjectDir As String = Me.Setup.GeneralFunctions.DirFromFileName(txtConfigurationFile.Text)
                    Me.Setup.SetAddSobekProject(ProjectDir, ProjectDir, True, True)
                    Dim myCases As List(Of String) = Me.Setup.Model.ActiveProject.getListOfCaseNames()
                    Me.Setup.GeneralFunctions.populateComboBoxFromList(myCases, cmbModelCase)

            End Select


        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim ModelProjectName As String = cmbModelProject.Text
        Dim ConfigurationFile As String = txtConfigurationFile.Text
        Dim ModelCaseName As String = ""
        Dim Modules As String = ""
        Dim Version As String = ""
        Dim SimulationPeriod As String = ""
        Dim ClimateScenario As String = ""
        Dim Employee As String = ""
        Dim EnvironmentalScenario As String = ""
        Dim DesignScenario As String = ""
        Dim ParentProject As String = ""
        Dim ParentCase As String = ""
        Dim CreateDate As String = ""
        Dim Description As String = ""


        Select Case Setup.GeneralFunctions.getExtensionFromFileName(ConfigurationFile).Trim.ToUpper
            Case "XML"
                ModelCaseName = txtCaseName.Text
            Case "CMT"
                ModelCaseName = cmbModelCase.Text
        End Select

        Modules = cmbModules.Text
        Version = txtVersion.Text
        SimulationPeriod = txtSimulationPeriod.Text
        ClimateScenario = cmbClimateScenario.Text
        Employee = cmbEmployee.Text
        EnvironmentalScenario = cmbEnvironmentalScenario.Text
        DesignScenario = txtDesignScenario.Text
        ParentProject = cmbParentProject.Text
        ParentCase = cmbParentCase.Text
        CreateDate = pckCreateDate.Value.ToString("yyyy-MM-dd")
        Description = txtDescription.Text

        If ModelProjectName.Length = 0 Then
            MsgBox("Selecteer het modelproject waartoe de nieuwe case behoort.")
        ElseIf ModelCaseName.Length = 0 Then
            MsgBox("Geef de naam van de nieuwe case op.")
        ElseIf Modules.Length = 0 Then
            MsgBox("Selecteer de modules die in de nieuwe case worden gebruikt.")
        Else
            Dim query As String = "INSERT INTO tblModelCases (MODELPROJECTNAAM, MODELCASENAAM, MODULES, VERSIE, SIMULATIEPERIODE, KLIMAATSCENARIO, MEDEWERKER, CONFIGURATIEBESTAND) VALUES ('" & ModelProjectName & "', '" & ModelCaseName & "', '" & Modules & "', '" & Version & "', '" & SimulationPeriod & "', '" & ClimateScenario & "', '" & Employee & "', '" & ConfigurationFile & "');"
            If Not Setup.GeneralFunctions.SQLiteNoQuery(Setup.SqliteCon, query) Then
                MsgBox("Er is een fout opgetreden bij het toevoegen van de case aan de database.")
            Else
                MsgBox("De case is met succes toegevoegd aan de database.")
            End If
        End If


        RefreshCases()

    End Sub

End Class