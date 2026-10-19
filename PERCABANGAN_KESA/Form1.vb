Public Class Form1
    Private Sub BTNCek_Click(sender As Object, e As EventArgs) Handles BTNCek.Click
        Dim umur As Integer =
            CInt(TextUmur.Text)
        If umur >= 17 Then
            TextHASIL.Text = "Dewasa"
        Else
            TextHASIL.Text = "Belum Dewasa"
        End If
    End Sub
End Class
