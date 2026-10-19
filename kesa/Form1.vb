Public Class Form1

    'PENJUMLAHAN
    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Dim angka1 As Double
        Dim angka2 As Double
        Dim hasil As Double

        If Double.TryParse(TxtangkaPertama.Text, angka1) AndAlso
            Double.TryParse(TxtangkaKedua.Text, angka2) Then

            hasil = angka1 + angka2
            TxtHasil.Text = hasil.ToString()
        Else
            MessageBox.Show("masukkan Angka Yang Valid !", "PERINGATAN", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    'PENGURANGAN
    Private Sub BtnKurang_Click(sender As Object, e As EventArgs) Handles BtnKurang.Click
        Dim angka1 As Double
        Dim angka2 As Double
        Dim hasil As Double

        If Double.TryParse(TxtangkaPertama.Text, angka1) AndAlso
            Double.TryParse(TxtangkaKedua.Text, angka2) Then

            hasil = angka1 - angka2
            TxtHasil.Text = hasil.ToString()
        Else
            MessageBox.Show("Masukkan Angka yang Valid !", "PERINGATAN", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    'PERKALIAN
    Private Sub BtnKali_Click(sender As Object, e As EventArgs) Handles BtnKali.Click
        Dim angka1 As Double
        Dim angka2 As Double
        Dim hasil As Double

        If Double.TryParse(TxtangkaPertama.Text, angka1) AndAlso
            Double.TryParse(TxtangkaKedua.Text, angka2) Then

            hasil = angka1 * angka2
            TxtHasil.Text = hasil.ToString()
        Else
            MessageBox.Show("masukkan Angka Yang Valid !", "PERINGATAN", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    'PEMBAGIAN
    Private Sub BtnBagi_Click(sender As Object, e As EventArgs) Handles BtnBagi.Click
        Dim angka1 As Double
        Dim angka2 As Double
        Dim hasil As Double

        If Double.TryParse(TxtangkaPertama.Text, angka1) AndAlso
            Double.TryParse(TxtangkaKedua.Text, angka2) Then

            If angka2 = 0 Then
                MessageBox.Show("Angka Kedua Tidak Boleh 0 !", "PERINGATAN", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                hasil = angka1 / angka2
                TxtHasil.Text.ToString()
            End If

        Else
            MessageBox.Show("Masukkan Angka yang Valid !", "PERINGATAN", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class
