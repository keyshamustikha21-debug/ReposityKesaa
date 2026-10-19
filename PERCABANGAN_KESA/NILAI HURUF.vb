Public Class NILAI_HURUF
    Private Sub ButtonCEK_Click(sender As Object, e As EventArgs) Handles ButtonCEK.Click
        Dim nilai As Integer =
            CInt(TextNILAI.Text)
        Dim grade As String

        Select Case nilai
            Case 85 To 100
                grade = "A"
            Case 70 To 84
                grade = "B"
            Case 55 To 69
                grade = "C"
            Case 0 To 54
                grade = "D"
            Case Else
                grade = "Nilai Tidak Valid"
        End Select

        TextGRADE.Text = grade
    End Sub
End Class