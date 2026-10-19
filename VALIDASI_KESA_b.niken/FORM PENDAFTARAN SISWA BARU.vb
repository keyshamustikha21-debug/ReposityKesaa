Imports System.Text.RegularExpressions
Public Class FORM_PENDAFTARAN_SISWA_BARU
    Private Sub BtnDaftar_Click(sender As Object, e As EventArgs) Handles BtnDaftar.Click

        Dim dataValid As Boolean = False
        ErrorProvider1.Clear()

        Try

            If TxtNama.Text.Trim() = "" Then
                ErrorProvider1.SetError(TxtNama, "Nama Tidak Boleh Kosong !")
                TxtNama.Focus()
                Exit Try
            End If

            If Not Regex.IsMatch(TxtNISN.Text.Trim(), "^\d{10}$") Then
                ErrorProvider1.SetError(TxtNISN, "NISN harus tepat 10 digit angka")
                TxtNISN.Focus()
                Exit Try
            End If

            Dim usia As Integer
            If Not Integer.TryParse(TxtUsia.Text.Trim(), usia) Then
                ErrorProvider1.SetError(TxtUsia, "Usia Tidak Boleh Kosong !")
                TxtUsia.Focus()
                Exit Try
            End If

            If usia < 10 OrElse usia > 20 Then
                ErrorProvider1.SetError(TxtUsia, "Usia harus antara 10 sampai 20 tahun")
                TxtUsia.Focus()
                Exit Try
            End If

            Dim polaEmail As String = "^[^@\s]+@[^@\s]+\.[^@\s]+$"
            If Not Regex.IsMatch(TxtEmail.Text.Trim(), polaEmail) Then
                ErrorProvider1.SetError(TxtEmail, "Format email tidak valid !")
                TxtEmail.Focus()
            End If

            dataValid = True

        Catch ex As Exception
            MessageBox.Show("Terjadi Kesalahan : " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally

            If dataValid Then
                MessageBox.Show("Data Telah Valid", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End Try
    End Sub

    Private Sub BtnBersih_Click(sender As Object, e As EventArgs) Handles BtnBersih.Click
        TxtNama.Clear()
        TxtNISN.Clear()
        TxtUsia.Clear()
        TxtEmail.Clear()
        ErrorProvider1.Clear()

        TxtNama.Focus()
    End Sub

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        If MessageBox.Show("Apakah Anda Ingin Keluar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Exit()
        End If

    End Sub
End Class