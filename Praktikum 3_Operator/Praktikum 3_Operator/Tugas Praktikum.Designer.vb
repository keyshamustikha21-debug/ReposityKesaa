<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tugas_Praktikum
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tugas_Praktikum))
        LabelRupiah = New Label()
        Labeluang = New Label()
        LabelHasil = New Label()
        ButtonKonversi = New Button()
        ButtonBersih = New Button()
        ButtonKeluar = New Button()
        ComboBoxUang = New ComboBox()
        TextBoxHasil = New TextBox()
        TextBoxRupiah = New TextBox()
        SuspendLayout()
        ' 
        ' LabelRupiah
        ' 
        LabelRupiah.AutoSize = True
        LabelRupiah.BackColor = Color.OldLace
        LabelRupiah.Font = New Font("Kristen ITC", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelRupiah.ForeColor = Color.SaddleBrown
        LabelRupiah.Location = New Point(70, 125)
        LabelRupiah.Name = "LabelRupiah"
        LabelRupiah.Size = New Size(92, 22)
        LabelRupiah.TabIndex = 0
        LabelRupiah.Text = " RUPIAH :"
        ' 
        ' Labeluang
        ' 
        Labeluang.AutoSize = True
        Labeluang.BackColor = Color.OldLace
        Labeluang.Font = New Font("Kristen ITC", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Labeluang.ForeColor = Color.SaddleBrown
        Labeluang.ImageAlign = ContentAlignment.TopRight
        Labeluang.Location = New Point(70, 175)
        Labeluang.Name = "Labeluang"
        Labeluang.Size = New Size(130, 22)
        Labeluang.TabIndex = 1
        Labeluang.Text = "MATA UANG :"
        ' 
        ' LabelHasil
        ' 
        LabelHasil.AutoSize = True
        LabelHasil.BackColor = Color.OldLace
        LabelHasil.Font = New Font("Kristen ITC", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelHasil.ForeColor = Color.SaddleBrown
        LabelHasil.Location = New Point(70, 222)
        LabelHasil.Name = "LabelHasil"
        LabelHasil.Size = New Size(77, 22)
        LabelHasil.TabIndex = 2
        LabelHasil.Text = "HASIL : "
        ' 
        ' ButtonKonversi
        ' 
        ButtonKonversi.Font = New Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ButtonKonversi.ForeColor = Color.SaddleBrown
        ButtonKonversi.Location = New Point(70, 284)
        ButtonKonversi.Name = "ButtonKonversi"
        ButtonKonversi.Size = New Size(141, 35)
        ButtonKonversi.TabIndex = 3
        ButtonKonversi.Text = "KONVERSI"
        ButtonKonversi.UseVisualStyleBackColor = True
        ' 
        ' ButtonBersih
        ' 
        ButtonBersih.Font = New Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ButtonBersih.ForeColor = Color.Sienna
        ButtonBersih.Location = New Point(236, 284)
        ButtonBersih.Name = "ButtonBersih"
        ButtonBersih.Size = New Size(252, 35)
        ButtonBersih.TabIndex = 4
        ButtonBersih.Text = "BERSIH"
        ButtonBersih.UseVisualStyleBackColor = True
        ' 
        ' ButtonKeluar
        ' 
        ButtonKeluar.Font = New Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ButtonKeluar.ForeColor = Color.Sienna
        ButtonKeluar.Location = New Point(514, 284)
        ButtonKeluar.Name = "ButtonKeluar"
        ButtonKeluar.Size = New Size(148, 35)
        ButtonKeluar.TabIndex = 5
        ButtonKeluar.Text = "KELUAR"
        ButtonKeluar.UseVisualStyleBackColor = True
        ' 
        ' ComboBoxUang
        ' 
        ComboBoxUang.FormattingEnabled = True
        ComboBoxUang.Location = New Point(206, 174)
        ComboBoxUang.Name = "ComboBoxUang"
        ComboBoxUang.Size = New Size(456, 23)
        ComboBoxUang.TabIndex = 6
        ' 
        ' TextBoxHasil
        ' 
        TextBoxHasil.Location = New Point(153, 221)
        TextBoxHasil.Name = "TextBoxHasil"
        TextBoxHasil.Size = New Size(509, 23)
        TextBoxHasil.TabIndex = 7
        ' 
        ' TextBoxRupiah
        ' 
        TextBoxRupiah.Location = New Point(168, 125)
        TextBoxRupiah.Name = "TextBoxRupiah"
        TextBoxRupiah.Size = New Size(494, 23)
        TextBoxRupiah.TabIndex = 8
        ' 
        ' Tugas_Praktikum
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkRed
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(734, 512)
        Controls.Add(TextBoxRupiah)
        Controls.Add(TextBoxHasil)
        Controls.Add(ComboBoxUang)
        Controls.Add(ButtonKeluar)
        Controls.Add(ButtonBersih)
        Controls.Add(ButtonKonversi)
        Controls.Add(LabelHasil)
        Controls.Add(Labeluang)
        Controls.Add(LabelRupiah)
        Name = "Tugas_Praktikum"
        Text = "Tugas_Praktikum"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LabelRupiah As Label
    Friend WithEvents Labeluang As Label
    Friend WithEvents LabelHasil As Label
    Friend WithEvents ButtonKonversi As Button
    Friend WithEvents ButtonBersih As Button
    Friend WithEvents ButtonKeluar As Button
    Friend WithEvents ComboBoxUang As ComboBox
    Friend WithEvents TextBoxHasil As TextBox
    Friend WithEvents TextBoxRupiah As TextBox
End Class
