<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        TextNilaiA = New TextBox()
        TextNilaiB = New TextBox()
        LabelNilaiA = New Label()
        LabelNilaiB = New Label()
        ButtonHitung = New Button()
        TextHasil = New TextBox()
        LabelHasil = New Label()
        SuspendLayout()
        ' 
        ' TextNilaiA
        ' 
        TextNilaiA.Location = New Point(236, 126)
        TextNilaiA.Name = "TextNilaiA"
        TextNilaiA.Size = New Size(447, 23)
        TextNilaiA.TabIndex = 0
        ' 
        ' TextNilaiB
        ' 
        TextNilaiB.Location = New Point(236, 199)
        TextNilaiB.Name = "TextNilaiB"
        TextNilaiB.Size = New Size(447, 23)
        TextNilaiB.TabIndex = 1
        ' 
        ' LabelNilaiA
        ' 
        LabelNilaiA.AutoSize = True
        LabelNilaiA.Location = New Point(100, 129)
        LabelNilaiA.Name = "LabelNilaiA"
        LabelNilaiA.Size = New Size(105, 15)
        LabelNilaiA.TabIndex = 2
        LabelNilaiA.Text = "Masukkan Nilai A :"
        ' 
        ' LabelNilaiB
        ' 
        LabelNilaiB.AutoSize = True
        LabelNilaiB.Location = New Point(100, 202)
        LabelNilaiB.Name = "LabelNilaiB"
        LabelNilaiB.Size = New Size(104, 15)
        LabelNilaiB.TabIndex = 3
        LabelNilaiB.Text = "Masukkan Nilai B :"
        ' 
        ' ButtonHitung
        ' 
        ButtonHitung.Location = New Point(236, 248)
        ButtonHitung.Name = "ButtonHitung"
        ButtonHitung.Size = New Size(447, 40)
        ButtonHitung.TabIndex = 4
        ButtonHitung.Text = "Hitung"
        ButtonHitung.UseVisualStyleBackColor = True
        ' 
        ' TextHasil
        ' 
        TextHasil.Location = New Point(100, 376)
        TextHasil.Name = "TextHasil"
        TextHasil.Size = New Size(583, 23)
        TextHasil.TabIndex = 5
        ' 
        ' LabelHasil
        ' 
        LabelHasil.AutoSize = True
        LabelHasil.Location = New Point(100, 349)
        LabelHasil.Name = "LabelHasil"
        LabelHasil.Size = New Size(39, 15)
        LabelHasil.TabIndex = 6
        LabelHasil.Text = "Hasil :"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(LabelHasil)
        Controls.Add(TextHasil)
        Controls.Add(ButtonHitung)
        Controls.Add(LabelNilaiB)
        Controls.Add(LabelNilaiA)
        Controls.Add(TextNilaiB)
        Controls.Add(TextNilaiA)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextNilaiA As TextBox
    Friend WithEvents TextNilaiB As TextBox
    Friend WithEvents LabelNilaiA As Label
    Friend WithEvents LabelNilaiB As Label
    Friend WithEvents ButtonHitung As Button
    Friend WithEvents TextHasil As TextBox
    Friend WithEvents LabelHasil As Label

    Private Sub ButtonHitung_Click(sender As Object, e As EventArgs) Handles ButtonHitung.Click
        Dim a As Integer = CInt(TextNilaiA.Text)
        Dim b As Integer = CInt(TextNilaiB.Text)
        Dim hasil As Integer
        hasil = a * b + (a - b) / a
        TextHasil.Text = " " & hasil
    End Sub
End Class
