Public Class Praktikum_3
    Private Sub ButtonProses_Click(sender As Object, e As EventArgs) Handles ButtonProses.Click
        Dim x As Boolean = CheckTrue.Checked
        Dim y As Boolean = CheckFalse.Checked
        Dim z As String
        If x And y Then
            z = "Keduanya TRUE"
        ElseIf x Or y Then
            z = "Salah Satu TRUE"
        Else
            z = "Keduanya FALSE"
        End If
        TextHasil.Text = z
    End Sub
End Class