<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddConsultancyFirm
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmAddConsultancyFirm))
        GroupBox1 = New GroupBox()
        grdEngineeringFirms = New DataGridView()
        colNaam = New DataGridViewTextBoxColumn()
        GroupBox2 = New GroupBox()
        btnAdd = New Button()
        Label2 = New Label()
        Label1 = New Label()
        txtName = New TextBox()
        GroupBox1.SuspendLayout()
        CType(grdEngineeringFirms, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(grdEngineeringFirms)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(441, 426)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Reeds in de database"
        ' 
        ' grdEngineeringFirms
        ' 
        grdEngineeringFirms.AllowUserToAddRows = False
        grdEngineeringFirms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        grdEngineeringFirms.Columns.AddRange(New DataGridViewColumn() {colNaam})
        grdEngineeringFirms.Location = New Point(15, 32)
        grdEngineeringFirms.Name = "grdEngineeringFirms"
        grdEngineeringFirms.RowHeadersVisible = False
        grdEngineeringFirms.RowHeadersWidth = 51
        grdEngineeringFirms.RowTemplate.Height = 29
        grdEngineeringFirms.Size = New Size(407, 372)
        grdEngineeringFirms.TabIndex = 0
        ' 
        ' colNaam
        ' 
        colNaam.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        colNaam.HeaderText = "Naam"
        colNaam.MinimumWidth = 6
        colNaam.Name = "colNaam"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(btnAdd)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Controls.Add(txtName)
        GroupBox2.Location = New Point(459, 12)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(329, 426)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Ingenieursbureau toevoegen"
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(218, 369)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(105, 50)
        btnAdd.TabIndex = 3
        btnAdd.Text = "Toevoegen"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(16, 393)
        Label2.Name = "Label2"
        Label2.Size = New Size(182, 20)
        Label2.TabIndex = 2
        Label2.Text = "Velden met * zijn verplicht"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(16, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(62, 20)
        Label1.TabIndex = 1
        Label1.Text = "Naam: *"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(99, 32)
        txtName.Name = "txtName"
        txtName.Size = New Size(224, 27)
        txtName.TabIndex = 0
        ' 
        ' frmAddConsultancyFirm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmAddConsultancyFirm"
        Text = "Ingenieursbureau toevoegen"
        GroupBox1.ResumeLayout(False)
        CType(grdEngineeringFirms, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents grdEngineeringFirms As DataGridView
    Friend WithEvents colNaam As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As TextBox
End Class
