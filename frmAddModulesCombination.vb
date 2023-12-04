Imports HYDROC01.General
Public Class frmAddModulesCombination
    Private Setup As clsSetup
    Public Sub New(ByRef mySetup As clsSetup)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Setup = mySetup

    End Sub

    Private Sub frmAddModulesCombination_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshCombinations()
    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim CombinationName As String = ""
        Dim RR As Integer = 0
        Dim Flow1D As Integer = 0
        Dim RTC As Integer = 0
        Dim Flow2D As Integer = 0
        Dim WQ As Integer = 0

        For Each item In chkCheckedModules.CheckedItems
            CombinationName = CombinationName & item.ToString & " "
            Select Case item.ToString
                Case "RR"
                    RR = 1
                Case "Flow1D"
                    Flow1D = 1
                Case "RTC"
                    RTC = 1
                Case "Flow2D"
                    Flow2D = 1
                Case "WQ"
                    WQ = 1
            End Select

        Next
        'remove the last space
        CombinationName = CombinationName.Trim

        If CombinationName.Length = 0 Then
            MsgBox("Selecteer AUB één of meer modules.")
        Else
            Dim query As String = "INSERT INTO tblModelModules (COMBINATIENAAM, RR, FLOW1D, RTC, FLOW2D, WQ) VALUES ('" & CombinationName & "'," & RR & "," & Flow1D & "," & RTC & "," & Flow2D & "," & WQ & ");"
            Setup.GeneralFunctions.SQLiteNoQuery(Setup.SqliteCon, query)
            RefreshCombinations()
        End If

    End Sub

    Public Sub RefreshCombinations()
        Dim query As String = "SELECT DISTINCT COMBINATIENAAM, RR, FLOW1D, RTC, FLOW2D, WQ FROM tblModelModules;"
        Dim dt As New DataTable

        Setup.GeneralFunctions.SQLiteQuery(Setup.SqliteCon, query, dt)

        grdModelModules.Rows.Clear()
        For i As Integer = 0 To dt.Rows.Count - 1
            ' Convert integer columns to boolean
            Dim rr As Boolean = Convert.ToBoolean(dt.Rows(i).Item(1))
            Dim flow1D As Boolean = Convert.ToBoolean(dt.Rows(i).Item(2))
            Dim rtc As Boolean = Convert.ToBoolean(dt.Rows(i).Item(3))
            Dim flow2D As Boolean = Convert.ToBoolean(dt.Rows(i).Item(4))
            Dim wq As Boolean = Convert.ToBoolean(dt.Rows(i).Item(5))

            ' Create a row with the converted values
            Dim row As String() = New String() {dt.Rows(i).Item(0).ToString(), rr.ToString(), flow1D.ToString(), rtc.ToString(), flow2D.ToString(), wq.ToString()}
            grdModelModules.Rows.Add(row)
        Next
    End Sub

End Class