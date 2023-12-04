Imports GMap.NET
Imports GMap.NET.WindowsForms
Imports GMap.NET.WindowsForms.Markers
Imports HYDROC01
Imports HYDROC01.General
Imports MapWinGIS
Imports System.Drawing

Public Class frmModelBase

    Dim Setup As New clsSetup

    Private Sub frmModelBase_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'set the progress bar
        Setup.SetProgress(prProgress, lblProgress)

        'retrieve the database path from the settings file
        txtDatabase.Text = My.Settings.Database

        ConnectAndUpgrade()

        PopulateControls()

    End Sub

    Public Sub ConnectAndUpgrade()
        If System.IO.File.Exists(txtDatabase.Text) Then
            'set the connection and upgrade the database
            Setup.Database = txtDatabase.Text
            Setup.SqliteCon = New SQLite.SQLiteConnection
            Setup.SqliteCon.ConnectionString = "Data Source=" & Setup.Database & ";Version=3;"
            Setup.GeneralFunctions.UpgradeModelsdatabase()
        End If

    End Sub

    Public Sub PopulateControls()
        Setup.GeneralFunctions.PopulateComboboxFromDatabaseQuery(Setup.SqliteCon, "SELECT DISTINCT NAAM FROM tblStroomgebieden;", cmbStroomgebieden)
        Setup.GeneralFunctions.PopulateComboboxFromDatabaseQuery(Setup.SqliteCon, "SELECT DISTINCT NAAM FROM tblModelleersoftware;", cmbModelleersoftware)

        'populate the datagridview with all available models
        PopulateModels()
    End Sub

    Public Sub PopulateModels()
        'populate the datagridview with all available models
        grdModelSchematizations.Rows.Clear()

        Dim query As String = "SELECT MODELCASENAAM, MODELPROJECTNAAM, MODULES, CODESTRGEB FROM tblModelCases;"
        Dim dt As New DataTable
        Setup.GeneralFunctions.SQLiteQuery(Setup.SqliteCon, query, dt)

        grdModelSchematizations.Rows.Clear()
        For i = 0 To dt.Rows.Count - 1

            'find the name of the stroomgebied
            Dim stroomgebied As String = ""
            Dim query2 As String = "SELECT NAAM FROM tblStroomgebieden WHERE CODESTRGEB = '" & dt.Rows(i).Item(3) & "';"
            Dim dt2 As New DataTable
            Setup.GeneralFunctions.SQLiteQuery(Setup.SqliteCon, query2, dt2)
            If dt2.Rows.Count > 0 Then
                stroomgebied = dt2.Rows(0).Item(0)
            End If

            'also find the name of the modelproject and its modelleersoftware
            Dim modelleersoftware As String = ""
            Dim query3 As String = "SELECT MODELLEERSOFTWARE FROM tblModelProjecten WHERE MODELPROJECTNAAM = '" & dt.Rows(i).Item(1) & "';"
            Dim dt3 As New DataTable
            Setup.GeneralFunctions.SQLiteQuery(Setup.SqliteCon, query3, dt3)
            If dt3.Rows.Count > 0 Then
                modelleersoftware = dt3.Rows(0).Item(0)
            End If

            Dim row As String() = New String() {dt.Rows(i).Item(0), stroomgebied, modelleersoftware}
            grdModelSchematizations.Rows.Add(row)
        Next



    End Sub

    Private Sub AccessToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccessToolStripMenuItem.Click

    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        dlgOpenFile.Filter = "SQLite|*.db"
        Dim res As DialogResult = dlgOpenFile.ShowDialog
        If res = DialogResult.OK Then
            txtDatabase.Text = dlgOpenFile.FileName

            ConnectAndUpgrade()

            My.Settings.Database = txtDatabase.Text
            My.Settings.Save()
        End If

    End Sub

    Private Sub CreateNewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateNewToolStripMenuItem.Click
        dlgSaveFile.Filter = "SQLite|*.db"
        dlgSaveFile.ShowDialog()
        Setup.GeneralFunctions.SQLiteCreateDatabase(dlgSaveFile.FileName, True)
        txtDatabase.Text = dlgSaveFile.FileName

        ConnectAndUpgrade()

    End Sub

    Private Sub DatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DatabaseToolStripMenuItem.Click

    End Sub

    Private Sub ToevoegenToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToevoegenToolStripMenuItem1.Click
        Dim myForm As New frmAddEmployee(Setup)
        myForm.ShowDialog()
    End Sub

    Private Sub ToevoegenToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToevoegenToolStripMenuItem2.Click
        Dim myForm As New frmAddCatchment(Setup)
        myForm.ShowDialog()
    End Sub

    Private Sub ToevoegenToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToevoegenToolStripMenuItem3.Click
    End Sub

    Private Sub SoftwareToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SoftwareToolStripMenuItem.Click
        Dim myForm As New frmAddModellingSoftware(Setup)
        myForm.ShowDialog()
    End Sub

    Private Sub CombinatieVanModulesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CombinatieVanModulesToolStripMenuItem.Click
        Dim myForm As New frmAddModulesCombination(Setup)
        myForm.ShowDialog()
    End Sub

    Private Sub ProjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProjectToolStripMenuItem.Click
        Dim myForm As New frmAddModelProject(Setup)
        myForm.ShowDialog()
    End Sub

    Private Sub ToevoegenToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToevoegenToolStripMenuItem4.Click
        Dim myForm As New frmAddProject(Setup)
        myForm.ShowDialog()
    End Sub

    Private Sub CaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CaseToolStripMenuItem.Click
        Dim myForm As New frmAddModelCase(Setup)
        myForm.ShowDialog()
    End Sub
    Private Sub ToevoegenToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToevoegenToolStripMenuItem5.Click
        Dim myForm As New frmAddClimateScenario(Setup)
        myForm.ShowDialog()
    End Sub


    Private Sub grdModelSchematizations_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdModelSchematizations.CellContentClick

    End Sub

    Private Sub grdModelSchematizations_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdModelSchematizations.CellClick

        Dim ModelCaseName As String = grdModelSchematizations.Rows(e.RowIndex).Cells(0).Value
        Dim ModelProjectname As String = ""
        Dim ModelConfigFile As String = ""
        Dim ModelDir As String = ""

        'the user has clicked on one of the cases. Let's plot it on the map
        Dim query As String = "SELECT MODELPROJECTNAAM, CONFIGURATIEBESTAND FROM tblModelCases WHERE MODELCASENAAM = '" & grdModelSchematizations.Rows(e.RowIndex).Cells(0).Value & "';"
        Dim dt As New DataTable
        Setup.GeneralFunctions.SQLiteQuery(Setup.SqliteCon, query, dt)

        If dt.Rows.Count > 0 Then

            Dim ModelModules As New clsModelModules
            ModelModules.Flow1D.Topo.ReadAll = True

            ModelProjectname = dt.Rows(0).Item(0)
            ModelConfigFile = dt.Rows(0).Item(1)

            'find the modelproject
            Dim query2 As String = "SELECT MODELDIRECTORY FROM tblModelProjecten WHERE MODELPROJECTNAAM = '" & dt.Rows(0).Item(0) & "';"
            Dim dt2 As New DataTable
            Setup.GeneralFunctions.SQLiteQuery(Setup.SqliteCon, query2, dt2)

            If dt2.Rows.Count > 0 Then
                ModelDir = dt2.Rows(0).Item(0)

                'now we have all the information to read the  model schematization and plot it on the map
                'based on the file eension, we know which type of model schematization to read
                Select Case Me.Setup.GeneralFunctions.getExtensionFromFileName(ModelConfigFile).Trim.ToUpper
                    Case "XML"
                        'XML, so we assume it is a DIMR model
                        Setup.InitModel(True, True)
                        Setup.Model.ActiveProject = New ClsModelProject(Me.Setup, ModelDir, GeneralFunctions.enmSimulationModel.DIMR)
                        Setup.setDIMRProjectAndCase(ModelConfigFile, ModelCaseName)
                        Setup.ReadActiveCase(ModelModules, "")
                        RenderModelOnMap(Setup.Model.ActiveProject.ActiveCase)


                    Case "CMT"
                        'CMT, so we assume it is a SOBEK 2 model
                        Setup.SetAddSobekProject(ModelDir, ModelDir, True, True)
                        Setup.Model.ActiveProject.setPenColors()
                        Dim myCases As List(Of String) = Me.Setup.Model.ActiveProject.getListOfCaseNames()
                        For Each myCaseName As String In myCases
                            If myCaseName = ModelCaseName Then
                                Dim myCase As HYDROC01.clsModelCase = Me.Setup.Model.ActiveProject.Cases.Item(myCaseName.Trim.ToUpper)


                                myCase.Read(ModelModules, "")

                                RenderModelOnMap(myCase)

                                Exit For
                            End If
                        Next
                End Select





            End If
        End If



    End Sub

    Public Sub RenderModelOnMap(ByRef myCase As HYDROC01.clsModelCase)
        Try
            Dim ReachesOverlay As GMapOverlay
            Dim MarkersOverlay As GMapOverlay
            Dim RouteOverlay As GMapOverlay

            'start by clearing all overlays
            Map.Overlays.Clear()


            'first we'll justs load a default map with a default location
            Map.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly
            Map.Position = New GMap.NET.PointLatLng(51.0006238, 5.8864788) 'Example coordinates: Sittard, nl
            Map.Zoom = 10
            Map.ShowCenter = False

            Setup.Model.GeoProjection.ImportFromEPSG(28992)

            'we must reproject our reference case to WGS84
            Dim TargetProjection As New MapWinGIS.GeoProjection
            TargetProjection.ImportFromEPSG(4326)
            Dim Extents As New MapWinGIS.Extents
            myCase.TemporaryReprojectAndGetExtents(Setup.Model.GeoProjection, TargetProjection, Extents)

            'create an overlay for our reaches, an overlay for our markers and an overlay for our selected route
            ReachesOverlay = New GMapOverlay("Reaches")
            MarkersOverlay = New GMapOverlay("Markers")
            'RouteOverlay = New GMapOverlay("Route")


            'get all reaches from the active model & case
            Dim Reaches As Dictionary(Of String, HYDROC01.clsSbkReach) = myCase.CFTopo.getAllActiveReaches()

            For Each myReach As clsSbkReach In Reaches.Values
                'get the coordinates of the reach

                Dim ReachCoordinates As List(Of clsXY) = myReach.getLatLonCoordinates
                Dim ReachCoordinatesGMap As List(Of PointLatLng) = New List(Of PointLatLng)

                'convert the reachcoordinates to the reachcoordinatesGMap
                For Each myCoordinate As clsXY In ReachCoordinates
                    ReachCoordinatesGMap.Add(New PointLatLng(myCoordinate.Y, myCoordinate.X))
                Next

                'create a new polyline for the reach. Apparently this is called a route in GMap.NET
                Dim reach As GMapRoute = New GMapRoute(ReachCoordinatesGMap, myReach.Id)
                reach.Stroke = New Pen(Color.FromArgb(255, Color.Navy), 2)

                'add the reach to the overlay
                ReachesOverlay.Routes.Add(reach)
            Next

            Map.Overlays.Add(ReachesOverlay)
            'Map.Refresh()
            'Map.Update()



            'now we'll add the nodes to the map

            Dim objectBitmap As Bitmap
            Dim objectMarker As GMarkerGoogle

            'next we will create markers for the reachnodes
            Dim Nodes As Dictionary(Of String, HYDROC01.clsSbkReachNode) = myCase.CFTopo.getAllActiveReachNodes()

            For Each myNode As clsSbkReachNode In Nodes.Values
                'get the coordinate of the reachnode
                Dim NodeCoordinate As clsXY = myNode.getXY
                Dim NodeCoordinateGMap As PointLatLng = New PointLatLng(NodeCoordinate.Y, NodeCoordinate.X)

                objectBitmap = Setup.GeneralFunctions.createObjectIconBitmap(myNode.nt, False) '.CreateCircleBitmap(Color.Gray, 12, Color.Black, 1)
                objectMarker = New GMarkerGoogle(NodeCoordinateGMap, objectBitmap)
                objectMarker.Offset = New System.Drawing.Point(-objectBitmap.Width / 2, -objectBitmap.Height / 2)  'since all reachnodes are symmetrical we can simple set the marker's offset to half of the width and height

                Dim markerTag As New MarkerTag() With {
                .ID = myNode.ID,
                .NodeType = myNode.nt,
                .Offset = objectMarker.Offset  'we keep track of the offset in order to look it up when changing color
            }
                objectMarker.Tag = markerTag
                objectMarker.Offset = markerTag.Offset
                objectMarker.ToolTipText = myNode.ID
                objectMarker.ToolTipText = vbNewLine & myNode.ID
                objectMarker.ToolTip.Fill = Brushes.DarkGray
                objectMarker.ToolTip.Foreground = Brushes.White
                objectMarker.ToolTip.Stroke = Pens.Black
                objectMarker.ToolTip.TextPadding = New System.Drawing.Size(20, 20)
                MarkersOverlay.Markers.Add(objectMarker)
            Next

            'then create markers for the reachobjects
            Dim Objects As Dictionary(Of String, HYDROC01.clsSbkReachObject) = myCase.CFTopo.getAllActiveReachObjects
            For Each myObj As clsSbkReachObject In Objects.Values
                Select Case myObj.nt
                    Case GeneralFunctions.enmObjectType.NodeCFWeir, GeneralFunctions.enmObjectType.NodeCFOrifice, GeneralFunctions.enmObjectType.NodeCFPump, GeneralFunctions.enmObjectType.NodeCFBridge, GeneralFunctions.enmObjectType.NodeCFCrossSection, GeneralFunctions.enmObjectType.NodeCFLateral, GeneralFunctions.enmObjectType.NodeCFGridpoint, GeneralFunctions.enmObjectType.NodeCFGridpointFixed
                        objectBitmap = Setup.GeneralFunctions.createObjectIconBitmap(myObj.nt, False)
                    Case Else
                        Me.Setup.Log.AddWarning("Nodetype not (yet) supported for Sideview Map: " & myObj.nt.ToString)
                        Continue For
                End Select

                'create our marker
                Dim XY As clsXY = myObj.getXY
                Dim LatLon As New PointLatLng(XY.Y, XY.X)
                objectMarker = New GMarkerGoogle(LatLon, objectBitmap)

                'set the offset of the marker
                If myObj.isStructure Then
                    'structures have triangular shape
                    Dim triangleHeight As Double = objectBitmap.Width * System.Math.Sqrt(3) / 2.0
                    objectMarker.Offset = New System.Drawing.Point(-objectBitmap.Width / 2, CInt(-triangleHeight / 2))
                Else
                    'symmetrical shape
                    objectMarker.Offset = New System.Drawing.Point(-objectBitmap.Width / 2, -objectBitmap.Height / 2)
                End If

                Dim markerTag As New MarkerTag() With {
                .ID = myObj.ID,
                .NodeType = myObj.nt,
                .Offset = objectMarker.Offset 'we keep track of the offset in the marker's tag so we can simply look it up when changing color
            }
                objectMarker.Tag = markerTag
                objectMarker.ToolTipText = vbNewLine & myObj.ID
                objectMarker.ToolTip.Fill = Brushes.DarkGray
                objectMarker.ToolTip.Foreground = Brushes.White
                objectMarker.ToolTip.Stroke = Pens.Black
                objectMarker.ToolTip.TextPadding = New System.Drawing.Size(20, 20)
                MarkersOverlay.Markers.Add(objectMarker)

            Next

            'myCase.CFTopo.AddActiveReachNodesToGMapOverlay(MarkersOverlay, False)
            'myCase.CFTopo.AddActiveReachObjectsToGMapOverlay(MarkersOverlay)
            Map.Overlays.Add(MarkersOverlay)

            'now that we have the reaches, we can zoom to the extents of the model
            Map.ZoomAndCenterRoutes("Reaches")


        Catch ex As Exception
            Stop
        End Try


    End Sub

End Class
