Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim umur As Integer
        umur = CInt(TextUmur.Text)

        Dim tahunDepan As Integer
        tahunDepan = umur + 1

        MessageBox.Show("Umur tahun depan : " & tahunDepan)
    End Sub
End Class