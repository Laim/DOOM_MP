Public Class Form1

    Dim doomStart As New ProcessStartInfo

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Please open settings and location your Steam Directory")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        MsgBox("Copyright © 2016 UbiWare Studios")
        MsgBox("© 2016 Bethesda Softworks LLC, a ZeniMax Media company. Trademarks belong to their respective owners. All Rights Reserved.")
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("http://ubiwarestudios.com/doom")
    End Sub

    Private Sub picMP_Click(sender As Object, e As EventArgs) Handles picMP.Click
        Try
            doomStart.FileName = My.Settings.doomDir
            doomStart.Arguments = "-applaunch 379720 +com_gameMode 2" 'MP
            doomStart.UseShellExecute = True
            doomStart.WindowStyle = ProcessWindowStyle.Normal
            Dim proc As Process = Process.Start(doomStart)

            Application.Exit()
        Catch ex As Exception
            If ex.ToString.Contains("cannot find") Then
                MsgBox("DOOM EXE cannot be found.")
            Else
                MsgBox(ex.ToString & vbCrLf & "Please report this error to UbiWareStudios.com")
            End If
        End Try
    End Sub

    Private Sub picSP_Click(sender As Object, e As EventArgs) Handles picSP.Click
        Try
            doomStart.FileName = My.Settings.doomDir
            doomStart.Arguments = "-applaunch 379720 +com_gameMode 1" 'SP
            doomStart.UseShellExecute = True
            doomStart.WindowStyle = ProcessWindowStyle.Normal
            Dim proc As Process = Process.Start(doomStart)

            Application.Exit()
        Catch ex As Exception
            If ex.ToString.Contains("cannot find") Then
                MsgBox("DOOM EXE cannot be found.")
            Else
                MsgBox(ex.ToString & vbCrLf & "Please report this error to UbiWareStudios.com")
            End If
        End Try
    End Sub

    Private Sub picSNAP_Click(sender As Object, e As EventArgs) Handles picSNAP.Click
        Try
            doomStart.FileName = My.Settings.doomDir
            doomStart.Arguments = "-applaunch 379720 +com_gameMode 3" 'SNAP
            doomStart.UseShellExecute = True
            doomStart.WindowStyle = ProcessWindowStyle.Normal
            Dim proc As Process = Process.Start(doomStart)

            Application.Exit()
        Catch ex As Exception
            If ex.ToString.Contains("cannot find") Then
                MsgBox("DOOM EXE cannot be found.")
            Else
                MsgBox(ex.ToString & vbCrLf & "Please report this error to UbiWareStudios.com")
            End If
        End Try
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        doom_Settings.Show()
    End Sub
End Class
