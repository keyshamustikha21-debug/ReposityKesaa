Public Class Form1
    Private Sub BtnProses_Click(sender As Object, e As EventArgs) Handles BtnProses.Click

        Dim angka As Integer
        LstHasil.Items.Clear()

        If Integer.TryParse(TxtNilai.Text, angka) Then
            For i As Integer = 1 To 10
                LstHasil.Items.Add(angka & " x " & i & " - " & (angka * i))
            Next
        Else
            MessageBox.Show("Masukkan angka yang valid !", "PERINGATAN", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
