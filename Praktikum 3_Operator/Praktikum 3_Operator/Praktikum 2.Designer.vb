<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Praktikum_2
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
        ButtonCek = New Button()
        LabelNilaiA = New Label()
        TextNilaiA = New TextBox()
        LabelNilaiB = New Label()
        TextNilaiB = New TextBox()
        LabelHasil = New Label()
        TextHasil = New TextBox()
        SuspendLayout()
        ' 
        ' ButtonCek
        ' 
        ButtonCek.Location = New Point(242, 231)
        ButtonCek.Name = "ButtonCek"
        ButtonCek.Size = New Size(363, 55)
        ButtonCek.TabIndex = 0
        ButtonCek.Text = "CEK HASIL"
        ButtonCek.UseVisualStyleBackColor = True
        ' 
        ' LabelNilaiA
        ' 
        LabelNilaiA.AutoSize = True
        LabelNilaiA.Location = New Point(82, 165)
        LabelNilaiA.Name = "LabelNilaiA"
        LabelNilaiA.Size = New Size(53, 15)
        LabelNilaiA.TabIndex = 1
        LabelNilaiA.Text = "NILAI A :"
        ' 
        ' TextNilaiA
        ' 
        TextNilaiA.Location = New Point(241, 162)
        TextNilaiA.Name = "TextNilaiA"
        TextNilaiA.Size = New Size(363, 23)
        TextNilaiA.TabIndex = 2
        ' 
        ' LabelNilaiB
        ' 
        LabelNilaiB.AutoSize = True
        LabelNilaiB.Location = New Point(82, 199)
        LabelNilaiB.Name = "LabelNilaiB"
        LabelNilaiB.Size = New Size(52, 15)
        LabelNilaiB.TabIndex = 3
        LabelNilaiB.Text = "NILAI B :"
        ' 
        ' TextNilaiB
        ' 
        TextNilaiB.Location = New Point(241, 191)
        TextNilaiB.Name = "TextNilaiB"
        TextNilaiB.Size = New Size(363, 23)
        TextNilaiB.TabIndex = 4
        ' 
        ' LabelHasil
        ' 
        LabelHasil.AutoSize = True
        LabelHasil.Location = New Point(82, 330)
        LabelHasil.Name = "LabelHasil"
        LabelHasil.Size = New Size(39, 15)
        LabelHasil.TabIndex = 5
        LabelHasil.Text = "Hasil :"
        ' 
        ' TextHasil
        ' 
        TextHasil.Location = New Point(241, 327)
        TextHasil.Name = "TextHasil"
        TextHasil.Size = New Size(363, 23)
        TextHasil.TabIndex = 6
        ' 
        ' Praktikum_2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TextHasil)
        Controls.Add(LabelHasil)
        Controls.Add(TextNilaiB)
        Controls.Add(LabelNilaiB)
        Controls.Add(TextNilaiA)
        Controls.Add(LabelNilaiA)
        Controls.Add(ButtonCek)
        Name = "Praktikum_2"
        Text = "Praktikum_2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ButtonCek As Button
    Friend WithEvents LabelNilaiA As Label
    Friend WithEvents TextNilaiA As TextBox
    Friend WithEvents LabelNilaiB As Label
    Friend WithEvents TextNilaiB As TextBox
    Friend WithEvents LabelHasil As Label
    Friend WithEvents TextHasil As TextBox
End Class
