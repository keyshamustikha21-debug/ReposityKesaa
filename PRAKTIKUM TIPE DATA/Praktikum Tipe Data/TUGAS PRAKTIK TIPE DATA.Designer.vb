<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TUGAS_PRAKTIK_TIPE_DATA
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TUGAS_PRAKTIK_TIPE_DATA))
        Button1 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        TextNama = New TextBox()
        TextKelas = New TextBox()
        TextNilaiTugas = New TextBox()
        TextNilaiUts = New TextBox()
        TextNilaiUas = New TextBox()
        BtnHitung = New Button()
        BtnBersih = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.LightCyan
        Button1.Font = New Font("Garamond", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.SaddleBrown
        Button1.Location = New Point(21, 15)
        Button1.Name = "Button1"
        Button1.Size = New Size(762, 54)
        Button1.TabIndex = 0
        Button1.Text = "DATA NILAI SISWA"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.AntiqueWhite
        Label1.Font = New Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(52, 100)
        Label1.Name = "Label1"
        Label1.Size = New Size(83, 17)
        Label1.TabIndex = 1
        Label1.Text = "Nama         :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.AntiqueWhite
        Label2.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(52, 141)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 19)
        Label2.TabIndex = 2
        Label2.Text = "Kelas          :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.AntiqueWhite
        Label3.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(52, 187)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 19)
        Label3.TabIndex = 3
        Label3.Text = "Nilai Tugas  :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.AntiqueWhite
        Label4.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(52, 234)
        Label4.Name = "Label4"
        Label4.Size = New Size(85, 19)
        Label4.TabIndex = 4
        Label4.Text = "Nilai UTS   :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.AntiqueWhite
        Label5.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(52, 281)
        Label5.Name = "Label5"
        Label5.Size = New Size(87, 19)
        Label5.TabIndex = 5
        Label5.Text = "Nilai UAS   :"
        ' 
        ' TextNama
        ' 
        TextNama.Location = New Point(186, 95)
        TextNama.Name = "TextNama"
        TextNama.Size = New Size(495, 23)
        TextNama.TabIndex = 6
        ' 
        ' TextKelas
        ' 
        TextKelas.Location = New Point(188, 140)
        TextKelas.Name = "TextKelas"
        TextKelas.Size = New Size(495, 23)
        TextKelas.TabIndex = 7
        ' 
        ' TextNilaiTugas
        ' 
        TextNilaiTugas.Location = New Point(188, 186)
        TextNilaiTugas.Name = "TextNilaiTugas"
        TextNilaiTugas.Size = New Size(494, 23)
        TextNilaiTugas.TabIndex = 8
        ' 
        ' TextNilaiUts
        ' 
        TextNilaiUts.Location = New Point(188, 232)
        TextNilaiUts.Name = "TextNilaiUts"
        TextNilaiUts.Size = New Size(494, 23)
        TextNilaiUts.TabIndex = 9
        ' 
        ' TextNilaiUas
        ' 
        TextNilaiUas.Location = New Point(188, 279)
        TextNilaiUas.Name = "TextNilaiUas"
        TextNilaiUas.Size = New Size(495, 23)
        TextNilaiUas.TabIndex = 10
        ' 
        ' BtnHitung
        ' 
        BtnHitung.BackColor = Color.LightBlue
        BtnHitung.Font = New Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnHitung.Location = New Point(142, 350)
        BtnHitung.Name = "BtnHitung"
        BtnHitung.Size = New Size(288, 29)
        BtnHitung.TabIndex = 11
        BtnHitung.Text = "HITUNG"
        BtnHitung.UseVisualStyleBackColor = False
        ' 
        ' BtnBersih
        ' 
        BtnBersih.BackColor = Color.LightBlue
        BtnBersih.Font = New Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnBersih.Location = New Point(461, 350)
        BtnBersih.Name = "BtnBersih"
        BtnBersih.Size = New Size(288, 29)
        BtnBersih.TabIndex = 12
        BtnBersih.Text = "BERSIH"
        BtnBersih.UseVisualStyleBackColor = False
        ' 
        ' TUGAS_PRAKTIK_TIPE_DATA
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(BtnBersih)
        Controls.Add(BtnHitung)
        Controls.Add(TextNilaiUas)
        Controls.Add(TextNilaiUts)
        Controls.Add(TextNilaiTugas)
        Controls.Add(TextKelas)
        Controls.Add(TextNama)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Name = "TUGAS_PRAKTIK_TIPE_DATA"
        Text = "TUGAS_PRAKTIK_TIPE_DATA"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextNama As TextBox
    Friend WithEvents TextKelas As TextBox
    Friend WithEvents TextNilaiTugas As TextBox
    Friend WithEvents TextNilaiUts As TextBox
    Friend WithEvents TextNilaiUas As TextBox
    Friend WithEvents BtnHitung As Button
    Friend WithEvents BtnBersih As Button
End Class
