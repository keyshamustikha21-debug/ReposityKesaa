<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CEK_BILANGAN
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
        Me.ButtonCEK = New System.Windows.Forms.Button()
        Me.LabelANGKA = New System.Windows.Forms.Label()
        Me.LabelHASIL = New System.Windows.Forms.Label()
        Me.TextNILAI = New System.Windows.Forms.TextBox()
        Me.TextHASIL = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ButtonCEK
        '
        Me.ButtonCEK.Location = New System.Drawing.Point(65, 129)
        Me.ButtonCEK.Name = "ButtonCEK"
        Me.ButtonCEK.Size = New System.Drawing.Size(639, 58)
        Me.ButtonCEK.TabIndex = 0
        Me.ButtonCEK.Text = "CEK"
        Me.ButtonCEK.UseVisualStyleBackColor = True
        '
        'LabelANGKA
        '
        Me.LabelANGKA.AutoSize = True
        Me.LabelANGKA.Location = New System.Drawing.Point(63, 96)
        Me.LabelANGKA.Name = "LabelANGKA"
        Me.LabelANGKA.Size = New System.Drawing.Size(113, 13)
        Me.LabelANGKA.TabIndex = 1
        Me.LabelANGKA.Text = "MASUKKAN ANGKA :"
        '
        'LabelHASIL
        '
        Me.LabelHASIL.AutoSize = True
        Me.LabelHASIL.Location = New System.Drawing.Point(63, 216)
        Me.LabelHASIL.Name = "LabelHASIL"
        Me.LabelHASIL.Size = New System.Drawing.Size(44, 13)
        Me.LabelHASIL.TabIndex = 2
        Me.LabelHASIL.Text = "HASIL :"
        '
        'TextNILAI
        '
        Me.TextNILAI.Location = New System.Drawing.Point(243, 93)
        Me.TextNILAI.Name = "TextNILAI"
        Me.TextNILAI.Size = New System.Drawing.Size(461, 20)
        Me.TextNILAI.TabIndex = 3
        '
        'TextHASIL
        '
        Me.TextHASIL.Location = New System.Drawing.Point(243, 213)
        Me.TextHASIL.Name = "TextHASIL"
        Me.TextHASIL.Size = New System.Drawing.Size(461, 20)
        Me.TextHASIL.TabIndex = 4
        '
        'CEK_BILANGAN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextHASIL)
        Me.Controls.Add(Me.TextNILAI)
        Me.Controls.Add(Me.LabelHASIL)
        Me.Controls.Add(Me.LabelANGKA)
        Me.Controls.Add(Me.ButtonCEK)
        Me.Name = "CEK_BILANGAN"
        Me.Text = "CEK_BILANGAN"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonCEK As Button
    Friend WithEvents LabelANGKA As Label
    Friend WithEvents LabelHASIL As Label
    Friend WithEvents TextNILAI As TextBox
    Friend WithEvents TextHASIL As TextBox
End Class
