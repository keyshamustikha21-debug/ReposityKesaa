Public Class Form2
    Private Sub BtnMasuk_Click(sender As Object, e As EventArgs) Handles BtnMasuk.Click

        Dim passwordBenar As String = "vbnet123"
        Dim percobaan As String = 0
        Dim berhasil As Boolean = False

        Do While percobaan < 3 And Not berhasil
            Dim input As String = InputBox("Masukkan password (percobaan ke-)" & (percobaan + 1) & " dari 3):")
            percobaan += 1

            If input = passwordBenar Then
                berhasil = True
                MessageBox.Show("SELAMAT", "Login Berhasil!", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ElseIf percobaan < 3 Then
                MessageBox.Show("WARNING", "Password salah, sisa percobaan : " & (3 - percobaan), MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Loop

        If Not berhasil Then
            Application.Exit()
        End If
    End Sub
End Class