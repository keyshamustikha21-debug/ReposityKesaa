<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Prsktikum_4
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
        BtnHitung = New Button()
        LabelNilai = New Label()
        TextBoxNilai = New TextBox()
        LabelHasil = New Label()
        SuspendLayout()
        ' 
        ' BtnHitung
        ' 
        BtnHitung.Location = New Point(195, 239)
        BtnHitung.Name = "BtnHitung"
        BtnHitung.Size = New Size(400, 58)
        BtnHitung.TabIndex = 0
        BtnHitung.Text = "HITUNG"
        BtnHitung.UseVisualStyleBackColor = True
        ' 
        ' LabelNilai
        ' 
        LabelNilai.AutoSize = True
        LabelNilai.Location = New Point(195, 165)
        LabelNilai.Name = "LabelNilai"
        LabelNilai.Size = New Size(94, 15)
        LabelNilai.TabIndex = 1
        LabelNilai.Text = "Masukkan Nilai :"
        ' 
        ' TextBoxNilai
        ' 
        TextBoxNilai.Location = New Point(295, 162)
        TextBoxNilai.Name = "TextBoxNilai"
        TextBoxNilai.Size = New Size(300, 23)
        TextBoxNilai.TabIndex = 2
        ' 
        ' LabelHasil
        ' 
        LabelHasil.AutoSize = True
        LabelHasil.Location = New Point(196, 349)
        LabelHasil.Name = "LabelHasil"
        LabelHasil.Size = New Size(39, 15)
        LabelHasil.TabIndex = 4
        LabelHasil.Text = "HASIL"
        ' 
        ' Prsktikum_4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(LabelHasil)
        Controls.Add(TextBoxNilai)
        Controls.Add(LabelNilai)
        Controls.Add(BtnHitung)
        Name = "Prsktikum_4"
        Text = "Prsktikum_4"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnHitung As Button
    Friend WithEvents LabelNilai As Label
    Friend WithEvents TextBoxNilai As TextBox
    Friend WithEvents LabelHasil As Label
End Class
