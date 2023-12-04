Imports HYDROC01.General

Public Class frmAddConsultancyFirm
    Private Setup As clsSetup
    Public Sub New(ByRef mySetup As clsSetup)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Setup = mySetup

    End Sub

    Public Sub RefreshConsultancyFirms()
        Dim query As String = "SELECT DISTINCT INGENIEURSBUREAU FROM tblIngenieursbureaus;"
        Dim dt As New DataTable

        Setup.GeneralFunctions.SQLiteQuery(Setup.SqliteCon, query, dt)

        grdEngineeringFirms.Rows.Clear()
        For i = 0 To dt.Rows.Count - 1
            Dim row As String() = New String() {dt.Rows(i).Item(0)}
            grdEngineeringFirms.Rows.Add(row)
        Next
    End Sub
    Private Sub frmAddConsultancyFirm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshConsultancyFirms()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If txtName.Text.Length = 0 Then
            MsgBox("Geef aub een naam voor het ingenieursbureau op.")
        Else
            Dim query As String = "INSERT INTO tblIngenieursbureaus (INGENIEURSBUREAU) VALUES ('" & txtName.Text & "');"
            Setup.GeneralFunctions.SQLiteNoQuery(Setup.SqliteCon, query)
            RefreshConsultancyFirms()
        End If
    End Sub
End Class