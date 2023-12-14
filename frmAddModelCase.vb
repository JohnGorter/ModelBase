Imports System.Text.RegularExpressions
Imports HYDROC01.General

Public Class frmAddModelCase
    Private Setup As clsSetup

    Public Sub New(ByRef mySetup As clsSetup)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Setup = mySetup

    End Sub

    Private Sub SetPlaceholderText()
        ' Set the placeholder text and color
        txtVersion.Text = "1.0.0"  ' Example version format
        txtVersion.ForeColor = Color.Gray
    End Sub


    Private Function ValidateVersionFormat(versionText As String) As Boolean
        Dim pattern As String = "^\d+\.\d+\.\d+$"
        If Regex.IsMatch(versionText, pattern) Then
            ' Text matches the pattern, you can set the text color to black (or another color indicating valid input)
            txtVersion.ForeColor = Color.Black
            Return True
        Else
            ' Text does not match the pattern, set the text color to red (or another color indicating invalid input)
            txtVersion.ForeColor = Color.Red
            Return False
        End If
    End Function

    Private Sub frmAddCase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'populate the combobox with the availagble modelprojects
        Setup.GeneralFunctions.PopulateComboboxFromDatabaseQuery(Setup.SqliteCon, "SELECT DISTINCT PROJECTMODELNAAM FROM tblProjectmodellen;", cmbProjectmodel)
        Setup.GeneralFunctions.PopulateComboboxFromDatabaseQuery(Setup.SqliteCon, "SELECT DISTINCT COMBINATIENAAM FROM tblModelModules;", cmbModules)
        Setup.GeneralFunctions.PopulateComboboxFromDatabaseQuery(Setup.SqliteCon, "SELECT DISTINCT NAAM FROM tblKlimaatscenarios;", cmbClimateScenario)
        Setup.GeneralFunctions.PopulateComboboxFromDatabaseQuery(Setup.SqliteCon, "SELECT DISTINCT NAAM FROM tblOmgevingsscenarios;", cmbEnvironmentalScenario)
        Setup.GeneralFunctions.PopulateComboboxFromDatabaseQuery(Setup.SqliteCon, "SELECT DISTINCT NAAM FROM tblMedewerkers;", cmbEmployee)
        Setup.GeneralFunctions.PopulateComboboxFromDatabaseQuery(Setup.SqliteCon, "SELECT DISTINCT NAAM FROM tblIngenieursbureaus;", cmbConsultant)
        SetPlaceholderText()
        RefreshCases()
    End Sub


    Public Sub RefreshCases()

        If cmbProjectmodel.Text.Length > 0 Then
            Dim query As String = "SELECT MODELCASENAAM, MODULES, VERSIE FROM tblModelCases WHERE PROJECTMODEL = '" & cmbProjectmodel.Text & "';"
            Dim dt As New DataTable

            Setup.GeneralFunctions.SQLiteQuery(Setup.SqliteCon, query, dt)

            grdModelCases.Rows.Clear()
            For i = 0 To dt.Rows.Count - 1

                'version is retrieved from the database as a concatenation of the version numbers for basemodel, projectmodel and modelcase


                Dim row As String() = New String() {dt.Rows(i).Item(0), dt.Rows(i).Item(1), dt.Rows(i).Item(2)}
                grdModelCases.Rows.Add(row)
            Next

        End If

    End Sub



    Private Sub cmbProjectmodel_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbProjectmodel.SelectedValueChanged
        RefreshCases()
    End Sub

    Private Sub btnConfigurationFile_Click(sender As Object, e As EventArgs) Handles btnConfigurationFile.Click
        dlgOpenFile.Filter = "Model configuration files|*.xml;caselist.cmt;*.toml"
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
        Dim ModelProjectName As String = cmbProjectmodel.Text
        Dim ConfigurationFile As String = txtConfigurationFile.Text
        Dim ModelCaseName As String = ""
        Dim Modules As String = ""
        Dim SimulationPeriod As String = ""
        Dim ClimateScenario As String = ""
        Dim Employee As String = ""
        Dim EnvironmentalScenario As String = ""
        Dim DesignScenario As String = ""
        Dim ParentProject As String = ""
        Dim ParentCase As String = ""
        Dim CreateDate As String = ""
        Dim Description As String = ""
        Dim Consultant As String = ""

        Select Case Setup.GeneralFunctions.getExtensionFromFileName(ConfigurationFile).Trim.ToUpper
            Case "XML"
                ModelCaseName = txtCaseName.Text
            Case "CMT"
                ModelCaseName = cmbModelCase.Text
        End Select

        Modules = cmbModules.Text
        SimulationPeriod = txtSimulationPeriod.Text
        ClimateScenario = cmbClimateScenario.Text
        Employee = cmbEmployee.Text
        EnvironmentalScenario = cmbEnvironmentalScenario.Text
        DesignScenario = txtDesignScenario.Text
        ParentProject = cmbProjectmodel.Text
        CreateDate = pckCreateDate.Value.ToString("yyyy-MM-dd")
        Description = txtDescription.Text
        Consultant = cmbConsultant.Text


        If ModelProjectName.Length = 0 Then
            MsgBox("Selecteer het modelproject waaraan de nieuwe case moet worden toegekend.")
        ElseIf ModelCaseName.Length = 0 Then
            MsgBox("Geef de naam van de nieuwe case op.")
        ElseIf Modules.Length = 0 Then
            MsgBox("Selecteer de modules die in de nieuwe case worden gebruikt.")
        ElseIf Not ValidateVersionFormat(txtVersion.text) Then
            MsgBox("Het versienummer moet in het formaat x.x.x zijn.")
        Else
            Dim Version As String = "_c" & txtVersion.Text '_c voor modelcase
            Dim query As String = "INSERT INTO tblModelCases (PROJECTMODEL, CONFIGURATIEBESTAND, MODELCASENAAM, MODULES, VERSIE, SIMULATIEPERIODE, KLIMAATSCENARIO, OMGEVINGSSCENARIO, ONTWERPSCENARIO, MEDEWERKER, INGENIEURSBUREAU, OMSCHRIJVING) VALUES ('" & ModelProjectName & "','" & txtConfigurationFile.Text & "','" & ModelCaseName & "', '" & Modules & "', '" & Version & "', '" & SimulationPeriod & "','" & ClimateScenario & "','" & EnvironmentalScenario & "','" & DesignScenario & "','" & Employee & "','" & Consultant & "','" & Description & "');"
            If Not Setup.GeneralFunctions.SQLiteNoQuery(Setup.SqliteCon, query) Then
                MsgBox("Er is een fout opgetreden bij het toevoegen van de case aan de database.")
            Else
                MsgBox("De case is met succes toegevoegd aan de database.")
            End If
        End If


        RefreshCases()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Een configuratiebestand aanwijzen is verplicht voor het aanmaken van een case. Voor D-Hydro-DIMR, verwijs naar de DIMR_Config.xml; voor SOBEK, verwijs naar de caselist.cmt.")
    End Sub

    Private Sub cmbProjectmodel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProjectmodel.SelectedIndexChanged

    End Sub

    Private Sub txtVersion_TextChanged(sender As Object, e As EventArgs) Handles txtVersion.TextChanged
        ValidateVersionFormat(txtVersion.Text)
    End Sub

End Class