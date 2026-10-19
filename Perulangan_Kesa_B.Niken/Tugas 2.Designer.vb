<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tugas_2
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
        Me.LblJudul = New System.Windows.Forms.Label()
        Me.BtnMulai = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblJudul
        '
        Me.LblJudul.AutoSize = True
        Me.LblJudul.Location = New System.Drawing.Point(369, 70)
        Me.LblJudul.Name = "LblJudul"
        Me.LblJudul.Size = New System.Drawing.Size(207, 13)
        Me.LblJudul.TabIndex = 0
        Me.LblJudul.Text = "PROGRAM PENJUMLAHAN BERULANG"
        '
        'BtnMulai
        '
        Me.BtnMulai.Location = New System.Drawing.Point(32, 143)
        Me.BtnMulai.Name = "BtnMulai"
        Me.BtnMulai.Size = New System.Drawing.Size(730, 77)
        Me.BtnMulai.TabIndex = 1
        Me.BtnMulai.Text = "MULAIII"
        Me.BtnMulai.UseVisualStyleBackColor = True
        '
        'Tugas_2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnMulai)
        Me.Controls.Add(Me.LblJudul)
        Me.Name = "Tugas_2"
        Me.Text = "Tugas_2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblJudul As Label
    Friend WithEvents BtnMulai As Button
End Class
