<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Praktikumvb
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
        Me.TxtAngka = New System.Windows.Forms.TextBox()
        Me.TxtBagi = New System.Windows.Forms.TextBox()
        Me.BtnBagi = New System.Windows.Forms.Button()
        Me.LblAngka = New System.Windows.Forms.Label()
        Me.LblBagi = New System.Windows.Forms.Label()
        Me.LblHasil = New System.Windows.Forms.Label()
        Me.LblHasilHasil = New System.Windows.Forms.Label()
        Me.BtnBErsih = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtAngka
        '
        Me.TxtAngka.Location = New System.Drawing.Point(155, 100)
        Me.TxtAngka.Name = "TxtAngka"
        Me.TxtAngka.Size = New System.Drawing.Size(591, 20)
        Me.TxtAngka.TabIndex = 0
        '
        'TxtBagi
        '
        Me.TxtBagi.Location = New System.Drawing.Point(155, 155)
        Me.TxtBagi.Name = "TxtBagi"
        Me.TxtBagi.Size = New System.Drawing.Size(591, 20)
        Me.TxtBagi.TabIndex = 1
        '
        'BtnBagi
        '
        Me.BtnBagi.Location = New System.Drawing.Point(155, 195)
        Me.BtnBagi.Name = "BtnBagi"
        Me.BtnBagi.Size = New System.Drawing.Size(251, 59)
        Me.BtnBagi.TabIndex = 2
        Me.BtnBagi.Text = "BAGI"
        Me.BtnBagi.UseVisualStyleBackColor = True
        '
        'LblAngka
        '
        Me.LblAngka.AutoSize = True
        Me.LblAngka.Location = New System.Drawing.Point(30, 103)
        Me.LblAngka.Name = "LblAngka"
        Me.LblAngka.Size = New System.Drawing.Size(91, 13)
        Me.LblAngka.TabIndex = 3
        Me.LblAngka.Text = "Masukkan Angka"
        '
        'LblBagi
        '
        Me.LblBagi.AutoSize = True
        Me.LblBagi.Location = New System.Drawing.Point(30, 158)
        Me.LblBagi.Name = "LblBagi"
        Me.LblBagi.Size = New System.Drawing.Size(119, 13)
        Me.LblBagi.TabIndex = 4
        Me.LblBagi.Text = "Masukkan Pembagian :"
        '
        'LblHasil
        '
        Me.LblHasil.AutoSize = True
        Me.LblHasil.Location = New System.Drawing.Point(30, 317)
        Me.LblHasil.Name = "LblHasil"
        Me.LblHasil.Size = New System.Drawing.Size(33, 13)
        Me.LblHasil.TabIndex = 5
        Me.LblHasil.Text = "Hasil "
        '
        'LblHasilHasil
        '
        Me.LblHasilHasil.AutoSize = True
        Me.LblHasilHasil.Location = New System.Drawing.Point(152, 317)
        Me.LblHasilHasil.Name = "LblHasilHasil"
        Me.LblHasilHasil.Size = New System.Drawing.Size(10, 13)
        Me.LblHasilHasil.TabIndex = 6
        Me.LblHasilHasil.Text = "-"
        '
        'BtnBErsih
        '
        Me.BtnBErsih.Location = New System.Drawing.Point(512, 195)
        Me.BtnBErsih.Name = "BtnBErsih"
        Me.BtnBErsih.Size = New System.Drawing.Size(234, 59)
        Me.BtnBErsih.TabIndex = 8
        Me.BtnBErsih.Text = "BERSIH"
        Me.BtnBErsih.UseVisualStyleBackColor = True
        '
        'Praktikumvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnBErsih)
        Me.Controls.Add(Me.LblHasilHasil)
        Me.Controls.Add(Me.LblHasil)
        Me.Controls.Add(Me.LblBagi)
        Me.Controls.Add(Me.LblAngka)
        Me.Controls.Add(Me.BtnBagi)
        Me.Controls.Add(Me.TxtBagi)
        Me.Controls.Add(Me.TxtAngka)
        Me.Name = "Praktikumvb"
        Me.Text = "Praktikumvb"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtAngka As TextBox
    Friend WithEvents TxtBagi As TextBox
    Friend WithEvents BtnBagi As Button
    Friend WithEvents LblAngka As Label
    Friend WithEvents LblBagi As Label
    Friend WithEvents LblHasil As Label
    Friend WithEvents LblHasilHasil As Label
    Friend WithEvents BtnBErsih As Button
End Class
