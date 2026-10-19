Public Class TUGAS_PRAKTIK_TIPE_DATA
    Private Sub BtnHitung_Click(sender As Object, e As EventArgs) Handles BtnHitung.Click
        Dim nama As String
        Dim kelas As String
        Dim tugas As Double
        Dim uts As Double
        Dim uas As Double
        Dim rata As Double

        nama = TextNama.Text
        kelas = TextKelas.Text
        tugas = CDbl(TextNilaiTugas.Text)
        uts = CDbl(TextNilaiUts.Text)
        uas = CDbl(TextNilaiUas.Text)

        rata = (tugas + uts + uas) / 3

        MessageBox.Show("DATA NILAI SISWA" & vbCrLf &
        "Nama" & vbTab & vbTab & ": " & nama & vbCrLf &
        "Kelas" & vbTab & vbTab & ": " & kelas & vbCrLf &
        "Nilai Tugas" & vbTab & ": " & tugas & vbCrLf &
        "Nilai UTS" & vbTab & vbTab & ": " & uts & vbCrLf &
        "Nilai UAS" & vbTab & vbTab & ": " & uas & vbCrLf &
        "Rata - Rata" & vbTab & ": " & Format(rata, "0,00"))

    End Sub

    Private Sub BtnBersih_Click(sender As Object, e As EventArgs) Handles BtnBersih.Click
        TextNama.Clear()
        TextKelas.Clear()
        TextNilaiTugas.Clear()
        TextNilaiUts.Clear()
        TextNilaiUas.Clear()

        TextNama.Focus()
    End Sub
End Class