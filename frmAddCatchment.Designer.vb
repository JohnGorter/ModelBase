<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddCatchment
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmAddCatchment))
        GroupBox1 = New GroupBox()
        grdCatchments = New DataGridView()
        GroupBox2 = New GroupBox()
        btnAdd = New Button()
        txtCatchmentShort = New TextBox()
        Label3 = New Label()
        Label1 = New Label()
        txtCatchmentName = New TextBox()
        colCatchmentName = New DataGridViewTextBoxColumn()
        colCatchmentAbbreviation = New DataGridViewTextBoxColumn()
        Label2 = New Label()
        GroupBox1.SuspendLayout()
        CType(grdCatchments, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(grdCatchments)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(452, 426)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Reeds in de database"
        ' 
        ' grdCatchments
        ' 
        grdCatchments.AllowUserToAddRows = False
        grdCatchments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        grdCatchments.Columns.AddRange(New DataGridViewColumn() {colCatchmentName, colCatchmentAbbreviation})
        grdCatchments.Location = New Point(16, 37)
        grdCatchments.Name = "grdCatchments"
        grdCatchments.RowHeadersVisible = False
        grdCatchments.RowHeadersWidth = 51
        grdCatchments.RowTemplate.Height = 29
        grdCatchments.Size = New Size(422, 369)
        grdCatchments.TabIndex = 0
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(btnAdd)
        GroupBox2.Controls.Add(txtCatchmentShort)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Controls.Add(txtCatchmentName)
        GroupBox2.Location = New Point(470, 12)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(318, 426)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Stroomgebied toevoegen"
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(201, 373)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(100, 47)
        btnAdd.TabIndex = 6
        btnAdd.Text = "Toevoegen"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' txtCatchmentShort
        ' 
        txtCatchmentShort.Location = New Point(101, 70)
        txtCatchmentShort.Name = "txtCatchmentShort"
        txtCatchmentShort.Size = New Size(200, 27)
        txtCatchmentShort.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(11, 73)
        Label3.Name = "Label3"
        Label3.Size = New Size(84, 20)
        Label3.TabIndex = 4
        Label3.Text = "Afkorting: *"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(15, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(62, 20)
        Label1.TabIndex = 1
        Label1.Text = "Naam: *"
        ' 
        ' txtCatchmentName
        ' 
        txtCatchmentName.Location = New Point(101, 37)
        txtCatchmentName.Name = "txtCatchmentName"
        txtCatchmentName.Size = New Size(200, 27)
        txtCatchmentName.TabIndex = 0
        ' 
        ' colCatchmentName
        ' 
        colCatchmentName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        colCatchmentName.HeaderText = "Naam"
        colCatchmentName.MinimumWidth = 6
        colCatchmentName.Name = "colCatchmentName"
        ' 
        ' colCatchmentAbbreviation
        ' 
        colCatchmentAbbreviation.HeaderText = "Afkorting"
        colCatchmentAbbreviation.MinimumWidth = 6
        colCatchmentAbbreviation.Name = "colCatchmentAbbreviation"
        colCatchmentAbbreviation.Width = 120
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(6, 397)
        Label2.Name = "Label2"
        Label2.Size = New Size(182, 20)
        Label2.TabIndex = 7
        Label2.Text = "Velden met * zijn verplicht"
        ' 
        ' frmAddCatchment
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmAddCatchment"
        Text = "Stroomgebied toevoegen"
        GroupBox1.ResumeLayout(False)
        CType(grdCatchments, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents grdCatchments As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCatchmentName As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtCatchmentShort As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents colCatchmentName As DataGridViewTextBoxColumn
    Friend WithEvents colCatchmentAbbreviation As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
End Class
