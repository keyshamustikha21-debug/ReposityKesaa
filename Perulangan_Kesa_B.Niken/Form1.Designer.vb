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
        Me.LblNIlai = New System.Windows.Forms.Label()
        Me.TxtNilai = New System.Windows.Forms.TextBox()
        Me.BtnProses = New System.Windows.Forms.Button()
        Me.LstHasil = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'LblNIlai
        '
        Me.LblNIlai.AutoSize = True
        Me.LblNIlai.Location = New System.Drawing.Point(25, 46)
        Me.LblNIlai.Name = "LblNIlai"
        Me.LblNIlai.Size = New System.Drawing.Size(87, 13)
        Me.LblNIlai.TabIndex = 0
        Me.LblNIlai.Text = "Masukkan NIlai :"
        '
        'TxtNilai
        '
        Me.TxtNilai.Location = New System.Drawing.Point(118, 43)
        Me.TxtNilai.Name = "TxtNilai"
        Me.TxtNilai.Size = New System.Drawing.Size(636, 20)
        Me.TxtNilai.TabIndex = 1
        '
        'BtnProses
        '
        Me.BtnProses.Location = New System.Drawing.Point(118, 184)
        Me.BtnProses.Name = "BtnProses"
        Me.BtnProses.Size = New System.Drawing.Size(636, 59)
        Me.BtnProses.TabIndex = 2
        Me.BtnProses.Text = "PROSES"
        Me.BtnProses.UseVisualStyleBackColor = True
        '
        'LstHasil
        '
        Me.LstHasil.FormattingEnabled = True
        Me.LstHasil.Location = New System.Drawing.Point(118, 85)
        Me.LstHasil.Name = "LstHasil"
        Me.LstHasil.Size = New System.Drawing.Size(636, 30)
        Me.LstHasil.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LstHasil)
        Me.Controls.Add(Me.BtnProses)
        Me.Controls.Add(Me.TxtNilai)
        Me.Controls.Add(Me.LblNIlai)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblNIlai As Label
    Friend WithEvents TxtNilai As TextBox
    Friend WithEvents BtnProses As Button
    Friend WithEvents LstHasil As ListBox
End Class
