Public Class Prsktikum_4
    Private Sub BtnHitung_Click(sender As Object, e As EventArgs) Handles BtnHitung.Click
        Dim a As Integer = CInt(TextBoxNilai.Text)
        a += 10  ' a = a + 10
        a *= 2   ' a = a * 2
        a -= 5   ' a = a * a - 5
        a = a Mod 6 ' sisa bagi 6

        LabelHasil.Text = "Hasil : " & a
    End Sub
End Class