Public Class APK_CEK_UMUR

    Private Sub APK_CEK_UMUR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtTahunLahir.Clear()
        LblHasilUmur.Text = "-"

        ErrorProvider1.Clear()
    End Sub

    Private Sub BtnCekUmur_Click(sender As Object, e As EventArgs) Handles BtnCekUmur.Click
        Try
            ErrorProvider1.Clear()

            If TxtTahunLahir.Text.Trim() = "" Then
                ErrorProvider1.SetError(TxtTahunLahir, "Tahun Tidak Boleh Kosong !")

                LblHasilUmur.Text = "-"
                Exit Sub
            End If


            Dim tahunLahir As Integer

            If Not Integer.TryParse(TxtTahunLahir.Text.Trim(), tahunLahir) Then
                ErrorProvider1.SetError(TxtTahunLahir, "Tahun lahir harus berupa angka")

                LblHasilUmur.Text = "-"
                Exit Sub
            End If


            Dim tahunSekarang As Integer = DateTime.Now.Year

            If tahunLahir < 1900 OrElse tahunLahir > tahunSekarang Then
                ErrorProvider1.SetError(TxtTahunLahir, "Tahun lahir harus antara 1900 sampai " & tahunSekarang & ".")

                LblHasilUmur.Text = "-"
                Exit Sub
            End If


            Dim umur As Integer = tahunSekarang - tahunLahir

            LblHasilUmur.Text = umur & " tahun"

        Catch ex As Exception
            ErrorProvider1.SetError(TxtTahunLahir, "Terjadi kesalahan : " & ex.Message)

            LblHasilUmur.Text = "-"

        Finally
            BtnCekUmur.Enabled = True
        End Try
    End Sub

    Private Sub BtnBersih_Click(sender As Object, e As EventArgs) Handles BtnBersih.Click
        TxtTahunLahir.Clear()
        LblHasilUmur.Text = "-"
        ErrorProvider1.Clear()

        TxtTahunLahir.Focus()
    End Sub

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        If MessageBox.Show("Apakah anda ingin keluar ?", "konformasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class