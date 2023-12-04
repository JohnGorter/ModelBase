Imports HYDROC01.General
Public Class frmAddModelProject
    Private Setup As clsSetup

    Public Sub New(ByRef mySetup As clsSetup)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Setup = mySetup

    End Sub


    Public Sub RefreshProjects()
        Dim query As String = "SELECT MODELPROJECTNAAM, MODELDIRECTORY, STROOMGEBIED, MODELLEERSOFTWARE FROM tblModelProjecten;"
        Dim dt As New DataTable

        Setup.GeneralFunctions.SQLiteQuery(Setup.SqliteCon, query, dt)

        grdProjecten.Rows.Clear()
        For i = 0 To dt.Rows.Count - 1
            Dim row As String() = New String() {dt.Rows(i).Item(0), dt.Rows(i).Item(1), dt.Rows(i).Item(2), dt.Rows(i).Item(3)}
            grdProjecten.Rows.Add(row)
        Next
    End Sub
    Private Sub frmAddProject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'populate the comboboxes
        Setup.GeneralFunctions.PopulateComboboxFromDatabaseQuery(Setup.SqliteCon, "SELECT DISTINCT STROOMGEBIED FROM tblStroomgebieden;", cmbCatchment)
        Setup.GeneralFunctions.PopulateComboboxFromDatabaseQuery(Setup.SqliteCon, "SELECT DISTINCT NAAM FROM tblModelleersoftware;", cmbModellingSoftware)
        Setup.GeneralFunctions.PopulateComboboxFromDatabaseQuery(Setup.SqliteCon, "SELECT DISTINCT PROJECTNAAM FROM tblProjecten;", cmbProject)

        RefreshProjects()

    End Sub

    Private Sub btnModelProject_Click(sender As Object, e As EventArgs) Handles btnModelProject.Click
        Dim res As New DialogResult
        res = dlgFolder.ShowDialog
        If res = DialogResult.OK Then
            txtprojectDir.Text = dlgFolder.SelectedPath
        End If
    End Sub

    Private Sub cmbModellingSoftware_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbModellingSoftware.SelectedIndexChanged
    End Sub

    Private Sub btnAddProject_Click(sender As Object, e As EventArgs) Handles btnAddProject.Click

        If txtProjectName.Text.Length = 0 Then
            MsgBox("Geef aub de naam van het project op.")
        ElseIf txtprojectDir.Text.Length = 0 Then
            MsgBox("Geef aub de locatie van het project op.")
        ElseIf cmbCatchment.Text.Length = 0 Then
            MsgBox("Geef aub het stroomgebied op.")
        ElseIf cmbModellingSoftware.Text.Length = 0 Then
            MsgBox("Geef aub de modelleersoftware op.")
        ElseIf cmbProject.Text.Length = 0 Then
            MsgBox("Selecteer aub het project behorende bij het model.")
        Else
            Dim query As String = "INSERT INTO tblModelProjecten (MODELPROJECTNAAM, MODELDIRECTORY, STROOMGEBIED, MODELLEERSOFTWARE) VALUES ('" & txtProjectName.Text & "','" & txtprojectDir.Text & "','" & cmbCatchment.Text & "','" & cmbModellingSoftware.Text & "');"
            Setup.GeneralFunctions.SQLiteNoQuery(Setup.SqliteCon, query)
        End If


        RefreshProjects()

    End Sub
End Class