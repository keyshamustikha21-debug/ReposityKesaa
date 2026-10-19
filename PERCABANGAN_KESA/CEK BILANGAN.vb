Public Class CEK_BILANGAN
    Private Sub ButtonCEK_Click(sender As Object, e As EventArgs) Handles ButtonCEK.Click
        Dim angka As Integer =
            CInt(TextNILAI.Text)
        If angka > 0 Then
            TextHASIL.Text = "POSITIF"
        ElseIf angka < 0 Then
            TextHASIL.Text = "NEGATIF"
        Else
            TextHASIL.Text = "NOL"
        End If
    End Sub
End Class