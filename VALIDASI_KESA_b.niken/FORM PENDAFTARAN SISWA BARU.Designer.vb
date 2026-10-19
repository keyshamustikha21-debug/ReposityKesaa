<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FORM_PENDAFTARAN_SISWA_BARU
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
        Me.LblNama = New System.Windows.Forms.Label()
        Me.LblNISN = New System.Windows.Forms.Label()
        Me.LblUsia = New System.Windows.Forms.Label()
        Me.LblEmail = New System.Windows.Forms.Label()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.TxtUsia = New System.Windows.Forms.TextBox()
        Me.TxtNISN = New System.Windows.Forms.TextBox()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.BtnDaftar = New System.Windows.Forms.Button()
        Me.BtnBersih = New System.Windows.Forms.Button()
        Me.BtnKeluar = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblJUDUL
        '
        Me.LblJUDUL.AutoSize = True
        Me.LblJUDUL.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.LblJUDUL.Location = New System.Drawing.Point(221, 55)
        Me.LblJUDUL.Name = "LblJUDUL"
        Me.LblJUDUL.Size = New System.Drawing.Size(354, 25)
        Me.LblJUDUL.TabIndex = 0
        Me.LblJUDUL.Text = "FORM PENDAFTARAN SISWA BARU"
        '
        'LblNama
        '
        Me.LblNama.AutoSize = True
        Me.LblNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LblNama.Location = New System.Drawing.Point(45, 125)
        Me.LblNama.Name = "LblNama"
        Me.LblNama.Size = New System.Drawing.Size(53, 17)
        Me.LblNama.TabIndex = 1
        Me.LblNama.Text = "Nama :"
        '
        'LblNISN
        '
        Me.LblNISN.AutoSize = True
        Me.LblNISN.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LblNISN.Location = New System.Drawing.Point(45, 180)
        Me.LblNISN.Name = "LblNISN"
        Me.LblNISN.Size = New System.Drawing.Size(48, 17)
        Me.LblNISN.TabIndex = 2
        Me.LblNISN.Text = "NISN :"
        '
        'LblUsia
        '
        Me.LblUsia.AutoSize = True
        Me.LblUsia.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LblUsia.Location = New System.Drawing.Point(45, 238)
        Me.LblUsia.Name = "LblUsia"
        Me.LblUsia.Size = New System.Drawing.Size(44, 17)
        Me.LblUsia.TabIndex = 3
        Me.LblUsia.Text = "Usia :"
        '
        'LblEmail
        '
        Me.LblEmail.AutoSize = True
        Me.LblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LblEmail.Location = New System.Drawing.Point(45, 302)
        Me.LblEmail.Name = "LblEmail"
        Me.LblEmail.Size = New System.Drawing.Size(50, 17)
        Me.LblEmail.TabIndex = 4
        Me.LblEmail.Text = "Email :"
        '
        'TxtNama
        '
        Me.TxtNama.Location = New System.Drawing.Point(104, 122)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(611, 20)
        Me.TxtNama.TabIndex = 5
        '
        'TxtUsia
        '
        Me.TxtUsia.Location = New System.Drawing.Point(104, 237)
        Me.TxtUsia.Name = "TxtUsia"
        Me.TxtUsia.Size = New System.Drawing.Size(611, 20)
        Me.TxtUsia.TabIndex = 6
        '
        'TxtNISN
        '
        Me.TxtNISN.Location = New System.Drawing.Point(104, 177)
        Me.TxtNISN.Name = "TxtNISN"
        Me.TxtNISN.Size = New System.Drawing.Size(611, 20)
        Me.TxtNISN.TabIndex = 7
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(104, 301)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(611, 20)
        Me.TxtEmail.TabIndex = 8
        '
        'BtnDaftar
        '
        Me.BtnDaftar.BackColor = System.Drawing.Color.RosyBrown
        Me.BtnDaftar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnDaftar.Location = New System.Drawing.Point(103, 349)
        Me.BtnDaftar.Name = "BtnDaftar"
        Me.BtnDaftar.Size = New System.Drawing.Size(204, 51)
        Me.BtnDaftar.TabIndex = 9
        Me.BtnDaftar.Text = "DAFTAR"
        Me.BtnDaftar.UseVisualStyleBackColor = False
        '
        'BtnBersih
        '
        Me.BtnBersih.BackColor = System.Drawing.Color.RosyBrown
        Me.BtnBersih.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BtnBersih.Location = New System.Drawing.Point(307, 349)
        Me.BtnBersih.Name = "BtnBersih"
        Me.BtnBersih.Size = New System.Drawing.Size(204, 51)
        Me.BtnBersih.TabIndex = 10
        Me.BtnBersih.Text = "BERSIH"
        Me.BtnBersih.UseVisualStyleBackColor = False
        '
        'BtnKeluar
        '
        Me.BtnKeluar.BackColor = System.Drawing.Color.RosyBrown
        Me.BtnKeluar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BtnKeluar.Location = New System.Drawing.Point(511, 349)
        Me.BtnKeluar.Name = "BtnKeluar"
        Me.BtnKeluar.Size = New System.Drawing.Size(204, 51)
        Me.BtnKeluar.TabIndex = 11
        Me.BtnKeluar.Text = "KELUAR"
        Me.BtnKeluar.UseVisualStyleBackColor = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'FORM_PENDAFTARAN_SISWA_BARU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnKeluar)
        Me.Controls.Add(Me.BtnBersih)
        Me.Controls.Add(Me.BtnDaftar)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.TxtNISN)
        Me.Controls.Add(Me.TxtUsia)
        Me.Controls.Add(Me.TxtNama)
        Me.Controls.Add(Me.LblEmail)
        Me.Controls.Add(Me.LblUsia)
        Me.Controls.Add(Me.LblNISN)
        Me.Controls.Add(Me.LblNama)
        Me.Controls.Add(Me.LblJUDUL)
        Me.Name = "FORM_PENDAFTARAN_SISWA_BARU"
        Me.Text = "FORM_PENDAFTARAN_SISWA_BARU"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblJUDUL As Label
    Friend WithEvents LblNama As Label
    Friend WithEvents LblNISN As Label
    Friend WithEvents LblUsia As Label
    Friend WithEvents LblEmail As Label
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents TxtUsia As TextBox
    Friend WithEvents TxtNISN As TextBox
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents BtnDaftar As Button
    Friend WithEvents BtnBersih As Button
    Friend WithEvents BtnKeluar As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
