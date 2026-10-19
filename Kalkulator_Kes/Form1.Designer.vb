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
        Me.LblAngka1 = New System.Windows.Forms.Label()
        Me.LblAngka2 = New System.Windows.Forms.Label()
        Me.TextAngka1 = New System.Windows.Forms.TextBox()
        Me.TextAngka2 = New System.Windows.Forms.TextBox()
        Me.TextHASIL = New System.Windows.Forms.TextBox()
        Me.LblHasil = New System.Windows.Forms.Label()
        Me.ButtonTambah = New System.Windows.Forms.Button()
        Me.ButtonKurang = New System.Windows.Forms.Button()
        Me.ButtonKali = New System.Windows.Forms.Button()
        Me.ButtonBagi = New System.Windows.Forms.Button()
        Me.ButtonBersih = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblAngka1
        '
        Me.LblAngka1.AutoSize = True
        Me.LblAngka1.Location = New System.Drawing.Point(95, 66)
        Me.LblAngka1.Name = "LblAngka1"
        Me.LblAngka1.Size = New System.Drawing.Size(86, 13)
        Me.LblAngka1.TabIndex = 0
        Me.LblAngka1.Text = "Angka Pertama :"
        '
        'LblAngka2
        '
        Me.LblAngka2.AutoSize = True
        Me.LblAngka2.Location = New System.Drawing.Point(95, 119)
        Me.LblAngka2.Name = "LblAngka2"
        Me.LblAngka2.Size = New System.Drawing.Size(78, 13)
        Me.LblAngka2.TabIndex = 1
        Me.LblAngka2.Text = "Angka Kedua :"
        '
        'TextAngka1
        '
        Me.TextAngka1.Location = New System.Drawing.Point(219, 59)
        Me.TextAngka1.Name = "TextAngka1"
        Me.TextAngka1.Size = New System.Drawing.Size(373, 20)
        Me.TextAngka1.TabIndex = 2
        '
        'TextAngka2
        '
        Me.TextAngka2.Location = New System.Drawing.Point(219, 119)
        Me.TextAngka2.Name = "TextAngka2"
        Me.TextAngka2.Size = New System.Drawing.Size(373, 20)
        Me.TextAngka2.TabIndex = 3
        '
        'TextHASIL
        '
        Me.TextHASIL.Location = New System.Drawing.Point(219, 226)
        Me.TextHASIL.Name = "TextHASIL"
        Me.TextHASIL.Size = New System.Drawing.Size(373, 20)
        Me.TextHASIL.TabIndex = 4
        '
        'LblHasil
        '
        Me.LblHasil.AutoSize = True
        Me.LblHasil.Location = New System.Drawing.Point(95, 229)
        Me.LblHasil.Name = "LblHasil"
        Me.LblHasil.Size = New System.Drawing.Size(44, 13)
        Me.LblHasil.TabIndex = 5
        Me.LblHasil.Text = "HASIL ;"
        '
        'ButtonTambah
        '
        Me.ButtonTambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.ButtonTambah.Location = New System.Drawing.Point(219, 145)
        Me.ButtonTambah.Name = "ButtonTambah"
        Me.ButtonTambah.Size = New System.Drawing.Size(74, 62)
        Me.ButtonTambah.TabIndex = 6
        Me.ButtonTambah.Text = "+"
        Me.ButtonTambah.UseVisualStyleBackColor = True
        '
        'ButtonKurang
        '
        Me.ButtonKurang.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.ButtonKurang.Location = New System.Drawing.Point(316, 145)
        Me.ButtonKurang.Name = "ButtonKurang"
        Me.ButtonKurang.Size = New System.Drawing.Size(74, 62)
        Me.ButtonKurang.TabIndex = 7
        Me.ButtonKurang.Text = "-"
        Me.ButtonKurang.UseVisualStyleBackColor = True
        '
        'ButtonKali
        '
        Me.ButtonKali.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.ButtonKali.Location = New System.Drawing.Point(421, 145)
        Me.ButtonKali.Name = "ButtonKali"
        Me.ButtonKali.Size = New System.Drawing.Size(74, 62)
        Me.ButtonKali.TabIndex = 8
        Me.ButtonKali.Text = "X"
        Me.ButtonKali.UseVisualStyleBackColor = True
        '
        'ButtonBagi
        '
        Me.ButtonBagi.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.ButtonBagi.Location = New System.Drawing.Point(518, 145)
        Me.ButtonBagi.Name = "ButtonBagi"
        Me.ButtonBagi.Size = New System.Drawing.Size(74, 62)
        Me.ButtonBagi.TabIndex = 9
        Me.ButtonBagi.Text = "/"
        Me.ButtonBagi.UseVisualStyleBackColor = True
        '
        'ButtonBersih
        '
        Me.ButtonBersih.Location = New System.Drawing.Point(219, 282)
        Me.ButtonBersih.Name = "ButtonBersih"
        Me.ButtonBersih.Size = New System.Drawing.Size(373, 42)
        Me.ButtonBersih.TabIndex = 10
        Me.ButtonBersih.Text = "BERSIHKAN"
        Me.ButtonBersih.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Kalkulator_Kes.My.Resources.Resources._46936021114207093
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonBersih)
        Me.Controls.Add(Me.ButtonBagi)
        Me.Controls.Add(Me.ButtonKali)
        Me.Controls.Add(Me.ButtonKurang)
        Me.Controls.Add(Me.ButtonTambah)
        Me.Controls.Add(Me.LblHasil)
        Me.Controls.Add(Me.TextHASIL)
        Me.Controls.Add(Me.TextAngka2)
        Me.Controls.Add(Me.TextAngka1)
        Me.Controls.Add(Me.LblAngka2)
        Me.Controls.Add(Me.LblAngka1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblAngka1 As Label
    Friend WithEvents LblAngka2 As Label
    Friend WithEvents TextAngka1 As TextBox
    Friend WithEvents TextAngka2 As TextBox
    Friend WithEvents TextHASIL As TextBox
    Friend WithEvents LblHasil As Label
    Friend WithEvents ButtonTambah As Button
    Friend WithEvents ButtonKurang As Button
    Friend WithEvents ButtonKali As Button
    Friend WithEvents ButtonBagi As Button
    Friend WithEvents ButtonBersih As Button
End Class
