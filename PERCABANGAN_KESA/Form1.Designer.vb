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
        Me.LblUmur = New System.Windows.Forms.Label()
        Me.TextUmur = New System.Windows.Forms.TextBox()
        Me.TextHASIL = New System.Windows.Forms.TextBox()
        Me.BTNCek = New System.Windows.Forms.Button()
        Me.Lblhasil = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblUmur
        '
        Me.LblUmur.AutoSize = True
        Me.LblUmur.Location = New System.Drawing.Point(128, 96)
        Me.LblUmur.Name = "LblUmur"
        Me.LblUmur.Size = New System.Drawing.Size(91, 13)
        Me.LblUmur.TabIndex = 0
        Me.LblUmur.Text = "Masukkan Umur :"
        '
        'TextUmur
        '
        Me.TextUmur.Location = New System.Drawing.Point(223, 89)
        Me.TextUmur.Name = "TextUmur"
        Me.TextUmur.Size = New System.Drawing.Size(308, 20)
        Me.TextUmur.TabIndex = 1
        '
        'TextHASIL
        '
        Me.TextHASIL.Location = New System.Drawing.Point(223, 191)
        Me.TextHASIL.Name = "TextHASIL"
        Me.TextHASIL.Size = New System.Drawing.Size(308, 20)
        Me.TextHASIL.TabIndex = 2
        '
        'BTNCek
        '
        Me.BTNCek.Location = New System.Drawing.Point(223, 115)
        Me.BTNCek.Name = "BTNCek"
        Me.BTNCek.Size = New System.Drawing.Size(308, 51)
        Me.BTNCek.TabIndex = 3
        Me.BTNCek.Text = "CEK"
        Me.BTNCek.UseVisualStyleBackColor = True
        '
        'Lblhasil
        '
        Me.Lblhasil.AutoSize = True
        Me.Lblhasil.Location = New System.Drawing.Point(128, 198)
        Me.Lblhasil.Name = "Lblhasil"
        Me.Lblhasil.Size = New System.Drawing.Size(44, 13)
        Me.Lblhasil.TabIndex = 4
        Me.Lblhasil.Text = "HASIL :"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Lblhasil)
        Me.Controls.Add(Me.BTNCek)
        Me.Controls.Add(Me.TextHASIL)
        Me.Controls.Add(Me.TextUmur)
        Me.Controls.Add(Me.LblUmur)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblUmur As Label
    Friend WithEvents TextUmur As TextBox
    Friend WithEvents TextHASIL As TextBox
    Friend WithEvents BTNCek As Button
    Friend WithEvents Lblhasil As Label
End Class
