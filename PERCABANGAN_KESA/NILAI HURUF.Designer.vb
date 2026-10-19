<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NILAI_HURUF
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
        Me.TextNILAI = New System.Windows.Forms.TextBox()
        Me.LabelNilai = New System.Windows.Forms.Label()
        Me.LabelGrade = New System.Windows.Forms.Label()
        Me.ButtonCEK = New System.Windows.Forms.Button()
        Me.TextGRADE = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TextNILAI
        '
        Me.TextNILAI.Location = New System.Drawing.Point(236, 112)
        Me.TextNILAI.Name = "TextNILAI"
        Me.TextNILAI.Size = New System.Drawing.Size(346, 20)
        Me.TextNILAI.TabIndex = 0
        '
        'LabelNilai
        '
        Me.LabelNilai.AutoSize = True
        Me.LabelNilai.Location = New System.Drawing.Point(98, 115)
        Me.LabelNilai.Name = "LabelNilai"
        Me.LabelNilai.Size = New System.Drawing.Size(96, 13)
        Me.LabelNilai.TabIndex = 1
        Me.LabelNilai.Text = "MASUKAN NILAI :"
        '
        'LabelGrade
        '
        Me.LabelGrade.AutoSize = True
        Me.LabelGrade.Location = New System.Drawing.Point(98, 238)
        Me.LabelGrade.Name = "LabelGrade"
        Me.LabelGrade.Size = New System.Drawing.Size(45, 13)
        Me.LabelGrade.TabIndex = 2
        Me.LabelGrade.Text = "GRADE"
        '
        'ButtonCEK
        '
        Me.ButtonCEK.Location = New System.Drawing.Point(236, 158)
        Me.ButtonCEK.Name = "ButtonCEK"
        Me.ButtonCEK.Size = New System.Drawing.Size(345, 48)
        Me.ButtonCEK.TabIndex = 3
        Me.ButtonCEK.Text = "( CEK )"
        Me.ButtonCEK.UseVisualStyleBackColor = True
        '
        'TextGRADE
        '
        Me.TextGRADE.Location = New System.Drawing.Point(236, 235)
        Me.TextGRADE.Name = "TextGRADE"
        Me.TextGRADE.Size = New System.Drawing.Size(346, 20)
        Me.TextGRADE.TabIndex = 4
        '
        'NILAI_HURUF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextGRADE)
        Me.Controls.Add(Me.ButtonCEK)
        Me.Controls.Add(Me.LabelGrade)
        Me.Controls.Add(Me.LabelNilai)
        Me.Controls.Add(Me.TextNILAI)
        Me.Name = "NILAI_HURUF"
        Me.Text = "NILAI_HURUF"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextNILAI As TextBox
    Friend WithEvents LabelNilai As Label
    Friend WithEvents LabelGrade As Label
    Friend WithEvents ButtonCEK As Button
    Friend WithEvents TextGRADE As TextBox
End Class
