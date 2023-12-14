<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddModelCase
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmAddModelCase))
        btnAdd = New Button()
        GroupBox1 = New GroupBox()
        grdModelCases = New DataGridView()
        colModelCaseName = New DataGridViewTextBoxColumn()
        colModules = New DataGridViewTextBoxColumn()
        colVersion = New DataGridViewTextBoxColumn()
        pckCreateDate = New DateTimePicker()
        Label14 = New Label()
        cmbProjectmodel = New ComboBox()
        Label4 = New Label()
        Label13 = New Label()
        cmbModules = New ComboBox()
        cmbClimateScenario = New ComboBox()
        Label12 = New Label()
        cmbEmployee = New ComboBox()
        Label10 = New Label()
        btnConfigurationFile = New Button()
        Label3 = New Label()
        txtCaseName = New TextBox()
        GroupBox2 = New GroupBox()
        cmbConsultant = New ComboBox()
        Label16 = New Label()
        txtSimulationPeriod = New TextBox()
        Label1 = New Label()
        Label7 = New Label()
        Button1 = New Button()
        txtConfigurationFile = New TextBox()
        Label6 = New Label()
        cmbModelCase = New ComboBox()
        txtDescription = New TextBox()
        Label15 = New Label()
        cmbEnvironmentalScenario = New ComboBox()
        Label2 = New Label()
        Label11 = New Label()
        txtDesignScenario = New TextBox()
        Label8 = New Label()
        txtVersion = New TextBox()
        dlgOpenFile = New OpenFileDialog()
        GroupBox1.SuspendLayout()
        CType(grdModelCases, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(528, 392)
        btnAdd.Margin = New Padding(3, 2, 3, 2)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(102, 44)
        btnAdd.TabIndex = 0
        btnAdd.Text = "Toevoegen"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(grdModelCases)
        GroupBox1.Location = New Point(10, 9)
        GroupBox1.Margin = New Padding(3, 2, 3, 2)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 2, 3, 2)
        GroupBox1.Size = New Size(495, 448)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Reeds in de database"
        ' 
        ' grdModelCases
        ' 
        grdModelCases.AllowUserToAddRows = False
        grdModelCases.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        grdModelCases.Columns.AddRange(New DataGridViewColumn() {colModelCaseName, colModules, colVersion})
        grdModelCases.Location = New Point(18, 22)
        grdModelCases.Margin = New Padding(3, 2, 3, 2)
        grdModelCases.Name = "grdModelCases"
        grdModelCases.RowHeadersVisible = False
        grdModelCases.RowHeadersWidth = 51
        grdModelCases.RowTemplate.Height = 29
        grdModelCases.Size = New Size(457, 415)
        grdModelCases.TabIndex = 5
        ' 
        ' colModelCaseName
        ' 
        colModelCaseName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        colModelCaseName.HeaderText = "Naam"
        colModelCaseName.MinimumWidth = 6
        colModelCaseName.Name = "colModelCaseName"
        ' 
        ' colModules
        ' 
        colModules.HeaderText = "Modules"
        colModules.MinimumWidth = 6
        colModules.Name = "colModules"
        colModules.Width = 125
        ' 
        ' colVersion
        ' 
        colVersion.HeaderText = "Versie"
        colVersion.MinimumWidth = 6
        colVersion.Name = "colVersion"
        colVersion.Width = 125
        ' 
        ' pckCreateDate
        ' 
        pckCreateDate.Location = New Point(172, 291)
        pckCreateDate.Margin = New Padding(3, 2, 3, 2)
        pckCreateDate.Name = "pckCreateDate"
        pckCreateDate.Size = New Size(459, 23)
        pckCreateDate.TabIndex = 28
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(18, 297)
        Label14.Name = "Label14"
        Label14.Size = New Size(95, 15)
        Label14.TabIndex = 27
        Label14.Text = "Aanmaakdatum:"
        ' 
        ' cmbProjectmodel
        ' 
        cmbProjectmodel.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbProjectmodel.FormattingEnabled = True
        cmbProjectmodel.Location = New Point(172, 22)
        cmbProjectmodel.Margin = New Padding(3, 2, 3, 2)
        cmbProjectmodel.Name = "cmbProjectmodel"
        cmbProjectmodel.Size = New Size(459, 23)
        cmbProjectmodel.TabIndex = 24
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 25)
        Label4.Name = "Label4"
        Label4.Size = New Size(81, 15)
        Label4.TabIndex = 23
        Label4.Text = "Projectmodel:"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(17, 132)
        Label13.Name = "Label13"
        Label13.Size = New Size(64, 15)
        Label13.TabIndex = 22
        Label13.Text = "Modules: *"
        ' 
        ' cmbModules
        ' 
        cmbModules.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbModules.FormattingEnabled = True
        cmbModules.Location = New Point(172, 128)
        cmbModules.Margin = New Padding(3, 2, 3, 2)
        cmbModules.Name = "cmbModules"
        cmbModules.Size = New Size(173, 23)
        cmbModules.TabIndex = 21
        ' 
        ' cmbClimateScenario
        ' 
        cmbClimateScenario.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbClimateScenario.FormattingEnabled = True
        cmbClimateScenario.Location = New Point(172, 183)
        cmbClimateScenario.Margin = New Padding(3, 2, 3, 2)
        cmbClimateScenario.Name = "cmbClimateScenario"
        cmbClimateScenario.Size = New Size(458, 23)
        cmbClimateScenario.TabIndex = 20
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(17, 186)
        Label12.Name = "Label12"
        Label12.Size = New Size(94, 15)
        Label12.TabIndex = 19
        Label12.Text = "Klimaatscenario:"
        ' 
        ' cmbEmployee
        ' 
        cmbEmployee.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbEmployee.FormattingEnabled = True
        cmbEmployee.Location = New Point(172, 156)
        cmbEmployee.Margin = New Padding(3, 2, 3, 2)
        cmbEmployee.Name = "cmbEmployee"
        cmbEmployee.Size = New Size(173, 23)
        cmbEmployee.TabIndex = 18
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(18, 159)
        Label10.Name = "Label10"
        Label10.Size = New Size(75, 15)
        Label10.TabIndex = 17
        Label10.Text = "Medewerker:"
        ' 
        ' btnConfigurationFile
        ' 
        btnConfigurationFile.Location = New Point(579, 50)
        btnConfigurationFile.Margin = New Padding(3, 2, 3, 2)
        btnConfigurationFile.Name = "btnConfigurationFile"
        btnConfigurationFile.Size = New Size(23, 20)
        btnConfigurationFile.TabIndex = 16
        btnConfigurationFile.Text = ".."
        btnConfigurationFile.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 80)
        Label3.Name = "Label3"
        Label3.Size = New Size(73, 15)
        Label3.TabIndex = 5
        Label3.Text = "Casenaam: *"
        ' 
        ' txtCaseName
        ' 
        txtCaseName.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtCaseName.Location = New Point(172, 77)
        txtCaseName.Margin = New Padding(3, 2, 3, 2)
        txtCaseName.Name = "txtCaseName"
        txtCaseName.Size = New Size(459, 23)
        txtCaseName.TabIndex = 6
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(cmbConsultant)
        GroupBox2.Controls.Add(Label16)
        GroupBox2.Controls.Add(txtSimulationPeriod)
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(Button1)
        GroupBox2.Controls.Add(btnConfigurationFile)
        GroupBox2.Controls.Add(Label10)
        GroupBox2.Controls.Add(txtConfigurationFile)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(cmbEmployee)
        GroupBox2.Controls.Add(pckCreateDate)
        GroupBox2.Controls.Add(Label14)
        GroupBox2.Controls.Add(cmbModelCase)
        GroupBox2.Controls.Add(txtDescription)
        GroupBox2.Controls.Add(btnAdd)
        GroupBox2.Controls.Add(Label15)
        GroupBox2.Controls.Add(cmbProjectmodel)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(cmbEnvironmentalScenario)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(cmbClimateScenario)
        GroupBox2.Controls.Add(Label12)
        GroupBox2.Controls.Add(Label11)
        GroupBox2.Controls.Add(Label13)
        GroupBox2.Controls.Add(txtDesignScenario)
        GroupBox2.Controls.Add(cmbModules)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Controls.Add(txtVersion)
        GroupBox2.Controls.Add(txtCaseName)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Location = New Point(511, 9)
        GroupBox2.Margin = New Padding(3, 2, 3, 2)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(3, 2, 3, 2)
        GroupBox2.Size = New Size(643, 448)
        GroupBox2.TabIndex = 2
        GroupBox2.TabStop = False
        GroupBox2.Text = "Modelcase toevoegen"
        ' 
        ' cmbConsultant
        ' 
        cmbConsultant.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbConsultant.FormattingEnabled = True
        cmbConsultant.Location = New Point(459, 156)
        cmbConsultant.Margin = New Padding(3, 2, 3, 2)
        cmbConsultant.Name = "cmbConsultant"
        cmbConsultant.Size = New Size(172, 23)
        cmbConsultant.TabIndex = 21
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(351, 159)
        Label16.Name = "Label16"
        Label16.Size = New Size(102, 15)
        Label16.TabIndex = 33
        Label16.Text = "Ingenieursbureau:"
        ' 
        ' txtSimulationPeriod
        ' 
        txtSimulationPeriod.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtSimulationPeriod.Location = New Point(172, 264)
        txtSimulationPeriod.Margin = New Padding(3, 2, 3, 2)
        txtSimulationPeriod.Name = "txtSimulationPeriod"
        txtSimulationPeriod.Size = New Size(459, 23)
        txtSimulationPeriod.TabIndex = 32
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(17, 267)
        Label1.Name = "Label1"
        Label1.Size = New Size(99, 15)
        Label1.TabIndex = 31
        Label1.Text = "Simulatieperiode:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(15, 422)
        Label7.Name = "Label7"
        Label7.Size = New Size(147, 15)
        Label7.TabIndex = 30
        Label7.Text = "Velden met * zijn verplicht."
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Gold
        Button1.Location = New Point(607, 50)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(23, 20)
        Button1.TabIndex = 29
        Button1.Text = "?"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' txtConfigurationFile
        ' 
        txtConfigurationFile.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtConfigurationFile.Location = New Point(172, 50)
        txtConfigurationFile.Margin = New Padding(3, 2, 3, 2)
        txtConfigurationFile.Name = "txtConfigurationFile"
        txtConfigurationFile.Size = New Size(403, 23)
        txtConfigurationFile.TabIndex = 12
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(12, 52)
        Label6.Name = "Label6"
        Label6.Size = New Size(126, 15)
        Label6.TabIndex = 11
        Label6.Text = "Configuratiebestand: *"
        ' 
        ' cmbModelCase
        ' 
        cmbModelCase.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbModelCase.FormattingEnabled = True
        cmbModelCase.Location = New Point(172, 102)
        cmbModelCase.Margin = New Padding(3, 2, 3, 2)
        cmbModelCase.Name = "cmbModelCase"
        cmbModelCase.Size = New Size(459, 23)
        cmbModelCase.TabIndex = 28
        ' 
        ' txtDescription
        ' 
        txtDescription.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtDescription.Location = New Point(172, 318)
        txtDescription.Margin = New Padding(3, 2, 3, 2)
        txtDescription.Multiline = True
        txtDescription.Name = "txtDescription"
        txtDescription.Size = New Size(459, 70)
        txtDescription.TabIndex = 25
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(18, 321)
        Label15.Name = "Label15"
        Label15.Size = New Size(81, 15)
        Label15.TabIndex = 24
        Label15.Text = "Omschrijving:"
        ' 
        ' cmbEnvironmentalScenario
        ' 
        cmbEnvironmentalScenario.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbEnvironmentalScenario.FormattingEnabled = True
        cmbEnvironmentalScenario.Location = New Point(172, 210)
        cmbEnvironmentalScenario.Margin = New Padding(3, 2, 3, 2)
        cmbEnvironmentalScenario.Name = "cmbEnvironmentalScenario"
        cmbEnvironmentalScenario.Size = New Size(459, 23)
        cmbEnvironmentalScenario.TabIndex = 23
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(17, 212)
        Label2.Name = "Label2"
        Label2.Size = New Size(115, 15)
        Label2.TabIndex = 17
        Label2.Text = "Omgevingsscenario:"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(17, 239)
        Label11.Name = "Label11"
        Label11.Size = New Size(92, 15)
        Label11.TabIndex = 16
        Label11.Text = "Ontwerpvariant:"
        ' 
        ' txtDesignScenario
        ' 
        txtDesignScenario.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtDesignScenario.Location = New Point(172, 237)
        txtDesignScenario.Margin = New Padding(3, 2, 3, 2)
        txtDesignScenario.Name = "txtDesignScenario"
        txtDesignScenario.Size = New Size(459, 23)
        txtDesignScenario.TabIndex = 15
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(349, 131)
        Label8.Name = "Label8"
        Label8.Size = New Size(83, 15)
        Label8.TabIndex = 10
        Label8.Text = "Versie (x.x.x) *:"
        ' 
        ' txtVersion
        ' 
        txtVersion.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtVersion.Location = New Point(459, 129)
        txtVersion.Margin = New Padding(3, 2, 3, 2)
        txtVersion.Name = "txtVersion"
        txtVersion.Size = New Size(171, 23)
        txtVersion.TabIndex = 9
        ' 
        ' dlgOpenFile
        ' 
        dlgOpenFile.FileName = "OpenFileDialog1"
        ' 
        ' frmAddModelCase
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1165, 466)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 2, 3, 2)
        Name = "frmAddModelCase"
        Text = "Modelcase toevoegen"
        GroupBox1.ResumeLayout(False)
        CType(grdModelCases, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtCaseName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmbEmployee As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnConfigurationFile As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents txtVersion As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtDesignScenario As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents cmbModules As ComboBox
    Friend WithEvents cmbClimateScenario As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents cmbEnvironmentalScenario As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbProjectmodel As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbModelCase As ComboBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents pckCreateDate As DateTimePicker
    Friend WithEvents Label14 As Label
    Friend WithEvents grdModelCases As DataGridView
    Friend WithEvents dlgOpenFile As OpenFileDialog
    Friend WithEvents colModelCaseName As DataGridViewTextBoxColumn
    Friend WithEvents colModules As DataGridViewTextBoxColumn
    Friend WithEvents colVersion As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtConfigurationFile As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtSimulationPeriod As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbConsultant As ComboBox
    Friend WithEvents Label16 As Label
End Class
