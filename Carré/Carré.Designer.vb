<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Carré
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
        Label1 = New Label()
        LabelResultat = New Label()
        Buttoncalcul = New Button()
        Txtnb = New TextBox()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Simplified Arabic", 10.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.DarkRed
        Label1.Location = New Point(3, 93)
        Label1.Name = "Label1"
        Label1.Size = New Size(176, 34)
        Label1.TabIndex = 0
        Label1.Text = "Entrez un nombre "
        ' 
        ' LabelResultat
        ' 
        LabelResultat.AutoSize = True
        LabelResultat.Location = New Point(139, 163)
        LabelResultat.Name = "LabelResultat"
        LabelResultat.Size = New Size(292, 25)
        LabelResultat.TabIndex = 1
        LabelResultat.Text = "                                                        "
        ' 
        ' Buttoncalcul
        ' 
        Buttoncalcul.BackColor = Color.Cornsilk
        Buttoncalcul.Font = New Font("Simplified Arabic", 10.0F, FontStyle.Bold Or FontStyle.Italic)
        Buttoncalcul.ForeColor = Color.DarkRed
        Buttoncalcul.Location = New Point(3, 154)
        Buttoncalcul.Name = "Buttoncalcul"
        Buttoncalcul.Size = New Size(112, 34)
        Buttoncalcul.TabIndex = 2
        Buttoncalcul.Text = "calcul"
        Buttoncalcul.UseVisualStyleBackColor = False
        ' 
        ' Txtnb
        ' 
        Txtnb.BackColor = Color.Cornsilk
        Txtnb.Location = New Point(211, 96)
        Txtnb.Name = "Txtnb"
        Txtnb.Size = New Size(150, 31)
        Txtnb.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Simplified Arabic", 10.0F, FontStyle.Bold Or FontStyle.Italic)
        Label2.Location = New Point(178, 20)
        Label2.Name = "Label2"
        Label2.Size = New Size(62, 34)
        Label2.TabIndex = 4
        Label2.Text = "Carré"
        ' 
        ' Carré
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Cornsilk
        ClientSize = New Size(443, 229)
        Controls.Add(Label2)
        Controls.Add(Txtnb)
        Controls.Add(Buttoncalcul)
        Controls.Add(LabelResultat)
        Controls.Add(Label1)
        ForeColor = Color.DarkRed
        Name = "Carré"
        Text = "carré"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LabelResultat As Label
    Friend WithEvents Buttoncalcul As Button

    Private Sub Buttoncalcull_Click(sender As Object, e As EventArgs) Handles Buttoncalcul.Click

    End Sub

    Friend WithEvents Txtnb As TextBox
    Friend WithEvents Label2 As Label
End Class
