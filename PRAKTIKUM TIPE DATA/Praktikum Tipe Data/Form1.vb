Imports System.Runtime.InteropServices.Marshalling

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nama As String = "Kesa"
        Dim umur As Integer = 17
        Dim tinggi As Double = 155
        Dim aktif As Boolean = True

        MessageBox.Show("Nama : " & nama & vbCrLf & "Umur : " & umur & vbCrLf & "Tinggi : " & tinggi & vbCrLf & "Aktif : " & aktif & vbCrLf)
    End Sub
End Class
