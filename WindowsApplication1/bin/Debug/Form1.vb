Imports System.Net
Imports System.IO
Imports System.IO.Compression
'Hello
Public Class Form1

    Public WithEvents Downloader As WebClient


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click

        BtnUpdate.Enabled = "false"

        If My.Computer.FileSystem.FileExists(".\SpellDuel.zip") Then
            My.Computer.FileSystem.DeleteFile(".\SpellDuel.zip")
        End If
        If My.Computer.FileSystem.FileExists(".\SpellDuel.pck") Then
            My.Computer.FileSystem.DeleteFile(".\SpellDuel.pck")
        End If
        If My.Computer.FileSystem.FileExists(".\SpellDuel.exe") Then
            My.Computer.FileSystem.DeleteFile(".\SpellDuel.exe")
        End If
        If My.Computer.FileSystem.DirectoryExists(".\Animation") Then
            My.Computer.FileSystem.DeleteDirectory(".\Animation", FileIO.DeleteDirectoryOption.DeleteAllContents)
        End If

        Dim uri As New Uri("http://vortexirc.com/spellduel/SpellDuel.zip")
        Downloader = New WebClient
        Downloader.DownloadFileAsync(uri, ".\SpellDuel.zip")

    End Sub

    Private Sub Downloader_DownloadProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs) Handles Downloader.DownloadProgressChanged
        ProgressBar1.Value = e.ProgressPercentage
        Download_Percent.Text = e.ProgressPercentage & "%"
    End Sub
    Private Sub Downloader_DownloadFileCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs) Handles Downloader.DownloadFileCompleted
        ZipFile.ExtractToDirectory(".\SpellDuel.zip", ".\")
        BtnStart.Enabled = "true"
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnStart.Click
        If BtnStart.Enabled = "true" And ProgressBar1.Value = "100" OrElse ProgressBar1.Value = "0" Then
            Process.Start(".\SpellDuel.exe")
            Application.Exit()
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.FileExists(".\SpellDuel.exe") Then
            BtnStart.Enabled = "true"
        Else
            BtnUpdate.Text = "Download"
        End If
    End Sub

    Private Sub Infotext_button_Click(sender As Object, e As EventArgs) Handles Infotext_button.Click
        If Infotext.Visible = "false" Then
            Infotext.Visible = "true"
            Infotext_button.Text = "Changelog"
            TopLabel.Text = "Installation information"
        Else
            Infotext.Visible = "false"
            Infotext_button.Text = "Installation information"
            TopLabel.Text = "Changelog"
        End If
    End Sub
End Class
