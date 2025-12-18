<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class facture
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
        Rdp = New RadioButton()
        Rdburger = New RadioButton()
        Rdpate = New RadioButton()
        Label1 = New Label()
        Grpp = New GroupBox()
        RdF = New RadioButton()
        RdFr = New RadioButton()
        RdD = New RadioButton()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        gpbs = New GroupBox()
        Lblb = New Label()
        Btc = New Button()
        Bta = New Button()
        Lstboissoin = New ListBox()
        Lblf = New Label()
        Label2 = New Label()
        Grpp.SuspendLayout()
        gpbs.SuspendLayout()
        SuspendLayout()
        ' 
        ' Rdp
        ' 
        Rdp.AutoSize = True
        Rdp.BackColor = Color.OldLace
        Rdp.Font = New Font("Garamond", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Rdp.ForeColor = Color.Brown
        Rdp.Location = New Point(35, 30)
        Rdp.Name = "Rdp"
        Rdp.Size = New Size(86, 29)
        Rdp.TabIndex = 0
        Rdp.TabStop = True
        Rdp.Text = "pizza"
        Rdp.UseVisualStyleBackColor = False
        ' 
        ' Rdburger
        ' 
        Rdburger.AutoSize = True
        Rdburger.Font = New Font("Garamond", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Rdburger.ForeColor = Color.Brown
        Rdburger.Location = New Point(33, 65)
        Rdburger.Name = "Rdburger"
        Rdburger.Size = New Size(102, 29)
        Rdburger.TabIndex = 1
        Rdburger.TabStop = True
        Rdburger.Text = "Burger"
        Rdburger.UseVisualStyleBackColor = True
        ' 
        ' Rdpate
        ' 
        Rdpate.AutoSize = True
        Rdpate.Font = New Font("Garamond", 11F, FontStyle.Bold)
        Rdpate.Location = New Point(36, 100)
        Rdpate.Name = "Rdpate"
        Rdpate.Size = New Size(88, 29)
        Rdpate.TabIndex = 2
        Rdpate.TabStop = True
        Rdpate.Text = "Pates"
        Rdpate.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(86, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 25)
        Label1.TabIndex = 3
        ' 
        ' Grpp
        ' 
        Grpp.Controls.Add(Rdp)
        Grpp.Controls.Add(Rdburger)
        Grpp.Controls.Add(Rdpate)
        Grpp.ForeColor = Color.Brown
        Grpp.Location = New Point(12, 26)
        Grpp.Name = "Grpp"
        Grpp.Size = New Size(182, 155)
        Grpp.TabIndex = 4
        Grpp.TabStop = False
        Grpp.Text = "choix du plat"
        ' 
        ' RdF
        ' 
        RdF.AutoSize = True
        RdF.Font = New Font("Garamond", 11F, FontStyle.Bold)
        RdF.Location = New Point(27, 39)
        RdF.Name = "RdF"
        RdF.Size = New Size(122, 29)
        RdF.TabIndex = 6
        RdF.TabStop = True
        RdF.Text = "Fromage"
        RdF.UseVisualStyleBackColor = True
        ' 
        ' RdFr
        ' 
        RdFr.AutoSize = True
        RdFr.Font = New Font("Garamond", 11F, FontStyle.Bold)
        RdFr.Location = New Point(27, 74)
        RdFr.Name = "RdFr"
        RdFr.Size = New Size(91, 29)
        RdFr.TabIndex = 7
        RdFr.TabStop = True
        RdFr.Text = "Frites"
        RdFr.UseVisualStyleBackColor = True
        ' 
        ' RdD
        ' 
        RdD.AutoSize = True
        RdD.Font = New Font("Garamond", 11F, FontStyle.Bold)
        RdD.Location = New Point(27, 109)
        RdD.Name = "RdD"
        RdD.Size = New Size(107, 29)
        RdD.TabIndex = 8
        RdD.TabStop = True
        RdD.Text = "Dessert"
        RdD.UseVisualStyleBackColor = True
        ' 
        ' gpbs
        ' 
        gpbs.Controls.Add(RdF)
        gpbs.Controls.Add(RdD)
        gpbs.Controls.Add(RdFr)
        gpbs.ForeColor = Color.Brown
        gpbs.Location = New Point(12, 202)
        gpbs.Name = "gpbs"
        gpbs.Size = New Size(182, 150)
        gpbs.TabIndex = 9
        gpbs.TabStop = False
        gpbs.Text = "supplement"
        ' 
        ' Lblb
        ' 
        Lblb.AutoSize = True
        Lblb.Font = New Font("Garamond", 11F, FontStyle.Bold)
        Lblb.ForeColor = Color.IndianRed
        Lblb.Location = New Point(233, 141)
        Lblb.Name = "Lblb"
        Lblb.Size = New Size(85, 25)
        Lblb.TabIndex = 11
        Lblb.Text = "Boisson"
        ' 
        ' Btc
        ' 
        Btc.BackColor = Color.AntiqueWhite
        Btc.Font = New Font("Garamond", 11F, FontStyle.Bold)
        Btc.Location = New Point(233, 236)
        Btc.Name = "Btc"
        Btc.Size = New Size(147, 34)
        Btc.TabIndex = 12
        Btc.Text = "Commander"
        Btc.UseVisualStyleBackColor = False
        ' 
        ' Bta
        ' 
        Bta.BackColor = Color.AntiqueWhite
        Bta.Font = New Font("Garamond", 11F, FontStyle.Bold)
        Bta.Location = New Point(404, 225)
        Bta.Name = "Bta"
        Bta.Size = New Size(112, 34)
        Bta.TabIndex = 13
        Bta.Text = "Annuler"
        Bta.UseVisualStyleBackColor = False
        ' 
        ' Lstboissoin
        ' 
        Lstboissoin.BackColor = Color.OldLace
        Lstboissoin.FormattingEnabled = True
        Lstboissoin.ItemHeight = 25
        Lstboissoin.Location = New Point(367, 137)
        Lstboissoin.Name = "Lstboissoin"
        Lstboissoin.Size = New Size(180, 29)
        Lstboissoin.TabIndex = 14
        ' 
        ' Lblf
        ' 
        Lblf.AutoSize = True
        Lblf.Font = New Font("Garamond", 11F, FontStyle.Bold)
        Lblf.ForeColor = Color.IndianRed
        Lblf.Location = New Point(248, 290)
        Lblf.Name = "Lblf"
        Lblf.Size = New Size(84, 25)
        Lblf.TabIndex = 15
        Lblf.Text = "Facture"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.IndianRed
        Label2.Location = New Point(521, 16)
        Label2.Name = "Label2"
        Label2.Size = New Size(108, 30)
        Label2.TabIndex = 16
        Label2.Text = "FACTURE"
        ' 
        ' facture
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.OldLace
        ClientSize = New Size(800, 450)
        Controls.Add(Label2)
        Controls.Add(Lblf)
        Controls.Add(Lstboissoin)
        Controls.Add(Bta)
        Controls.Add(Btc)
        Controls.Add(Lblb)
        Controls.Add(gpbs)
        Controls.Add(Grpp)
        Controls.Add(Label1)
        Name = "facture"
        Text = "Facture"
        Grpp.ResumeLayout(False)
        Grpp.PerformLayout()
        gpbs.ResumeLayout(False)
        gpbs.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Rdp As RadioButton
    Friend WithEvents Rdburger As RadioButton
    Friend WithEvents Rdpate As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Grpp As GroupBox
    Friend WithEvents RdF As RadioButton
    Friend WithEvents RdFr As RadioButton
    Friend WithEvents RdD As RadioButton
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents gpbs As GroupBox
    Friend WithEvents Lblb As Label
    Friend WithEvents Btc As Button
    Friend WithEvents Bta As Button
    Friend WithEvents Lstboissoin As ListBox
    Friend WithEvents Lblf As Label
    Friend WithEvents Label2 As Label

End Class
