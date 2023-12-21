Imports HYDROC01
Imports HYDROC01.General
Imports System.Text.RegularExpressions
Public Class frmAddProjectModel
    Private Setup As clsSetup

    Public Sub New(ByRef mySetup As clsSetup)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Setup = mySetup

    End Sub


    Public Sub RefreshProjectModels()
        Dim query As String = "SELECT PROJECTMODELNAAM, VERSIE, PROJECT FROM tblProjectModellen;"
        Dim dt As New DataTable

        Setup.GeneralFunctions.SQLiteQuery(Setup.SqliteCon, query, dt)

        grdProjectModels.Rows.Clear()
        For i = 0 To dt.Rows.Count - 1
            Dim row As String() = New String() {dt.Rows(i).Item(0), dt.Rows(i).Item(1), dt.Rows(i).Item(2)}
            grdProjectModels.Rows.Add(row)
        Next
    End Sub
    Private Sub frmAddProject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'populate the comboboxes
        Setup.GeneralFunctions.PopulateComboboxFromDatabaseQuery(Setup.SqliteCon, "SELECT DISTINCT BASISMODELNAAM FROM tblBasismodellen;", cmbBasisModel)
        Setup.GeneralFunctions.PopulateComboboxFromDatabaseQuery(Setup.SqliteCon, "SELECT DISTINCT PROJECTNAAM FROM tblProjecten;", cmbProject)

        SetPlaceholderText()
        RefreshProjectModels()

    End Sub

    Private Sub btnModelProject_Click(sender As Object, e As EventArgs) Handles btnModelDir.Click
        Dim res As New DialogResult
        res = dlgFolder.ShowDialog
        If res = DialogResult.OK Then
            txtModelDir.Text = dlgFolder.SelectedPath
        End If
    End Sub


    Private Sub btnAddProject_Click(sender As Object, e As EventArgs) Handles btnAddProject.Click

        If txtProjectModelName.Text.Length = 0 Then
            MsgBox("Geef aub de naam van het project op.")
        ElseIf cmbBasisModel.Text.Length = 0 Then
            MsgBox("Selecteer eerst het basismodel dat ten grondslag ligt aan dit projectmodel.")
        ElseIf txtModelDir.Text.Length = 0 Then
            MsgBox("Geef aub de locatie van het model op.")
        ElseIf cmbProject.Text.Length = 0 Then
            MsgBox("Selecteer aub het project behorende bij het model.")
        ElseIf Not ValidateVersionFormat(txtVersion.text) Then
            MsgBox("Het versienummer moet in het formaat x.x.x zijn.")
        Else

            'check if the project model with this name and version already exists
            Dim query As String = "SELECT PROJECTMODELNAAM, VERSIE FROM tblProjectmodellen WHERE LOWER(PROJECTMODELNAAM) = LOWER('" & txtProjectModelName.Text & "') AND VERSIE = '" & txtVersion.Text & "';"
            Dim dt As New DataTable
            Setup.GeneralFunctions.SQLiteQuery(Setup.SqliteCon, query, dt)
            If dt.Rows.Count > 0 Then
                MsgBox("Er bestaat al een projectmodel met deze naam en versie.")
            Else
                query = "INSERT INTO tblProjectmodellen (PROJECTMODELNAAM, MODELDIRECTORY, BASISMODEL, BASISMODELVERSIE, PROJECT, VERSIE) VALUES ('" & txtProjectModelName.Text & "','" & txtModelDir.Text & "','" & cmbBasisModel.Text & "','" & cmbBasismodelVersie.Text & "','" & cmbProject.Text & "','" & txtVersion.Text & "');"
                Setup.GeneralFunctions.SQLiteNoQuery(Setup.SqliteCon, query)
            End If
        End If

        RefreshProjectModels()
    End Sub

    Private Sub cmbBasisModel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBasisModel.SelectedIndexChanged
        Setup.GeneralFunctions.PopulateComboboxFromDatabaseQuery(Setup.SqliteCon, "SELECT DISTINCT VERSIE FROM tblBasismodellen WHERE BASISMODELNAAM = '" & cmbBasisModel.Text & "';", cmbBasismodelVersie)
    End Sub

    Private Sub txtVersion_TextChanged(sender As Object, e As EventArgs) Handles txtVersion.TextChanged
        ValidateVersionFormat(txtVersion.Text)
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