Public Class FORM_LOGIN
    Private Sub FORM_LOGIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Txtusername.Clear()
        txtPW.Clear()

        txtPW.UseSystemPasswordChar = True
    End Sub

    Private Sub BtnLOGIN_Click(sender As Object, e As EventArgs) Handles BtnLOGIN.Click
        Try
            If Txtusername.Text.Trim() = "" Then
                MessageBox.Show("Username tidak boleh kosong !", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                Txtusername.Focus()
                Exit Sub
            End If

            If txtPW.Text.Trim() = "" Then
                MessageBox.Show("Password tidak boleh kosong !", "validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                txtPW.Focus()
                Exit Sub
            End If

            Dim username As String = Txtusername.Text.Trim()
            Dim password As String = txtPW.Text.Trim()

            If password = "121212" Then
                MessageBox.Show("Login Berhasil!" & vbCrLf & "Selamat Datang, " & username & ".", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                MessageBox.Show("Password Salah!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("terjadi kesalahan : " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
        End Try
    End Sub

    Private Sub BtnBersih_Click(sender As Object, e As EventArgs) Handles BtnBersih.Click
        Txtusername.Clear()
        txtPW.Clear()
        Txtusername.Focus()
    End Sub

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        Dim hasil As DialogResult

        hasil = MessageBox.Show("Apakah anda yakin ingin keluar?", "konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Question)

        Application.Exit()

    End Sub
End Class