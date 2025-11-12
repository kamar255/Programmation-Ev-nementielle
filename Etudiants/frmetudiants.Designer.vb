<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frmetudiants
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
        Txtn = New TextBox()
        Txtp = New TextBox()
        Txtno = New TextBox()
        ErrorProvider = New ErrorProvider(components)
        Btnajo = New Button()
        Btnsupp = New Button()
        BtnAfficher = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        dgvetudiants = New DataGridView()
        NOM = New DataGridViewTextBoxColumn()
        PRENOM = New DataGridViewTextBoxColumn()
        NOTE = New DataGridViewTextBoxColumn()
        Label4 = New Label()
        CType(ErrorProvider, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvetudiants, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Txtn
        ' 
        Txtn.Location = New Point(115, 61)
        Txtn.Name = "Txtn"
        Txtn.Size = New Size(150, 31)
        Txtn.TabIndex = 0
        ' 
        ' Txtp
        ' 
        Txtp.Location = New Point(115, 118)
        Txtp.Name = "Txtp"
        Txtp.Size = New Size(150, 31)
        Txtp.TabIndex = 1
        ' 
        ' Txtno
        ' 
        Txtno.Location = New Point(115, 165)
        Txtno.Name = "Txtno"
        Txtno.Size = New Size(150, 31)
        Txtno.TabIndex = 2
        ' 
        ' ErrorProvider
        ' 
        ErrorProvider.ContainerControl = Me
        ' 
        ' Btnajo
        ' 
        Btnajo.BackColor = Color.DarkSeaGreen
        Btnajo.Font = New Font("Times New Roman", 11.0F, FontStyle.Bold Or FontStyle.Italic)
        Btnajo.ForeColor = Color.DarkOliveGreen
        Btnajo.Location = New Point(12, 249)
        Btnajo.Name = "Btnajo"
        Btnajo.Size = New Size(112, 34)
        Btnajo.TabIndex = 3
        Btnajo.Text = "Ajouter"
        Btnajo.UseVisualStyleBackColor = False
        ' 
        ' Btnsupp
        ' 
        Btnsupp.BackColor = Color.DarkSeaGreen
        Btnsupp.Font = New Font("Times New Roman", 11.0F, FontStyle.Bold Or FontStyle.Italic)
        Btnsupp.ForeColor = Color.DarkOliveGreen
        Btnsupp.Location = New Point(136, 249)
        Btnsupp.Name = "Btnsupp"
        Btnsupp.Size = New Size(112, 34)
        Btnsupp.TabIndex = 4
        Btnsupp.Text = "Annuler"
        Btnsupp.UseVisualStyleBackColor = False
        ' 
        ' BtnAfficher
        ' 
        BtnAfficher.BackColor = Color.DarkSeaGreen
        BtnAfficher.Font = New Font("Times New Roman", 11.0F, FontStyle.Bold Or FontStyle.Italic)
        BtnAfficher.ForeColor = Color.DarkOliveGreen
        BtnAfficher.Location = New Point(254, 249)
        BtnAfficher.Name = "BtnAfficher"
        BtnAfficher.Size = New Size(112, 34)
        BtnAfficher.TabIndex = 5
        BtnAfficher.Text = "Afficher"
        BtnAfficher.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 11.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.DarkOliveGreen
        Label1.Location = New Point(28, 67)
        Label1.Name = "Label1"
        Label1.Size = New Size(56, 25)
        Label1.TabIndex = 6
        Label1.Text = "Nom"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 11.0F, FontStyle.Bold Or FontStyle.Italic)
        Label2.ForeColor = Color.DarkOliveGreen
        Label2.Location = New Point(25, 124)
        Label2.Name = "Label2"
        Label2.Size = New Size(84, 25)
        Label2.TabIndex = 7
        Label2.Text = "Prenom"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 11.0F, FontStyle.Bold Or FontStyle.Italic)
        Label3.ForeColor = Color.DarkOliveGreen
        Label3.Location = New Point(29, 165)
        Label3.Name = "Label3"
        Label3.Size = New Size(54, 25)
        Label3.TabIndex = 8
        Label3.Text = "Note"
        ' 
        ' dgvetudiants
        ' 
        dgvetudiants.BackgroundColor = Color.Honeydew
        dgvetudiants.CellBorderStyle = DataGridViewCellBorderStyle.Sunken
        dgvetudiants.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvetudiants.Columns.AddRange(New DataGridViewColumn() {NOM, PRENOM, NOTE})
        dgvetudiants.GridColor = Color.Lime
        dgvetudiants.Location = New Point(431, 85)
        dgvetudiants.Name = "dgvetudiants"
        dgvetudiants.RowHeadersWidth = 62
        dgvetudiants.Size = New Size(511, 166)
        dgvetudiants.TabIndex = 9
        ' 
        ' NOM
        ' 
        NOM.HeaderText = "NOM"
        NOM.MinimumWidth = 8
        NOM.Name = "NOM"
        NOM.Width = 150
        ' 
        ' PRENOM
        ' 
        PRENOM.HeaderText = "PRENOM"
        PRENOM.MinimumWidth = 8
        PRENOM.Name = "PRENOM"
        PRENOM.Width = 150
        ' 
        ' NOTE
        ' 
        NOTE.HeaderText = "NOTE"
        NOTE.MinimumWidth = 8
        NOTE.Name = "NOTE"
        NOTE.Width = 150
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Black", 12.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.DarkOliveGreen
        Label4.Location = New Point(379, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(220, 32)
        Label4.TabIndex = 10
        Label4.Text = "Gestion etudiants"
        ' 
        ' Frmetudiants
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Honeydew
        ClientSize = New Size(976, 450)
        Controls.Add(Label4)
        Controls.Add(dgvetudiants)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(BtnAfficher)
        Controls.Add(Btnsupp)
        Controls.Add(Btnajo)
        Controls.Add(Txtno)
        Controls.Add(Txtp)
        Controls.Add(Txtn)
        Name = "Frmetudiants"
        Text = "Form1"
        CType(ErrorProvider, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvetudiants, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Txtn As TextBox
    Friend WithEvents Txtp As TextBox
    Friend WithEvents Txtno As TextBox
    Friend WithEvents ErrorProvider As ErrorProvider
    Friend WithEvents BtnAfficher As Button
    Friend WithEvents Btnsupp As Button
    Friend WithEvents Btnajo As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvetudiants As DataGridView
    Friend WithEvents NOM As DataGridViewTextBoxColumn
    Friend WithEvents Label4 As Label
    Friend WithEvents PRENOM As DataGridViewTextBoxColumn
    Friend WithEvents NOTE As DataGridViewTextBoxColumn

End Class
