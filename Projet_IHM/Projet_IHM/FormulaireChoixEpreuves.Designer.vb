<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormulaireChoixEpreuves
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormulaireChoixEpreuves))
        Me.SeparationFormulaireChoixEpreuves = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TitreFormulaireChoixEpreuves = New System.Windows.Forms.Label()
        Me.SousTitreFormulaireChoixEpreuves = New System.Windows.Forms.Label()
        Me.DateHeure1 = New System.Windows.Forms.Label()
        Me.TempsRestant1 = New System.Windows.Forms.Label()
        Me.LBL_TempsRestant1 = New System.Windows.Forms.Label()
        Me.LBL_TempsImparti1 = New System.Windows.Forms.Label()
        Me.TempsImparti1 = New System.Windows.Forms.Label()
        Me.LBL_DateHeure1 = New System.Windows.Forms.Label()
        Me.Minuteur2 = New System.Windows.Forms.Timer(Me.components)
        Me.LBL_InfosCandidat = New System.Windows.Forms.Label()
        Me.LBL_PrenomCandidat1 = New System.Windows.Forms.Label()
        Me.LBL_NomCandidat1 = New System.Windows.Forms.Label()
        Me.LBL_ChoixRegionPassage = New System.Windows.Forms.Label()
        Me.CMB_Regions = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SéparationMatières = New System.Windows.Forms.Label()
        Me.LBL_ChoixRestantsEcrit = New System.Windows.Forms.Label()
        Me.ChoixRestantEcrit = New System.Windows.Forms.Label()
        Me.LBL_ChoixRestantsOral = New System.Windows.Forms.Label()
        Me.ChoixRestantOral = New System.Windows.Forms.Label()
        Me.NomCandidat1 = New System.Windows.Forms.Label()
        Me.PrenomCandidat1 = New System.Windows.Forms.Label()
        Me.AbandonnerInscrip1 = New System.Windows.Forms.Button()
        Me.GRP_MatieresEcrit = New System.Windows.Forms.GroupBox()
        Me.VisualBasicNET = New System.Windows.Forms.CheckBox()
        Me.Système = New System.Windows.Forms.CheckBox()
        Me.Réseau = New System.Windows.Forms.CheckBox()
        Me.ProgrammationWEB = New System.Windows.Forms.CheckBox()
        Me.Mathématiques = New System.Windows.Forms.CheckBox()
        Me.Droit = New System.Windows.Forms.CheckBox()
        Me.LangageJava = New System.Windows.Forms.CheckBox()
        Me.LangageC = New System.Windows.Forms.CheckBox()
        Me.Expression = New System.Windows.Forms.CheckBox()
        Me.Gestion = New System.Windows.Forms.CheckBox()
        Me.BaseDeDonnées = New System.Windows.Forms.CheckBox()
        Me.Algorithmique = New System.Windows.Forms.CheckBox()
        Me.GRP_MatieresOral = New System.Windows.Forms.GroupBox()
        Me.Système1 = New System.Windows.Forms.CheckBox()
        Me.Réseau1 = New System.Windows.Forms.CheckBox()
        Me.Mathématiques1 = New System.Windows.Forms.CheckBox()
        Me.Gestion1 = New System.Windows.Forms.CheckBox()
        Me.Expression1 = New System.Windows.Forms.CheckBox()
        Me.Espagnol = New System.Windows.Forms.CheckBox()
        Me.Droit1 = New System.Windows.Forms.CheckBox()
        Me.Chinois = New System.Windows.Forms.CheckBox()
        Me.Anglais = New System.Windows.Forms.CheckBox()
        Me.RADIO_Oui = New System.Windows.Forms.RadioButton()
        Me.GRP_Facultatif = New System.Windows.Forms.GroupBox()
        Me.RADIO_Non = New System.Windows.Forms.RadioButton()
        Me.CMB_Facultatif = New System.Windows.Forms.ComboBox()
        Me.ValidInscrip1 = New System.Windows.Forms.Button()
        Me.GRP_EpreuvesFacultatives = New System.Windows.Forms.GroupBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GRP_MatieresEcrit.SuspendLayout()
        Me.GRP_MatieresOral.SuspendLayout()
        Me.GRP_Facultatif.SuspendLayout()
        Me.GRP_EpreuvesFacultatives.SuspendLayout()
        Me.SuspendLayout()
        '
        'SeparationFormulaireChoixEpreuves
        '
        Me.SeparationFormulaireChoixEpreuves.AutoSize = True
        Me.SeparationFormulaireChoixEpreuves.Font = New System.Drawing.Font("Bahnschrift Condensed", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SeparationFormulaireChoixEpreuves.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.SeparationFormulaireChoixEpreuves.Location = New System.Drawing.Point(-5, 191)
        Me.SeparationFormulaireChoixEpreuves.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.SeparationFormulaireChoixEpreuves.Name = "SeparationFormulaireChoixEpreuves"
        Me.SeparationFormulaireChoixEpreuves.Size = New System.Drawing.Size(1370, 78)
        Me.SeparationFormulaireChoixEpreuves.TabIndex = 3
        Me.SeparationFormulaireChoixEpreuves.Text = "---------------------------------------------------------------------------------" &
    "------------------------------------------" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(314, -49)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(293, 263)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'TitreFormulaireChoixEpreuves
        '
        Me.TitreFormulaireChoixEpreuves.AutoSize = True
        Me.TitreFormulaireChoixEpreuves.Font = New System.Drawing.Font("Bahnschrift Condensed", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitreFormulaireChoixEpreuves.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TitreFormulaireChoixEpreuves.Location = New System.Drawing.Point(538, 62)
        Me.TitreFormulaireChoixEpreuves.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TitreFormulaireChoixEpreuves.Name = "TitreFormulaireChoixEpreuves"
        Me.TitreFormulaireChoixEpreuves.Size = New System.Drawing.Size(332, 58)
        Me.TitreFormulaireChoixEpreuves.TabIndex = 5
        Me.TitreFormulaireChoixEpreuves.Text = "Choix des épreuves"
        '
        'SousTitreFormulaireChoixEpreuves
        '
        Me.SousTitreFormulaireChoixEpreuves.AutoSize = True
        Me.SousTitreFormulaireChoixEpreuves.Font = New System.Drawing.Font("Bahnschrift Condensed", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SousTitreFormulaireChoixEpreuves.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.SousTitreFormulaireChoixEpreuves.Location = New System.Drawing.Point(541, 120)
        Me.SousTitreFormulaireChoixEpreuves.Name = "SousTitreFormulaireChoixEpreuves"
        Me.SousTitreFormulaireChoixEpreuves.Size = New System.Drawing.Size(241, 45)
        Me.SousTitreFormulaireChoixEpreuves.TabIndex = 6
        Me.SousTitreFormulaireChoixEpreuves.Text = "Concours National"
        '
        'DateHeure1
        '
        Me.DateHeure1.AutoSize = True
        Me.DateHeure1.Font = New System.Drawing.Font("Bahnschrift Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateHeure1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.DateHeure1.Location = New System.Drawing.Point(1072, 76)
        Me.DateHeure1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.DateHeure1.Name = "DateHeure1"
        Me.DateHeure1.Size = New System.Drawing.Size(0, 29)
        Me.DateHeure1.TabIndex = 28
        '
        'TempsRestant1
        '
        Me.TempsRestant1.AutoSize = True
        Me.TempsRestant1.Font = New System.Drawing.Font("Bahnschrift Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TempsRestant1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TempsRestant1.Location = New System.Drawing.Point(1067, 162)
        Me.TempsRestant1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TempsRestant1.Name = "TempsRestant1"
        Me.TempsRestant1.Size = New System.Drawing.Size(88, 29)
        Me.TempsRestant1.TabIndex = 23
        Me.TempsRestant1.Text = "1 min 30s"
        '
        'LBL_TempsRestant1
        '
        Me.LBL_TempsRestant1.AutoSize = True
        Me.LBL_TempsRestant1.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_TempsRestant1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LBL_TempsRestant1.Location = New System.Drawing.Point(902, 159)
        Me.LBL_TempsRestant1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBL_TempsRestant1.Name = "LBL_TempsRestant1"
        Me.LBL_TempsRestant1.Size = New System.Drawing.Size(167, 33)
        Me.LBL_TempsRestant1.TabIndex = 24
        Me.LBL_TempsRestant1.Text = "- Temps restant :"
        '
        'LBL_TempsImparti1
        '
        Me.LBL_TempsImparti1.AutoSize = True
        Me.LBL_TempsImparti1.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_TempsImparti1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LBL_TempsImparti1.Location = New System.Drawing.Point(902, 113)
        Me.LBL_TempsImparti1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBL_TempsImparti1.Name = "LBL_TempsImparti1"
        Me.LBL_TempsImparti1.Size = New System.Drawing.Size(166, 33)
        Me.LBL_TempsImparti1.TabIndex = 25
        Me.LBL_TempsImparti1.Text = "- Temps imparti :"
        '
        'TempsImparti1
        '
        Me.TempsImparti1.AutoSize = True
        Me.TempsImparti1.Font = New System.Drawing.Font("Bahnschrift Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TempsImparti1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TempsImparti1.Location = New System.Drawing.Point(1067, 117)
        Me.TempsImparti1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TempsImparti1.Name = "TempsImparti1"
        Me.TempsImparti1.Size = New System.Drawing.Size(88, 29)
        Me.TempsImparti1.TabIndex = 26
        Me.TempsImparti1.Text = "1 min 30s"
        '
        'LBL_DateHeure1
        '
        Me.LBL_DateHeure1.AutoSize = True
        Me.LBL_DateHeure1.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_DateHeure1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LBL_DateHeure1.Location = New System.Drawing.Point(907, 72)
        Me.LBL_DateHeure1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBL_DateHeure1.Name = "LBL_DateHeure1"
        Me.LBL_DateHeure1.Size = New System.Drawing.Size(161, 33)
        Me.LBL_DateHeure1.TabIndex = 27
        Me.LBL_DateHeure1.Text = "- Date et heure :"
        '
        'Minuteur2
        '
        '
        'LBL_InfosCandidat
        '
        Me.LBL_InfosCandidat.AutoSize = True
        Me.LBL_InfosCandidat.Font = New System.Drawing.Font("Bahnschrift Condensed", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_InfosCandidat.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LBL_InfosCandidat.Location = New System.Drawing.Point(470, 230)
        Me.LBL_InfosCandidat.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBL_InfosCandidat.Name = "LBL_InfosCandidat"
        Me.LBL_InfosCandidat.Size = New System.Drawing.Size(247, 39)
        Me.LBL_InfosCandidat.TabIndex = 30
        Me.LBL_InfosCandidat.Text = "Informations candidat"
        '
        'LBL_PrenomCandidat1
        '
        Me.LBL_PrenomCandidat1.AutoSize = True
        Me.LBL_PrenomCandidat1.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_PrenomCandidat1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LBL_PrenomCandidat1.Location = New System.Drawing.Point(471, 323)
        Me.LBL_PrenomCandidat1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBL_PrenomCandidat1.Name = "LBL_PrenomCandidat1"
        Me.LBL_PrenomCandidat1.Size = New System.Drawing.Size(103, 33)
        Me.LBL_PrenomCandidat1.TabIndex = 35
        Me.LBL_PrenomCandidat1.Text = "-Prénom :"
        '
        'LBL_NomCandidat1
        '
        Me.LBL_NomCandidat1.AutoSize = True
        Me.LBL_NomCandidat1.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_NomCandidat1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LBL_NomCandidat1.Location = New System.Drawing.Point(471, 277)
        Me.LBL_NomCandidat1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBL_NomCandidat1.Name = "LBL_NomCandidat1"
        Me.LBL_NomCandidat1.Size = New System.Drawing.Size(74, 33)
        Me.LBL_NomCandidat1.TabIndex = 34
        Me.LBL_NomCandidat1.Text = "-Nom :"
        '
        'LBL_ChoixRegionPassage
        '
        Me.LBL_ChoixRegionPassage.AutoSize = True
        Me.LBL_ChoixRegionPassage.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_ChoixRegionPassage.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LBL_ChoixRegionPassage.Location = New System.Drawing.Point(471, 365)
        Me.LBL_ChoixRegionPassage.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBL_ChoixRegionPassage.Name = "LBL_ChoixRegionPassage"
        Me.LBL_ChoixRegionPassage.Size = New System.Drawing.Size(328, 33)
        Me.LBL_ChoixRegionPassage.TabIndex = 38
        Me.LBL_ChoixRegionPassage.Text = "-Choisissez une région de passage:"
        '
        'CMB_Regions
        '
        Me.CMB_Regions.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMB_Regions.FormattingEnabled = True
        Me.CMB_Regions.Items.AddRange(New Object() {"Auvergne", "Bordelais", "Bourgogne", "Bretagne", "Corse", "Nord", "Normandie", "Paris", "Poitou", "Roussillon"})
        Me.CMB_Regions.Location = New System.Drawing.Point(804, 372)
        Me.CMB_Regions.Name = "CMB_Regions"
        Me.CMB_Regions.Size = New System.Drawing.Size(121, 26)
        Me.CMB_Regions.TabIndex = 39
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(375, 414)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(249, 29)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Matières disponibles à l'écrit "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(760, 414)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(245, 29)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Matières disponibles à l'oral "
        '
        'SéparationMatières
        '
        Me.SéparationMatières.AutoSize = True
        Me.SéparationMatières.Font = New System.Drawing.Font("Bahnschrift Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SéparationMatières.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.SéparationMatières.Location = New System.Drawing.Point(688, 414)
        Me.SéparationMatières.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.SéparationMatières.Name = "SéparationMatières"
        Me.SéparationMatières.Size = New System.Drawing.Size(18, 638)
        Me.SéparationMatières.TabIndex = 45
        Me.SéparationMatières.Text = "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LBL_ChoixRestantsEcrit
        '
        Me.LBL_ChoixRestantsEcrit.AutoSize = True
        Me.LBL_ChoixRestantsEcrit.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_ChoixRestantsEcrit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LBL_ChoixRestantsEcrit.Location = New System.Drawing.Point(392, 682)
        Me.LBL_ChoixRestantsEcrit.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBL_ChoixRestantsEcrit.Name = "LBL_ChoixRestantsEcrit"
        Me.LBL_ChoixRestantsEcrit.Size = New System.Drawing.Size(182, 23)
        Me.LBL_ChoixRestantsEcrit.TabIndex = 49
        Me.LBL_ChoixRestantsEcrit.Text = "Nombre de choix restants : "
        '
        'ChoixRestantEcrit
        '
        Me.ChoixRestantEcrit.AutoSize = True
        Me.ChoixRestantEcrit.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChoixRestantEcrit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ChoixRestantEcrit.Location = New System.Drawing.Point(578, 682)
        Me.ChoixRestantEcrit.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ChoixRestantEcrit.Name = "ChoixRestantEcrit"
        Me.ChoixRestantEcrit.Size = New System.Drawing.Size(18, 23)
        Me.ChoixRestantEcrit.TabIndex = 50
        Me.ChoixRestantEcrit.Text = "4"
        '
        'LBL_ChoixRestantsOral
        '
        Me.LBL_ChoixRestantsOral.AutoSize = True
        Me.LBL_ChoixRestantsOral.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_ChoixRestantsOral.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LBL_ChoixRestantsOral.Location = New System.Drawing.Point(766, 682)
        Me.LBL_ChoixRestantsOral.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBL_ChoixRestantsOral.Name = "LBL_ChoixRestantsOral"
        Me.LBL_ChoixRestantsOral.Size = New System.Drawing.Size(182, 23)
        Me.LBL_ChoixRestantsOral.TabIndex = 51
        Me.LBL_ChoixRestantsOral.Text = "Nombre de choix restants : "
        '
        'ChoixRestantOral
        '
        Me.ChoixRestantOral.AutoSize = True
        Me.ChoixRestantOral.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChoixRestantOral.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ChoixRestantOral.Location = New System.Drawing.Point(952, 682)
        Me.ChoixRestantOral.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ChoixRestantOral.Name = "ChoixRestantOral"
        Me.ChoixRestantOral.Size = New System.Drawing.Size(18, 23)
        Me.ChoixRestantOral.TabIndex = 52
        Me.ChoixRestantOral.Text = "3"
        '
        'NomCandidat1
        '
        Me.NomCandidat1.AutoSize = True
        Me.NomCandidat1.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomCandidat1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.NomCandidat1.Location = New System.Drawing.Point(543, 283)
        Me.NomCandidat1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.NomCandidat1.Name = "NomCandidat1"
        Me.NomCandidat1.Size = New System.Drawing.Size(112, 25)
        Me.NomCandidat1.TabIndex = 53
        Me.NomCandidat1.Text = "[NomCandidat]"
        '
        'PrenomCandidat1
        '
        Me.PrenomCandidat1.AutoSize = True
        Me.PrenomCandidat1.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrenomCandidat1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.PrenomCandidat1.Location = New System.Drawing.Point(567, 329)
        Me.PrenomCandidat1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.PrenomCandidat1.Name = "PrenomCandidat1"
        Me.PrenomCandidat1.Size = New System.Drawing.Size(135, 25)
        Me.PrenomCandidat1.TabIndex = 54
        Me.PrenomCandidat1.Text = "[PrénomCandidat]"
        '
        'AbandonnerInscrip1
        '
        Me.AbandonnerInscrip1.BackColor = System.Drawing.Color.Gray
        Me.AbandonnerInscrip1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.AbandonnerInscrip1.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AbandonnerInscrip1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.AbandonnerInscrip1.Location = New System.Drawing.Point(494, 868)
        Me.AbandonnerInscrip1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.AbandonnerInscrip1.Name = "AbandonnerInscrip1"
        Me.AbandonnerInscrip1.Size = New System.Drawing.Size(190, 79)
        Me.AbandonnerInscrip1.TabIndex = 55
        Me.AbandonnerInscrip1.Text = "Abandonner Inscription"
        Me.AbandonnerInscrip1.UseVisualStyleBackColor = False
        '
        'GRP_MatieresEcrit
        '
        Me.GRP_MatieresEcrit.Controls.Add(Me.VisualBasicNET)
        Me.GRP_MatieresEcrit.Controls.Add(Me.Système)
        Me.GRP_MatieresEcrit.Controls.Add(Me.Réseau)
        Me.GRP_MatieresEcrit.Controls.Add(Me.ProgrammationWEB)
        Me.GRP_MatieresEcrit.Controls.Add(Me.Mathématiques)
        Me.GRP_MatieresEcrit.Controls.Add(Me.Droit)
        Me.GRP_MatieresEcrit.Controls.Add(Me.LangageJava)
        Me.GRP_MatieresEcrit.Controls.Add(Me.LangageC)
        Me.GRP_MatieresEcrit.Controls.Add(Me.Expression)
        Me.GRP_MatieresEcrit.Controls.Add(Me.Gestion)
        Me.GRP_MatieresEcrit.Controls.Add(Me.BaseDeDonnées)
        Me.GRP_MatieresEcrit.Controls.Add(Me.Algorithmique)
        Me.GRP_MatieresEcrit.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRP_MatieresEcrit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GRP_MatieresEcrit.Location = New System.Drawing.Point(330, 456)
        Me.GRP_MatieresEcrit.Name = "GRP_MatieresEcrit"
        Me.GRP_MatieresEcrit.Size = New System.Drawing.Size(352, 211)
        Me.GRP_MatieresEcrit.TabIndex = 56
        Me.GRP_MatieresEcrit.TabStop = False
        Me.GRP_MatieresEcrit.Text = "Veuillez choisir 4 matières "
        '
        'VisualBasicNET
        '
        Me.VisualBasicNET.AutoSize = True
        Me.VisualBasicNET.Location = New System.Drawing.Point(187, 176)
        Me.VisualBasicNET.Name = "VisualBasicNET"
        Me.VisualBasicNET.Size = New System.Drawing.Size(133, 23)
        Me.VisualBasicNET.TabIndex = 11
        Me.VisualBasicNET.Text = "Visual Basic.NET"
        Me.VisualBasicNET.UseVisualStyleBackColor = True
        '
        'Système
        '
        Me.Système.AutoSize = True
        Me.Système.Location = New System.Drawing.Point(187, 147)
        Me.Système.Name = "Système"
        Me.Système.Size = New System.Drawing.Size(81, 23)
        Me.Système.TabIndex = 10
        Me.Système.Text = "Système"
        Me.Système.UseVisualStyleBackColor = True
        '
        'Réseau
        '
        Me.Réseau.AutoSize = True
        Me.Réseau.Location = New System.Drawing.Point(187, 118)
        Me.Réseau.Name = "Réseau"
        Me.Réseau.Size = New System.Drawing.Size(74, 23)
        Me.Réseau.TabIndex = 9
        Me.Réseau.Text = "Réseau"
        Me.Réseau.UseVisualStyleBackColor = True
        '
        'ProgrammationWEB
        '
        Me.ProgrammationWEB.AutoSize = True
        Me.ProgrammationWEB.Location = New System.Drawing.Point(187, 89)
        Me.ProgrammationWEB.Name = "ProgrammationWEB"
        Me.ProgrammationWEB.Size = New System.Drawing.Size(159, 23)
        Me.ProgrammationWEB.TabIndex = 8
        Me.ProgrammationWEB.Text = "Programmation WEB"
        Me.ProgrammationWEB.UseVisualStyleBackColor = True
        '
        'Mathématiques
        '
        Me.Mathématiques.AutoSize = True
        Me.Mathématiques.Location = New System.Drawing.Point(187, 60)
        Me.Mathématiques.Name = "Mathématiques"
        Me.Mathématiques.Size = New System.Drawing.Size(132, 23)
        Me.Mathématiques.TabIndex = 7
        Me.Mathématiques.Text = "*Mathématiques"
        Me.Mathématiques.UseVisualStyleBackColor = True
        '
        'Droit
        '
        Me.Droit.AutoSize = True
        Me.Droit.Location = New System.Drawing.Point(8, 89)
        Me.Droit.Name = "Droit"
        Me.Droit.Size = New System.Drawing.Size(59, 23)
        Me.Droit.TabIndex = 6
        Me.Droit.Text = "Droit"
        Me.Droit.UseVisualStyleBackColor = True
        '
        'LangageJava
        '
        Me.LangageJava.AutoSize = True
        Me.LangageJava.Location = New System.Drawing.Point(187, 31)
        Me.LangageJava.Name = "LangageJava"
        Me.LangageJava.Size = New System.Drawing.Size(117, 23)
        Me.LangageJava.TabIndex = 5
        Me.LangageJava.Text = "Langage Java"
        Me.LangageJava.UseVisualStyleBackColor = True
        '
        'LangageC
        '
        Me.LangageC.AutoSize = True
        Me.LangageC.Location = New System.Drawing.Point(8, 176)
        Me.LangageC.Name = "LangageC"
        Me.LangageC.Size = New System.Drawing.Size(95, 23)
        Me.LangageC.TabIndex = 4
        Me.LangageC.Text = "Langage C"
        Me.LangageC.UseVisualStyleBackColor = True
        '
        'Expression
        '
        Me.Expression.AutoSize = True
        Me.Expression.Location = New System.Drawing.Point(8, 118)
        Me.Expression.Name = "Expression"
        Me.Expression.Size = New System.Drawing.Size(97, 23)
        Me.Expression.TabIndex = 3
        Me.Expression.Text = "Expression"
        Me.Expression.UseVisualStyleBackColor = True
        '
        'Gestion
        '
        Me.Gestion.AutoSize = True
        Me.Gestion.Location = New System.Drawing.Point(8, 147)
        Me.Gestion.Name = "Gestion"
        Me.Gestion.Size = New System.Drawing.Size(75, 23)
        Me.Gestion.TabIndex = 2
        Me.Gestion.Text = "Gestion"
        Me.Gestion.UseVisualStyleBackColor = True
        '
        'BaseDeDonnées
        '
        Me.BaseDeDonnées.AutoSize = True
        Me.BaseDeDonnées.Location = New System.Drawing.Point(8, 60)
        Me.BaseDeDonnées.Name = "BaseDeDonnées"
        Me.BaseDeDonnées.Size = New System.Drawing.Size(134, 23)
        Me.BaseDeDonnées.TabIndex = 1
        Me.BaseDeDonnées.Text = "Base de données"
        Me.BaseDeDonnées.UseVisualStyleBackColor = True
        '
        'Algorithmique
        '
        Me.Algorithmique.AutoSize = True
        Me.Algorithmique.Location = New System.Drawing.Point(8, 31)
        Me.Algorithmique.Name = "Algorithmique"
        Me.Algorithmique.Size = New System.Drawing.Size(118, 23)
        Me.Algorithmique.TabIndex = 0
        Me.Algorithmique.Text = "Algorithmique"
        Me.Algorithmique.UseVisualStyleBackColor = True
        '
        'GRP_MatieresOral
        '
        Me.GRP_MatieresOral.Controls.Add(Me.Système1)
        Me.GRP_MatieresOral.Controls.Add(Me.Réseau1)
        Me.GRP_MatieresOral.Controls.Add(Me.Mathématiques1)
        Me.GRP_MatieresOral.Controls.Add(Me.Gestion1)
        Me.GRP_MatieresOral.Controls.Add(Me.Expression1)
        Me.GRP_MatieresOral.Controls.Add(Me.Espagnol)
        Me.GRP_MatieresOral.Controls.Add(Me.Droit1)
        Me.GRP_MatieresOral.Controls.Add(Me.Chinois)
        Me.GRP_MatieresOral.Controls.Add(Me.Anglais)
        Me.GRP_MatieresOral.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRP_MatieresOral.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GRP_MatieresOral.Location = New System.Drawing.Point(708, 456)
        Me.GRP_MatieresOral.Name = "GRP_MatieresOral"
        Me.GRP_MatieresOral.Size = New System.Drawing.Size(352, 211)
        Me.GRP_MatieresOral.TabIndex = 57
        Me.GRP_MatieresOral.TabStop = False
        Me.GRP_MatieresOral.Text = "Veuillez choisir 3 matières "
        '
        'Système1
        '
        Me.Système1.AutoSize = True
        Me.Système1.Location = New System.Drawing.Point(153, 122)
        Me.Système1.Name = "Système1"
        Me.Système1.Size = New System.Drawing.Size(81, 23)
        Me.Système1.TabIndex = 11
        Me.Système1.Text = "Système"
        Me.Système1.UseVisualStyleBackColor = True
        '
        'Réseau1
        '
        Me.Réseau1.AutoSize = True
        Me.Réseau1.Location = New System.Drawing.Point(153, 93)
        Me.Réseau1.Name = "Réseau1"
        Me.Réseau1.Size = New System.Drawing.Size(74, 23)
        Me.Réseau1.TabIndex = 10
        Me.Réseau1.Text = "Réseau"
        Me.Réseau1.UseVisualStyleBackColor = True
        '
        'Mathématiques1
        '
        Me.Mathématiques1.AutoSize = True
        Me.Mathématiques1.Location = New System.Drawing.Point(153, 64)
        Me.Mathématiques1.Name = "Mathématiques1"
        Me.Mathématiques1.Size = New System.Drawing.Size(126, 23)
        Me.Mathématiques1.TabIndex = 8
        Me.Mathématiques1.Text = "Mathématiques"
        Me.Mathématiques1.UseVisualStyleBackColor = True
        '
        'Gestion1
        '
        Me.Gestion1.AutoSize = True
        Me.Gestion1.Location = New System.Drawing.Point(153, 35)
        Me.Gestion1.Name = "Gestion1"
        Me.Gestion1.Size = New System.Drawing.Size(75, 23)
        Me.Gestion1.TabIndex = 6
        Me.Gestion1.Text = "Gestion"
        Me.Gestion1.UseVisualStyleBackColor = True
        '
        'Expression1
        '
        Me.Expression1.AutoSize = True
        Me.Expression1.Location = New System.Drawing.Point(6, 147)
        Me.Expression1.Name = "Expression1"
        Me.Expression1.Size = New System.Drawing.Size(97, 23)
        Me.Expression1.TabIndex = 5
        Me.Expression1.Text = "Expression"
        Me.Expression1.UseVisualStyleBackColor = True
        '
        'Espagnol
        '
        Me.Espagnol.AutoSize = True
        Me.Espagnol.Location = New System.Drawing.Point(6, 118)
        Me.Espagnol.Name = "Espagnol"
        Me.Espagnol.Size = New System.Drawing.Size(86, 23)
        Me.Espagnol.TabIndex = 4
        Me.Espagnol.Text = "Espagnol"
        Me.Espagnol.UseVisualStyleBackColor = True
        '
        'Droit1
        '
        Me.Droit1.AutoSize = True
        Me.Droit1.Location = New System.Drawing.Point(6, 89)
        Me.Droit1.Name = "Droit1"
        Me.Droit1.Size = New System.Drawing.Size(59, 23)
        Me.Droit1.TabIndex = 3
        Me.Droit1.Text = "Droit"
        Me.Droit1.UseVisualStyleBackColor = True
        '
        'Chinois
        '
        Me.Chinois.AutoSize = True
        Me.Chinois.Location = New System.Drawing.Point(6, 60)
        Me.Chinois.Name = "Chinois"
        Me.Chinois.Size = New System.Drawing.Size(74, 23)
        Me.Chinois.TabIndex = 2
        Me.Chinois.Text = "Chinois"
        Me.Chinois.UseVisualStyleBackColor = True
        '
        'Anglais
        '
        Me.Anglais.AutoSize = True
        Me.Anglais.Location = New System.Drawing.Point(6, 31)
        Me.Anglais.Name = "Anglais"
        Me.Anglais.Size = New System.Drawing.Size(76, 23)
        Me.Anglais.TabIndex = 1
        Me.Anglais.Text = "Anglais"
        Me.Anglais.UseVisualStyleBackColor = True
        '
        'RADIO_Oui
        '
        Me.RADIO_Oui.AutoSize = True
        Me.RADIO_Oui.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RADIO_Oui.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.RADIO_Oui.Location = New System.Drawing.Point(106, 30)
        Me.RADIO_Oui.Name = "RADIO_Oui"
        Me.RADIO_Oui.Size = New System.Drawing.Size(44, 22)
        Me.RADIO_Oui.TabIndex = 58
        Me.RADIO_Oui.TabStop = True
        Me.RADIO_Oui.Text = "Oui"
        Me.RADIO_Oui.UseVisualStyleBackColor = True
        '
        'GRP_Facultatif
        '
        Me.GRP_Facultatif.Controls.Add(Me.RADIO_Non)
        Me.GRP_Facultatif.Controls.Add(Me.RADIO_Oui)
        Me.GRP_Facultatif.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRP_Facultatif.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GRP_Facultatif.Location = New System.Drawing.Point(330, 743)
        Me.GRP_Facultatif.Name = "GRP_Facultatif"
        Me.GRP_Facultatif.Size = New System.Drawing.Size(352, 83)
        Me.GRP_Facultatif.TabIndex = 59
        Me.GRP_Facultatif.TabStop = False
        Me.GRP_Facultatif.Text = "Voulez vous vous inscrire à une épreuve facultative ?"
        '
        'RADIO_Non
        '
        Me.RADIO_Non.AutoSize = True
        Me.RADIO_Non.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RADIO_Non.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.RADIO_Non.Location = New System.Drawing.Point(176, 30)
        Me.RADIO_Non.Name = "RADIO_Non"
        Me.RADIO_Non.Size = New System.Drawing.Size(49, 22)
        Me.RADIO_Non.TabIndex = 59
        Me.RADIO_Non.TabStop = True
        Me.RADIO_Non.Text = "Non"
        Me.RADIO_Non.UseVisualStyleBackColor = True
        '
        'CMB_Facultatif
        '
        Me.CMB_Facultatif.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMB_Facultatif.FormattingEnabled = True
        Me.CMB_Facultatif.Location = New System.Drawing.Point(80, 29)
        Me.CMB_Facultatif.Name = "CMB_Facultatif"
        Me.CMB_Facultatif.Size = New System.Drawing.Size(171, 26)
        Me.CMB_Facultatif.TabIndex = 60
        '
        'ValidInscrip1
        '
        Me.ValidInscrip1.BackColor = System.Drawing.Color.Gray
        Me.ValidInscrip1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ValidInscrip1.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValidInscrip1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ValidInscrip1.Location = New System.Drawing.Point(708, 868)
        Me.ValidInscrip1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ValidInscrip1.Name = "ValidInscrip1"
        Me.ValidInscrip1.Size = New System.Drawing.Size(190, 79)
        Me.ValidInscrip1.TabIndex = 61
        Me.ValidInscrip1.Text = "Valider Inscription"
        Me.ValidInscrip1.UseVisualStyleBackColor = False
        '
        'GRP_EpreuvesFacultatives
        '
        Me.GRP_EpreuvesFacultatives.Controls.Add(Me.CMB_Facultatif)
        Me.GRP_EpreuvesFacultatives.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.0!)
        Me.GRP_EpreuvesFacultatives.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GRP_EpreuvesFacultatives.Location = New System.Drawing.Point(708, 743)
        Me.GRP_EpreuvesFacultatives.Name = "GRP_EpreuvesFacultatives"
        Me.GRP_EpreuvesFacultatives.Size = New System.Drawing.Size(352, 83)
        Me.GRP_EpreuvesFacultatives.TabIndex = 62
        Me.GRP_EpreuvesFacultatives.TabStop = False
        Me.GRP_EpreuvesFacultatives.Text = "Liste des épreuves facultatives disponibles "
        '
        'FormulaireChoixEpreuves
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(1356, 1061)
        Me.Controls.Add(Me.GRP_EpreuvesFacultatives)
        Me.Controls.Add(Me.ValidInscrip1)
        Me.Controls.Add(Me.GRP_Facultatif)
        Me.Controls.Add(Me.GRP_MatieresOral)
        Me.Controls.Add(Me.GRP_MatieresEcrit)
        Me.Controls.Add(Me.AbandonnerInscrip1)
        Me.Controls.Add(Me.PrenomCandidat1)
        Me.Controls.Add(Me.NomCandidat1)
        Me.Controls.Add(Me.ChoixRestantOral)
        Me.Controls.Add(Me.LBL_ChoixRestantsOral)
        Me.Controls.Add(Me.ChoixRestantEcrit)
        Me.Controls.Add(Me.LBL_ChoixRestantsEcrit)
        Me.Controls.Add(Me.SéparationMatières)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CMB_Regions)
        Me.Controls.Add(Me.LBL_ChoixRegionPassage)
        Me.Controls.Add(Me.LBL_PrenomCandidat1)
        Me.Controls.Add(Me.LBL_NomCandidat1)
        Me.Controls.Add(Me.LBL_InfosCandidat)
        Me.Controls.Add(Me.DateHeure1)
        Me.Controls.Add(Me.LBL_DateHeure1)
        Me.Controls.Add(Me.TempsImparti1)
        Me.Controls.Add(Me.LBL_TempsImparti1)
        Me.Controls.Add(Me.LBL_TempsRestant1)
        Me.Controls.Add(Me.TempsRestant1)
        Me.Controls.Add(Me.SousTitreFormulaireChoixEpreuves)
        Me.Controls.Add(Me.TitreFormulaireChoixEpreuves)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.SeparationFormulaireChoixEpreuves)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormulaireChoixEpreuves"
        Me.Text = "Choix des épreuves"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GRP_MatieresEcrit.ResumeLayout(False)
        Me.GRP_MatieresEcrit.PerformLayout()
        Me.GRP_MatieresOral.ResumeLayout(False)
        Me.GRP_MatieresOral.PerformLayout()
        Me.GRP_Facultatif.ResumeLayout(False)
        Me.GRP_Facultatif.PerformLayout()
        Me.GRP_EpreuvesFacultatives.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SeparationFormulaireChoixEpreuves As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TitreFormulaireChoixEpreuves As Label
    Friend WithEvents SousTitreFormulaireChoixEpreuves As Label
    Friend WithEvents DateHeure1 As Label
    Friend WithEvents TempsRestant1 As Label
    Friend WithEvents LBL_TempsRestant1 As Label
    Friend WithEvents LBL_TempsImparti1 As Label
    Friend WithEvents TempsImparti1 As Label
    Friend WithEvents LBL_DateHeure1 As Label
    Friend WithEvents Minuteur2 As Timer
    Friend WithEvents LBL_InfosCandidat As Label
    Friend WithEvents LBL_PrenomCandidat1 As Label
    Friend WithEvents LBL_NomCandidat1 As Label
    Friend WithEvents LBL_ChoixRegionPassage As Label
    Friend WithEvents CMB_Regions As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents SéparationMatières As Label
    Friend WithEvents LBL_ChoixRestantsEcrit As Label
    Friend WithEvents ChoixRestantEcrit As Label
    Friend WithEvents LBL_ChoixRestantsOral As Label
    Friend WithEvents ChoixRestantOral As Label
    Friend WithEvents NomCandidat1 As Label
    Friend WithEvents PrenomCandidat1 As Label
    Friend WithEvents AbandonnerInscrip1 As Button
    Friend WithEvents GRP_MatieresEcrit As GroupBox
    Friend WithEvents Droit As CheckBox
    Friend WithEvents LangageJava As CheckBox
    Friend WithEvents LangageC As CheckBox
    Friend WithEvents Expression As CheckBox
    Friend WithEvents Gestion As CheckBox
    Friend WithEvents BaseDeDonnées As CheckBox
    Friend WithEvents Algorithmique As CheckBox
    Friend WithEvents GRP_MatieresOral As GroupBox
    Friend WithEvents VisualBasicNET As CheckBox
    Friend WithEvents Système As CheckBox
    Friend WithEvents Réseau As CheckBox
    Friend WithEvents ProgrammationWEB As CheckBox
    Friend WithEvents Mathématiques As CheckBox
    Friend WithEvents Système1 As CheckBox
    Friend WithEvents Réseau1 As CheckBox
    Friend WithEvents Mathématiques1 As CheckBox
    Friend WithEvents Gestion1 As CheckBox
    Friend WithEvents Expression1 As CheckBox
    Friend WithEvents Espagnol As CheckBox
    Friend WithEvents Droit1 As CheckBox
    Friend WithEvents Chinois As CheckBox
    Friend WithEvents Anglais As CheckBox
    Friend WithEvents RADIO_Oui As RadioButton
    Friend WithEvents GRP_Facultatif As GroupBox
    Friend WithEvents RADIO_Non As RadioButton
    Friend WithEvents CMB_Facultatif As ComboBox
    Friend WithEvents ValidInscrip1 As Button
    Friend WithEvents GRP_EpreuvesFacultatives As GroupBox
End Class
