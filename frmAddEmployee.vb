Imports HYDROC01.General
Public Class frmAddEmployee
    Private Setup As clsSetup
    Public Sub New(ByRef mySetup As clsSetup)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Setup = mySetup

    End Sub

    Private Sub frmAddEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        RefreshEmployees()

    End Sub

    Public Sub RefreshEmployees()
        Dim query As String = "SELECT DISTINCT NAAM FROM tblMedewerkers;"
        Dim dt As New DataTable

        Setup.GeneralFunctions.SQLiteQuery(Setup.SqliteCon, query, dt)

        grdEmployees.Rows.Clear()
        For i = 0 To dt.Rows.Count - 1
            Dim row As String() = New String() {dt.Rows(i).Item(0)}
            grdEmployees.Rows.Add(row)
        Next
    End Sub

    Private Sub btnAddEmployee_Click(sender As Object, e As EventArgs) Handles btnAddEmployee.Click
        If txtName.Text.Length = 0 Then
            MsgBox("Geef AUB de naam van de medewerker op.")
        Else
            Dim query As String = "INSERT INTO tblMedewerkers (NAAM) VALUES ('" & txtName.Text & "');"
            Setup.GeneralFunctions.SQLiteNoQuery(Setup.SqliteCon, query)

            RefreshEmployees()
        End If
    End Sub
End Class