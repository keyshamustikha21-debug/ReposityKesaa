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
        Me.components = New System.ComponentModel.Container()
        Me.LblJudul = New System.Windows.Forms.Label()
        Me.LblCelcius = New System.Windows.Forms.Label()
        Me.BtnKonversi = New System.Windows.Forms.Button()
        Me.BtnBersih = New System.Windows.Forms.Button()
        Me.BtnKeluar = New System.Windows.Forms.Button()
        Me.TxtSuhuCelcius = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblJudul
        '
        Me.LblJudul.AutoSize = True
        Me.LblJudul.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblJudul.Location = New System.Drawing.Point(331, 49)
        Me.LblJudul.Name = "LblJudul"
        Me.LblJudul.Size = New System.Drawing.Size(142, 20)
        Me.LblJudul.TabIndex = 0
        Me.LblJudul.Text = "KONVENSI SUHU"
        '
        'LblCelcius
        '
        Me.LblCelcius.AutoSize = True
        Me.LblCelcius.Location = New System.Drawing.Point(51, 151)
        Me.LblCelcius.Name = "LblCelcius"
        Me.LblCelcius.Size = New System.Drawing.Size(131, 13)
        Me.LblCelcius.TabIndex = 1
        Me.LblCelcius.Text = " Masukkan Suhu Celcius :"
        '
        'BtnKonversi
        '
        Me.BtnKonversi.Location = New System.Drawing.Point(188, 215)
        Me.BtnKonversi.Name = "BtnKonversi"
        Me.BtnKonversi.Size = New System.Drawing.Size(273, 45)
        Me.BtnKonversi.TabIndex = 3
        Me.BtnKonversi.Text = "KONVERSI"
        Me.BtnKonversi.UseVisualStyleBackColor = True
        '
        'BtnBersih
        '
        Me.BtnBersih.Location = New System.Drawing.Point(467, 215)
        Me.BtnBersih.Name = "BtnBersih"
        Me.BtnBersih.Size = New System.Drawing.Size(277, 45)
        Me.BtnBersih.TabIndex = 4
        Me.BtnBersih.Text = "BERSIHKAN"
        Me.BtnBersih.UseVisualStyleBackColor = True
        '
        'BtnKeluar
        '
        Me.BtnKeluar.Location = New System.Drawing.Point(188, 287)
        Me.BtnKeluar.Name = "BtnKeluar"
        Me.BtnKeluar.Size = New System.Drawing.Size(556, 45)
        Me.BtnKeluar.TabIndex = 5
        Me.BtnKeluar.Text = "KELUAR"
        Me.BtnKeluar.UseVisualStyleBackColor = True
        '
        'TxtSuhuCelcius
        '
        Me.TxtSuhuCelcius.Location = New System.Drawing.Point(188, 148)
        Me.TxtSuhuCelcius.Name = "TxtSuhuCelcius"
        Me.TxtSuhuCelcius.Size = New System.Drawing.Size(556, 20)
        Me.TxtSuhuCelcius.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(293, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(212, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "CELCIUS KE FAHRENHEIT"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtSuhuCelcius)
        Me.Controls.Add(Me.BtnKeluar)
        Me.Controls.Add(Me.BtnBersih)
        Me.Controls.Add(Me.BtnKonversi)
        Me.Controls.Add(Me.LblCelcius)
        Me.Controls.Add(Me.LblJudul)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblJudul As Label
    Friend WithEvents LblCelcius As Label
    Friend WithEvents BtnKonversi As Button
    Friend WithEvents BtnBersih As Button
    Friend WithEvents BtnKeluar As Button
    Friend WithEvents TxtSuhuCelcius As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
