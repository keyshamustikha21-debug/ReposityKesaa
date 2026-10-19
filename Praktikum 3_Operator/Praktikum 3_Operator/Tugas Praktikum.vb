Public Class Tugas_Praktikum
    Private Sub Tugas_Praktikum_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Mengisi pilihan mata uang
        ComboBoxUang.Items.Add("USD")
        ComboBoxUang.Items.Add("EUR")
        ComboBoxUang.Items.Add("JPY")

        'Pilihan Awal
        ComboBoxUang.SelectedIndex = 0

        'Hasil Tidak Bisa Diketik Manual
        TextBoxHasil.ReadOnly = True

        'Kursor Langsung ke Input Rupiah
        TextBoxRupiah.Focus()

    End Sub

    Private Sub ButtonKonversi_Click(sender As Object, e As EventArgs) Handles ButtonKonversi.Click
        Dim rupiah As Double
        Dim hasil As Double

        'Memeriksa Apakah Inputan Berupa Angka
        If Not IsNumeric(TextBoxRupiah.Text) Then
            MessageBox.Show("Input harus berupa ANGKA", "PERINGATAN!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBoxRupiah.Clear()
            TextBoxRupiah.Focus()
            Exit Sub
        End If

        'Mengambil Nilai Dari TextBox
        rupiah = CDbl(TextBoxRupiah.Text)

        Select Case ComboBoxUang.Text
            Case "USD"
                hasil = rupiah / 1800000
            Case "EUR"
                hasil = rupiah / 2067800
            Case "JPY"
                hasil = rupiah / 11353
        End Select

        TextBoxHasil.Text = hasil.ToString("N2")
    End Sub

    Private Sub ButtonBersih_Click(sender As Object, e As EventArgs) Handles ButtonBersih.Click
        TextBoxRupiah.Clear()
        TextBoxHasil.Clear()
        ComboBoxUang.SelectedIndex = 0
        TextBoxRupiah.Focus()
    End Sub

    Private Sub ButtonKeluar_Click(sender As Object, e As EventArgs) Handles ButtonKeluar.Click
        Dim jawab As DialogResult
        jawab = MessageBox.Show("Yakin, ingin keluar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If jawab = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class