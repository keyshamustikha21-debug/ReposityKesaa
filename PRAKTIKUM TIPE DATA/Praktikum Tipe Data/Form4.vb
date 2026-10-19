Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nama As String
        Dim gajiPokok As Double
        Dim tunjangan As Decimal
        Dim total As Decimal

        nama = TextNama.Text
        gajiPokok = CDbl(TextGajiPokok.Text)
        tunjangan = CDec(TextTunjangan.Text)
        total = gajiPokok + tunjangan

        MessageBox.Show("Nama : " & nama & vbCrLf & "Total Gaji : Rp. " & Format(total, "#,##0"))
    End Sub
End Class