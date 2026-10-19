<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Tugas_1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LblJudul = New System.Windows.Forms.Label()
        Me.BtnBersih = New System.Windows.Forms.Button()
        Me.BtnTampil = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblJudul
        '
        Me.LblJudul.AutoSize = True
        Me.LblJudul.Location = New System.Drawing.Point(356, 51)
        Me.LblJudul.Name = "LblJudul"
        Me.LblJudul.Size = New System.Drawing.Size(119, 13)
        Me.LblJudul.TabIndex = 0
        Me.LblJudul.Text = "Bilangan Genap (1-50) :"
        '
        'BtnBersih
        '
        Me.BtnBersih.Location = New System.Drawing.Point(123, 100)
        Me.BtnBersih.Name = "BtnBersih"
        Me.BtnBersih.Size = New System.Drawing.Size(214, 57)
        Me.BtnBersih.TabIndex = 2
        Me.BtnBersih.Text = "BERSIHKAN"
        Me.BtnBersih.UseVisualStyleBackColor = True
        '
        'BtnTampil
        '
        Me.BtnTampil.Location = New System.Drawing.Point(516, 100)
        Me.BtnTampil.Name = "BtnTampil"
        Me.BtnTampil.Size = New System.Drawing.Size(216, 57)
        Me.BtnTampil.TabIndex = 3
        Me.BtnTampil.Text = "TAMPILKAN"
        Me.BtnTampil.UseVisualStyleBackColor = True
        '
        'Tugas_1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnTampil)
        Me.Controls.Add(Me.BtnBersih)
        Me.Controls.Add(Me.LblJudul)
        Me.Name = "Tugas_1"
        Me.Text = "Program Bilangan Genap"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblJudul As Label
    Friend WithEvents BtnBersih As Button
    Friend WithEvents BtnTampil As Button
End Class
