<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        TextGajiPokok = New TextBox()
        TextTunjangan = New TextBox()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Brown
        Button1.Font = New Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ButtonFace
        Button1.Location = New Point(15, 313)
        Button1.Name = "Button1"
        Button1.Size = New Size(771, 111)
        Button1.TabIndex = 0
        Button1.Text = "HITUNG"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(48, 179)
        Label1.Name = "Label1"
        Label1.Size = New Size(76, 15)
        Label1.TabIndex = 1
        Label1.Text = "NAMA          :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(45, 218)
        Label2.Name = "Label2"
        Label2.Size = New Size(81, 15)
        Label2.TabIndex = 2
        Label2.Text = "GAJI POKOK  :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(43, 261)
        Label3.Name = "Label3"
        Label3.Size = New Size(85, 15)
        Label3.TabIndex = 3
        Label3.Text = "TUNJANGAN  :"
        ' 
        ' TextNama
        ' 
        TextNama.Location = New Point(130, 174)
        TextNama.Name = "TextNama"
        TextNama.Size = New Size(644, 23)
        TextNama.TabIndex = 4
        ' 
        ' TextGajiPokok
        ' 
        TextGajiPokok.Location = New Point(130, 214)
        TextGajiPokok.Name = "TextGajiPokok"
        TextGajiPokok.Size = New Size(644, 23)
        TextGajiPokok.TabIndex = 5
        ' 
        ' TextTunjangan
        ' 
        TextTunjangan.Location = New Point(130, 257)
        TextTunjangan.Name = "TextTunjangan"
        TextTunjangan.Size = New Size(644, 23)
        TextTunjangan.TabIndex = 6
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TextTunjangan)
        Controls.Add(TextGajiPokok)
        Controls.Add(TextNama)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Name = "Form4"
        Text = "Form4"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextNama As TextBox
    Friend WithEvents TextGajiPokok As TextBox
    Friend WithEvents TextTunjangan As TextBox
End Class
