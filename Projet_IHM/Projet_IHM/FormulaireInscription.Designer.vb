<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormulaireInscription
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormulaireInscription))
        Me.TitreFormulaireInscription = New System.Windows.Forms.Label()
        Me.SousTitreFormulaireInscription = New System.Windows.Forms.Label()
        Me.SeparationFormulaireInscription = New System.Windows.Forms.Label()
        Me.LBL_NomCandidat = New System.Windows.Forms.Label()
        Me.NomCandidat = New System.Windows.Forms.TextBox()
        Me.LBL_PrenomCandidat = New System.Windows.Forms.Label()
        Me.PrenomCandidat = New System.Windows.Forms.TextBox()
        Me.LBL_Adresse = New System.Windows.Forms.Label()
        Me.AdresseCandidat = New System.Windows.Forms.TextBox()
        Me.LBL_CodePostalCandidat = New System.Windows.Forms.Label()
        Me.CodePostalCandidat = New System.Windows.Forms.TextBox()
        Me.LBL_VilleCandidat = New System.Windows.Forms.Label()
        Me.VilleCandidat = New System.Windows.Forms.TextBox()
        Me.LBL_AgeCandidat = New System.Windows.Forms.Label()
        Me.AgeCandidat = New System.Windows.Forms.HScrollBar()
        Me.LBL_Age = New System.Windows.Forms.Label()
        Me.Minuteur1 = New System.Windows.Forms.Timer(Me.components)
        Me.TempsRestant = New System.Windows.Forms.Label()
        Me.LBL_TempsRestant = New System.Windows.Forms.Label()
        Me.TempsImparti = New System.Windows.Forms.Label()
        Me.LBL_TempsImparti = New System.Windows.Forms.Label()
        Me.LBL_DateHeure = New System.Windows.Forms.Label()
        Me.DateHeure = New System.Windows.Forms.Label()
        Me.ValidInscription = New System.Windows.Forms.Button()
        Me.AbandonnerInscrip = New System.Windows.Forms.Button()
        Me.IconeFormulaireInscription = New System.Windows.Forms.PictureBox()
        Me.ChampsObligatoires = New System.Windows.Forms.Label()
        CType(Me.IconeFormulaireInscription, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TitreFormulaireInscription
        '
        Me.TitreFormulaireInscription.AutoSize = True
        Me.TitreFormulaireInscription.Font = New System.Drawing.Font("Bahnschrift Condensed", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitreFormulaireInscription.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TitreFormulaireInscription.Location = New System.Drawing.Point(426, 60)
        Me.TitreFormulaireInscription.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TitreFormulaireInscription.Name = "TitreFormulaireInscription"
        Me.TitreFormulaireInscription.Size = New System.Drawing.Size(406, 58)
        Me.TitreFormulaireInscription.TabIndex = 0
        Me.TitreFormulaireInscription.Text = "Formulaire d'inscription"
        '
        'SousTitreFormulaireInscription
        '
        Me.SousTitreFormulaireInscription.AutoSize = True
        Me.SousTitreFormulaireInscription.Font = New System.Drawing.Font("Bahnschrift Condensed", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SousTitreFormulaireInscription.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.SousTitreFormulaireInscription.Location = New System.Drawing.Point(428, 118)
        Me.SousTitreFormulaireInscription.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.SousTitreFormulaireInscription.Name = "SousTitreFormulaireInscription"
        Me.SousTitreFormulaireInscription.Size = New System.Drawing.Size(241, 45)
        Me.SousTitreFormulaireInscription.TabIndex = 1
        Me.SousTitreFormulaireInscription.Text = "Concours National"
        '
        'SeparationFormulaireInscription
        '
        Me.SeparationFormulaireInscription.AutoSize = True
        Me.SeparationFormulaireInscription.Font = New System.Drawing.Font("Bahnschrift Condensed", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SeparationFormulaireInscription.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.SeparationFormulaireInscription.Location = New System.Drawing.Point(-2, 191)
        Me.SeparationFormulaireInscription.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.SeparationFormulaireInscription.Name = "SeparationFormulaireInscription"
        Me.SeparationFormulaireInscription.Size = New System.Drawing.Size(1370, 78)
        Me.SeparationFormulaireInscription.TabIndex = 2
        Me.SeparationFormulaireInscription.Text = "---------------------------------------------------------------------------------" &
    "------------------------------------------" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LBL_NomCandidat
        '
        Me.LBL_NomCandidat.AutoSize = True
        Me.LBL_NomCandidat.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_NomCandidat.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LBL_NomCandidat.Location = New System.Drawing.Point(470, 236)
        Me.LBL_NomCandidat.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBL_NomCandidat.Name = "LBL_NomCandidat"
        Me.LBL_NomCandidat.Size = New System.Drawing.Size(81, 33)
        Me.LBL_NomCandidat.TabIndex = 3
        Me.LBL_NomCandidat.Text = "-Nom* :"
        '
        'NomCandidat
        '
        Me.NomCandidat.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomCandidat.Location = New System.Drawing.Point(551, 242)
        Me.NomCandidat.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.NomCandidat.Name = "NomCandidat"
        Me.NomCandidat.Size = New System.Drawing.Size(150, 26)
        Me.NomCandidat.TabIndex = 0
        Me.NomCandidat.Tag = ""
        '
        'LBL_PrenomCandidat
        '
        Me.LBL_PrenomCandidat.AutoSize = True
        Me.LBL_PrenomCandidat.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_PrenomCandidat.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LBL_PrenomCandidat.Location = New System.Drawing.Point(470, 282)
        Me.LBL_PrenomCandidat.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBL_PrenomCandidat.Name = "LBL_PrenomCandidat"
        Me.LBL_PrenomCandidat.Size = New System.Drawing.Size(110, 33)
        Me.LBL_PrenomCandidat.TabIndex = 5
        Me.LBL_PrenomCandidat.Text = "-Prénom* :"
        '
        'PrenomCandidat
        '
        Me.PrenomCandidat.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrenomCandidat.Location = New System.Drawing.Point(580, 288)
        Me.PrenomCandidat.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PrenomCandidat.Name = "PrenomCandidat"
        Me.PrenomCandidat.Size = New System.Drawing.Size(180, 26)
        Me.PrenomCandidat.TabIndex = 1
        '
        'LBL_Adresse
        '
        Me.LBL_Adresse.AutoSize = True
        Me.LBL_Adresse.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Adresse.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LBL_Adresse.Location = New System.Drawing.Point(470, 326)
        Me.LBL_Adresse.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBL_Adresse.Name = "LBL_Adresse"
        Me.LBL_Adresse.Size = New System.Drawing.Size(207, 33)
        Me.LBL_Adresse.TabIndex = 7
        Me.LBL_Adresse.Text = "-Adresse (facultatif) :"
        '
        'AdresseCandidat
        '
        Me.AdresseCandidat.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdresseCandidat.Location = New System.Drawing.Point(684, 333)
        Me.AdresseCandidat.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.AdresseCandidat.Name = "AdresseCandidat"
        Me.AdresseCandidat.Size = New System.Drawing.Size(250, 26)
        Me.AdresseCandidat.TabIndex = 2
        '
        'LBL_CodePostalCandidat
        '
        Me.LBL_CodePostalCandidat.AutoSize = True
        Me.LBL_CodePostalCandidat.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_CodePostalCandidat.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LBL_CodePostalCandidat.Location = New System.Drawing.Point(470, 373)
        Me.LBL_CodePostalCandidat.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBL_CodePostalCandidat.Name = "LBL_CodePostalCandidat"
        Me.LBL_CodePostalCandidat.Size = New System.Drawing.Size(145, 33)
        Me.LBL_CodePostalCandidat.TabIndex = 9
        Me.LBL_CodePostalCandidat.Text = "-Code Postal* :"
        '
        'CodePostalCandidat
        '
        Me.CodePostalCandidat.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodePostalCandidat.Location = New System.Drawing.Point(612, 380)
        Me.CodePostalCandidat.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.CodePostalCandidat.Name = "CodePostalCandidat"
        Me.CodePostalCandidat.Size = New System.Drawing.Size(100, 26)
        Me.CodePostalCandidat.TabIndex = 3
        '
        'LBL_VilleCandidat
        '
        Me.LBL_VilleCandidat.AutoSize = True
        Me.LBL_VilleCandidat.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_VilleCandidat.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LBL_VilleCandidat.Location = New System.Drawing.Point(470, 422)
        Me.LBL_VilleCandidat.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBL_VilleCandidat.Name = "LBL_VilleCandidat"
        Me.LBL_VilleCandidat.Size = New System.Drawing.Size(81, 33)
        Me.LBL_VilleCandidat.TabIndex = 11
        Me.LBL_VilleCandidat.Text = "-Ville* :"
        '
        'VilleCandidat
        '
        Me.VilleCandidat.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VilleCandidat.Location = New System.Drawing.Point(551, 428)
        Me.VilleCandidat.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.VilleCandidat.Name = "VilleCandidat"
        Me.VilleCandidat.Size = New System.Drawing.Size(150, 26)
        Me.VilleCandidat.TabIndex = 4
        '
        'LBL_AgeCandidat
        '
        Me.LBL_AgeCandidat.AutoSize = True
        Me.LBL_AgeCandidat.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_AgeCandidat.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LBL_AgeCandidat.Location = New System.Drawing.Point(470, 471)
        Me.LBL_AgeCandidat.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBL_AgeCandidat.Name = "LBL_AgeCandidat"
        Me.LBL_AgeCandidat.Size = New System.Drawing.Size(81, 33)
        Me.LBL_AgeCandidat.TabIndex = 13
        Me.LBL_AgeCandidat.Text = "-Âge* : "
        '
        'AgeCandidat
        '
        Me.AgeCandidat.LargeChange = 1
        Me.AgeCandidat.Location = New System.Drawing.Point(540, 472)
        Me.AgeCandidat.Maximum = 55
        Me.AgeCandidat.Minimum = 18
        Me.AgeCandidat.Name = "AgeCandidat"
        Me.AgeCandidat.Size = New System.Drawing.Size(334, 32)
        Me.AgeCandidat.TabIndex = 5
        Me.AgeCandidat.Value = 18
        '
        'LBL_Age
        '
        Me.LBL_Age.AutoSize = True
        Me.LBL_Age.BackColor = System.Drawing.Color.Gray
        Me.LBL_Age.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Age.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LBL_Age.Location = New System.Drawing.Point(540, 505)
        Me.LBL_Age.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBL_Age.Name = "LBL_Age"
        Me.LBL_Age.Size = New System.Drawing.Size(62, 33)
        Me.LBL_Age.TabIndex = 15
        Me.LBL_Age.Text = "? ans"
        '
        'Minuteur1
        '
        '
        'TempsRestant
        '
        Me.TempsRestant.AutoSize = True
        Me.TempsRestant.Font = New System.Drawing.Font("Bahnschrift Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TempsRestant.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TempsRestant.Location = New System.Drawing.Point(1001, 161)
        Me.TempsRestant.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TempsRestant.Name = "TempsRestant"
        Me.TempsRestant.Size = New System.Drawing.Size(54, 29)
        Me.TempsRestant.TabIndex = 16
        Me.TempsRestant.Text = "1 min"
        '
        'LBL_TempsRestant
        '
        Me.LBL_TempsRestant.AutoSize = True
        Me.LBL_TempsRestant.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_TempsRestant.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LBL_TempsRestant.Location = New System.Drawing.Point(836, 158)
        Me.LBL_TempsRestant.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBL_TempsRestant.Name = "LBL_TempsRestant"
        Me.LBL_TempsRestant.Size = New System.Drawing.Size(167, 33)
        Me.LBL_TempsRestant.TabIndex = 17
        Me.LBL_TempsRestant.Text = "- Temps restant :"
        '
        'TempsImparti
        '
        Me.TempsImparti.AutoSize = True
        Me.TempsImparti.Font = New System.Drawing.Font("Bahnschrift Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TempsImparti.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TempsImparti.Location = New System.Drawing.Point(1001, 116)
        Me.TempsImparti.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TempsImparti.Name = "TempsImparti"
        Me.TempsImparti.Size = New System.Drawing.Size(54, 29)
        Me.TempsImparti.TabIndex = 19
        Me.TempsImparti.Text = "1 min"
        '
        'LBL_TempsImparti
        '
        Me.LBL_TempsImparti.AutoSize = True
        Me.LBL_TempsImparti.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_TempsImparti.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LBL_TempsImparti.Location = New System.Drawing.Point(836, 112)
        Me.LBL_TempsImparti.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBL_TempsImparti.Name = "LBL_TempsImparti"
        Me.LBL_TempsImparti.Size = New System.Drawing.Size(166, 33)
        Me.LBL_TempsImparti.TabIndex = 18
        Me.LBL_TempsImparti.Text = "- Temps imparti :"
        '
        'LBL_DateHeure
        '
        Me.LBL_DateHeure.AutoSize = True
        Me.LBL_DateHeure.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_DateHeure.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LBL_DateHeure.Location = New System.Drawing.Point(838, 70)
        Me.LBL_DateHeure.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBL_DateHeure.Name = "LBL_DateHeure"
        Me.LBL_DateHeure.Size = New System.Drawing.Size(161, 33)
        Me.LBL_DateHeure.TabIndex = 20
        Me.LBL_DateHeure.Text = "- Date et heure :"
        '
        'DateHeure
        '
        Me.DateHeure.AutoSize = True
        Me.DateHeure.Font = New System.Drawing.Font("Bahnschrift Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateHeure.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.DateHeure.Location = New System.Drawing.Point(1001, 74)
        Me.DateHeure.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.DateHeure.Name = "DateHeure"
        Me.DateHeure.Size = New System.Drawing.Size(0, 29)
        Me.DateHeure.TabIndex = 21
        '
        'ValidInscription
        '
        Me.ValidInscription.BackColor = System.Drawing.Color.Gray
        Me.ValidInscription.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ValidInscription.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValidInscription.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ValidInscription.Location = New System.Drawing.Point(702, 621)
        Me.ValidInscription.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ValidInscription.Name = "ValidInscription"
        Me.ValidInscription.Size = New System.Drawing.Size(190, 79)
        Me.ValidInscription.TabIndex = 6
        Me.ValidInscription.Text = "Continuer Inscription"
        Me.ValidInscription.UseVisualStyleBackColor = False
        '
        'AbandonnerInscrip
        '
        Me.AbandonnerInscrip.BackColor = System.Drawing.Color.Gray
        Me.AbandonnerInscrip.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.AbandonnerInscrip.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AbandonnerInscrip.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.AbandonnerInscrip.Location = New System.Drawing.Point(491, 621)
        Me.AbandonnerInscrip.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.AbandonnerInscrip.Name = "AbandonnerInscrip"
        Me.AbandonnerInscrip.Size = New System.Drawing.Size(190, 79)
        Me.AbandonnerInscrip.TabIndex = 6
        Me.AbandonnerInscrip.Text = "Abandonner Inscription"
        Me.AbandonnerInscrip.UseVisualStyleBackColor = False
        '
        'IconeFormulaireInscription
        '
        Me.IconeFormulaireInscription.Image = CType(resources.GetObject("IconeFormulaireInscription.Image"), System.Drawing.Image)
        Me.IconeFormulaireInscription.Location = New System.Drawing.Point(178, -5)
        Me.IconeFormulaireInscription.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.IconeFormulaireInscription.Name = "IconeFormulaireInscription"
        Me.IconeFormulaireInscription.Size = New System.Drawing.Size(293, 207)
        Me.IconeFormulaireInscription.TabIndex = 24
        Me.IconeFormulaireInscription.TabStop = False
        '
        'ChampsObligatoires
        '
        Me.ChampsObligatoires.AutoSize = True
        Me.ChampsObligatoires.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChampsObligatoires.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ChampsObligatoires.Location = New System.Drawing.Point(485, 568)
        Me.ChampsObligatoires.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ChampsObligatoires.Name = "ChampsObligatoires"
        Me.ChampsObligatoires.Size = New System.Drawing.Size(168, 19)
        Me.ChampsObligatoires.TabIndex = 25
        Me.ChampsObligatoires.Text = "*Ces champs sont obligatoires"
        '
        'FormulaireInscription
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(1334, 761)
        Me.Controls.Add(Me.ChampsObligatoires)
        Me.Controls.Add(Me.AbandonnerInscrip)
        Me.Controls.Add(Me.ValidInscription)
        Me.Controls.Add(Me.DateHeure)
        Me.Controls.Add(Me.LBL_DateHeure)
        Me.Controls.Add(Me.TempsImparti)
        Me.Controls.Add(Me.LBL_TempsImparti)
        Me.Controls.Add(Me.LBL_TempsRestant)
        Me.Controls.Add(Me.TempsRestant)
        Me.Controls.Add(Me.LBL_Age)
        Me.Controls.Add(Me.AgeCandidat)
        Me.Controls.Add(Me.LBL_AgeCandidat)
        Me.Controls.Add(Me.VilleCandidat)
        Me.Controls.Add(Me.LBL_VilleCandidat)
        Me.Controls.Add(Me.CodePostalCandidat)
        Me.Controls.Add(Me.LBL_CodePostalCandidat)
        Me.Controls.Add(Me.AdresseCandidat)
        Me.Controls.Add(Me.LBL_Adresse)
        Me.Controls.Add(Me.PrenomCandidat)
        Me.Controls.Add(Me.LBL_PrenomCandidat)
        Me.Controls.Add(Me.NomCandidat)
        Me.Controls.Add(Me.LBL_NomCandidat)
        Me.Controls.Add(Me.SeparationFormulaireInscription)
        Me.Controls.Add(Me.SousTitreFormulaireInscription)
        Me.Controls.Add(Me.TitreFormulaireInscription)
        Me.Controls.Add(Me.IconeFormulaireInscription)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "FormulaireInscription"
        Me.Text = "Formulaire d'Inscription"
        CType(Me.IconeFormulaireInscription, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TitreFormulaireInscription As Label
    Friend WithEvents SousTitreFormulaireInscription As Label
    Friend WithEvents SeparationFormulaireInscription As Label
    Friend WithEvents LBL_NomCandidat As Label
    Friend WithEvents NomCandidat As TextBox
    Friend WithEvents LBL_PrenomCandidat As Label
    Friend WithEvents PrenomCandidat As TextBox
    Friend WithEvents LBL_Adresse As Label
    Friend WithEvents AdresseCandidat As TextBox
    Friend WithEvents LBL_CodePostalCandidat As Label
    Friend WithEvents CodePostalCandidat As TextBox
    Friend WithEvents LBL_VilleCandidat As Label
    Friend WithEvents VilleCandidat As TextBox
    Friend WithEvents LBL_AgeCandidat As Label
    Friend WithEvents AgeCandidat As HScrollBar
    Friend WithEvents LBL_Age As Label
    Friend WithEvents Minuteur1 As Timer
    Friend WithEvents TempsRestant As Label
    Friend WithEvents LBL_TempsRestant As Label
    Friend WithEvents TempsImparti As Label
    Friend WithEvents LBL_TempsImparti As Label
    Friend WithEvents LBL_DateHeure As Label
    Friend WithEvents DateHeure As Label
    Friend WithEvents ValidInscription As Button
    Friend WithEvents AbandonnerInscrip As Button
    Friend WithEvents IconeFormulaireInscription As PictureBox
    Friend WithEvents ChampsObligatoires As Label
End Class
