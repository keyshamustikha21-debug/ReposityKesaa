<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FORM_LOGIN
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
        Me.Lbljudulform = New System.Windows.Forms.Label()
        Me.LblUsername = New System.Windows.Forms.Label()
        Me.LblPW = New System.Windows.Forms.Label()
        Me.Txtusername = New System.Windows.Forms.TextBox()
        Me.txtPW = New System.Windows.Forms.TextBox()
        Me.BtnLOGIN = New System.Windows.Forms.Button()
        Me.BtnBersih = New System.Windows.Forms.Button()
        Me.BtnKeluar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lbljudulform
        '
        Me.Lbljudulform.AutoSize = True
        Me.Lbljudulform.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbljudulform.ForeColor = System.Drawing.Color.SeaShell
        Me.Lbljudulform.Location = New System.Drawing.Point(315, 36)
        Me.Lbljudulform.Name = "Lbljudulform"
        Me.Lbljudulform.Size = New System.Drawing.Size(190, 29)
        Me.Lbljudulform.TabIndex = 0
        Me.Lbljudulform.Text = "FORM LOGIN"
        '
        'LblUsername
        '
        Me.LblUsername.AutoSize = True
        Me.LblUsername.Location = New System.Drawing.Point(42, 104)
        Me.LblUsername.Name = "LblUsername"
        Me.LblUsername.Size = New System.Drawing.Size(61, 13)
        Me.LblUsername.TabIndex = 1
        Me.LblUsername.Text = "Username :"
        '
        'LblPW
        '
        Me.LblPW.AutoSize = True
        Me.LblPW.Location = New System.Drawing.Point(42, 177)
        Me.LblPW.Name = "LblPW"
        Me.LblPW.Size = New System.Drawing.Size(59, 13)
        Me.LblPW.TabIndex = 2
        Me.LblPW.Text = "Password :"
        '
        'Txtusername
        '
        Me.Txtusername.Location = New System.Drawing.Point(163, 101)
        Me.Txtusername.Name = "Txtusername"
        Me.Txtusername.Size = New System.Drawing.Size(552, 20)
        Me.Txtusername.TabIndex = 3
        '
        'txtPW
        '
        Me.txtPW.Location = New System.Drawing.Point(163, 174)
        Me.txtPW.Name = "txtPW"
        Me.txtPW.Size = New System.Drawing.Size(552, 20)
        Me.txtPW.TabIndex = 4
        '
        'BtnLOGIN
        '
        Me.BtnLOGIN.Location = New System.Drawing.Point(168, 223)
        Me.BtnLOGIN.Name = "BtnLOGIN"
        Me.BtnLOGIN.Size = New System.Drawing.Size(180, 41)
        Me.BtnLOGIN.TabIndex = 5
        Me.BtnLOGIN.Text = "LOGIN"
        Me.BtnLOGIN.UseVisualStyleBackColor = True
        '
        'BtnBersih
        '
        Me.BtnBersih.Location = New System.Drawing.Point(353, 223)
        Me.BtnBersih.Name = "BtnBersih"
        Me.BtnBersih.Size = New System.Drawing.Size(180, 41)
        Me.BtnBersih.TabIndex = 6
        Me.BtnBersih.Text = "BERSIHKAN"
        Me.BtnBersih.UseVisualStyleBackColor = True
        '
        'BtnKeluar
        '
        Me.BtnKeluar.Location = New System.Drawing.Point(535, 223)
        Me.BtnKeluar.Name = "BtnKeluar"
        Me.BtnKeluar.Size = New System.Drawing.Size(180, 41)
        Me.BtnKeluar.TabIndex = 7
        Me.BtnKeluar.Text = "KELUAR"
        Me.BtnKeluar.UseVisualStyleBackColor = True
        '
        'FORM_LOGIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnKeluar)
        Me.Controls.Add(Me.BtnBersih)
        Me.Controls.Add(Me.BtnLOGIN)
        Me.Controls.Add(Me.txtPW)
        Me.Controls.Add(Me.Txtusername)
        Me.Controls.Add(Me.LblPW)
        Me.Controls.Add(Me.LblUsername)
        Me.Controls.Add(Me.Lbljudulform)
        Me.ForeColor = System.Drawing.Color.Salmon
        Me.Name = "FORM_LOGIN"
        Me.Text = "FORM_LOGIN"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbljudulform As Label
    Friend WithEvents LblUsername As Label
    Friend WithEvents LblPW As Label
    Friend WithEvents Txtusername As TextBox
    Friend WithEvents txtPW As TextBox
    Friend WithEvents BtnLOGIN As Button
    Friend WithEvents BtnBersih As Button
    Friend WithEvents BtnKeluar As Button
End Class
