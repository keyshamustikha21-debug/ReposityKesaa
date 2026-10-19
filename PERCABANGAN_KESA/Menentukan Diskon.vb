Public Class Menentukan_Diskon
    Private Sub BtnHItung_Click(sender As Object, e As EventArgs) Handles BtnHItung.Click
        Dim total As Integer =
           CInt(TextHAriTOtal.Text)
        Dim diskon As Integer = 0
        If total >= 500000 Then
            diskon = 20
        ElseIf total >= 200000 Then
            diskon = 10
        Else
            diskon = 0
        End If
        TextHAsildiskon.Text = diskon & " %"
    End Sub
End Class