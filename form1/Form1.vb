Public Class FormDiskon
    Private ReadOnly txtTotal As Object
    Private txtBayar As Object
    Private txtDiskon As Object

    Private Sub BtnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        ' Validasi input angka
        Dim total As Double = 0
        If Not Double.TryParse(txtTotal.Text, total) Then
            MessageBox.Show("Masukkan total belanja berupa angka yang valid!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim diskon As Double = 0
        Dim bayar As Double = 0

        ' Logika Penentuan Diskon
        If total >= 100000 Then
            diskon = total * 0.1
        ElseIf total >= 50000 Then
            diskon = total * 0.05
        Else
            diskon = 0
        End If

        ' Hitung Total Bayar
        bayar = total - diskon

        ' Tampilkan Hasil
        txtDiskon.Text = diskon.ToString()
        txtBayar.Text = bayar.ToString()
    End Sub

End Class