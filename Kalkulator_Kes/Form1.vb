Public Class Form1
    Private Sub ButtonTambah_Click(sender As Object, e As EventArgs) Handles ButtonTambah.Click
        Dim angka1 As Double
        Dim angka2 As Double
        Dim hasil As Double

        If Double.TryParse(TextAngka1.Text, angka1) AndAlso
            Double.TryParse(TextAngka2.Text, angka2) Then

            hasil = angka1 + angka2
            TextHASIL.Text = hasil.ToString()

        Else
            MessageBox.Show("Masukkan Nilai Yang Valid!", "PERINGATAN", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub ButtonKurang_Click(sender As Object, e As EventArgs) Handles ButtonKurang.Click
        Dim angka1 As Double
        Dim angka2 As Double
        Dim hasil As Double

        If Double.TryParse(TextAngka1.Text, angka1) AndAlso
            Double.TryParse(TextAngka2.Text, angka2) Then

            hasil = angka1 - angka2
            TextHASIL.Text = hasil.ToString()

        Else
            MessageBox.Show("Masukkan Nilai Yang Valid!", "PERINGATAN", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub ButtonKali_Click(sender As Object, e As EventArgs) Handles ButtonKali.Click
        Dim angka1 As Double
        Dim angka2 As Double
        Dim hasil As Double

        If Double.TryParse(TextAngka1.Text, angka1) AndAlso
            Double.TryParse(TextAngka2.Text, angka2) Then

            hasil = angka1 * angka2
            TextHASIL.Text = hasil.ToString()
        End If
    End Sub

    Private Sub ButtonBagi_Click(sender As Object, e As EventArgs) Handles ButtonBagi.Click
        Dim angka1 As Double
        Dim angka2 As Double
        Dim hasil As Double

        If Double.TryParse(TextAngka1.Text, angka1) AndAlso
            Double.TryParse(TextAngka2.Text, angka2) Then

            If angka2 = 0 Then
                MessageBox.Show("Angka Kedua tidak Boleh 0!", "PERINGATAN", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            Else
                hasil = angka1 / angka2
                TextHASIL.Text = hasil.ToString()
            End If
        Else
            MessageBox.Show("masukkan Angka yang Valid!", "PERINGATAN", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub ButtonBersih_Click(sender As Object, e As EventArgs) Handles ButtonBersih.Click
        TextAngka1.Clear()
        TextAngka2.Clear()
        TextHASIL.Clear()

        TextAngka1.Focus()
    End Sub
End Class
