<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEmployee
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmAddEmployee))
        btnAddEmployee = New Button()
        GroupBox1 = New GroupBox()
        grdEmployees = New DataGridView()
        colMedewerker = New DataGridViewTextBoxColumn()
        GroupBox2 = New GroupBox()
        Label1 = New Label()
        txtName = New TextBox()
        GroupBox1.SuspendLayout()
        CType(grdEmployees, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnAddEmployee
        ' 
        btnAddEmployee.Location = New Point(226, 369)
        btnAddEmployee.Name = "btnAddEmployee"
        btnAddEmployee.Size = New Size(110, 51)
        btnAddEmployee.TabIndex = 0
        btnAddEmployee.Text = "Toevoegen"
        btnAddEmployee.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(grdEmployees)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(428, 426)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Reeds in de database"
        ' 
        ' grdEmployees
        ' 
        grdEmployees.AllowUserToAddRows = False
        grdEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        grdEmployees.Columns.AddRange(New DataGridViewColumn() {colMedewerker})
        grdEmployees.Location = New Point(21, 41)
        grdEmployees.Name = "grdEmployees"
        grdEmployees.RowHeadersVisible = False
        grdEmployees.RowHeadersWidth = 51
        grdEmployees.RowTemplate.Height = 29
        grdEmployees.Size = New Size(390, 368)
        grdEmployees.TabIndex = 0
        ' 
        ' colMedewerker
        ' 
        colMedewerker.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        colMedewerker.HeaderText = "Naam"
        colMedewerker.MinimumWidth = 6
        colMedewerker.Name = "colMedewerker"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Controls.Add(txtName)
        GroupBox2.Controls.Add(btnAddEmployee)
        GroupBox2.Location = New Point(446, 12)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(342, 426)
        GroupBox2.TabIndex = 2
        GroupBox2.TabStop = False
        GroupBox2.Text = "Medewerker toevoegen"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(16, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(52, 20)
        Label1.TabIndex = 1
        Label1.Text = "Naam:"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(75, 41)
        txtName.Name = "txtName"
        txtName.Size = New Size(247, 27)
        txtName.TabIndex = 0
        ' 
        ' frmAddEmployee
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmAddEmployee"
        Text = "Medewerker toevoegen"
        GroupBox1.ResumeLayout(False)
        CType(grdEmployees, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnAddEmployee As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents grdEmployees As DataGridView
    Friend WithEvents colMedewerker As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As TextBox
End Class
