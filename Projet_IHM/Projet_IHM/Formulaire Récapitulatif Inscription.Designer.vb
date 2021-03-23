<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Formulaire_Récapitulatif_Inscription
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formulaire_Récapitulatif_Inscription))
        Me.TitreFormulaireRecapInscription = New System.Windows.Forms.Label()
        Me.LBL_NomCandidat1 = New System.Windows.Forms.Label()
        Me.LBL_PrenomCandidat1 = New System.Windows.Forms.Label()
        Me.LBL_AdresseCandidat1 = New System.Windows.Forms.Label()
        Me.LBL_CodePostalCandidat1 = New System.Windows.Forms.Label()
        Me.LBL_VilleCandidat1 = New System.Windows.Forms.Label()
        Me.LBL_AgeCandidat1 = New System.Windows.Forms.Label()
        Me.LBL_InfosCandidat = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GRP_TotalEpreuves = New System.Windows.Forms.GroupBox()
        Me.LIST_TotalEcrit = New System.Windows.Forms.ListBox()
        Me.NomCandidat2 = New System.Windows.Forms.Label()
        Me.PrenomCandidat2 = New System.Windows.Forms.Label()
        Me.AdresseCandidat2 = New System.Windows.Forms.Label()
        Me.CodePostal2 = New System.Windows.Forms.Label()
        Me.VilleCandidat2 = New System.Windows.Forms.Label()
        Me.AgeCandidat2 = New System.Windows.Forms.Label()
        Me.EpreuveFacultative2 = New System.Windows.Forms.Label()
        Me.RégionPassage2 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.SeparationFormulaireChoixEpreuves = New System.Windows.Forms.Label()
        Me.AnnulerInscrip = New System.Windows.Forms.Button()
        Me.EnregistrerInscrip = New System.Windows.Forms.Button()
        Me.ModifierInscrip1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LIST_TotalOral = New System.Windows.Forms.ListBox()
        Me.GRP_TotalEpreuves.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TitreFormulaireRecapInscription
        '
        Me.TitreFormulaireRecapInscription.AutoSize = True
        Me.TitreFormulaireRecapInscription.Font = New System.Drawing.Font("Bahnschrift Condensed", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitreFormulaireRecapInscription.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TitreFormulaireRecapInscription.Location = New System.Drawing.Point(237, 20)
        Me.TitreFormulaireRecapInscription.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TitreFormulaireRecapInscription.Name = "TitreFormulaireRecapInscription"
        Me.TitreFormulaireRecapInscription.Size = New System.Drawing.Size(563, 58)
        Me.TitreFormulaireRecapInscription.TabIndex = 6
        Me.TitreFormulaireRecapInscription.Text = "Récapitulatif de votre inscription "
        '
        'LBL_NomCandidat1
        '
        Me.LBL_NomCandidat1.AutoSize = True
        Me.LBL_NomCandidat1.Font = New System.Drawing.Font("Bahnschrift Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_NomCandidat1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LBL_NomCandidat1.Location = New System.Drawing.Point(84, 200)
        Me.LBL_NomCandidat1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBL_NomCandidat1.Name = "LBL_NomCandidat1"
        Me.LBL_NomCandidat1.Size = New System.Drawing.Size(66, 29)
        Me.LBL_NomCandidat1.TabIndex = 8
        Me.LBL_NomCandidat1.Text = "-Nom :"
        '
        'LBL_PrenomCandidat1
        '
        Me.LBL_PrenomCandidat1.AutoSize = True
        Me.LBL_PrenomCandidat1.Font = New System.Drawing.Font("Bahnschrift Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_PrenomCandidat1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LBL_PrenomCandidat1.Location = New System.Drawing.Point(84, 238)
        Me.LBL_PrenomCandidat1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBL_PrenomCandidat1.Name = "LBL_PrenomCandidat1"
        Me.LBL_PrenomCandidat1.Size = New System.Drawing.Size(91, 29)
        Me.LBL_PrenomCandidat1.TabIndex = 9
        Me.LBL_PrenomCandidat1.Text = "-Prénom :"
        '
        'LBL_AdresseCandidat1
        '
        Me.LBL_AdresseCandidat1.AutoSize = True
        Me.LBL_AdresseCandidat1.Font = New System.Drawing.Font("Bahnschrift Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_AdresseCandidat1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LBL_AdresseCandidat1.Location = New System.Drawing.Point(84, 277)
        Me.LBL_AdresseCandidat1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBL_AdresseCandidat1.Name = "LBL_AdresseCandidat1"
        Me.LBL_AdresseCandidat1.Size = New System.Drawing.Size(185, 29)
        Me.LBL_AdresseCandidat1.TabIndex = 10
        Me.LBL_AdresseCandidat1.Text = "-Adresse (facultatif) :"
        '
        'LBL_CodePostalCandidat1
        '
        Me.LBL_CodePostalCandidat1.AutoSize = True
        Me.LBL_CodePostalCandidat1.Font = New System.Drawing.Font("Bahnschrift Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_CodePostalCandidat1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LBL_CodePostalCandidat1.Location = New System.Drawing.Point(84, 317)
        Me.LBL_CodePostalCandidat1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBL_CodePostalCandidat1.Name = "LBL_CodePostalCandidat1"
        Me.LBL_CodePostalCandidat1.Size = New System.Drawing.Size(118, 29)
        Me.LBL_CodePostalCandidat1.TabIndex = 11
        Me.LBL_CodePostalCandidat1.Text = "-Code Postal:"
        '
        'LBL_VilleCandidat1
        '
        Me.LBL_VilleCandidat1.AutoSize = True
        Me.LBL_VilleCandidat1.Font = New System.Drawing.Font("Bahnschrift Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_VilleCandidat1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LBL_VilleCandidat1.Location = New System.Drawing.Point(84, 358)
        Me.LBL_VilleCandidat1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBL_VilleCandidat1.Name = "LBL_VilleCandidat1"
        Me.LBL_VilleCandidat1.Size = New System.Drawing.Size(66, 29)
        Me.LBL_VilleCandidat1.TabIndex = 12
        Me.LBL_VilleCandidat1.Text = "-Ville :"
        '
        'LBL_AgeCandidat1
        '
        Me.LBL_AgeCandidat1.AutoSize = True
        Me.LBL_AgeCandidat1.Font = New System.Drawing.Font("Bahnschrift Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_AgeCandidat1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LBL_AgeCandidat1.Location = New System.Drawing.Point(84, 398)
        Me.LBL_AgeCandidat1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBL_AgeCandidat1.Name = "LBL_AgeCandidat1"
        Me.LBL_AgeCandidat1.Size = New System.Drawing.Size(61, 29)
        Me.LBL_AgeCandidat1.TabIndex = 13
        Me.LBL_AgeCandidat1.Text = "-Âge :"
        '
        'LBL_InfosCandidat
        '
        Me.LBL_InfosCandidat.AutoSize = True
        Me.LBL_InfosCandidat.Font = New System.Drawing.Font("Bahnschrift Condensed", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_InfosCandidat.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LBL_InfosCandidat.Location = New System.Drawing.Point(82, 145)
        Me.LBL_InfosCandidat.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBL_InfosCandidat.Name = "LBL_InfosCandidat"
        Me.LBL_InfosCandidat.Size = New System.Drawing.Size(247, 39)
        Me.LBL_InfosCandidat.TabIndex = 31
        Me.LBL_InfosCandidat.Text = "Informations candidat"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bahnschrift Condensed", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(459, 145)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(255, 39)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Informations épreuves"
        '
        'GRP_TotalEpreuves
        '
        Me.GRP_TotalEpreuves.Controls.Add(Me.LIST_TotalEcrit)
        Me.GRP_TotalEpreuves.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRP_TotalEpreuves.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GRP_TotalEpreuves.Location = New System.Drawing.Point(463, 295)
        Me.GRP_TotalEpreuves.Name = "GRP_TotalEpreuves"
        Me.GRP_TotalEpreuves.Size = New System.Drawing.Size(218, 223)
        Me.GRP_TotalEpreuves.TabIndex = 34
        Me.GRP_TotalEpreuves.TabStop = False
        Me.GRP_TotalEpreuves.Text = "Epreuves écrites choisies"
        '
        'LIST_TotalEcrit
        '
        Me.LIST_TotalEcrit.FormattingEnabled = True
        Me.LIST_TotalEcrit.ItemHeight = 19
        Me.LIST_TotalEcrit.Location = New System.Drawing.Point(36, 40)
        Me.LIST_TotalEcrit.Name = "LIST_TotalEcrit"
        Me.LIST_TotalEcrit.Size = New System.Drawing.Size(138, 156)
        Me.LIST_TotalEcrit.TabIndex = 34
        '
        'NomCandidat2
        '
        Me.NomCandidat2.AutoSize = True
        Me.NomCandidat2.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomCandidat2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.NomCandidat2.Location = New System.Drawing.Point(144, 203)
        Me.NomCandidat2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.NomCandidat2.Name = "NomCandidat2"
        Me.NomCandidat2.Size = New System.Drawing.Size(112, 25)
        Me.NomCandidat2.TabIndex = 54
        Me.NomCandidat2.Text = "[NomCandidat]"
        '
        'PrenomCandidat2
        '
        Me.PrenomCandidat2.AutoSize = True
        Me.PrenomCandidat2.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrenomCandidat2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.PrenomCandidat2.Location = New System.Drawing.Point(169, 241)
        Me.PrenomCandidat2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.PrenomCandidat2.Name = "PrenomCandidat2"
        Me.PrenomCandidat2.Size = New System.Drawing.Size(135, 25)
        Me.PrenomCandidat2.TabIndex = 55
        Me.PrenomCandidat2.Text = "[PrénomCandidat]"
        '
        'AdresseCandidat2
        '
        Me.AdresseCandidat2.AutoSize = True
        Me.AdresseCandidat2.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdresseCandidat2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.AdresseCandidat2.Location = New System.Drawing.Point(264, 281)
        Me.AdresseCandidat2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.AdresseCandidat2.Name = "AdresseCandidat2"
        Me.AdresseCandidat2.Size = New System.Drawing.Size(138, 25)
        Me.AdresseCandidat2.TabIndex = 56
        Me.AdresseCandidat2.Text = "[AdresseCandidat]"
        '
        'CodePostal2
        '
        Me.CodePostal2.AutoSize = True
        Me.CodePostal2.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodePostal2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.CodePostal2.Location = New System.Drawing.Point(199, 320)
        Me.CodePostal2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.CodePostal2.Name = "CodePostal2"
        Me.CodePostal2.Size = New System.Drawing.Size(159, 25)
        Me.CodePostal2.TabIndex = 57
        Me.CodePostal2.Text = "[CodePostalCandidat]"
        '
        'VilleCandidat2
        '
        Me.VilleCandidat2.AutoSize = True
        Me.VilleCandidat2.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VilleCandidat2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.VilleCandidat2.Location = New System.Drawing.Point(145, 361)
        Me.VilleCandidat2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.VilleCandidat2.Name = "VilleCandidat2"
        Me.VilleCandidat2.Size = New System.Drawing.Size(112, 25)
        Me.VilleCandidat2.TabIndex = 58
        Me.VilleCandidat2.Text = "[VilleCandidat]"
        '
        'AgeCandidat2
        '
        Me.AgeCandidat2.AutoSize = True
        Me.AgeCandidat2.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgeCandidat2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.AgeCandidat2.Location = New System.Drawing.Point(144, 401)
        Me.AgeCandidat2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.AgeCandidat2.Name = "AgeCandidat2"
        Me.AgeCandidat2.Size = New System.Drawing.Size(107, 25)
        Me.AgeCandidat2.TabIndex = 59
        Me.AgeCandidat2.Text = "[ÂgeCandidat]"
        '
        'EpreuveFacultative2
        '
        Me.EpreuveFacultative2.AutoSize = True
        Me.EpreuveFacultative2.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EpreuveFacultative2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.EpreuveFacultative2.Location = New System.Drawing.Point(634, 241)
        Me.EpreuveFacultative2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.EpreuveFacultative2.Name = "EpreuveFacultative2"
        Me.EpreuveFacultative2.Size = New System.Drawing.Size(156, 25)
        Me.EpreuveFacultative2.TabIndex = 63
        Me.EpreuveFacultative2.Text = "[EpreuveFacultative]"
        '
        'RégionPassage2
        '
        Me.RégionPassage2.AutoSize = True
        Me.RégionPassage2.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RégionPassage2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.RégionPassage2.Location = New System.Drawing.Point(634, 203)
        Me.RégionPassage2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.RégionPassage2.Name = "RégionPassage2"
        Me.RégionPassage2.Size = New System.Drawing.Size(124, 25)
        Me.RégionPassage2.TabIndex = 62
        Me.RégionPassage2.Text = "[RégionPassage]"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Bahnschrift Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label13.Location = New System.Drawing.Point(458, 238)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(180, 29)
        Me.Label13.TabIndex = 61
        Me.Label13.Text = "Epreuve Facultative :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Bahnschrift Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label14.Location = New System.Drawing.Point(458, 200)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(172, 29)
        Me.Label14.TabIndex = 60
        Me.Label14.Text = "Région de passage :"
        '
        'SeparationFormulaireChoixEpreuves
        '
        Me.SeparationFormulaireChoixEpreuves.AutoSize = True
        Me.SeparationFormulaireChoixEpreuves.Font = New System.Drawing.Font("Bahnschrift Condensed", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SeparationFormulaireChoixEpreuves.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.SeparationFormulaireChoixEpreuves.Location = New System.Drawing.Point(-113, 78)
        Me.SeparationFormulaireChoixEpreuves.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.SeparationFormulaireChoixEpreuves.Name = "SeparationFormulaireChoixEpreuves"
        Me.SeparationFormulaireChoixEpreuves.Size = New System.Drawing.Size(1370, 78)
        Me.SeparationFormulaireChoixEpreuves.TabIndex = 64
        Me.SeparationFormulaireChoixEpreuves.Text = "---------------------------------------------------------------------------------" &
    "------------------------------------------" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'AnnulerInscrip
        '
        Me.AnnulerInscrip.BackColor = System.Drawing.Color.Gray
        Me.AnnulerInscrip.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.AnnulerInscrip.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnnulerInscrip.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.AnnulerInscrip.Location = New System.Drawing.Point(205, 563)
        Me.AnnulerInscrip.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.AnnulerInscrip.Name = "AnnulerInscrip"
        Me.AnnulerInscrip.Size = New System.Drawing.Size(190, 79)
        Me.AnnulerInscrip.TabIndex = 67
        Me.AnnulerInscrip.Text = "Annuler Inscription"
        Me.AnnulerInscrip.UseVisualStyleBackColor = False
        '
        'EnregistrerInscrip
        '
        Me.EnregistrerInscrip.BackColor = System.Drawing.Color.Gray
        Me.EnregistrerInscrip.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.EnregistrerInscrip.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnregistrerInscrip.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.EnregistrerInscrip.Location = New System.Drawing.Point(639, 563)
        Me.EnregistrerInscrip.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.EnregistrerInscrip.Name = "EnregistrerInscrip"
        Me.EnregistrerInscrip.Size = New System.Drawing.Size(190, 79)
        Me.EnregistrerInscrip.TabIndex = 68
        Me.EnregistrerInscrip.Text = "Enregistrer Inscription"
        Me.EnregistrerInscrip.UseVisualStyleBackColor = False
        '
        'ModifierInscrip1
        '
        Me.ModifierInscrip1.BackColor = System.Drawing.Color.Gray
        Me.ModifierInscrip1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ModifierInscrip1.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ModifierInscrip1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ModifierInscrip1.Location = New System.Drawing.Point(427, 563)
        Me.ModifierInscrip1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ModifierInscrip1.Name = "ModifierInscrip1"
        Me.ModifierInscrip1.Size = New System.Drawing.Size(190, 79)
        Me.ModifierInscrip1.TabIndex = 69
        Me.ModifierInscrip1.Text = "Modifier Inscription"
        Me.ModifierInscrip1.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LIST_TotalOral)
        Me.GroupBox1.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(714, 295)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(218, 223)
        Me.GroupBox1.TabIndex = 70
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Epreuves orales choisies"
        '
        'LIST_TotalOral
        '
        Me.LIST_TotalOral.FormattingEnabled = True
        Me.LIST_TotalOral.ItemHeight = 19
        Me.LIST_TotalOral.Location = New System.Drawing.Point(36, 40)
        Me.LIST_TotalOral.Name = "LIST_TotalOral"
        Me.LIST_TotalOral.Size = New System.Drawing.Size(138, 156)
        Me.LIST_TotalOral.TabIndex = 34
        '
        'Formulaire_Récapitulatif_Inscription
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(998, 708)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ModifierInscrip1)
        Me.Controls.Add(Me.EnregistrerInscrip)
        Me.Controls.Add(Me.AnnulerInscrip)
        Me.Controls.Add(Me.EpreuveFacultative2)
        Me.Controls.Add(Me.RégionPassage2)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.AgeCandidat2)
        Me.Controls.Add(Me.VilleCandidat2)
        Me.Controls.Add(Me.CodePostal2)
        Me.Controls.Add(Me.AdresseCandidat2)
        Me.Controls.Add(Me.PrenomCandidat2)
        Me.Controls.Add(Me.NomCandidat2)
        Me.Controls.Add(Me.GRP_TotalEpreuves)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LBL_InfosCandidat)
        Me.Controls.Add(Me.LBL_AgeCandidat1)
        Me.Controls.Add(Me.LBL_VilleCandidat1)
        Me.Controls.Add(Me.LBL_CodePostalCandidat1)
        Me.Controls.Add(Me.LBL_AdresseCandidat1)
        Me.Controls.Add(Me.LBL_PrenomCandidat1)
        Me.Controls.Add(Me.LBL_NomCandidat1)
        Me.Controls.Add(Me.TitreFormulaireRecapInscription)
        Me.Controls.Add(Me.SeparationFormulaireChoixEpreuves)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Formulaire_Récapitulatif_Inscription"
        Me.Text = "Récapitulatif de l'inscription"
        Me.GRP_TotalEpreuves.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TitreFormulaireRecapInscription As Label
    Friend WithEvents LBL_NomCandidat1 As Label
    Friend WithEvents LBL_PrenomCandidat1 As Label
    Friend WithEvents LBL_AdresseCandidat1 As Label
    Friend WithEvents LBL_CodePostalCandidat1 As Label
    Friend WithEvents LBL_VilleCandidat1 As Label
    Friend WithEvents LBL_AgeCandidat1 As Label
    Friend WithEvents LBL_InfosCandidat As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GRP_TotalEpreuves As GroupBox
    Friend WithEvents LIST_TotalEcrit As ListBox
    Friend WithEvents NomCandidat2 As Label
    Friend WithEvents PrenomCandidat2 As Label
    Friend WithEvents AdresseCandidat2 As Label
    Friend WithEvents CodePostal2 As Label
    Friend WithEvents VilleCandidat2 As Label
    Friend WithEvents AgeCandidat2 As Label
    Friend WithEvents EpreuveFacultative2 As Label
    Friend WithEvents RégionPassage2 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents SeparationFormulaireChoixEpreuves As Label
    Friend WithEvents AnnulerInscrip As Button
    Friend WithEvents EnregistrerInscrip As Button
    Friend WithEvents ModifierInscrip1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LIST_TotalOral As ListBox
End Class
