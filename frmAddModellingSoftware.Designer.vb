<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddModellingSoftware
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmAddModellingSoftware))
        GroupBox1 = New GroupBox()
        grdModellingSoftware = New DataGridView()
        colName = New DataGridViewTextBoxColumn()
        colMaker = New DataGridViewTextBoxColumn()
        GroupBox2 = New GroupBox()
        btnAdd = New Button()
        Label2 = New Label()
        txtMaker = New TextBox()
        Label1 = New Label()
        txtModellingSoftware = New TextBox()
        GroupBox1.SuspendLayout()
        CType(grdModellingSoftware, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(grdModellingSoftware)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(418, 426)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Reeds in de database"
        ' 
        ' grdModellingSoftware
        ' 
        grdModellingSoftware.AllowUserToAddRows = False
        grdModellingSoftware.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        grdModellingSoftware.Columns.AddRange(New DataGridViewColumn() {colName, colMaker})
        grdModellingSoftware.Location = New Point(16, 35)
        grdModellingSoftware.Name = "grdModellingSoftware"
        grdModellingSoftware.RowHeadersVisible = False
        grdModellingSoftware.RowHeadersWidth = 51
        grdModellingSoftware.RowTemplate.Height = 29
        grdModellingSoftware.Size = New Size(385, 372)
        grdModellingSoftware.TabIndex = 0
        ' 
        ' colName
        ' 
        colName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        colName.HeaderText = "Naam"
        colName.MinimumWidth = 6
        colName.Name = "colName"
        ' 
        ' colMaker
        ' 
        colMaker.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        colMaker.HeaderText = "Maker"
        colMaker.MinimumWidth = 6
        colMaker.Name = "colMaker"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(btnAdd)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(txtMaker)
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Controls.Add(txtModellingSoftware)
        GroupBox2.Location = New Point(436, 12)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(352, 426)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Modelleersoftware toevoegen"
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(247, 359)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(99, 48)
        btnAdd.TabIndex = 4
        btnAdd.Text = "Toevoegen"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(17, 71)
        Label2.Name = "Label2"
        Label2.Size = New Size(53, 20)
        Label2.TabIndex = 3
        Label2.Text = "Maker:"
        ' 
        ' txtMaker
        ' 
        txtMaker.Location = New Point(135, 68)
        txtMaker.Name = "txtMaker"
        txtMaker.Size = New Size(211, 27)
        txtMaker.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(17, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(108, 20)
        Label1.TabIndex = 1
        Label1.Text = "Naam product:"
        ' 
        ' txtModellingSoftware
        ' 
        txtModellingSoftware.Location = New Point(135, 35)
        txtModellingSoftware.Name = "txtModellingSoftware"
        txtModellingSoftware.Size = New Size(211, 27)
        txtModellingSoftware.TabIndex = 0
        ' 
        ' frmAddModellingSoftware
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmAddModellingSoftware"
        Text = "Modelleersoftware toevoegen"
        GroupBox1.ResumeLayout(False)
        CType(grdModellingSoftware, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents grdModellingSoftware As DataGridView
    Friend WithEvents colName As DataGridViewTextBoxColumn
    Friend WithEvents colMaker As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMaker As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtModellingSoftware As TextBox
    Friend WithEvents btnAdd As Button
End Class
