<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class pres

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
        components = New ComponentModel.Container()
        Gpvet = New GroupBox()
        Rb_r = New RadioButton()
        rb_p = New RadioButton()
        rb_ch = New RadioButton()
        Gpsu = New GroupBox()
        Chk_f = New CheckBox()
        Chk_a = New CheckBox()
        Grtype = New GroupBox()
        rb_n = New RadioButton()
        rb_l = New RadioButton()
        rb_re = New RadioButton()
        Nud_a = New NumericUpDown()
        Dgva = New DataGridView()
        code = New DataGridViewTextBoxColumn()
        choixvetelent = New DataGridViewTextBoxColumn()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Label1 = New Label()
        btnajouter = New Button()
        Button2 = New Button()
        ErrorProvider1 = New ErrorProvider(components)
        Label3 = New Label()
        Gpvet.SuspendLayout()
        Gpsu.SuspendLayout()
        Grtype.SuspendLayout()
        CType(Nud_a, ComponentModel.ISupportInitialize).BeginInit()
        CType(Dgva, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Gpvet
        ' 
        Gpvet.Controls.Add(Rb_r)
        Gpvet.Controls.Add(rb_p)
        Gpvet.Controls.Add(rb_ch)
        Gpvet.Font = New Font("Segoe UI Emoji", 10.0F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Gpvet.ForeColor = Color.PaleVioletRed
        Gpvet.Location = New Point(21, 91)
        Gpvet.Name = "Gpvet"
        Gpvet.Size = New Size(300, 150)
        Gpvet.TabIndex = 0
        Gpvet.TabStop = False
        Gpvet.Text = "choix vetemnt"
        ' 
        ' Rb_r
        ' 
        Rb_r.AutoSize = True
        Rb_r.Location = New Point(55, 35)
        Rb_r.Name = "Rb_r"
        Rb_r.Size = New Size(78, 31)
        Rb_r.TabIndex = 2
        Rb_r.TabStop = True
        Rb_r.Text = "robe"
        Rb_r.UseVisualStyleBackColor = True
        ' 
        ' rb_p
        ' 
        rb_p.AutoSize = True
        rb_p.Location = New Point(55, 67)
        rb_p.Name = "rb_p"
        rb_p.Size = New Size(120, 31)
        rb_p.TabIndex = 3
        rb_p.TabStop = True
        rb_p.Text = "pantallon"
        rb_p.UseVisualStyleBackColor = True
        ' 
        ' rb_ch
        ' 
        rb_ch.AutoSize = True
        rb_ch.Location = New Point(55, 102)
        rb_ch.Name = "rb_ch"
        rb_ch.Size = New Size(107, 31)
        rb_ch.TabIndex = 4
        rb_ch.TabStop = True
        rb_ch.Text = "chemise"
        rb_ch.UseVisualStyleBackColor = True
        ' 
        ' Gpsu
        ' 
        Gpsu.Controls.Add(Chk_f)
        Gpsu.Controls.Add(Chk_a)
        Gpsu.Font = New Font("Segoe UI Emoji", 10.0F, FontStyle.Italic)
        Gpsu.ForeColor = Color.PaleVioletRed
        Gpsu.Location = New Point(39, 288)
        Gpsu.Name = "Gpsu"
        Gpsu.Size = New Size(300, 150)
        Gpsu.TabIndex = 0
        Gpsu.TabStop = False
        Gpsu.Text = "supplement"
        ' 
        ' Chk_f
        ' 
        Chk_f.AutoSize = True
        Chk_f.Location = New Point(6, 45)
        Chk_f.Name = "Chk_f"
        Chk_f.Size = New Size(120, 31)
        Chk_f.TabIndex = 2
        Chk_f.Text = "froidsage"
        Chk_f.UseVisualStyleBackColor = True
        ' 
        ' Chk_a
        ' 
        Chk_a.AutoSize = True
        Chk_a.Location = New Point(17, 80)
        Chk_a.Name = "Chk_a"
        Chk_a.Size = New Size(118, 31)
        Chk_a.TabIndex = 3
        Chk_a.Text = "antitache"
        Chk_a.UseVisualStyleBackColor = True
        ' 
        ' Grtype
        ' 
        Grtype.Controls.Add(rb_n)
        Grtype.Controls.Add(rb_l)
        Grtype.Controls.Add(rb_re)
        Grtype.Font = New Font("Segoe UI Emoji", 10.0F, FontStyle.Italic)
        Grtype.ForeColor = Color.PaleVioletRed
        Grtype.Location = New Point(370, 91)
        Grtype.Name = "Grtype"
        Grtype.Size = New Size(300, 150)
        Grtype.TabIndex = 1
        Grtype.TabStop = False
        Grtype.Text = "type de nettoyage"
        ' 
        ' rb_n
        ' 
        rb_n.AutoSize = True
        rb_n.Location = New Point(54, 30)
        rb_n.Name = "rb_n"
        rb_n.Size = New Size(173, 31)
        rb_n.TabIndex = 5
        rb_n.TabStop = True
        rb_n.Text = "nettoyage a sec"
        rb_n.UseVisualStyleBackColor = True
        ' 
        ' rb_l
        ' 
        rb_l.AutoSize = True
        rb_l.Location = New Point(54, 67)
        rb_l.Name = "rb_l"
        rb_l.Size = New Size(94, 31)
        rb_l.TabIndex = 6
        rb_l.TabStop = True
        rb_l.Text = "lavage"
        rb_l.UseVisualStyleBackColor = True
        ' 
        ' rb_re
        ' 
        rb_re.AutoSize = True
        rb_re.Location = New Point(54, 102)
        rb_re.Name = "rb_re"
        rb_re.Size = New Size(124, 31)
        rb_re.TabIndex = 7
        rb_re.TabStop = True
        rb_re.Text = "repassage"
        rb_re.UseVisualStyleBackColor = True
        ' 
        ' Nud_a
        ' 
        Nud_a.BackColor = Color.SeaShell
        Nud_a.Location = New Point(755, 135)
        Nud_a.Name = "Nud_a"
        Nud_a.Size = New Size(180, 31)
        Nud_a.TabIndex = 0
        ' 
        ' Dgva
        ' 
        Dgva.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Dgva.Columns.AddRange(New DataGridViewColumn() {code, choixvetelent, Column1, Column2})
        Dgva.Location = New Point(448, 262)
        Dgva.Name = "Dgva"
        Dgva.RowHeadersWidth = 62
        Dgva.Size = New Size(655, 176)
        Dgva.TabIndex = 8
        ' 
        ' code
        ' 
        code.HeaderText = "code"
        code.MinimumWidth = 8
        code.Name = "code"
        code.Width = 150
        ' 
        ' choixvetelent
        ' 
        choixvetelent.HeaderText = "choix vetelent"
        choixvetelent.MinimumWidth = 8
        choixvetelent.Name = "choixvetelent"
        choixvetelent.Width = 150
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "type de nettoyage"
        Column1.MinimumWidth = 8
        Column1.Name = "Column1"
        Column1.Width = 150
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "supplement"
        Column2.MinimumWidth = 8
        Column2.Name = "Column2"
        Column2.Width = 150
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.PaleVioletRed
        Label1.Location = New Point(755, 91)
        Label1.Name = "Label1"
        Label1.Size = New Size(132, 25)
        Label1.TabIndex = 9
        Label1.Text = "nombredarticle"
        ' 
        ' btnajouter
        ' 
        btnajouter.BackColor = Color.SeaShell
        btnajouter.ForeColor = Color.PaleVioletRed
        btnajouter.Location = New Point(701, 188)
        btnajouter.Name = "btnajouter"
        btnajouter.Size = New Size(112, 34)
        btnajouter.TabIndex = 10
        btnajouter.Text = "Ajouter"
        btnajouter.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.SeaShell
        Button2.ForeColor = Color.PaleVioletRed
        Button2.Location = New Point(881, 188)
        Button2.Name = "Button2"
        Button2.Size = New Size(112, 34)
        Button2.TabIndex = 11
        Button2.Text = "Annuler"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Showcard Gothic", 10.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.PaleVioletRed
        Label3.Location = New Point(448, 21)
        Label3.Name = "Label3"
        Label3.Size = New Size(243, 26)
        Label3.TabIndex = 13
        Label3.Text = "GESTION DU PRESSING"
        ' 
        ' PRES
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SeaShell
        ClientSize = New Size(1182, 450)
        Controls.Add(Label3)
        Controls.Add(Button2)
        Controls.Add(btnajouter)
        Controls.Add(Label1)
        Controls.Add(Dgva)
        Controls.Add(Nud_a)
        Controls.Add(Gpsu)
        Controls.Add(Grtype)
        Controls.Add(Gpvet)
        Name = "PRES"
        Text = "PRES"
        Gpvet.ResumeLayout(False)
        Gpvet.PerformLayout()
        Gpsu.ResumeLayout(False)
        Gpsu.PerformLayout()
        Grtype.ResumeLayout(False)
        Grtype.PerformLayout()
        CType(Nud_a, ComponentModel.ISupportInitialize).EndInit()
        CType(Dgva, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Gpvet As GroupBox
    Friend WithEvents Gpsu As GroupBox
    Friend WithEvents Grtype As GroupBox
    Friend WithEvents Nud_a As NumericUpDown
    Friend WithEvents Chk_f As CheckBox
    Friend WithEvents Chk_a As CheckBox
    Friend WithEvents Rb_r As RadioButton
    Friend WithEvents rb_p As RadioButton
    Friend WithEvents rb_ch As RadioButton
    Friend WithEvents rb_n As RadioButton
    Friend WithEvents rb_l As RadioButton
    Friend WithEvents rb_re As RadioButton
    Friend WithEvents Dgva As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btnajouter As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents code As DataGridViewTextBoxColumn
    Friend WithEvents choixvetelent As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label

End Class
