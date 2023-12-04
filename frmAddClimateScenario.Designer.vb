<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddClimateScenario
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmAddClimateScenario))
        GroupBox1 = New GroupBox()
        grdClimateScenarios = New DataGridView()
        colScenarioName = New DataGridViewTextBoxColumn()
        GroupBox2 = New GroupBox()
        btnAdd = New Button()
        txtClimateScenario = New TextBox()
        Label4 = New Label()
        txtZichtjaar = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        txtPublicationYear = New TextBox()
        txtClimateScenarioName = New TextBox()
        Label1 = New Label()
        Label5 = New Label()
        GroupBox1.SuspendLayout()
        CType(grdClimateScenarios, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(grdClimateScenarios)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(444, 426)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Reeds in de database"
        ' 
        ' grdClimateScenarios
        ' 
        grdClimateScenarios.AllowUserToAddRows = False
        grdClimateScenarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        grdClimateScenarios.Columns.AddRange(New DataGridViewColumn() {colScenarioName})
        grdClimateScenarios.Location = New Point(20, 41)
        grdClimateScenarios.Name = "grdClimateScenarios"
        grdClimateScenarios.RowHeadersVisible = False
        grdClimateScenarios.RowHeadersWidth = 51
        grdClimateScenarios.RowTemplate.Height = 29
        grdClimateScenarios.Size = New Size(408, 367)
        grdClimateScenarios.TabIndex = 0
        ' 
        ' colScenarioName
        ' 
        colScenarioName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        colScenarioName.HeaderText = "Scenarionaam"
        colScenarioName.MinimumWidth = 6
        colScenarioName.Name = "colScenarioName"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(btnAdd)
        GroupBox2.Controls.Add(txtClimateScenario)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(txtZichtjaar)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(txtPublicationYear)
        GroupBox2.Controls.Add(txtClimateScenarioName)
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Location = New Point(462, 12)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(326, 426)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Klimaatscenario toevoegen"
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(226, 363)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(94, 45)
        btnAdd.TabIndex = 8
        btnAdd.Text = "Toevoegen"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' txtClimateScenario
        ' 
        txtClimateScenario.Location = New Point(130, 148)
        txtClimateScenario.Name = "txtClimateScenario"
        txtClimateScenario.Size = New Size(190, 27)
        txtClimateScenario.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(22, 151)
        Label4.Name = "Label4"
        Label4.Size = New Size(58, 20)
        Label4.TabIndex = 6
        Label4.Text = "Variant:"
        ' 
        ' txtZichtjaar
        ' 
        txtZichtjaar.Location = New Point(130, 110)
        txtZichtjaar.Name = "txtZichtjaar"
        txtZichtjaar.Size = New Size(190, 27)
        txtZichtjaar.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(22, 113)
        Label3.Name = "Label3"
        Label3.Size = New Size(80, 20)
        Label3.TabIndex = 4
        Label3.Text = "Zichtjaar: *"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(22, 77)
        Label2.Name = "Label2"
        Label2.Size = New Size(102, 20)
        Label2.TabIndex = 3
        Label2.Text = "Publicatiejaar:"
        ' 
        ' txtPublicationYear
        ' 
        txtPublicationYear.Location = New Point(130, 74)
        txtPublicationYear.Name = "txtPublicationYear"
        txtPublicationYear.Size = New Size(190, 27)
        txtPublicationYear.TabIndex = 2
        ' 
        ' txtClimateScenarioName
        ' 
        txtClimateScenarioName.Location = New Point(130, 41)
        txtClimateScenarioName.Name = "txtClimateScenarioName"
        txtClimateScenarioName.Size = New Size(190, 27)
        txtClimateScenarioName.TabIndex = 1
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
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(22, 388)
        Label5.Name = "Label5"
        Label5.Size = New Size(182, 20)
        Label5.TabIndex = 9
        Label5.Text = "Velden met * zijn verplicht"
        ' 
        ' frmAddClimateScenario
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmAddClimateScenario"
        Text = "Klimaatscenario toevoegen"
        GroupBox1.ResumeLayout(False)
        CType(grdClimateScenarios, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents grdClimateScenarios As DataGridView
    Friend WithEvents colScenarioName As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtZichtjaar As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPublicationYear As TextBox
    Friend WithEvents txtClimateScenarioName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtClimateScenario As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
