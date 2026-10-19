<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Praktikum_3
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
        ButtonProses = New Button()
        CheckTrue = New CheckBox()
        CheckFalse = New CheckBox()
        LabelHasil = New Label()
        TextHasil = New TextBox()
        SuspendLayout()
        ' 
        ' ButtonProses
        ' 
        ButtonProses.Location = New Point(276, 214)
        ButtonProses.Name = "ButtonProses"
        ButtonProses.Size = New Size(173, 52)
        ButtonProses.TabIndex = 0
        ButtonProses.Text = "Proses"
        ButtonProses.UseVisualStyleBackColor = True
        ' 
        ' CheckTrue
        ' 
        CheckTrue.AutoSize = True
        CheckTrue.Location = New Point(252, 171)
        CheckTrue.Name = "CheckTrue"
        CheckTrue.Size = New Size(71, 19)
        CheckTrue.TabIndex = 1
        CheckTrue.Text = "X (TRUE)"
        CheckTrue.UseVisualStyleBackColor = True
        ' 
        ' CheckFalse
        ' 
        CheckFalse.AutoSize = True
        CheckFalse.Location = New Point(396, 171)
        CheckFalse.Name = "CheckFalse"
        CheckFalse.Size = New Size(75, 19)
        CheckFalse.TabIndex = 2
        CheckFalse.Text = "Y (FALSE)"
        CheckFalse.UseVisualStyleBackColor = True
        ' 
        ' LabelHasil
        ' 
        LabelHasil.AutoSize = True
        LabelHasil.Location = New Point(229, 288)
        LabelHasil.Name = "LabelHasil"
        LabelHasil.Size = New Size(39, 15)
        LabelHasil.TabIndex = 3
        LabelHasil.Text = "Hasil :"
        ' 
        ' TextHasil
        ' 
        TextHasil.Location = New Point(276, 285)
        TextHasil.Name = "TextHasil"
        TextHasil.Size = New Size(205, 23)
        TextHasil.TabIndex = 4
        ' 
        ' Praktikum_3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TextHasil)
        Controls.Add(LabelHasil)
        Controls.Add(CheckFalse)
        Controls.Add(CheckTrue)
        Controls.Add(ButtonProses)
        Name = "Praktikum_3"
        Text = "Praktikum_3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ButtonProses As Button
    Friend WithEvents CheckTrue As CheckBox
    Friend WithEvents CheckFalse As CheckBox
    Friend WithEvents LabelHasil As Label
    Friend WithEvents TextHasil As TextBox
End Class
