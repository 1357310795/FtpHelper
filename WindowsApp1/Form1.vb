Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Text

Public Class Form1
    Private f As New FtpWeb("ftp://10.233.88.2", "user", "2003")
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        f.Download("ftp://10.233.88.2/Everything-1.4.1.969.x64\Everything.lng", "D:\1.tmp")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
