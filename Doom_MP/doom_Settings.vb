
Public Class doom_Settings
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        My.Settings.doomDir = txtDir.Text
        My.Settings.Save()
        My.Settings.Reload()

        Application.Restart()
    End Sub

    Private Sub doom_Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDir.Text = My.Settings.doomDir
    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()

        fd.Title = "Open File Dialog"
        fd.InitialDirectory = "C:\"
        fd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            txtDir.Text = fd.FileName
        End If
    End Sub
End Class