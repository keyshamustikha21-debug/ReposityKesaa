Public Class RATA__NILAI
    Private Sub RATA__NILAI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtNilai1.Clear()
        TxtNilai2.Clear()
        TxtNilai3.Clear()
        TxtNilai4.Clear()
        TxtNilai5.Clear()
    End Sub

    Private Sub BtnHitung_Click(sender As Object, e As EventArgs) Handles BtnHitung.Click
        Try
            Dim nilai1 As Double
            Dim nilai2 As Double
            Dim nilai3 As Double
            Dim nilai4 As Double
            Dim nilai5 As Double

            If Not Double.TryParse(TxtNilai1.Text.Trim(), nilai1) Then
                Throw New FormatException("Nilai 1 harus berupa angka !")
            End If

            If nilai1 < 0 OrElse nilai1 > 100 Then
                Throw New FormatException("Niai 1 harus antara 0 sampai 100")
            End If


            If Not Double.TryParse(TxtNilai2.Text.Trim(), nilai2) Then
                Throw New FormatException("Nilai 2 harus berupa angka !")
            End If

            If nilai2 < 0 OrElse nilai2 > 100 Then
                Throw New FormatException("Nilai 2 harus antara 0 sampai 100")
            End If


            If Not Double.TryParse(TxtNilai3.Text.Trim(), nilai3) Then
                Throw New FormatException("Nilai 3 harus berupa angka !")
            End If

            If nilai3 < 0 OrElse nilai3 > 100 Then
                Throw New FormatException("Nilai 3 harus antara 0 sampai 100")
            End If


            If Not Double.TryParse(TxtNilai4.Text.Trim(), nilai4) Then
                Throw New FormatException("Nilai 4 harus berupa angka !")
            End If

            If nilai4 < 0 OrElse nilai4 > 100 Then
                Throw New FormatException("Nilai 4 harus antara 0 sampai 100")
            End If


            If Not Double.TryParse(TxtNilai5.Text.Trim(), nilai5) Then
                Throw New FormatException("Nilai 5 harus berupa angka !")
            End If

            If nilai5 < 0 OrElse nilai5 > 100 Then
                Throw New FormatException("Nilai 5 harus antara 0 sampai 100")
            End If

            Dim RataRata As Double
            RataRata = (nilai1 + nilai2 + nilai3 + nilai4 + nilai5) / 5

            MessageBox.Show("Rata-Rata dari 5 Nilai Adalah " & RataRata.ToString(0.00), "Hasil Rata-Rata", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "input Tidak Valid", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Finally
            MessageBox.Show("Proses Hitung Sudah Selesai", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub BtnBersih_Click(sender As Object, e As EventArgs) Handles BtnBersih.Click
        TxtNilai1.Clear()
        TxtNilai2.Clear()
        TxtNilai3.Clear()
        TxtNilai4.Clear()
        TxtNilai5.Clear()
    End Sub

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        If MessageBox.Show("Apakah Anda Ingin Keluar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class