<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Mention
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
        BtnValider = New Button()
        Txtmoy = New TextBox()
        lblres = New Label()
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' BtnValider
        ' 
        BtnValider.BackColor = Color.Maroon
        BtnValider.Font = New Font("Times New Roman", 12F, FontStyle.Bold Or FontStyle.Italic)
        BtnValider.ForeColor = SystemColors.ButtonHighlight
        BtnValider.Location = New Point(445, 53)
        BtnValider.Name = "BtnValider"
        BtnValider.Size = New Size(112, 34)
        BtnValider.TabIndex = 0
        BtnValider.Text = "Valider"
        BtnValider.UseVisualStyleBackColor = False
        ' 
        ' Txtmoy
        ' 
        Txtmoy.BackColor = Color.Linen
        Txtmoy.Location = New Point(254, 53)
        Txtmoy.Name = "Txtmoy"
        Txtmoy.Size = New Size(150, 31)
        Txtmoy.TabIndex = 1
        ' 
        ' lblres
        ' 
        lblres.AutoSize = True
        lblres.Font = New Font("Times New Roman", 12F, FontStyle.Bold Or FontStyle.Italic)
        lblres.ForeColor = Color.Brown
        lblres.Location = New Point(254, 107)
        lblres.Name = "lblres"
        lblres.Size = New Size(198, 28)
        lblres.TabIndex = 2
        lblres.Text = "                               "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Brown
        Label1.Location = New Point(12, 53)
        Label1.Name = "Label1"
        Label1.Size = New Size(210, 28)
        Label1.TabIndex = 3
        Label1.Text = "entrer une moyenne"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 12F, FontStyle.Bold Or FontStyle.Italic)
        Label2.ForeColor = Color.Brown
        Label2.Location = New Point(12, 107)
        Label2.Name = "Label2"
        Label2.Size = New Size(94, 28)
        Label2.TabIndex = 4
        Label2.Text = "Resultat"
        ' 
        ' Mention
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Linen
        ClientSize = New Size(608, 230)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lblres)
        Controls.Add(Txtmoy)
        Controls.Add(BtnValider)
        Name = "Mention"
        Text = "mention"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnValider As Button
    Friend WithEvents Txtmoy As TextBox
    Friend WithEvents lblres As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label

End Class

