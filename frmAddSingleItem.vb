Imports HYDROC01.General

Public Class frmAddSingleItem
    Private Setup As clsSetup
    Private ItemName As String
    Private TableName As String
    Public Sub New(ByRef mySetup As clsSetup, myItemName As String, myTableName As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Setup = mySetup
        ItemName = myItemName
        TableName = myTableName

        Text = "Voeg " & ItemName & " toe"


    End Sub

    Public Sub RefreshItems()
        Dim query As String = $"SELECT DISTINCT NAAM FROM {TableName};"
        Dim dt As New DataTable

        Setup.GeneralFunctions.SQLiteQuery(Setup.SqliteCon, query, dt)

        grdItems.Rows.Clear()
        For i = 0 To dt.Rows.Count - 1
            Dim row As String() = New String() {dt.Rows(i).Item(0)}
            grdItems.Rows.Add(row)
        Next
    End Sub
    Private Sub frmAddConsultancyFirm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshItems()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If txtName.Text.Length = 0 Then
            MsgBox("Geef aub een naam voor het ingenieursbureau op.")
        Else
            Dim query As String = $"INSERT INTO  {TableName} (NAAM) VALUES ('" & txtName.Text & "');"
            Setup.GeneralFunctions.SQLiteNoQuery(Setup.SqliteCon, query)
            RefreshItems()
        End If
    End Sub
End Class