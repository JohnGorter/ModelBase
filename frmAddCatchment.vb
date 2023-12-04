Imports HYDROC01.General
Public Class frmAddCatchment
    Private Setup As clsSetup
    Public Sub New(ByRef mySetup As clsSetup)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Setup = mySetup

    End Sub

    Private Sub frmAddCatchment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshCatchments()
    End Sub


    Public Sub RefreshCatchments()

        Dim query As String = "SELECT DISTINCT STROOMGEBIED, AFKORTING FROM tblStroomgebieden;"

        Dim dt As New DataTable
        Setup.GeneralFunctions.SQLiteQuery(Setup.SqliteCon, query, dt)

        grdCatchments.Rows.Clear()
        For i = 0 To dt.Rows.Count - 1
            Dim row As String() = New String() {dt.Rows(i).Item(0), dt.Rows(i).Item(1)}
            grdCatchments.Rows.Add(row)
        Next
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtCatchmentName.Text.Length = 0 Then
            MsgBox("Geef aub de naam van het stroomgebied op.")
        ElseIf txtCatchmentShort.Text.Length = 0 Then
            MsgBox("Geef aub een afkorting voor het stroomgebied op.")
        Else
            Dim query As String = "INSERT INTO tblStroomgebieden (STROOMGEBIED, AFKORTING) VALUES ('" & txtCatchmentName.Text & "', '" & txtCatchmentShort.Text & "');"
            Setup.GeneralFunctions.SQLiteNoQuery(Setup.SqliteCon, query)

            RefreshCatchments()
        End If
    End Sub
End Class