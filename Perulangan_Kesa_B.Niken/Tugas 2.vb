Public Class Tugas_2
    Private Sub BtnMulai_Click(sender As Object, e As EventArgs) Handles BtnMulai.Click

        Dim angka As Integer
        Dim total As Integer = 0
        Dim input As String

        Do While True

            input = InputBox("Masukkan angka (0 untuk berhenti) :")

            If Integer.TryParse(input, angka) Then
                If angka = 0 Then
                    Exit Do
                End If

                total += angka

            Else
                MessageBox.Show("Masukkan angka yang valid !", "Peringatan")
            End If
        Loop

        MessageBox.Show("Total Penjumlahan = " & total, "Hasil")
    End Sub
End Class