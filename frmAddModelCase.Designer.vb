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
        cmbModelProject = New ComboBox()
        Label1 = New Label()
        pckCreateDate = New DateTimePicker()
        Label14 = New Label()
        cmbParentCase = New ComboBox()
        Label9 = New Label()
        cmbParentProject = New ComboBox()
        Label4 = New Label()
        Label13 = New Label()
        cmbModules = New ComboBox()
        cmbClimateScenario = New ComboBox()
        Label12 = New Label()
        cmbEmployee = New ComboBox()
        Label10 = New Label()
        btnConfigurationFile = New Button()
        txtConfigurationFile = New TextBox()
        Label6 = New Label()
        Label3 = New Label()
        txtCaseName = New TextBox()
        GroupBox2 = New GroupBox()
        Button1 = New Button()
        cmbModelCase = New ComboBox()
        txtDescription = New TextBox()
        Label15 = New Label()
        cmbEnvironmentalScenario = New ComboBox()
        Label2 = New Label()
        Label11 = New Label()
        txtDesignScenario = New TextBox()
        Label8 = New Label()
        txtVersion = New TextBox()
        txtSimulationPeriod = New TextBox()
        Label5 = New Label()
        dlgOpenFile = New OpenFileDialog()
        Label7 = New Label()
        GroupBox1.SuspendLayout()
        CType(grdModelCases, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(603, 523)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(117, 59)
        btnAdd.TabIndex = 0
        btnAdd.Text = "Toevoegen"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(grdModelCases)
        GroupBox1.Controls.Add(cmbModelProject)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(566, 597)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Reeds in de database"
        ' 
        ' grdModelCases
        ' 
        grdModelCases.AllowUserToAddRows = False
        grdModelCases.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        grdModelCases.Columns.AddRange(New DataGridViewColumn() {colModelCaseName, colModules, colVersion})
        grdModelCases.Location = New Point(20, 81)
        grdModelCases.Name = "grdModelCases"
        grdModelCases.RowHeadersVisible = False
        grdModelCases.RowHeadersWidth = 51
        grdModelCases.RowTemplate.Height = 29
        grdModelCases.Size = New Size(522, 501)
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
        ' cmbModelProject
        ' 
        cmbModelProject.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbModelProject.FormattingEnabled = True
        cmbModelProject.Location = New Point(176, 26)
        cmbModelProject.Name = "cmbModelProject"
        cmbModelProject.Size = New Size(366, 28)
        cmbModelProject.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(20, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(99, 20)
        Label1.TabIndex = 0
        Label1.Text = "Modelproject"
        ' 
        ' pckCreateDate
        ' 
        pckCreateDate.Location = New Point(196, 378)
        pckCreateDate.Name = "pckCreateDate"
        pckCreateDate.Size = New Size(524, 27)
        pckCreateDate.TabIndex = 28
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(19, 383)
        Label14.Name = "Label14"
        Label14.Size = New Size(117, 20)
        Label14.TabIndex = 27
        Label14.Text = "Aanmaakdatum:"
        ' 
        ' cmbParentCase
        ' 
        cmbParentCase.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbParentCase.FormattingEnabled = True
        cmbParentCase.Location = New Point(196, 344)
        cmbParentCase.Name = "cmbParentCase"
        cmbParentCase.Size = New Size(524, 28)
        cmbParentCase.TabIndex = 26
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(19, 347)
        Label9.Name = "Label9"
        Label9.Size = New Size(74, 20)
        Label9.TabIndex = 25
        Label9.Text = "Basiscase:"
        ' 
        ' cmbParentProject
        ' 
        cmbParentProject.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbParentProject.FormattingEnabled = True
        cmbParentProject.Location = New Point(196, 310)
        cmbParentProject.Name = "cmbParentProject"
        cmbParentProject.Size = New Size(524, 28)
        cmbParentProject.TabIndex = 24
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(19, 313)
        Label4.Name = "Label4"
        Label4.Size = New Size(92, 20)
        Label4.TabIndex = 23
        Label4.Text = "Basisproject:"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(19, 137)
        Label13.Name = "Label13"
        Label13.Size = New Size(79, 20)
        Label13.TabIndex = 22
        Label13.Text = "Modules: *"
        ' 
        ' cmbModules
        ' 
        cmbModules.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbModules.FormattingEnabled = True
        cmbModules.Location = New Point(196, 137)
        cmbModules.Name = "cmbModules"
        cmbModules.Size = New Size(197, 28)
        cmbModules.TabIndex = 21
        ' 
        ' cmbClimateScenario
        ' 
        cmbClimateScenario.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbClimateScenario.FormattingEnabled = True
        cmbClimateScenario.Location = New Point(196, 206)
        cmbClimateScenario.Name = "cmbClimateScenario"
        cmbClimateScenario.Size = New Size(197, 28)
        cmbClimateScenario.TabIndex = 20
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(19, 209)
        Label12.Name = "Label12"
        Label12.Size = New Size(118, 20)
        Label12.TabIndex = 19
        Label12.Text = "Klimaatscenario:"
        ' 
        ' cmbEmployee
        ' 
        cmbEmployee.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbEmployee.FormattingEnabled = True
        cmbEmployee.Location = New Point(508, 205)
        cmbEmployee.Name = "cmbEmployee"
        cmbEmployee.Size = New Size(212, 28)
        cmbEmployee.TabIndex = 18
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(399, 209)
        Label10.Name = "Label10"
        Label10.Size = New Size(94, 20)
        Label10.TabIndex = 17
        Label10.Text = "Medewerker:"
        ' 
        ' btnConfigurationFile
        ' 
        btnConfigurationFile.Location = New Point(662, 37)
        btnConfigurationFile.Name = "btnConfigurationFile"
        btnConfigurationFile.Size = New Size(26, 27)
        btnConfigurationFile.TabIndex = 16
        btnConfigurationFile.Text = ".."
        btnConfigurationFile.UseVisualStyleBackColor = True
        ' 
        ' txtConfigurationFile
        ' 
        txtConfigurationFile.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtConfigurationFile.Location = New Point(196, 37)
        txtConfigurationFile.Name = "txtConfigurationFile"
        txtConfigurationFile.Size = New Size(460, 27)
        txtConfigurationFile.TabIndex = 12
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(14, 40)
        Label6.Name = "Label6"
        Label6.Size = New Size(157, 20)
        Label6.TabIndex = 11
        Label6.Text = "Configuratiebestand: *"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(17, 70)
        Label3.Name = "Label3"
        Label3.Size = New Size(90, 20)
        Label3.TabIndex = 5
        Label3.Text = "Casenaam: *"
        ' 
        ' txtCaseName
        ' 
        txtCaseName.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtCaseName.Location = New Point(196, 70)
        txtCaseName.Name = "txtCaseName"
        txtCaseName.Size = New Size(524, 27)
        txtCaseName.TabIndex = 6
        ' 
        ' GroupBox2
        ' 
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
        GroupBox2.Controls.Add(Label9)
        GroupBox2.Controls.Add(cmbParentCase)
        GroupBox2.Controls.Add(btnAdd)
        GroupBox2.Controls.Add(Label15)
        GroupBox2.Controls.Add(cmbParentProject)
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
        GroupBox2.Controls.Add(txtSimulationPeriod)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Location = New Point(584, 12)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(735, 597)
        GroupBox2.TabIndex = 2
        GroupBox2.TabStop = False
        GroupBox2.Text = "Modelcase toevoegen"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Gold
        Button1.Location = New Point(694, 37)
        Button1.Name = "Button1"
        Button1.Size = New Size(26, 27)
        Button1.TabIndex = 29
        Button1.Text = "?"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' cmbModelCase
        ' 
        cmbModelCase.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbModelCase.FormattingEnabled = True
        cmbModelCase.Location = New Point(196, 103)
        cmbModelCase.Name = "cmbModelCase"
        cmbModelCase.Size = New Size(524, 28)
        cmbModelCase.TabIndex = 28
        ' 
        ' txtDescription
        ' 
        txtDescription.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtDescription.Location = New Point(196, 411)
        txtDescription.Multiline = True
        txtDescription.Name = "txtDescription"
        txtDescription.Size = New Size(524, 95)
        txtDescription.TabIndex = 25
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(19, 414)
        Label15.Name = "Label15"
        Label15.Size = New Size(98, 20)
        Label15.TabIndex = 24
        Label15.Text = "Omschrijving:"
        ' 
        ' cmbEnvironmentalScenario
        ' 
        cmbEnvironmentalScenario.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbEnvironmentalScenario.FormattingEnabled = True
        cmbEnvironmentalScenario.Location = New Point(196, 241)
        cmbEnvironmentalScenario.Name = "cmbEnvironmentalScenario"
        cmbEnvironmentalScenario.Size = New Size(524, 28)
        cmbEnvironmentalScenario.TabIndex = 23
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(19, 244)
        Label2.Name = "Label2"
        Label2.Size = New Size(142, 20)
        Label2.TabIndex = 17
        Label2.Text = "Omgevingsscenario:"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(19, 278)
        Label11.Name = "Label11"
        Label11.Size = New Size(114, 20)
        Label11.TabIndex = 16
        Label11.Text = "Ontwerpvariant:"
        ' 
        ' txtDesignScenario
        ' 
        txtDesignScenario.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtDesignScenario.Location = New Point(196, 275)
        txtDesignScenario.Name = "txtDesignScenario"
        txtDesignScenario.Size = New Size(524, 27)
        txtDesignScenario.TabIndex = 15
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(399, 141)
        Label8.Name = "Label8"
        Label8.Size = New Size(106, 20)
        Label8.TabIndex = 10
        Label8.Text = "Versienummer:"
        ' 
        ' txtVersion
        ' 
        txtVersion.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtVersion.Location = New Point(508, 138)
        txtVersion.Name = "txtVersion"
        txtVersion.Size = New Size(212, 27)
        txtVersion.TabIndex = 9
        ' 
        ' txtSimulationPeriod
        ' 
        txtSimulationPeriod.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtSimulationPeriod.Location = New Point(196, 171)
        txtSimulationPeriod.Name = "txtSimulationPeriod"
        txtSimulationPeriod.Size = New Size(524, 27)
        txtSimulationPeriod.TabIndex = 14
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(19, 175)
        Label5.Name = "Label5"
        Label5.Size = New Size(126, 20)
        Label5.TabIndex = 13
        Label5.Text = "Simulatieperiode:"
        ' 
        ' dlgOpenFile
        ' 
        dlgOpenFile.FileName = "OpenFileDialog1"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(17, 562)
        Label7.Name = "Label7"
        Label7.Size = New Size(185, 20)
        Label7.TabIndex = 30
        Label7.Text = "Velden met * zijn verplicht."
        ' 
        ' frmAddModelCase
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1331, 621)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmAddModelCase"
        Text = "Modelcase toevoegen"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(grdModelCases, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCaseName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbModelProject As ComboBox
    Friend WithEvents txtSimulationPeriod As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtConfigurationFile As TextBox
    Friend WithEvents Label6 As Label
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
    Friend WithEvents cmbParentProject As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbParentCase As ComboBox
    Friend WithEvents Label9 As Label
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
End Class
