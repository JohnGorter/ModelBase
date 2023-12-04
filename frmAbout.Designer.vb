<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbout
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmAbout))
        Label1 = New Label()
        Label2 = New Label()
        LinkLabel1 = New LinkLabel()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(147, 111)
        Label1.Name = "Label1"
        Label1.Size = New Size(205, 20)
        Label1.TabIndex = 0
        Label1.Text = "Copyright 2023, Hydroconsult"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(20, 73)
        Label2.Name = "Label2"
        Label2.Size = New Size(467, 20)
        Label2.TabIndex = 1
        Label2.Text = "Vervaardigd door Hydroconsult, in opdracht van Waterschap Limburg"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Location = New Point(434, 234)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(53, 20)
        LinkLabel1.TabIndex = 2
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Github"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 234)
        Label3.Name = "Label3"
        Label3.Size = New Size(416, 20)
        Label3.TabIndex = 3
        Label3.Text = "Broncode van de GUI gepubliceerd onder Apache 2.0 licentie."
        ' 
        ' frmAbout
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(518, 280)
        Controls.Add(Label3)
        Controls.Add(LinkLabel1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmAbout"
        Text = "Over de Modellenbeheerder"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label3 As Label
End Class
