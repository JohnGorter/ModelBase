Public Class frmModelBase

    Dim ModelBase As New clsModelBase()

    Private Sub frmModelBase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDatabase.Text = My.Settings.Database
    End Sub

    Private Sub AccessToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccessToolStripMenuItem.Click

    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        dlgOpenFile.Filter = "SQLite|*.db"
        Dim res As DialogResult = dlgOpenFile.ShowDialog
        If res = DialogResult.OK Then
            txtDatabase.Text = dlgOpenFile.FileName
            My.Settings.Database = txtDatabase.Text
            My.Settings.Save()
        End If

    End Sub

    Private Sub CreateNewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateNewToolStripMenuItem.Click

    End Sub
End Class
