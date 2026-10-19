Imports System.Runtime.InteropServices.Marshalling

Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nama As String = TextNama.Text
        Dim kelas As String = TextKelas.Text
        Dim jurusan As String = TextJurusan.Text

        MessageBox.Show("Nama : " & nama & vbCrLf & "Kelas : " & kelas & vbCrLf & "Jurusan : " & jurusan)
    End Sub
End Class