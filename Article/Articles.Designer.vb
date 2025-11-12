<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Articles
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
        Btneff = New Button()
        btnajou = New Button()
        Label1 = New Label()
        Lblco = New Label()
        Txtcode = New TextBox()
        Txtdes = New TextBox()
        Lbldes = New Label()
        Lblprix = New Label()
        Lblqte = New Label()
        Txtprix = New TextBox()
        Txtqte = New TextBox()
        SuspendLayout()
        ' 
        ' Btneff
        ' 
        Btneff.BackColor = Color.Azure
        Btneff.Font = New Font("Times New Roman", 12.0F, FontStyle.Bold Or FontStyle.Italic)
        Btneff.ForeColor = Color.CadetBlue
        Btneff.Location = New Point(480, 217)
        Btneff.Name = "Btneff"
        Btneff.Size = New Size(112, 34)
        Btneff.TabIndex = 0
        Btneff.Text = "Effacer"
        Btneff.UseVisualStyleBackColor = False
        ' 
        ' btnajou
        ' 
        btnajou.BackColor = Color.Azure
        btnajou.Font = New Font("Times New Roman", 12.0F, FontStyle.Bold Or FontStyle.Italic)
        btnajou.ForeColor = Color.CadetBlue
        btnajou.Location = New Point(480, 110)
        btnajou.Name = "btnajou"
        btnajou.Size = New Size(112, 34)
        btnajou.TabIndex = 1
        btnajou.Text = "Ajouter"
        btnajou.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Goudy Old Style", 16.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.DarkCyan
        Label1.Location = New Point(230, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(224, 37)
        Label1.TabIndex = 2
        Label1.Text = "Ajout un article"
        ' 
        ' Lblco
        ' 
        Lblco.AutoSize = True
        Lblco.Font = New Font("Times New Roman", 12.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Lblco.ForeColor = Color.CadetBlue
        Lblco.Location = New Point(63, 79)
        Lblco.Name = "Lblco"
        Lblco.Size = New Size(63, 28)
        Lblco.TabIndex = 3
        Lblco.Text = "Code"
        ' 
        ' Txtcode
        ' 
        Txtcode.BackColor = Color.Azure
        Txtcode.Font = New Font("Times New Roman", 12.0F, FontStyle.Bold Or FontStyle.Italic)
        Txtcode.ForeColor = Color.CadetBlue
        Txtcode.Location = New Point(253, 76)
        Txtcode.Name = "Txtcode"
        Txtcode.Size = New Size(150, 35)
        Txtcode.TabIndex = 4
        ' 
        ' Txtdes
        ' 
        Txtdes.BackColor = Color.Azure
        Txtdes.Font = New Font("Times New Roman", 12.0F, FontStyle.Bold Or FontStyle.Italic)
        Txtdes.ForeColor = Color.CadetBlue
        Txtdes.Location = New Point(253, 139)
        Txtdes.Name = "Txtdes"
        Txtdes.Size = New Size(150, 35)
        Txtdes.TabIndex = 5
        ' 
        ' Lbldes
        ' 
        Lbldes.AutoSize = True
        Lbldes.Font = New Font("Times New Roman", 12.0F, FontStyle.Bold Or FontStyle.Italic)
        Lbldes.ForeColor = Color.CadetBlue
        Lbldes.Location = New Point(63, 139)
        Lbldes.Name = "Lbldes"
        Lbldes.Size = New Size(132, 28)
        Lbldes.TabIndex = 6
        Lbldes.Text = "Designation"
        ' 
        ' Lblprix
        ' 
        Lblprix.AutoSize = True
        Lblprix.Font = New Font("Times New Roman", 12.0F, FontStyle.Bold Or FontStyle.Italic)
        Lblprix.ForeColor = Color.CadetBlue
        Lblprix.Location = New Point(63, 192)
        Lblprix.Name = "Lblprix"
        Lblprix.Size = New Size(55, 28)
        Lblprix.TabIndex = 7
        Lblprix.Text = "Prix"
        ' 
        ' Lblqte
        ' 
        Lblqte.AutoSize = True
        Lblqte.Font = New Font("Times New Roman", 12.0F, FontStyle.Bold Or FontStyle.Italic)
        Lblqte.ForeColor = Color.CadetBlue
        Lblqte.Location = New Point(63, 244)
        Lblqte.Name = "Lblqte"
        Lblqte.Size = New Size(99, 28)
        Lblqte.TabIndex = 8
        Lblqte.Text = "Quantite"
        ' 
        ' Txtprix
        ' 
        Txtprix.BackColor = Color.Azure
        Txtprix.Font = New Font("Times New Roman", 12.0F, FontStyle.Bold Or FontStyle.Italic)
        Txtprix.ForeColor = Color.CadetBlue
        Txtprix.Location = New Point(253, 189)
        Txtprix.Name = "Txtprix"
        Txtprix.Size = New Size(150, 35)
        Txtprix.TabIndex = 9
        ' 
        ' Txtqte
        ' 
        Txtqte.BackColor = Color.Azure
        Txtqte.Font = New Font("Times New Roman", 12.0F, FontStyle.Bold Or FontStyle.Italic)
        Txtqte.ForeColor = Color.CadetBlue
        Txtqte.Location = New Point(253, 244)
        Txtqte.Name = "Txtqte"
        Txtqte.Size = New Size(150, 35)
        Txtqte.TabIndex = 10
        ' 
        ' Articles
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Azure
        ClientSize = New Size(638, 450)
        Controls.Add(Txtqte)
        Controls.Add(Txtprix)
        Controls.Add(Lblqte)
        Controls.Add(Lblprix)
        Controls.Add(Lbldes)
        Controls.Add(Txtdes)
        Controls.Add(Txtcode)
        Controls.Add(Lblco)
        Controls.Add(Label1)
        Controls.Add(btnajou)
        Controls.Add(Btneff)
        Name = "Articles"
        Text = "ARTICLE"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Btneff As Button
    Friend WithEvents btnajou As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Lblco As Label
    Friend WithEvents Txtcode As TextBox
    Friend WithEvents Txtdes As TextBox
    Friend WithEvents Lbldes As Label
    Friend WithEvents Lblprix As Label
    Friend WithEvents Lblqte As Label
    Friend WithEvents Txtprix As TextBox
    Friend WithEvents Txtqte As TextBox

End Class
