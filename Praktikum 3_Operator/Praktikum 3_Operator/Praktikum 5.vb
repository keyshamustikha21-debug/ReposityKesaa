Public Class Praktikum_5
    Private Sub ButtonProses_Click(sender As Object, e As EventArgs) Handles ButtonProses.Click
        Dim a As Integer = CInt(TextA.Text)
        Dim b As Integer = CInt(TextB.Text)
        Dim hasil As Integer
        hasil = (a + b) ^ 2 - (a Mod b)
        Labelhasil.Text = "Hasil : " & hasil
    End Sub
End Class