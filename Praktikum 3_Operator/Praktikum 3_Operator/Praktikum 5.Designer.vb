<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Praktikum_5
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
        TextA = New TextBox()
        ButtonProses = New Button()
        TextB = New TextBox()
        LabelNilaiA = New Label()
        LabelNilaiB = New Label()
        Labelhasil = New Label()
        SuspendLayout()
        ' 
        ' TextA
        ' 
        TextA.Location = New Point(261, 126)
        TextA.Name = "TextA"
        TextA.Size = New Size(324, 23)
        TextA.TabIndex = 0
        ' 
        ' ButtonProses
        ' 
        ButtonProses.Location = New Point(261, 215)
        ButtonProses.Name = "ButtonProses"
        ButtonProses.Size = New Size(168, 49)
        ButtonProses.TabIndex = 1
        ButtonProses.Text = "Proses"
        ButtonProses.UseVisualStyleBackColor = True
        ' 
        ' TextB
        ' 
        TextB.Location = New Point(261, 168)
        TextB.Name = "TextB"
        TextB.Size = New Size(324, 23)
        TextB.TabIndex = 2
        ' 
        ' LabelNilaiA
        ' 
        LabelNilaiA.AutoSize = True
        LabelNilaiA.Location = New Point(153, 126)
        LabelNilaiA.Name = "LabelNilaiA"
        LabelNilaiA.Size = New Size(48, 15)
        LabelNilaiA.TabIndex = 3
        LabelNilaiA.Text = "Nilai A :"
        ' 
        ' LabelNilaiB
        ' 
        LabelNilaiB.AutoSize = True
        LabelNilaiB.Location = New Point(153, 176)
        LabelNilaiB.Name = "LabelNilaiB"
        LabelNilaiB.Size = New Size(47, 15)
        LabelNilaiB.TabIndex = 4
        LabelNilaiB.Text = "Nilai B :"
        ' 
        ' Labelhasil
        ' 
        Labelhasil.AutoSize = True
        Labelhasil.Location = New Point(153, 299)
        Labelhasil.Name = "Labelhasil"
        Labelhasil.Size = New Size(33, 15)
        Labelhasil.TabIndex = 5
        Labelhasil.Text = "Hasil"
        ' 
        ' Praktikum_5
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Labelhasil)
        Controls.Add(LabelNilaiB)
        Controls.Add(LabelNilaiA)
        Controls.Add(TextB)
        Controls.Add(ButtonProses)
        Controls.Add(TextA)
        Name = "Praktikum_5"
        Text = "Praktikum_5"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextA As TextBox
    Friend WithEvents ButtonProses As Button
    Friend WithEvents TextB As TextBox
    Friend WithEvents LabelNilaiA As Label
    Friend WithEvents LabelNilaiB As Label
    Friend WithEvents Labelhasil As Label
End Class
