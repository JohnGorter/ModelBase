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
        colCatchmentName = New DataGridViewTextBoxColumn()
        colCatchmentNumber = New DataGridViewTextBoxColumn()
        colCatchmentAbbreviation = New DataGridViewTextBoxColumn()
        GroupBox2 = New GroupBox()
        btnAdd = New Button()
        txtCatchmentShort = New TextBox()
        Label3 = New Label()
        txtCatchmentNumber = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        txtCatchmentName = New TextBox()
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
        grdCatchments.Columns.AddRange(New DataGridViewColumn() {colCatchmentName, colCatchmentNumber, colCatchmentAbbreviation})
        grdCatchments.Location = New Point(16, 37)
        grdCatchments.Name = "grdCatchments"
        grdCatchments.RowHeadersVisible = False
        grdCatchments.RowHeadersWidth = 51
        grdCatchments.RowTemplate.Height = 29
        grdCatchments.Size = New Size(422, 369)
        grdCatchments.TabIndex = 0
        ' 
        ' colCatchmentName
        ' 
        colCatchmentName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        colCatchmentName.HeaderText = "Naam"
        colCatchmentName.MinimumWidth = 6
        colCatchmentName.Name = "colCatchmentName"
        ' 
        ' colCatchmentNumber
        ' 
        colCatchmentNumber.HeaderText = "Nummer"
        colCatchmentNumber.MinimumWidth = 6
        colCatchmentNumber.Name = "colCatchmentNumber"
        colCatchmentNumber.Width = 80
        ' 
        ' colCatchmentAbbreviation
        ' 
        colCatchmentAbbreviation.HeaderText = "Afkorting"
        colCatchmentAbbreviation.MinimumWidth = 6
        colCatchmentAbbreviation.Name = "colCatchmentAbbreviation"
        colCatchmentAbbreviation.Width = 80
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(btnAdd)
        GroupBox2.Controls.Add(txtCatchmentShort)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(txtCatchmentNumber)
        GroupBox2.Controls.Add(Label2)
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
        btnAdd.Location = New Point(201, 359)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(100, 47)
        btnAdd.TabIndex = 6
        btnAdd.Text = "Toevoegen"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' txtCatchmentShort
        ' 
        txtCatchmentShort.Location = New Point(91, 103)
        txtCatchmentShort.Name = "txtCatchmentShort"
        txtCatchmentShort.Size = New Size(210, 27)
        txtCatchmentShort.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(15, 106)
        Label3.Name = "Label3"
        Label3.Size = New Size(74, 20)
        Label3.TabIndex = 4
        Label3.Text = "Afkorting:"
        ' 
        ' txtCatchmentNumber
        ' 
        txtCatchmentNumber.Location = New Point(91, 70)
        txtCatchmentNumber.Name = "txtCatchmentNumber"
        txtCatchmentNumber.Size = New Size(210, 27)
        txtCatchmentNumber.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(15, 73)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 20)
        Label2.TabIndex = 2
        Label2.Text = "Nummer:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(15, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(52, 20)
        Label1.TabIndex = 1
        Label1.Text = "Naam:"
        ' 
        ' txtCatchmentName
        ' 
        txtCatchmentName.Location = New Point(91, 37)
        txtCatchmentName.Name = "txtCatchmentName"
        txtCatchmentName.Size = New Size(210, 27)
        txtCatchmentName.TabIndex = 0
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
    Friend WithEvents colCatchmentName As DataGridViewTextBoxColumn
    Friend WithEvents colCatchmentNumber As DataGridViewTextBoxColumn
    Friend WithEvents colCatchmentAbbreviation As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCatchmentName As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtCatchmentShort As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCatchmentNumber As TextBox
    Friend WithEvents Label2 As Label
End Class
