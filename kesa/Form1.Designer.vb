<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.LblPertama = New System.Windows.Forms.Label()
        Me.LblKedua = New System.Windows.Forms.Label()
        Me.TxtangkaPertama = New System.Windows.Forms.TextBox()
        Me.TxtangkaKedua = New System.Windows.Forms.TextBox()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.BtnKurang = New System.Windows.Forms.Button()
        Me.BtnKali = New System.Windows.Forms.Button()
        Me.BtnBagi = New System.Windows.Forms.Button()
        Me.LblHASIL = New System.Windows.Forms.Label()
        Me.TxtHasil = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LblPertama
        '
        Me.LblPertama.AutoSize = True
        Me.LblPertama.Location = New System.Drawing.Point(41, 67)
        Me.LblPertama.Name = "LblPertama"
        Me.LblPertama.Size = New System.Drawing.Size(86, 13)
        Me.LblPertama.TabIndex = 0
        Me.LblPertama.Text = "Angka Pertama :"
        '
        'LblKedua
        '
        Me.LblKedua.AutoSize = True
        Me.LblKedua.Location = New System.Drawing.Point(41, 120)
        Me.LblKedua.Name = "LblKedua"
        Me.LblKedua.Size = New System.Drawing.Size(78, 13)
        Me.LblKedua.TabIndex = 1
        Me.LblKedua.Text = "Angka Kedua :"
        '
        'TxtangkaPertama
        '
        Me.TxtangkaPertama.Location = New System.Drawing.Point(133, 64)
        Me.TxtangkaPertama.Name = "TxtangkaPertama"
        Me.TxtangkaPertama.Size = New System.Drawing.Size(434, 20)
        Me.TxtangkaPertama.TabIndex = 2
        '
        'TxtangkaKedua
        '
        Me.TxtangkaKedua.Location = New System.Drawing.Point(133, 117)
        Me.TxtangkaKedua.Name = "TxtangkaKedua"
        Me.TxtangkaKedua.Size = New System.Drawing.Size(434, 20)
        Me.TxtangkaKedua.TabIndex = 3
        '
        'BtnTambah
        '
        Me.BtnTambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.BtnTambah.Location = New System.Drawing.Point(133, 160)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(96, 56)
        Me.BtnTambah.TabIndex = 4
        Me.BtnTambah.Text = "+"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'BtnKurang
        '
        Me.BtnKurang.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.BtnKurang.Location = New System.Drawing.Point(246, 160)
        Me.BtnKurang.Name = "BtnKurang"
        Me.BtnKurang.Size = New System.Drawing.Size(96, 56)
        Me.BtnKurang.TabIndex = 5
        Me.BtnKurang.Text = "-"
        Me.BtnKurang.UseVisualStyleBackColor = True
        '
        'BtnKali
        '
        Me.BtnKali.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.BtnKali.Location = New System.Drawing.Point(359, 160)
        Me.BtnKali.Name = "BtnKali"
        Me.BtnKali.Size = New System.Drawing.Size(96, 56)
        Me.BtnKali.TabIndex = 6
        Me.BtnKali.Text = "X"
        Me.BtnKali.UseVisualStyleBackColor = True
        '
        'BtnBagi
        '
        Me.BtnBagi.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.BtnBagi.Location = New System.Drawing.Point(471, 160)
        Me.BtnBagi.Name = "BtnBagi"
        Me.BtnBagi.Size = New System.Drawing.Size(96, 56)
        Me.BtnBagi.TabIndex = 7
        Me.BtnBagi.Text = "/"
        Me.BtnBagi.UseVisualStyleBackColor = True
        '
        'LblHASIL
        '
        Me.LblHASIL.AutoSize = True
        Me.LblHASIL.Location = New System.Drawing.Point(41, 255)
        Me.LblHASIL.Name = "LblHASIL"
        Me.LblHASIL.Size = New System.Drawing.Size(44, 13)
        Me.LblHASIL.TabIndex = 8
        Me.LblHASIL.Text = "HASIL :"
        '
        'TxtHasil
        '
        Me.TxtHasil.Location = New System.Drawing.Point(133, 252)
        Me.TxtHasil.Name = "TxtHasil"
        Me.TxtHasil.Size = New System.Drawing.Size(434, 20)
        Me.TxtHasil.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TxtHasil)
        Me.Controls.Add(Me.LblHASIL)
        Me.Controls.Add(Me.BtnBagi)
        Me.Controls.Add(Me.BtnKali)
        Me.Controls.Add(Me.BtnKurang)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.TxtangkaKedua)
        Me.Controls.Add(Me.TxtangkaPertama)
        Me.Controls.Add(Me.LblKedua)
        Me.Controls.Add(Me.LblPertama)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblPertama As Label
    Friend WithEvents LblKedua As Label
    Friend WithEvents TxtangkaPertama As TextBox
    Friend WithEvents TxtangkaKedua As TextBox
    Friend WithEvents BtnTambah As Button
    Friend WithEvents BtnKurang As Button
    Friend WithEvents BtnKali As Button
    Friend WithEvents BtnBagi As Button
    Friend WithEvents LblHASIL As Label
    Friend WithEvents TxtHasil As TextBox
End Class
