﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEnvironmentalScenario
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmAddEnvironmentalScenario))
        GroupBox2 = New GroupBox()
        Label5 = New Label()
        btnAdd = New Button()
        txtEnvironmentalScenarioExplanation = New TextBox()
        Label4 = New Label()
        txtEnvironmentalScenarioName = New TextBox()
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        grdEnvironmentalScenarios = New DataGridView()
        colScenarioName = New DataGridViewTextBoxColumn()
        Label2 = New Label()
        Label3 = New Label()
        txtPublicationYear = New TextBox()
        txtZichtjaar = New TextBox()
        GroupBox2.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(grdEnvironmentalScenarios, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(txtZichtjaar)
        GroupBox2.Controls.Add(txtPublicationYear)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(btnAdd)
        GroupBox2.Controls.Add(txtEnvironmentalScenarioExplanation)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(txtEnvironmentalScenarioName)
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Location = New Point(462, 12)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(326, 426)
        GroupBox2.TabIndex = 3
        GroupBox2.TabStop = False
        GroupBox2.Text = "Omgevingsscenario toevoegen"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(22, 388)
        Label5.Name = "Label5"
        Label5.Size = New Size(182, 20)
        Label5.TabIndex = 9
        Label5.Text = "Velden met * zijn verplicht"
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(226, 363)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(94, 57)
        btnAdd.TabIndex = 8
        btnAdd.Text = "Toevoegen"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' txtEnvironmentalScenarioExplanation
        ' 
        txtEnvironmentalScenarioExplanation.Location = New Point(22, 178)
        txtEnvironmentalScenarioExplanation.Multiline = True
        txtEnvironmentalScenarioExplanation.Name = "txtEnvironmentalScenarioExplanation"
        txtEnvironmentalScenarioExplanation.Size = New Size(298, 179)
        txtEnvironmentalScenarioExplanation.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(22, 155)
        Label4.Name = "Label4"
        Label4.Size = New Size(98, 20)
        Label4.TabIndex = 6
        Label4.Text = "Omschrijving:"
        ' 
        ' txtEnvironmentalScenarioName
        ' 
        txtEnvironmentalScenarioName.Location = New Point(130, 41)
        txtEnvironmentalScenarioName.Name = "txtEnvironmentalScenarioName"
        txtEnvironmentalScenarioName.Size = New Size(190, 27)
        txtEnvironmentalScenarioName.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(22, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(62, 20)
        Label1.TabIndex = 0
        Label1.Text = "Naam: *"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(grdEnvironmentalScenarios)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(444, 426)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "Reeds in de database"
        ' 
        ' grdEnvironmentalScenarios
        ' 
        grdEnvironmentalScenarios.AllowUserToAddRows = False
        grdEnvironmentalScenarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        grdEnvironmentalScenarios.Columns.AddRange(New DataGridViewColumn() {colScenarioName})
        grdEnvironmentalScenarios.Location = New Point(20, 41)
        grdEnvironmentalScenarios.Name = "grdEnvironmentalScenarios"
        grdEnvironmentalScenarios.RowHeadersVisible = False
        grdEnvironmentalScenarios.RowHeadersWidth = 51
        grdEnvironmentalScenarios.RowTemplate.Height = 29
        grdEnvironmentalScenarios.Size = New Size(408, 367)
        grdEnvironmentalScenarios.TabIndex = 0
        ' 
        ' colScenarioName
        ' 
        colScenarioName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        colScenarioName.HeaderText = "Scenarionaam"
        colScenarioName.MinimumWidth = 6
        colScenarioName.Name = "colScenarioName"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(22, 78)
        Label2.Name = "Label2"
        Label2.Size = New Size(102, 20)
        Label2.TabIndex = 10
        Label2.Text = "Publicatiejaar:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(22, 110)
        Label3.Name = "Label3"
        Label3.Size = New Size(70, 20)
        Label3.TabIndex = 11
        Label3.Text = "Zichtjaar:"
        ' 
        ' txtPublicationYear
        ' 
        txtPublicationYear.Location = New Point(130, 75)
        txtPublicationYear.Name = "txtPublicationYear"
        txtPublicationYear.Size = New Size(190, 27)
        txtPublicationYear.TabIndex = 12
        ' 
        ' txtZichtjaar
        ' 
        txtZichtjaar.Location = New Point(130, 110)
        txtZichtjaar.Name = "txtZichtjaar"
        txtZichtjaar.Size = New Size(190, 27)
        txtZichtjaar.TabIndex = 13
        ' 
        ' frmAddEnvironmentalScenario
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmAddEnvironmentalScenario"
        Text = "Omgevingsscenario toevoegen"
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox1.ResumeLayout(False)
        CType(grdEnvironmentalScenarios, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtEnvironmentalScenarioExplanation As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEnvironmentalScenarioName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents grdEnvironmentalScenarios As DataGridView
    Friend WithEvents colScenarioName As DataGridViewTextBoxColumn
    Friend WithEvents txtZichtjaar As TextBox
    Friend WithEvents txtPublicationYear As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
