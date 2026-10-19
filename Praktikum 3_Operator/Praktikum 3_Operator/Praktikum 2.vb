Public Class Praktikum_2
    Private Sub ButtonCek_Click(sender As Object, e As EventArgs) Handles ButtonCek.Click
        Dim a As Integer = CInt(TextNilaiA.Text)
        Dim b As Integer = CInt(TextNilaiB.Text)
        Dim teks As String
        If a >= b Then
            teks = "A lebih besar atau sama dengan B"
        Else
            teks = "A lebih kecil dari B"
        End If
        TextHasil.Text = teks
    End Sub
End Class