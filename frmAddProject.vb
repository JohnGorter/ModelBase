
Imports HYDROC01.General
Public Class frmAddProject
    Private Setup As clsSetup

    Public Sub New(ByRef mySetup As clsSetup)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Setup = mySetup

    End Sub

    Public Sub RefreshProjects()
        Dim query As String = "SELECT PROJECTNAAM, PROJECTNUMMER, INGENIEURSBUREAU, MEDEWERKER  FROM tblProjecten;"
        Dim dt As New DataTable

        Setup.GeneralFunctions.SQLiteQuery(Setup.SqliteCon, query, dt)

        grdProjects.Rows.Clear()
        For i = 0 To dt.Rows.Count - 1
            Dim row As String() = New String() {dt.Rows(i).Item(0), dt.Rows(i).Item(1), dt.Rows(i).Item(2), dt.Rows(i).Item(3)}
            grdProjects.Rows.Add(row)
        Next
    End Sub

    Private Sub frmAddProject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Setup.GeneralFunctions.PopulateComboboxFromDatabaseQuery(Me.Setup.SqliteCon, "SELECT DISTINCT NAAM FROM tblMedewerkers;", cmbMedewerker)
        RefreshProjects()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtProjectName.Text.Length = 0 Then
            MsgBox("Geef AUB de naam van het project op.")
        ElseIf txtProjectNumber.Text.Length = 0 Then
            MsgBox("Geef AUB het nummer van het project op.")
        ElseIf txtConsultant.Text.Length = 0 Then
            MsgBox("Geef AUB het adviesbureau van het project op.")
        ElseIf cmbMedewerker.Text.Length = 0 Then
            MsgBox("Geef AUB de medewerker van Waterschap Limburg van het project op.")
        Else
            Dim query As String = "INSERT INTO tblProjecten (PROJECTNAAM, PROJECTNUMMER, INGENIEURSBUREAU, MEDEWERKER) VALUES ('" & txtProjectName.Text & "', '" & txtProjectNumber.Text & "', '" & txtConsultant.Text & "', '" & cmbMedewerker.Text & "');"
            Setup.GeneralFunctions.SQLiteNoQuery(Setup.SqliteCon, query)
            RefreshProjects()
        End If
    End Sub

End Class