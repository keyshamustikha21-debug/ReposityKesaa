Public Class Tugas_1
    Private Sub BtnTampil_Click(sender As Object, e As EventArgs) Handles BtnTampil.Click

        Dim hasil As String = ""

        For i As Integer = 1 To 50
            If i Mod 2 = 0 Then
                hasil &= i & " "
            End If
        Next

        MessageBox.Show(hasil, "Bilangan genap")
    End Sub
End Class