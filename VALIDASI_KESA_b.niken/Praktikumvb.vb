Public Class Praktikumvb
    Private Sub BtnBagi_Click(sender As Object, e As EventArgs) Handles BtnBagi.Click
        Dim angka As Integer
        Dim pembagi As Integer
        Dim hasil As Integer

        Try
            '1. validasi awal : pastikan input tidak kosong
            If TxtAngka.Text.Trim = "" OrElse TxtBagi.Text.Trim = "" Then
                MessageBox.Show("Kolom Tidak Boleh Kosong !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            '2. Konversi & pembagian (beresiko error -> ditangani catch)
            angka = CInt(TxtAngka.Text)
            pembagi = CInt(TxtBagi.Text)
            hasil = angka \ pembagi

            '3. tampilkan hasil jika berhasil
            LblHasilHasil.Text = " " & hasil
            MessageBox.Show("Hasil : " & hasil, "SUKSES", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As DivideByZeroException
            MessageBox.Show("Tidak bisa dibagi nol !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            LblHasilHasil.Text = "-"

        Catch ex As FormatException
            MessageBox.Show("Masukkan angka valid !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            LblHasilHasil.Text = "-"

        Catch ex As OverflowException
            MessageBox.Show("Angka terlalu besar !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            LblHasilHasil.Text = "-"

        Finally
            MessageBox.Show("proses selesai", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub Praktikumvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblHasilHasil.Text = "-"
    End Sub

    Private Sub BtnBErsih_Click(sender As Object, e As EventArgs) Handles BtnBErsih.Click
        TxtAngka.Clear()
        TxtBagi.Clear()
        LblHasilHasil.Text = "-"
    End Sub
End Class