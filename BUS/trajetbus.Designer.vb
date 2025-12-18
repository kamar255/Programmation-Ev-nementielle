<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class trajetbus
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
        Label1 = New Label()
        GB_info = New GroupBox()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        NUD_places = New NumericUpDown()
        DTP_arri = New DateTimePicker()
        DTP_dep = New DateTimePicker()
        lstVilleArrivee = New ComboBox()
        lstVilleDep = New ComboBox()
        lstLigne = New ComboBox()
        FileSystemWatcher1 = New IO.FileSystemWatcher()
        GB_Options = New GroupBox()
        Chk_bus = New CheckBox()
        Chk_wifi = New CheckBox()
        Chk_Clima = New CheckBox()
        GB_type = New GroupBox()
        Rb_N = New RadioButton()
        Rb_EX = New RadioButton()
        Rb_R = New RadioButton()
        BtnAjouter = New Button()
        Btnannuller = New Button()
        Btnvider = New Button()
        ErrorProvider1 = New ErrorProvider(components)
        DGVReservation = New DataGridView()
        ligne = New DataGridViewTextBoxColumn()
        Depart = New DataGridViewTextBoxColumn()
        Arrivée = New DataGridViewTextBoxColumn()
        Heure_Départ = New DataGridViewTextBoxColumn()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        GB_info.SuspendLayout()
        CType(NUD_places, ComponentModel.ISupportInitialize).BeginInit()
        CType(FileSystemWatcher1, ComponentModel.ISupportInitialize).BeginInit()
        GB_Options.SuspendLayout()
        GB_type.SuspendLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DGVReservation, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Indigo
        Label1.Location = New Point(402, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(351, 28)
        Label1.TabIndex = 0
        Label1.Text = "GESTION HORRAIRES DE BUS"
        ' 
        ' GB_info
        ' 
        GB_info.Controls.Add(Label7)
        GB_info.Controls.Add(Label6)
        GB_info.Controls.Add(Label5)
        GB_info.Controls.Add(Label4)
        GB_info.Controls.Add(Label3)
        GB_info.Controls.Add(Label2)
        GB_info.Controls.Add(NUD_places)
        GB_info.Controls.Add(DTP_arri)
        GB_info.Controls.Add(DTP_dep)
        GB_info.Controls.Add(lstVilleArrivee)
        GB_info.Controls.Add(lstVilleDep)
        GB_info.Controls.Add(lstLigne)
        GB_info.Font = New Font("Times New Roman", 10F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        GB_info.ForeColor = Color.Indigo
        GB_info.Location = New Point(12, 59)
        GB_info.Name = "GB_info"
        GB_info.Size = New Size(737, 192)
        GB_info.TabIndex = 1
        GB_info.TabStop = False
        GB_info.Text = "Information trajet"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(364, 151)
        Label7.Name = "Label7"
        Label7.Size = New Size(64, 23)
        Label7.TabIndex = 11
        Label7.Text = "Places"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(346, 103)
        Label6.Name = "Label6"
        Label6.Size = New Size(112, 23)
        Label6.TabIndex = 10
        Label6.Text = "heure arrivé"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(342, 47)
        Label5.Name = "Label5"
        Label5.Size = New Size(116, 23)
        Label5.TabIndex = 9
        Label5.Text = "heure depart"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(6, 151)
        Label4.Name = "Label4"
        Label4.Size = New Size(108, 23)
        Label4.TabIndex = 8
        Label4.Text = "ville arrivée"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(6, 103)
        Label3.Name = "Label3"
        Label3.Size = New Size(127, 23)
        Label3.TabIndex = 7
        Label3.Text = "ville de depart"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(6, 47)
        Label2.Name = "Label2"
        Label2.Size = New Size(52, 23)
        Label2.TabIndex = 6
        Label2.Text = "ligne"
        ' 
        ' NUD_places
        ' 
        NUD_places.Location = New Point(496, 148)
        NUD_places.Name = "NUD_places"
        NUD_places.Size = New Size(180, 30)
        NUD_places.TabIndex = 5
        ' 
        ' DTP_arri
        ' 
        DTP_arri.Format = DateTimePickerFormat.Time
        DTP_arri.Location = New Point(496, 90)
        DTP_arri.Name = "DTP_arri"
        DTP_arri.Size = New Size(177, 30)
        DTP_arri.TabIndex = 4
        ' 
        ' DTP_dep
        ' 
        DTP_dep.Format = DateTimePickerFormat.Time
        DTP_dep.Location = New Point(491, 41)
        DTP_dep.Name = "DTP_dep"
        DTP_dep.Size = New Size(182, 30)
        DTP_dep.TabIndex = 3
        ' 
        ' lstVilleArrivee
        ' 
        lstVilleArrivee.FormattingEnabled = True
        lstVilleArrivee.Items.AddRange(New Object() {"BIZERTE", "TUNIS", "SOUSSE", "MONASTIR", "SFAX"})
        lstVilleArrivee.Location = New Point(139, 151)
        lstVilleArrivee.Name = "lstVilleArrivee"
        lstVilleArrivee.Size = New Size(182, 31)
        lstVilleArrivee.TabIndex = 2
        ' 
        ' lstVilleDep
        ' 
        lstVilleDep.FormattingEnabled = True
        lstVilleDep.Items.AddRange(New Object() {"BIZERTE", "TUNIS", "SOUSSE", "MONASTIR", "SFAX"})
        lstVilleDep.Location = New Point(139, 103)
        lstVilleDep.Name = "lstVilleDep"
        lstVilleDep.Size = New Size(182, 31)
        lstVilleDep.TabIndex = 1
        ' 
        ' lstLigne
        ' 
        lstLigne.FormattingEnabled = True
        lstLigne.Items.AddRange(New Object() {"ligne01", "Ligne02", "ligne03"})
        lstLigne.Location = New Point(139, 44)
        lstLigne.Name = "lstLigne"
        lstLigne.Size = New Size(182, 31)
        lstLigne.TabIndex = 0
        ' 
        ' FileSystemWatcher1
        ' 
        FileSystemWatcher1.EnableRaisingEvents = True
        FileSystemWatcher1.SynchronizingObject = Me
        ' 
        ' GB_Options
        ' 
        GB_Options.Controls.Add(Chk_bus)
        GB_Options.Controls.Add(Chk_wifi)
        GB_Options.Controls.Add(Chk_Clima)
        GB_Options.Font = New Font("Times New Roman", 10F, FontStyle.Bold Or FontStyle.Italic)
        GB_Options.ForeColor = Color.Indigo
        GB_Options.Location = New Point(952, 80)
        GB_Options.Name = "GB_Options"
        GB_Options.Size = New Size(195, 135)
        GB_Options.TabIndex = 2
        GB_Options.TabStop = False
        GB_Options.Text = "Options"
        ' 
        ' Chk_bus
        ' 
        Chk_bus.AutoSize = True
        Chk_bus.Location = New Point(33, 105)
        Chk_bus.Name = "Chk_bus"
        Chk_bus.Size = New Size(129, 27)
        Chk_bus.TabIndex = 2
        Chk_bus.Text = "bus a etage"
        Chk_bus.UseVisualStyleBackColor = True
        ' 
        ' Chk_wifi
        ' 
        Chk_wifi.AutoSize = True
        Chk_wifi.Location = New Point(33, 72)
        Chk_wifi.Name = "Chk_wifi"
        Chk_wifi.Size = New Size(72, 27)
        Chk_wifi.TabIndex = 1
        Chk_wifi.Text = "Wifi"
        Chk_wifi.UseVisualStyleBackColor = True
        ' 
        ' Chk_Clima
        ' 
        Chk_Clima.AutoSize = True
        Chk_Clima.Location = New Point(33, 31)
        Chk_Clima.Name = "Chk_Clima"
        Chk_Clima.Size = New Size(150, 27)
        Chk_Clima.TabIndex = 0
        Chk_Clima.Text = "Climatisation"
        Chk_Clima.UseVisualStyleBackColor = True
        ' 
        ' GB_type
        ' 
        GB_type.Controls.Add(Rb_N)
        GB_type.Controls.Add(Rb_EX)
        GB_type.Controls.Add(Rb_R)
        GB_type.Font = New Font("Times New Roman", 10F, FontStyle.Bold Or FontStyle.Italic)
        GB_type.ForeColor = Color.Indigo
        GB_type.Location = New Point(767, 68)
        GB_type.Name = "GB_type"
        GB_type.Size = New Size(162, 150)
        GB_type.TabIndex = 0
        GB_type.TabStop = False
        GB_type.Text = "type de trajet"
        ' 
        ' Rb_N
        ' 
        Rb_N.AutoSize = True
        Rb_N.Location = New Point(30, 120)
        Rb_N.Name = "Rb_N"
        Rb_N.Size = New Size(113, 27)
        Rb_N.TabIndex = 13
        Rb_N.TabStop = True
        Rb_N.Text = "Nocturne"
        Rb_N.UseVisualStyleBackColor = True
        ' 
        ' Rb_EX
        ' 
        Rb_EX.AutoSize = True
        Rb_EX.Location = New Point(30, 78)
        Rb_EX.Name = "Rb_EX"
        Rb_EX.Size = New Size(101, 27)
        Rb_EX.TabIndex = 12
        Rb_EX.TabStop = True
        Rb_EX.Text = "Express"
        Rb_EX.UseVisualStyleBackColor = True
        ' 
        ' Rb_R
        ' 
        Rb_R.AutoSize = True
        Rb_R.Location = New Point(30, 36)
        Rb_R.Name = "Rb_R"
        Rb_R.Size = New Size(107, 27)
        Rb_R.TabIndex = 0
        Rb_R.TabStop = True
        Rb_R.Text = "Régulier"
        Rb_R.UseVisualStyleBackColor = True
        ' 
        ' BtnAjouter
        ' 
        BtnAjouter.BackColor = Color.Lavender
        BtnAjouter.Font = New Font("Times New Roman", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        BtnAjouter.ForeColor = Color.Indigo
        BtnAjouter.Location = New Point(31, 286)
        BtnAjouter.Name = "BtnAjouter"
        BtnAjouter.Size = New Size(112, 34)
        BtnAjouter.TabIndex = 3
        BtnAjouter.Text = "Ajouter"
        BtnAjouter.UseVisualStyleBackColor = False
        ' 
        ' Btnannuller
        ' 
        Btnannuller.BackColor = Color.Lavender
        Btnannuller.Font = New Font("Times New Roman", 9F, FontStyle.Bold Or FontStyle.Italic)
        Btnannuller.ForeColor = Color.Indigo
        Btnannuller.Location = New Point(169, 284)
        Btnannuller.Name = "Btnannuller"
        Btnannuller.Size = New Size(112, 34)
        Btnannuller.TabIndex = 4
        Btnannuller.Text = "Annuler"
        Btnannuller.UseVisualStyleBackColor = False
        ' 
        ' Btnvider
        ' 
        Btnvider.BackColor = Color.Lavender
        Btnvider.Font = New Font("Times New Roman", 9F, FontStyle.Bold Or FontStyle.Italic)
        Btnvider.ForeColor = Color.Indigo
        Btnvider.Location = New Point(305, 284)
        Btnvider.Name = "Btnvider"
        Btnvider.Size = New Size(112, 34)
        Btnvider.TabIndex = 5
        Btnvider.Text = "vider"
        Btnvider.UseVisualStyleBackColor = False
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' DGVReservation
        ' 
        DGVReservation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGVReservation.Columns.AddRange(New DataGridViewColumn() {ligne, Depart, Arrivée, Heure_Départ, Column1, Column2, Column3})
        DGVReservation.Location = New Point(31, 370)
        DGVReservation.Name = "DGVReservation"
        DGVReservation.RowHeadersWidth = 62
        DGVReservation.Size = New Size(1242, 68)
        DGVReservation.TabIndex = 6
        ' 
        ' ligne
        ' 
        ligne.HeaderText = "ligne"
        ligne.MinimumWidth = 8
        ligne.Name = "ligne"
        ligne.Width = 150
        ' 
        ' Depart
        ' 
        Depart.HeaderText = "Depart"
        Depart.MinimumWidth = 8
        Depart.Name = "Depart"
        Depart.Width = 150
        ' 
        ' Arrivée
        ' 
        Arrivée.HeaderText = "Arrivée"
        Arrivée.MinimumWidth = 8
        Arrivée.Name = "Arrivée"
        Arrivée.Width = 150
        ' 
        ' Heure_Départ
        ' 
        Heure_Départ.HeaderText = "Heure_Départ"
        Heure_Départ.MinimumWidth = 8
        Heure_Départ.Name = "Heure_Départ"
        Heure_Départ.Width = 150
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Heure_Arrivée"
        Column1.MinimumWidth = 8
        Column1.Name = "Column1"
        Column1.Width = 150
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "places"
        Column2.MinimumWidth = 8
        Column2.Name = "Column2"
        Column2.Width = 150
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Options"
        Column3.MinimumWidth = 8
        Column3.Name = "Column3"
        Column3.Width = 150
        ' 
        ' Trajetbus
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Lavender
        ClientSize = New Size(1186, 450)
        Controls.Add(DGVReservation)
        Controls.Add(Btnvider)
        Controls.Add(Btnannuller)
        Controls.Add(BtnAjouter)
        Controls.Add(GB_type)
        Controls.Add(GB_Options)
        Controls.Add(GB_info)
        Controls.Add(Label1)
        Name = "Trajetbus"
        Text = "frmtarjetbus"
        GB_info.ResumeLayout(False)
        GB_info.PerformLayout()
        CType(NUD_places, ComponentModel.ISupportInitialize).EndInit()
        CType(FileSystemWatcher1, ComponentModel.ISupportInitialize).EndInit()
        GB_Options.ResumeLayout(False)
        GB_Options.PerformLayout()
        GB_type.ResumeLayout(False)
        GB_type.PerformLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        CType(DGVReservation, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GB_info As GroupBox
    Friend WithEvents lstLigne As ComboBox
    Friend WithEvents NUD_places As NumericUpDown
    Friend WithEvents DTP_arri As DateTimePicker
    Friend WithEvents DTP_dep As DateTimePicker
    Friend WithEvents lstVilleArrivee As ComboBox
    Friend WithEvents lstVilleDep As ComboBox
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents lstVilleArivee As Label
    Friend WithEvents ldtvilleDepP As Label
    Friend WithEvents lstLign As Label
    Friend WithEvents GB_type As GroupBox
    Friend WithEvents GB_Options As GroupBox
    Friend WithEvents Chk_bus As CheckBox
    Friend WithEvents Chk_wifi As CheckBox
    Friend WithEvents Chk_Clima As CheckBox
    Friend WithEvents Btnvider As Button
    Friend WithEvents Btnannuller As Button
    Friend WithEvents BtnAjouter As Button
    Friend WithEvents Rb_N As RadioButton
    Friend WithEvents Rb_EX As RadioButton
    Friend WithEvents Rb_R As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents DGVReservation As DataGridView
    Friend WithEvents ligne As DataGridViewTextBoxColumn
    Friend WithEvents Depart As DataGridViewTextBoxColumn
    Friend WithEvents Arrivée As DataGridViewTextBoxColumn
    Friend WithEvents Heure_Départ As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn

End Class
