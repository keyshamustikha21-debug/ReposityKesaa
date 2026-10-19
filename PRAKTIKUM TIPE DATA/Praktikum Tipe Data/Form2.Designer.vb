<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Button1 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        TextNama = New TextBox()
        TextKelas = New TextBox()
        TextJurusan = New TextBox()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.SandyBrown
        Button1.Font = New Font("Lucida Fax", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ButtonFace
        Button1.Location = New Point(80, 290)
        Button1.Name = "Button1"
        Button1.Size = New Size(633, 96)
        Button1.TabIndex = 0
        Button1.Text = "PROSES DATA"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(91, 126)
        Label1.Name = "Label1"
        Label1.Size = New Size(45, 15)
        Label1.TabIndex = 1
        Label1.Text = "Nama :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(91, 158)
        Label2.Name = "Label2"
        Label2.Size = New Size(40, 15)
        Label2.TabIndex = 2
        Label2.Text = "Kelas :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(91, 194)
        Label3.Name = "Label3"
        Label3.Size = New Size(53, 15)
        Label3.TabIndex = 3
        Label3.Text = "Jurusan :"
        ' 
        ' TextNama
        ' 
        TextNama.Location = New Point(163, 123)
        TextNama.Name = "TextNama"
        TextNama.Size = New Size(529, 23)
        TextNama.TabIndex = 4
        ' 
        ' TextKelas
        ' 
        TextKelas.Location = New Point(163, 158)
        TextKelas.Name = "TextKelas"
        TextKelas.Size = New Size(529, 23)
        TextKelas.TabIndex = 5
        ' 
        ' TextJurusan
        ' 
        TextJurusan.Location = New Point(163, 194)
        TextJurusan.Name = "TextJurusan"
        TextJurusan.Size = New Size(529, 23)
        TextJurusan.TabIndex = 6
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TextJurusan)
        Controls.Add(TextKelas)
        Controls.Add(TextNama)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextNama As TextBox
    Friend WithEvents TextKelas As TextBox
    Friend WithEvents TextJurusan As TextBox
End Class
