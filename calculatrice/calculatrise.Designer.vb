<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class calculatrise
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
        Btnplus = New Button()
        Btnmoins = New Button()
        Btnmulti = New Button()
        Btnsoustra = New Button()
        Btnegale = New Button()
        Btnrest = New Button()
        TextA = New TextBox()
        TextB = New TextBox()
        Lblres = New Label()
        SuspendLayout()
        ' 
        ' Btnplus
        ' 
        Btnplus.BackColor = Color.LightBlue
        Btnplus.ForeColor = Color.MidnightBlue
        Btnplus.Location = New Point(205, 46)
        Btnplus.Name = "Btnplus"
        Btnplus.Size = New Size(112, 34)
        Btnplus.TabIndex = 0
        Btnplus.Text = "+"
        Btnplus.UseVisualStyleBackColor = False
        ' 
        ' Btnmoins
        ' 
        Btnmoins.BackColor = Color.LightBlue
        Btnmoins.ForeColor = SystemColors.ActiveBorder
        Btnmoins.Location = New Point(205, 82)
        Btnmoins.Name = "Btnmoins"
        Btnmoins.Size = New Size(112, 34)
        Btnmoins.TabIndex = 1
        Btnmoins.Text = "-"
        Btnmoins.UseVisualStyleBackColor = False
        ' 
        ' Btnmulti
        ' 
        Btnmulti.BackColor = Color.LightBlue
        Btnmulti.ForeColor = Color.MidnightBlue
        Btnmulti.Location = New Point(205, 122)
        Btnmulti.Name = "Btnmulti"
        Btnmulti.Size = New Size(112, 34)
        Btnmulti.TabIndex = 2
        Btnmulti.Text = "*"
        Btnmulti.UseVisualStyleBackColor = False
        ' 
        ' Btnsoustra
        ' 
        Btnsoustra.BackColor = Color.LightBlue
        Btnsoustra.ForeColor = Color.MidnightBlue
        Btnsoustra.Location = New Point(205, 162)
        Btnsoustra.Name = "Btnsoustra"
        Btnsoustra.Size = New Size(112, 34)
        Btnsoustra.TabIndex = 3
        Btnsoustra.Text = "/"
        Btnsoustra.UseVisualStyleBackColor = False
        ' 
        ' Btnegale
        ' 
        Btnegale.BackColor = Color.LightBlue
        Btnegale.ForeColor = Color.MidnightBlue
        Btnegale.Location = New Point(205, 202)
        Btnegale.Name = "Btnegale"
        Btnegale.Size = New Size(112, 34)
        Btnegale.TabIndex = 4
        Btnegale.Text = "="
        Btnegale.UseVisualStyleBackColor = False
        ' 
        ' Btnrest
        ' 
        Btnrest.BackColor = Color.LightBlue
        Btnrest.ForeColor = Color.MidnightBlue
        Btnrest.Location = New Point(205, 255)
        Btnrest.Name = "Btnrest"
        Btnrest.Size = New Size(112, 34)
        Btnrest.TabIndex = 5
        Btnrest.Text = "REST"
        Btnrest.UseVisualStyleBackColor = False
        ' 
        ' TextA
        ' 
        TextA.BackColor = Color.Azure
        TextA.Location = New Point(18, 80)
        TextA.Name = "TextA"
        TextA.Size = New Size(150, 31)
        TextA.TabIndex = 6
        TextA.Text = "2"
        ' 
        ' TextB
        ' 
        TextB.BackColor = Color.Azure
        TextB.Location = New Point(18, 135)
        TextB.Name = "TextB"
        TextB.Size = New Size(150, 31)
        TextB.TabIndex = 7
        ' 
        ' Lblres
        ' 
        Lblres.AutoSize = True
        Lblres.Location = New Point(12, 255)
        Lblres.Name = "Lblres"
        Lblres.Size = New Size(152, 25)
        Lblres.TabIndex = 8
        Lblres.Text = "                            "
        ' 
        ' calculatrise
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Azure
        ClientSize = New Size(373, 304)
        Controls.Add(Lblres)
        Controls.Add(TextB)
        Controls.Add(TextA)
        Controls.Add(Btnrest)
        Controls.Add(Btnegale)
        Controls.Add(Btnsoustra)
        Controls.Add(Btnmulti)
        Controls.Add(Btnmoins)
        Controls.Add(Btnplus)
        Name = "calculatrise"
        Text = "Calculatrise"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Btnplus As Button
    Friend WithEvents Btnmoins As Button
    Friend WithEvents Btnmulti As Button
    Friend WithEvents Btnsoustra As Button
    Friend WithEvents Btnegale As Button
    Friend WithEvents Btnrest As Button
    Friend WithEvents TextA As TextBox
    Friend WithEvents TextB As TextBox
    Friend WithEvents Lblres As Label

End Class
