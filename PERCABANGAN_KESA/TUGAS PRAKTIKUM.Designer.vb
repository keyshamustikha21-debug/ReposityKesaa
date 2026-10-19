<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TUGAS_PRAKTIKUM
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
        Me.KALKULATOR = New System.Windows.Forms.Label()
        Me.LblBarang = New System.Windows.Forms.Label()
        Me.LblDISKON = New System.Windows.Forms.Label()
        Me.TextDISKON = New System.Windows.Forms.TextBox()
        Me.ButtonHITUNG = New System.Windows.Forms.Button()
        Me.ButtonBERSIH = New System.Windows.Forms.Button()
        Me.LabelJenisDiskon = New System.Windows.Forms.Label()
        Me.TextJenisDiskon = New System.Windows.Forms.TextBox()
        Me.LabelHargaAkhir = New System.Windows.Forms.Label()
        Me.TextHargaAkhir = New System.Windows.Forms.TextBox()
        Me.TextHARGA = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'KALKULATOR
        '
        Me.KALKULATOR.AutoSize = True
        Me.KALKULATOR.Font = New System.Drawing.Font("Lucida Handwriting", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KALKULATOR.ForeColor = System.Drawing.Color.DarkRed
        Me.KALKULATOR.Location = New System.Drawing.Point(246, 27)
        Me.KALKULATOR.Name = "KALKULATOR"
        Me.KALKULATOR.Size = New System.Drawing.Size(344, 36)
        Me.KALKULATOR.TabIndex = 0
        Me.KALKULATOR.Text = "KALKULATOR DISKON"
        '
        'LblBarang
        '
        Me.LblBarang.AutoSize = True
        Me.LblBarang.Location = New System.Drawing.Point(52, 101)
        Me.LblBarang.Name = "LblBarang"
        Me.LblBarang.Size = New System.Drawing.Size(79, 13)
        Me.LblBarang.TabIndex = 1
        Me.LblBarang.Text = "Harga Barang ;"
        '
        'LblDISKON
        '
        Me.LblDISKON.AutoSize = True
        Me.LblDISKON.Location = New System.Drawing.Point(52, 152)
        Me.LblDISKON.Name = "LblDISKON"
        Me.LblDISKON.Size = New System.Drawing.Size(125, 13)
        Me.LblDISKON.TabIndex = 2
        Me.LblDISKON.Text = "Persentanse Diskon (%) :"
        '
        'TextDISKON
        '
        Me.TextDISKON.Location = New System.Drawing.Point(197, 149)
        Me.TextDISKON.Name = "TextDISKON"
        Me.TextDISKON.Size = New System.Drawing.Size(497, 20)
        Me.TextDISKON.TabIndex = 4
        '
        'ButtonHITUNG
        '
        Me.ButtonHITUNG.Location = New System.Drawing.Point(197, 197)
        Me.ButtonHITUNG.Name = "ButtonHITUNG"
        Me.ButtonHITUNG.Size = New System.Drawing.Size(243, 47)
        Me.ButtonHITUNG.TabIndex = 5
        Me.ButtonHITUNG.Text = "HITUNG"
        Me.ButtonHITUNG.UseVisualStyleBackColor = True
        '
        'ButtonBERSIH
        '
        Me.ButtonBERSIH.Location = New System.Drawing.Point(446, 197)
        Me.ButtonBERSIH.Name = "ButtonBERSIH"
        Me.ButtonBERSIH.Size = New System.Drawing.Size(248, 47)
        Me.ButtonBERSIH.TabIndex = 6
        Me.ButtonBERSIH.Text = "BERSIHKAN"
        Me.ButtonBERSIH.UseVisualStyleBackColor = True
        '
        'LabelJenisDiskon
        '
        Me.LabelJenisDiskon.AutoSize = True
        Me.LabelJenisDiskon.Location = New System.Drawing.Point(52, 270)
        Me.LabelJenisDiskon.Name = "LabelJenisDiskon"
        Me.LabelJenisDiskon.Size = New System.Drawing.Size(73, 13)
        Me.LabelJenisDiskon.TabIndex = 7
        Me.LabelJenisDiskon.Text = "Jenis Diskon ;"
        '
        'TextJenisDiskon
        '
        Me.TextJenisDiskon.Location = New System.Drawing.Point(197, 263)
        Me.TextJenisDiskon.Name = "TextJenisDiskon"
        Me.TextJenisDiskon.Size = New System.Drawing.Size(497, 20)
        Me.TextJenisDiskon.TabIndex = 8
        '
        'LabelHargaAkhir
        '
        Me.LabelHargaAkhir.AutoSize = True
        Me.LabelHargaAkhir.Location = New System.Drawing.Point(52, 319)
        Me.LabelHargaAkhir.Name = "LabelHargaAkhir"
        Me.LabelHargaAkhir.Size = New System.Drawing.Size(72, 13)
        Me.LabelHargaAkhir.TabIndex = 9
        Me.LabelHargaAkhir.Text = " Harga Akhir :"
        '
        'TextHargaAkhir
        '
        Me.TextHargaAkhir.Location = New System.Drawing.Point(197, 312)
        Me.TextHargaAkhir.Name = "TextHargaAkhir"
        Me.TextHargaAkhir.Size = New System.Drawing.Size(497, 20)
        Me.TextHargaAkhir.TabIndex = 10
        '
        'TextHARGA
        '
        Me.TextHARGA.Location = New System.Drawing.Point(197, 98)
        Me.TextHARGA.Name = "TextHARGA"
        Me.TextHARGA.Size = New System.Drawing.Size(497, 20)
        Me.TextHARGA.TabIndex = 11
        '
        'TUGAS_PRAKTIKUM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PERCABANGAN_KESA.My.Resources.Resources.duck
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextHARGA)
        Me.Controls.Add(Me.TextHargaAkhir)
        Me.Controls.Add(Me.LabelHargaAkhir)
        Me.Controls.Add(Me.TextJenisDiskon)
        Me.Controls.Add(Me.LabelJenisDiskon)
        Me.Controls.Add(Me.ButtonBERSIH)
        Me.Controls.Add(Me.ButtonHITUNG)
        Me.Controls.Add(Me.TextDISKON)
        Me.Controls.Add(Me.LblDISKON)
        Me.Controls.Add(Me.LblBarang)
        Me.Controls.Add(Me.KALKULATOR)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "TUGAS_PRAKTIKUM"
        Me.Text = "TUGAS_PRAKTIKUM"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents KALKULATOR As Label
    Friend WithEvents LblBarang As Label
    Friend WithEvents LblDISKON As Label
    Friend WithEvents TextDISKON As TextBox
    Friend WithEvents ButtonHITUNG As Button
    Friend WithEvents ButtonBERSIH As Button
    Friend WithEvents LabelJenisDiskon As Label
    Friend WithEvents TextJenisDiskon As TextBox
    Friend WithEvents LabelHargaAkhir As Label
    Friend WithEvents TextHargaAkhir As TextBox
    Friend WithEvents TextHARGA As TextBox
End Class
