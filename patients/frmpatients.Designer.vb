<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmpatients
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
        Btnajouter = New Button()
        Button2 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Lbldate = New Label()
        Txtprenom = New TextBox()
        Txtnom = New TextBox()
        txtage = New NumericUpDown()
        Dgvpatients = New DataGridView()
        Code = New DataGridViewTextBoxColumn()
        Nom = New DataGridViewTextBoxColumn()
        Prénom = New DataGridViewTextBoxColumn()
        Age = New DataGridViewTextBoxColumn()
        ErrorProvider = New ErrorProvider(components)
        CType(txtage, ComponentModel.ISupportInitialize).BeginInit()
        CType(Dgvpatients, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Btnajouter
        ' 
        Btnajouter.BackColor = Color.DarkSlateGray
        Btnajouter.Font = New Font("Times New Roman", 11F, FontStyle.Bold Or FontStyle.Italic)
        Btnajouter.ForeColor = Color.CadetBlue
        Btnajouter.Location = New Point(37, 250)
        Btnajouter.Name = "Btnajouter"
        Btnajouter.Size = New Size(112, 34)
        Btnajouter.TabIndex = 0
        Btnajouter.Text = "Ajouter"
        Btnajouter.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.DarkSlateGray
        Button2.Font = New Font("Times New Roman", 11F, FontStyle.Bold Or FontStyle.Italic)
        Button2.ForeColor = Color.CadetBlue
        Button2.Location = New Point(172, 250)
        Button2.Name = "Button2"
        Button2.Size = New Size(112, 34)
        Button2.TabIndex = 1
        Button2.Text = "Annuler"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Azure
        Label1.Font = New Font("Times New Roman", 14F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Teal
        Label1.Location = New Point(263, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(342, 32)
        Label1.TabIndex = 2
        Label1.Text = "Ajouter un nouveaux patient"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Azure
        Label2.Font = New Font("Times New Roman", 11F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.CadetBlue
        Label2.Location = New Point(12, 102)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 25)
        Label2.TabIndex = 3
        Label2.Text = "Nom"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 11F, FontStyle.Bold Or FontStyle.Italic)
        Label3.ForeColor = Color.CadetBlue
        Label3.Location = New Point(20, 195)
        Label3.Name = "Label3"
        Label3.Size = New Size(48, 25)
        Label3.TabIndex = 4
        Label3.Text = "Age"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 11F, FontStyle.Bold Or FontStyle.Italic)
        Label4.ForeColor = Color.CadetBlue
        Label4.Location = New Point(12, 152)
        Label4.Name = "Label4"
        Label4.Size = New Size(84, 25)
        Label4.TabIndex = 5
        Label4.Text = "Prénom"
        ' 
        ' Lbldate
        ' 
        Lbldate.AutoSize = True
        Lbldate.Font = New Font("Urdu Typesetting", 10F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Lbldate.ForeColor = Color.CadetBlue
        Lbldate.Location = New Point(634, 45)
        Lbldate.Name = "Lbldate"
        Lbldate.Size = New Size(152, 37)
        Lbldate.TabIndex = 6
        Lbldate.Text = "                                             "
        ' 
        ' Txtprenom
        ' 
        Txtprenom.BackColor = Color.Azure
        Txtprenom.Location = New Point(134, 152)
        Txtprenom.Name = "Txtprenom"
        Txtprenom.Size = New Size(180, 31)
        Txtprenom.TabIndex = 7
        ' 
        ' Txtnom
        ' 
        Txtnom.BackColor = Color.Azure
        Txtnom.Location = New Point(134, 102)
        Txtnom.Name = "Txtnom"
        Txtnom.Size = New Size(180, 31)
        Txtnom.TabIndex = 8
        ' 
        ' txtage
        ' 
        txtage.BackColor = Color.Azure
        txtage.Location = New Point(134, 189)
        txtage.Name = "txtage"
        txtage.Size = New Size(180, 31)
        txtage.TabIndex = 9
        ' 
        ' Dgvpatients
        ' 
        Dgvpatients.BackgroundColor = Color.Azure
        Dgvpatients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Dgvpatients.Columns.AddRange(New DataGridViewColumn() {Code, Nom, Prénom, Age})
        Dgvpatients.GridColor = SystemColors.InactiveCaption
        Dgvpatients.Location = New Point(343, 102)
        Dgvpatients.Name = "Dgvpatients"
        Dgvpatients.RowHeadersWidth = 62
        Dgvpatients.Size = New Size(599, 225)
        Dgvpatients.TabIndex = 10
        ' 
        ' Code
        ' 
        Code.HeaderText = "Code"
        Code.MinimumWidth = 8
        Code.Name = "Code"
        Code.Width = 150
        ' 
        ' Nom
        ' 
        Nom.HeaderText = "Nom"
        Nom.MinimumWidth = 8
        Nom.Name = "Nom"
        Nom.Width = 150
        ' 
        ' Prénom
        ' 
        Prénom.HeaderText = "Prénom"
        Prénom.MinimumWidth = 8
        Prénom.Name = "Prénom"
        Prénom.Width = 150
        ' 
        ' Age
        ' 
        Age.HeaderText = "Age"
        Age.MinimumWidth = 8
        Age.Name = "Age"
        Age.Width = 150
        ' 
        ' ErrorProvider
        ' 
        ErrorProvider.ContainerControl = Me
        ' 
        ' frmpatients
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Azure
        ClientSize = New Size(975, 450)
        Controls.Add(Dgvpatients)
        Controls.Add(txtage)
        Controls.Add(Txtnom)
        Controls.Add(Txtprenom)
        Controls.Add(Lbldate)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button2)
        Controls.Add(Btnajouter)
        Name = "frmpatients"
        Text = "Frmpatients"
        CType(txtage, ComponentModel.ISupportInitialize).EndInit()
        CType(Dgvpatients, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Btnajouter As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Lbldate As Label
    Friend WithEvents Txtprenom As TextBox
    Friend WithEvents Txtnom As TextBox
    Friend WithEvents txtage As NumericUpDown
    Friend WithEvents Dgvpatients As DataGridView
    Friend WithEvents Code As DataGridViewTextBoxColumn
    Friend WithEvents Nom As DataGridViewTextBoxColumn
    Friend WithEvents Prénom As DataGridViewTextBoxColumn
    Friend WithEvents Age As DataGridViewTextBoxColumn
    Friend WithEvents ErrorProvider As ErrorProvider

End Class
