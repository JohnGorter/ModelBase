Imports System.Text.RegularExpressions
Imports HYDROC01.General

Public Class frmAddBaseModel
    Private Setup As clsSetup

    Public Sub New(ByRef mySetup As clsSetup)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Setup = mySetup

    End Sub


    Private Sub SetPlaceholderText()
        ' Set the placeholder text and color
        txtVersion.Text = "1.0"  ' Example version format
        txtVersion.ForeColor = Color.Gray
    End Sub


    Public Sub RefreshModels()
        Dim query As String = "SELECT BASISMODELNAAM, VERSIE FROM tblBasismodellen;"
        Dim dt As New DataTable

        Setup.GeneralFunctions.SQLiteQuery(Setup.SqliteCon, query, dt)

        grdBasismodellen.Rows.Clear()
        For i = 0 To dt.Rows.Count - 1
            Dim row As String() = New String() {dt.Rows(i).Item(0), dt.Rows(i).Item(1)}
            grdBasismodellen.Rows.Add(row)
        Next
    End Sub

    Private Sub btnAddBaseModel_Click(sender As Object, e As EventArgs) Handles btnAddBaseModel.Click
        If txtModelName.Text.Length = 0 Then
            MsgBox("Geef aub de naam van het project op.")
        ElseIf cmbModellingSoftware.Text.Length = 0 Then
            MsgBox("Geef aub de modelleersoftware op.")
        ElseIf txtModelDir.Text.Length = 0 Then
            MsgBox("Geef aub de locatie van het project op.")
        ElseIf cmbCatchment.Text.Length = 0 Then
            MsgBox("Geef aub het stroomgebied op.")
        ElseIf Not ValidateVersionFormat(txtVersion.text) Then
            MsgBox("Het versienummer moet in het formaat x.x zijn.")
        Else
            Dim CaseName As String = ""
            If cmbCaseName.Enabled = True AndAlso cmbCaseName.Text.Length > 0 Then
                'this is a model where the case name is selected from a list
                CaseName = cmbCaseName.Text
            Else
                CaseName = txtCaseNaam.Text
            End If

            Dim Version As String = "b" & txtVersion.Text 'b voor basismodel

            Dim query As String = "INSERT INTO tblBasismodellen (BASISMODELNAAM, MODELDIRECTORY, CONFIGFILE, CASENAAM, MODELLEERSOFTWARE, STROOMGEBIED, VERSIE, OMSCHRIJVING) VALUES ('" & txtModelName.Text & "','" & txtModelDir.Text & "','" & txtConfigFile.Text & "','" & CaseName & "','" & cmbModellingSoftware.Text & "','" & cmbCatchment.Text & "','" & Version & "','" & txtDescription.Text & "');"
            Setup.GeneralFunctions.SQLiteNoQuery(Setup.SqliteCon, query)
        End If

        RefreshModels()
    End Sub


    Private Sub txtVersion_TextChanged(sender As Object, e As EventArgs) Handles txtVersion.TextChanged
        ValidateVersionFormat(txtVersion.Text)
    End Sub

    Private Sub frmAddBaseModel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'populate the comboboxes
        Setup.GeneralFunctions.PopulateComboboxFromDatabaseQuery(Setup.SqliteCon, "SELECT DISTINCT STROOMGEBIED FROM tblStroomgebieden;", cmbCatchment)
        Setup.GeneralFunctions.PopulateComboboxFromDatabaseQuery(Setup.SqliteCon, "SELECT DISTINCT NAAM FROM tblModelleersoftware;", cmbModellingSoftware)

        SetPlaceholderText()
        RefreshModels()

    End Sub

    Private Sub btnModelFolder_Click(sender As Object, e As EventArgs) Handles btnModelFolder.Click
        Dim res As DialogResult
        res = dlgFolder.ShowDialog
        If res = DialogResult.OK Then
            txtModelDir.Text = dlgFolder.SelectedPath

            If Strings.Right(txtModelDir.Text, 4).ToLower = ".lit" Then
                'we're dealing with a SOBEK LIT file
                txtConfigFile.Text = txtModelDir.Text & "\Caselist.cmt"
                PopulateCases()

            End If

        End If
        UpdateGUIElements()
    End Sub

    Public Sub PopulateCases()

        If txtConfigFile.Text.Contains("caselist.cmt", StringComparison.CurrentCultureIgnoreCase) Then
            'temporarily create a model instance and populate the combobox with casenames
            Setup.SetAddSobekProject(txtModelDir.Text, txtModelDir.Text)
            Setup.SetAddSobekProject(txtModelDir.Text, txtModelDir.Text)
            Dim myCases As List(Of String) = Me.Setup.Model.ActiveProject.getListOfCaseNames()
            Me.Setup.GeneralFunctions.populateComboBoxFromListOfStrings(cmbCaseName, myCases)
        End If

    End Sub

    Private Sub btnConfigFile_Click(sender As Object, e As EventArgs) Handles btnConfigFile.Click
        Dim res As DialogResult
        res = dlgOpenFile.ShowDialog
        If res = DialogResult.OK Then
            dlgOpenFile.Filter = "Model config files|Caselist.cmt;*.xml;*.toml"
            txtConfigFile.Text = dlgOpenFile.FileName

            If Strings.Right(txtConfigFile.Text, 12).Trim.ToLower = "caselist.cmt" Then
                'we're dealing with a SOBEK caselist.cmt file
                'populate the list of casenames with the values
                PopulateCases()
            End If

            UpdateGUIElements()
        End If
    End Sub

    Private Sub cmbModellingSoftware_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbModellingSoftware.SelectedIndexChanged
        UpdateGUIElements()
    End Sub

    Public Sub UpdateGUIElements()
        If txtConfigFile.Text.Contains("caselist.cmt", StringComparison.CurrentCultureIgnoreCase) Then
            'we're dealing with a SOBEK model
            cmbCaseName.Enabled = True
            txtCaseNaam.Enabled = False
        Else
            cmbCaseName.Enabled = False
            txtCaseNaam.Enabled = True
        End If

    End Sub



    Private Function ValidateVersionFormat(versionText As String) As Boolean
        Dim pattern As String = "^\d+\.\d+$"
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

    ' Handle the Enter event
    Private Sub txtVersion_Enter(sender As Object, e As EventArgs) Handles txtVersion.Enter
        If txtVersion.Text = "1.0.0" AndAlso txtVersion.ForeColor = Color.Gray Then
            txtVersion.Text = ""
            txtVersion.ForeColor = Color.Black
        End If
    End Sub

    ' Handle the Leave event
    Private Sub txtVersion_Leave(sender As Object, e As EventArgs) Handles txtVersion.Leave
        If String.IsNullOrWhiteSpace(txtVersion.Text) Then
            SetPlaceholderText()
        End If
    End Sub

End Class