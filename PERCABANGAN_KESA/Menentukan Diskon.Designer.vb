<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menentukan_Diskon
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
        Me.LabelTotal = New System.Windows.Forms.Label()
        Me.LabelHasildiskon = New System.Windows.Forms.Label()
        Me.TextHAriTOtal = New System.Windows.Forms.TextBox()
        Me.BtnHItung = New System.Windows.Forms.Button()
        Me.TextHAsildiskon = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LabelTotal
        '
        Me.LabelTotal.AutoSize = True
        Me.LabelTotal.Location = New System.Drawing.Point(106, 84)
        Me.LabelTotal.Name = "LabelTotal"
        Me.LabelTotal.Size = New System.Drawing.Size(166, 13)
        Me.LabelTotal.TabIndex = 0
        Me.LabelTotal.Text = "MASUKKAN HARI DAN TOTAL :"
        '
        'LabelHasildiskon
        '
        Me.LabelHasildiskon.AutoSize = True
        Me.LabelHasildiskon.Location = New System.Drawing.Point(106, 215)
        Me.LabelHasildiskon.Name = "LabelHasildiskon"
        Me.LabelHasildiskon.Size = New System.Drawing.Size(88, 13)
        Me.LabelHasildiskon.TabIndex = 1
        Me.LabelHasildiskon.Text = "HASIL DISKON :"
        '
        'TextHAriTOtal
        '
        Me.TextHAriTOtal.Location = New System.Drawing.Point(294, 81)
        Me.TextHAriTOtal.Name = "TextHAriTOtal"
        Me.TextHAriTOtal.Size = New System.Drawing.Size(368, 20)
        Me.TextHAriTOtal.TabIndex = 2
        '
        'BtnHItung
        '
        Me.BtnHItung.Location = New System.Drawing.Point(294, 136)
        Me.BtnHItung.Name = "BtnHItung"
        Me.BtnHItung.Size = New System.Drawing.Size(368, 57)
        Me.BtnHItung.TabIndex = 3
        Me.BtnHItung.Text = "HITUNG"
        Me.BtnHItung.UseVisualStyleBackColor = True
        '
        'TextHAsildiskon
        '
        Me.TextHAsildiskon.Location = New System.Drawing.Point(294, 215)
        Me.TextHAsildiskon.Name = "TextHAsildiskon"
        Me.TextHAsildiskon.Size = New System.Drawing.Size(368, 20)
        Me.TextHAsildiskon.TabIndex = 4
        '
        'Menentukan_Diskon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextHAsildiskon)
        Me.Controls.Add(Me.BtnHItung)
        Me.Controls.Add(Me.TextHAriTOtal)
        Me.Controls.Add(Me.LabelHasildiskon)
        Me.Controls.Add(Me.LabelTotal)
        Me.Name = "Menentukan_Diskon"
        Me.Text = "Menentukan_Diskon"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelTotal As Label
    Friend WithEvents LabelHasildiskon As Label
    Friend WithEvents TextHAriTOtal As TextBox
    Friend WithEvents BtnHItung As Button
    Friend WithEvents TextHAsildiskon As TextBox
End Class
