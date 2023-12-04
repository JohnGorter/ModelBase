<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddProject
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmAddProject))
        GroupBox1 = New GroupBox()
        grdProjects = New DataGridView()
        colProjectName = New DataGridViewTextBoxColumn()
        colProjectNumber = New DataGridViewTextBoxColumn()
        colIngenieursbureau = New DataGridViewTextBoxColumn()
        colMedewerker = New DataGridViewTextBoxColumn()
        GroupBox2 = New GroupBox()
        cmbMedewerker = New ComboBox()
        Label3 = New Label()
        Label2 = New Label()
        txtProjectNumber = New TextBox()
        Label1 = New Label()
        lblName = New Label()
        txtProjectName = New TextBox()
        btnAdd = New Button()
        cmbConsultancyFirm = New ComboBox()
        Label4 = New Label()
        GroupBox1.SuspendLayout()
        CType(grdProjects, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(grdProjects)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(847, 426)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Reeds in de database"
        ' 
        ' grdProjects
        ' 
        grdProjects.AllowUserToAddRows = False
        grdProjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        grdProjects.Columns.AddRange(New DataGridViewColumn() {colProjectName, colProjectNumber, colIngenieursbureau, colMedewerker})
        grdProjects.Location = New Point(20, 36)
        grdProjects.Name = "grdProjects"
        grdProjects.RowHeadersVisible = False
        grdProjects.RowHeadersWidth = 51
        grdProjects.RowTemplate.Height = 29
        grdProjects.Size = New Size(803, 372)
        grdProjects.TabIndex = 0
        ' 
        ' colProjectName
        ' 
        colProjectName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        colProjectName.HeaderText = "Titel"
        colProjectName.MinimumWidth = 6
        colProjectName.Name = "colProjectName"
        ' 
        ' colProjectNumber
        ' 
        colProjectNumber.HeaderText = "Nummer"
        colProjectNumber.MinimumWidth = 6
        colProjectNumber.Name = "colProjectNumber"
        colProjectNumber.Width = 125
        ' 
        ' colIngenieursbureau
        ' 
        colIngenieursbureau.HeaderText = "Adviesbureau"
        colIngenieursbureau.MinimumWidth = 6
        colIngenieursbureau.Name = "colIngenieursbureau"
        colIngenieursbureau.Width = 125
        ' 
        ' colMedewerker
        ' 
        colMedewerker.HeaderText = "Medewerker"
        colMedewerker.MinimumWidth = 6
        colMedewerker.Name = "colMedewerker"
        colMedewerker.Resizable = DataGridViewTriState.True
        colMedewerker.SortMode = DataGridViewColumnSortMode.NotSortable
        colMedewerker.Width = 180
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(cmbConsultancyFirm)
        GroupBox2.Controls.Add(cmbMedewerker)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(txtProjectNumber)
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Controls.Add(lblName)
        GroupBox2.Controls.Add(txtProjectName)
        GroupBox2.Controls.Add(btnAdd)
        GroupBox2.Location = New Point(865, 12)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(393, 426)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Project toevoegen"
        ' 
        ' cmbMedewerker
        ' 
        cmbMedewerker.FormattingEnabled = True
        cmbMedewerker.Location = New Point(153, 69)
        cmbMedewerker.Name = "cmbMedewerker"
        cmbMedewerker.Size = New Size(234, 28)
        cmbMedewerker.TabIndex = 8
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(18, 72)
        Label3.Name = "Label3"
        Label3.Size = New Size(129, 20)
        Label3.TabIndex = 7
        Label3.Text = "Medewerker WL: *"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(18, 139)
        Label2.Name = "Label2"
        Label2.Size = New Size(102, 20)
        Label2.TabIndex = 5
        Label2.Text = "Adviesbureau:"
        ' 
        ' txtProjectNumber
        ' 
        txtProjectNumber.Location = New Point(153, 103)
        txtProjectNumber.Name = "txtProjectNumber"
        txtProjectNumber.Size = New Size(234, 27)
        txtProjectNumber.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(18, 106)
        Label1.Name = "Label1"
        Label1.Size = New Size(113, 20)
        Label1.TabIndex = 3
        Label1.Text = "Projectnummer:"
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(18, 40)
        lblName.Name = "lblName"
        lblName.Size = New Size(51, 20)
        lblName.TabIndex = 2
        lblName.Text = "Titel: *"
        ' 
        ' txtProjectName
        ' 
        txtProjectName.Location = New Point(153, 36)
        txtProjectName.Name = "txtProjectName"
        txtProjectName.Size = New Size(234, 27)
        txtProjectName.TabIndex = 1
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(293, 359)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(94, 49)
        btnAdd.TabIndex = 0
        btnAdd.Text = "Toevoegen"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' cmbConsultancyFirm
        ' 
        cmbConsultancyFirm.FormattingEnabled = True
        cmbConsultancyFirm.Location = New Point(153, 136)
        cmbConsultancyFirm.Name = "cmbConsultancyFirm"
        cmbConsultancyFirm.Size = New Size(234, 28)
        cmbConsultancyFirm.TabIndex = 9
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(18, 388)
        Label4.Name = "Label4"
        Label4.Size = New Size(182, 20)
        Label4.TabIndex = 10
        Label4.Text = "Velden met * zijn verplicht"
        ' 
        ' frmAddProject
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1270, 450)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmAddProject"
        Text = "Project toevoegen"
        GroupBox1.ResumeLayout(False)
        CType(grdProjects, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents grdProjects As DataGridView
    Friend WithEvents colProjectName As DataGridViewTextBoxColumn
    Friend WithEvents colProjectNumber As DataGridViewTextBoxColumn
    Friend WithEvents colIngenieursbureau As DataGridViewTextBoxColumn
    Friend WithEvents colMedewerker As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmbMedewerker As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtProjectNumber As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblName As Label
    Friend WithEvents txtProjectName As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbConsultancyFirm As ComboBox
End Class
