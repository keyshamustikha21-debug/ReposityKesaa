Public Class TUGAS_PRAKTIKUM
    Private Sub TUGAS_PRAKTIKUM_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Pengaturan Awal TextBox Hasil
        TextJenisDiskon.ReadOnly = True
        TextHARGA.ReadOnly = False

        TextJenisDiskon.Text = ""
        TextHARGA.Text = ""
    End Sub

    Private Sub ButtonHITUNG_Click(sender As Object, e As EventArgs) Handles ButtonHITUNG.Click
        Dim harga As Double
        Dim diskon As Double
        Dim potongan As Double
        Dim hargaAkhir As Double
        Dim inputDiskon As String

        If TextHARGA.Text.Trim() = "" Then
            MessageBox.Show("HARGA BARANG BELUM DIISI !", "PERINGATAN", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextHARGA.Focus()
            Exit Sub
        End If

        If Not Double.TryParse(TextHARGA.Text, harga) Then
            MessageBox.Show("HARGA BARANG HARUS BERUPA ANGKA !", "PERINGATAN", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            TextHARGA.SelectAll()
            TextHARGA.Focus()
            Exit Sub
        End If

        'DISKON
        If TextDISKON.Text.Trim() = "" Then
            MessageBox.Show("PRESENTASE DISKON BELUM DIISI !", "PERINGATAN", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            TextDISKON.Focus()
            Exit Sub
        End If

        'Mengambil Isi TextDISKON
        inputDiskon = TextDISKON.Text.Trim()

        'Menghapus Tanda % Jika Pengguna Mengetik 30%
        inputDiskon = inputDiskon.Replace("%", "")

        If Not Double.TryParse(inputDiskon, diskon) Then
            MessageBox.Show("PRESENTASE DISKON HARUS ANTARA 0% SAMPAI 30% !", "PERINGATAN", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            TextDISKON.SelectAll()
            TextDISKON.Focus()
            Exit Sub
        End If

        'Menghitung Potongan Harga
        potongan = harga * diskon / 100

        'Menghitung Harga Akhir
        hargaAkhir = harga - potongan

        'Menentukan Jenis Diskon Sesuai Aturan Praktikum
        If diskon >= 21 And diskon <= 30 Then
            TextJenisDiskon.Text = "Diskon Spesial"

            'Warna Merah 
            TextJenisDiskon.BackColor = Color.Red
            TextJenisDiskon.ForeColor = Color.White

        ElseIf diskon > 10 And diskon <= 20 Then
            TextJenisDiskon.Text = "Diskon Menengah"

            'warna Biru
            TextJenisDiskon.BackColor = Color.Blue
            TextJenisDiskon.ForeColor = Color.White

        ElseIf diskon >= 1 And diskon <= 9 Then
            TextJenisDiskon.Text = "Diskon Kecil"

            'Warna Hijau
            TextJenisDiskon.BackColor = Color.Green
            TextJenisDiskon.ForeColor = Color.White
        End If

        'Menampilkan Harga Akhir
        TextHargaAkhir.Text = "Rp " & hargaAkhir.ToString("#,##0")
    End Sub

    Private Sub ButtonBERSIH_Click(sender As Object, e As EventArgs) Handles ButtonBERSIH.Click

        'Menghapus Semua Input dan Jenis
        TextHARGA.Clear()
        TextDISKON.Clear()
        TextJenisDiskon.Clear()
        TextHargaAkhir.Clear()

        'mengembalikan Warna TextBox Jenis Diskon
        TextJenisDiskon.BackColor = Color.White
        TextJenisDiskon.ForeColor = Color.Black

        TextHARGA.Focus()
    End Sub

End Class