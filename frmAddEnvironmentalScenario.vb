Imports HYDROC01.General

Public Class frmAddEnvironmentalScenario
    Private Setup As clsSetup

    Public Sub New(ByRef mySetup As clsSetup)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Setup = mySetup

    End Sub

    Public Sub RefreshScenarios()
        Dim query As String = "SELECT DISTINCT NAAM FROM tblOmgevingsscenarios;"
        Dim dt As New DataTable

        Setup.GeneralFunctions.SQLiteQuery(Setup.SqliteCon, query, dt)

        grdEnvironmentalScenarios.Rows.Clear()
        For i = 0 To dt.Rows.Count - 1
            Dim row As String() = New String() {dt.Rows(i).Item(0)}
            grdEnvironmentalScenarios.Rows.Add(row)
        Next
    End Sub

    Private Sub frmAddEnvironmentalScenario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshScenarios()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtEnvironmentalScenarioName.Text.Length = 0 Then
            MsgBox("Geef aub een naam voor het omgevingsscenario op.")
        Else
            Dim query As String = "INSERT INTO tblOmgevingsscenarios (NAAM, TOELICHTING) VALUES ('" & txtEnvironmentalScenarioName.Text & "','" & txtEnvironmentalScenarioExplanation.Text & "');"
            Setup.GeneralFunctions.SQLiteNoQuery(Setup.SqliteCon, query)
            RefreshScenarios()
        End If

    End Sub
End Class