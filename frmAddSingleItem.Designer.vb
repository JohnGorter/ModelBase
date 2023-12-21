<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddSingleItem
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmAddSingleItem))
        GroupBox1 = New GroupBox()
        grdItems = New DataGridView()
        colNaam = New DataGridViewTextBoxColumn()
        grbAdd = New GroupBox()
        btnAdd = New Button()
        Label2 = New Label()
        Label1 = New Label()
        txtName = New TextBox()
        GroupBox1.SuspendLayout()
        CType(grdItems, ComponentModel.ISupportInitialize).BeginInit()
        grbAdd.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(grdItems)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(441, 426)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Reeds in de database"
        ' 
        ' grdItems
        ' 
        grdItems.AllowUserToAddRows = False
        grdItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        grdItems.Columns.AddRange(New DataGridViewColumn() {colNaam})
        grdItems.Location = New Point(15, 32)
        grdItems.Name = "grdItems"
        grdItems.RowHeadersVisible = False
        grdItems.RowHeadersWidth = 51
        grdItems.RowTemplate.Height = 29
        grdItems.Size = New Size(407, 372)
        grdItems.TabIndex = 0
        ' 
        ' colNaam
        ' 
        colNaam.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        colNaam.HeaderText = "Naam"
        colNaam.MinimumWidth = 6
        colNaam.Name = "colNaam"
        ' 
        ' grbAdd
        ' 
        grbAdd.Controls.Add(btnAdd)
        grbAdd.Controls.Add(Label2)
        grbAdd.Controls.Add(Label1)
        grbAdd.Controls.Add(txtName)
        grbAdd.Location = New Point(459, 12)
        grbAdd.Name = "grbAdd"
        grbAdd.Size = New Size(329, 426)
        grbAdd.TabIndex = 1
        grbAdd.TabStop = False
        grbAdd.Text = "Toevoegen"
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
        ' frmAddSingleItem
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(grbAdd)
        Controls.Add(GroupBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmAddSingleItem"
        Text = "Ingenieursbureau toevoegen"
        GroupBox1.ResumeLayout(False)
        CType(grdItems, ComponentModel.ISupportInitialize).EndInit()
        grbAdd.ResumeLayout(False)
        grbAdd.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents grdItems As DataGridView
    Friend WithEvents colNaam As DataGridViewTextBoxColumn
    Friend WithEvents grbAdd As GroupBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As TextBox
End Class
