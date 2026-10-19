<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class APK_CEK_UMUR
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
        Me.components = New System.ComponentModel.Container()
        Me.LblJUDUL = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblUmur = New System.Windows.Forms.Label()
        Me.TxtTahunLahir = New System.Windows.Forms.TextBox()
        Me.BtnCekUmur = New System.Windows.Forms.Button()
        Me.BtnBersih = New System.Windows.Forms.Button()
        Me.BtnKeluar = New System.Windows.Forms.Button()
        Me.LblHasilUmur = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblJUDUL
        '
        Me.LblJUDUL.AutoSize = True
        Me.LblJUDUL.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.LblJUDUL.Location = New System.Drawing.Point(225, 40)
        Me.LblJUDUL.Name = "LblJUDUL"
        Me.LblJUDUL.Size = New System.Drawing.Size(363, 39)
        Me.LblJUDUL.TabIndex = 0
        Me.LblJUDUL.Text = "APLIKASI CEK UMUR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(41, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tahun Lahir :"
        '
        'LblUmur
        '
        Me.LblUmur.AutoSize = True
        Me.LblUmur.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblUmur.Location = New System.Drawing.Point(42, 285)
        Me.LblUmur.Name = "LblUmur"
        Me.LblUmur.Size = New System.Drawing.Size(56, 20)
        Me.LblUmur.TabIndex = 2
        Me.LblUmur.Text = "Umur :"
        '
        'TxtTahunLahir
        '
        Me.TxtTahunLahir.Location = New System.Drawing.Point(174, 119)
        Me.TxtTahunLahir.Name = "TxtTahunLahir"
        Me.TxtTahunLahir.Size = New System.Drawing.Size(569, 20)
        Me.TxtTahunLahir.TabIndex = 3
        '
        'BtnCekUmur
        '
        Me.BtnCekUmur.BackColor = System.Drawing.Color.Sienna
        Me.BtnCekUmur.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnCekUmur.Location = New System.Drawing.Point(175, 177)
        Me.BtnCekUmur.Name = "BtnCekUmur"
        Me.BtnCekUmur.Size = New System.Drawing.Size(165, 46)
        Me.BtnCekUmur.TabIndex = 4
        Me.BtnCekUmur.Text = "CEK UMUR"
        Me.BtnCekUmur.UseVisualStyleBackColor = False
        '
        'BtnBersih
        '
        Me.BtnBersih.BackColor = System.Drawing.Color.Sienna
        Me.BtnBersih.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnBersih.Location = New System.Drawing.Point(382, 177)
        Me.BtnBersih.Name = "BtnBersih"
        Me.BtnBersih.Size = New System.Drawing.Size(165, 46)
        Me.BtnBersih.TabIndex = 5
        Me.BtnBersih.Text = "BERSIH"
        Me.BtnBersih.UseVisualStyleBackColor = False
        '
        'BtnKeluar
        '
        Me.BtnKeluar.BackColor = System.Drawing.Color.Sienna
        Me.BtnKeluar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnKeluar.Location = New System.Drawing.Point(578, 177)
        Me.BtnKeluar.Name = "BtnKeluar"
        Me.BtnKeluar.Size = New System.Drawing.Size(165, 46)
        Me.BtnKeluar.TabIndex = 6
        Me.BtnKeluar.Text = "KELUAR"
        Me.BtnKeluar.UseVisualStyleBackColor = False
        '
        'LblHasilUmur
        '
        Me.LblHasilUmur.AutoSize = True
        Me.LblHasilUmur.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.LblHasilUmur.Location = New System.Drawing.Point(172, 285)
        Me.LblHasilUmur.Name = "LblHasilUmur"
        Me.LblHasilUmur.Size = New System.Drawing.Size(0, 18)
        Me.LblHasilUmur.TabIndex = 7
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'APK_CEK_UMUR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LblHasilUmur)
        Me.Controls.Add(Me.BtnKeluar)
        Me.Controls.Add(Me.BtnBersih)
        Me.Controls.Add(Me.BtnCekUmur)
        Me.Controls.Add(Me.TxtTahunLahir)
        Me.Controls.Add(Me.LblUmur)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblJUDUL)
        Me.Name = "APK_CEK_UMUR"
        Me.Text = "APK_CEK_UMUR"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblJUDUL As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LblUmur As Label
    Friend WithEvents TxtTahunLahir As TextBox
    Friend WithEvents BtnCekUmur As Button
    Friend WithEvents BtnBersih As Button
    Friend WithEvents BtnKeluar As Button
    Friend WithEvents LblHasilUmur As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
