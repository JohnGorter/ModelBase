<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddModulesCombination
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmAddModulesCombination))
        GroupBox1 = New GroupBox()
        grdModelModules = New DataGridView()
        colCombinationID = New DataGridViewTextBoxColumn()
        ColRR = New DataGridViewCheckBoxColumn()
        colFlow1D = New DataGridViewCheckBoxColumn()
        colRTC = New DataGridViewCheckBoxColumn()
        colFlow2D = New DataGridViewCheckBoxColumn()
        colWQ = New DataGridViewCheckBoxColumn()
        chkCheckedModules = New CheckedListBox()
        GroupBox2 = New GroupBox()
        btnAdd = New Button()
        GroupBox1.SuspendLayout()
        CType(grdModelModules, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(grdModelModules)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(548, 426)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Reeds in de database"
        ' 
        ' grdModelModules
        ' 
        grdModelModules.AllowUserToAddRows = False
        grdModelModules.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        grdModelModules.Columns.AddRange(New DataGridViewColumn() {colCombinationID, ColRR, colFlow1D, colRTC, colFlow2D, colWQ})
        grdModelModules.Location = New Point(18, 36)
        grdModelModules.Name = "grdModelModules"
        grdModelModules.RowHeadersVisible = False
        grdModelModules.RowHeadersWidth = 51
        grdModelModules.RowTemplate.Height = 29
        grdModelModules.Size = New Size(508, 368)
        grdModelModules.TabIndex = 0
        ' 
        ' colCombinationID
        ' 
        colCombinationID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        colCombinationID.HeaderText = "Combinatienaam"
        colCombinationID.MinimumWidth = 6
        colCombinationID.Name = "colCombinationID"
        ' 
        ' ColRR
        ' 
        ColRR.HeaderText = "RR"
        ColRR.MinimumWidth = 6
        ColRR.Name = "ColRR"
        ColRR.Width = 70
        ' 
        ' colFlow1D
        ' 
        colFlow1D.HeaderText = "Flow1D"
        colFlow1D.MinimumWidth = 6
        colFlow1D.Name = "colFlow1D"
        colFlow1D.Width = 70
        ' 
        ' colRTC
        ' 
        colRTC.HeaderText = "RTC"
        colRTC.MinimumWidth = 6
        colRTC.Name = "colRTC"
        colRTC.Width = 70
        ' 
        ' colFlow2D
        ' 
        colFlow2D.HeaderText = "Flow2D"
        colFlow2D.MinimumWidth = 6
        colFlow2D.Name = "colFlow2D"
        colFlow2D.Width = 70
        ' 
        ' colWQ
        ' 
        colWQ.HeaderText = "WQ"
        colWQ.MinimumWidth = 6
        colWQ.Name = "colWQ"
        colWQ.Width = 70
        ' 
        ' chkCheckedModules
        ' 
        chkCheckedModules.FormattingEnabled = True
        chkCheckedModules.Items.AddRange(New Object() {"RR", "Flow1D", "RTC", "Flow2D", "WQ"})
        chkCheckedModules.Location = New Point(20, 36)
        chkCheckedModules.Name = "chkCheckedModules"
        chkCheckedModules.Size = New Size(365, 158)
        chkCheckedModules.TabIndex = 7
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(btnAdd)
        GroupBox2.Controls.Add(chkCheckedModules)
        GroupBox2.Location = New Point(566, 12)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(405, 426)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Combinatie van modules toevoegen"
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(291, 363)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(94, 41)
        btnAdd.TabIndex = 8
        btnAdd.Text = "Toevoegen"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' frmAddModulesCombination
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(985, 450)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmAddModulesCombination"
        Text = "Combinatie van modules toevoegen"
        GroupBox1.ResumeLayout(False)
        CType(grdModelModules, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents grdModelModules As DataGridView
    Friend WithEvents colCombinationID As DataGridViewTextBoxColumn
    Friend WithEvents ColRR As DataGridViewCheckBoxColumn
    Friend WithEvents colFlow1D As DataGridViewCheckBoxColumn
    Friend WithEvents colRTC As DataGridViewCheckBoxColumn
    Friend WithEvents colFlow2D As DataGridViewCheckBoxColumn
    Friend WithEvents colWQ As DataGridViewCheckBoxColumn
    Friend WithEvents chkCheckedModules As CheckedListBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnAdd As Button
End Class
