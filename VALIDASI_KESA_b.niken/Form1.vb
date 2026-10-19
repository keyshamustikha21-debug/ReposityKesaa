
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Text = "Konversi Suhu Celcius ke Fahrenheit"
        Me.StartPosition = FormStartPosition.CenterScreen

        TxtSuhuCelcius.Clear()
        ErrorProvider1.Clear()
    End Sub

    Private Sub BtnKonversi_Click(sender As Object, e As EventArgs) Handles BtnKonversi.Click

        ErrorProvider1.Clear()

        Try

            If String.IsNullOrEmpty(TxtSuhuCelcius.Text) Then
                ErrorProvider1.SetError(TxtSuhuCelcius, "Suhu Celcius Tidak Boleh Kosong !")

                MessageBox.Show("PERINGATAN" & vbCrLf & vbCrLf & "Silakan masukkan nilai suhu terlebih dahulu", "peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TxtSuhuCelcius.Focus()
                Return
            End If

            Dim celcius As Double

            If Not Double.TryParse(TxtSuhuCelcius.Text, celcius) Then
                ErrorProvider1.SetError(TxtSuhuCelcius, "Suhu Celcius Harus Berupa Angka !")

                MessageBox.Show("PERINGATAN !" & vbCrLf & vbCrLf & "Input tidak valid" & vbCrLf & "Suhu celcius harus berupa angka", "peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim fahrenheit As Double

            fahrenheit = (celcius * 9 / 5 + 32)

            MessageBox.Show("Konversi suhu berhasil" & vbCrLf & vbCrLf & celcius.ToString("N2") & "C = " & fahrenheit.ToString("N2") & " F", "Konversi Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan saat melakukan konversi" & vbCrLf & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

        End Try
    End Sub

    Private Sub BtnBersih_Click(sender As Object, e As EventArgs) Handles BtnBersih.Click
        TxtSuhuCelcius.Clear()
        ErrorProvider1.Clear()
        TxtSuhuCelcius.Focus()
    End Sub

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        Dim pilihan As DialogResult

        pilihan = MessageBox.Show("Apakah Anda Yakin Ingin keluar?", "Konfirmasi keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If pilihan = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class
