Public Class frmAbout

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        ' Open the URL in the user's default web browser.
        Try
            Process.Start("https://github.com/SiebeBosch/ModelBase")
        Catch ex As Exception
            ' Handle the exception if the Process.Start method fails
            MessageBox.Show("Unable to open link that was clicked.")
        End Try
    End Sub
End Class