Public Class Form5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim angka As String = "200"
        Dim hasil As Integer = CInt(angka)

        MessageBox.Show("Hasil : " & hasil)
    End Sub
End Class