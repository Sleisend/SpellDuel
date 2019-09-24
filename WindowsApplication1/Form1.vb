Imports System.Net
Imports System.IO
Imports System.IO.Compression

Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim var As String
        var = TextBox1.Text
    End Sub

    Private Sub FileExplorer_Click(sender As Object, e As EventArgs) Handles FileExplorer.Click
        FolderBrowserDialog1.ShowDialog()
        TextBox1.Text = FolderBrowserDialog1.SelectedPath
    End Sub

    Public WithEvents downloader As WebClient
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If My.Computer.FileSystem.FileExists(TextBox1.Text & "\SpellDuel.zip") Then
            My.Computer.FileSystem.DeleteFile(TextBox1.Text & "\SpellDuel.zip")
        End If
        Dim uri As New Uri("http://vortexirc.com/spellduel/SpellDuel.rar")
        downloader = New WebClient
        downloader.DownloadFileAsync(uri, TextBox1.Text & "\SpellDuel.zip")
        Dim ZipToUnpack As String = "C:\Users\Kebben\Desktop\SpellDuell\Spellduell.zip"
        Dim TargetDir As String = "C:\Users\Kebben\Desktop\SpellDuell"
        Console.WriteLine("Extracting file {0} to {1}", ZipToUnpack, TargetDir)
        Using zip1 As ZipFile = ZipFile.Read(ZipToUnpack)
            AddHandler zip1.ExtractProgress, AddressOf MyExtractProgress
            Dim e As ZipEntry
            ' here, we extract every entry, but we could extract    
            ' based on entry name, size, date, etc.   
            For Each e In zip1
                e.Extract(TargetDir, ExtractExistingFileAction.OverwriteSilently)
            Next
        End Using
    End Sub


    Private Sub downloader_DownloadProgressChanged(ByVal sender As Object, ByVal e As System.Net.DownloadProgressChangedEventArgs) Handles downloader.DownloadProgressChanged
        Me.ProgressBar1.Value = e.ProgressPercentage
        Me.Label2.Text = e.BytesReceived & " von " & e.TotalBytesToReceive & " Bytes"
        Me.Label3.Text = e.ProgressPercentage & "%"
    End Sub
End Class
