Imports HYDROC01.General
Public Class frmAddModellingSoftware
    Private Setup As clsSetup
    Public Sub New(ByRef mySetup As clsSetup)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Setup = mySetup

    End Sub

    Public Sub RefreshModellingSoftware()
        Dim query As String = "SELECT DISTINCT NAAM, MAKER FROM tblModelleersoftware;"
        Dim dt As New DataTable

        Setup.GeneralFunctions.SQLiteQuery(Setup.SqliteCon, query, dt)

        grdModellingSoftware.Rows.Clear()
        For i = 0 To dt.Rows.Count - 1
            Dim row As String() = New String() {dt.Rows(i).Item(0), dt.Rows(i).Item(1)}
            grdModellingSoftware.Rows.Add(row)
        Next
    End Sub

    Private Sub frmAddModellingSoftware_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshModellingSoftware()

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If txtModellingSoftware.Text.Length = 0 Then
            MsgBox("Geef AUB de naam van de modelleersoftware op.")
        ElseIf txtMaker.Text.Length = 0 Then
            MsgBox("Geef AUB de naam van de maker op.")
        Else
            Dim query As String = "INSERT INTO tblModelleersoftware (NAAM, MAKER) VALUES ('" & txtModellingSoftware.Text & "','" & txtMaker.Text & "');"
            Setup.GeneralFunctions.SQLiteNoQuery(Setup.SqliteCon, query)

            RefreshModellingSoftware()
        End If
    End Sub

End Class