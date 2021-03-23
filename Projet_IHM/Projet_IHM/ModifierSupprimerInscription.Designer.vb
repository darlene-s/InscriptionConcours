<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModifierSupprimerInscription
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModifierSupprimerInscription))
        Me.SeparationFormulaireAccueil = New System.Windows.Forms.Label()
        Me.TitreModifierSupprimer = New System.Windows.Forms.Label()
        Me.RetourMenuPrincipal = New System.Windows.Forms.Button()
        Me.SousTitreModifierInscrip = New System.Windows.Forms.Label()
        Me.IdentifNom = New System.Windows.Forms.Label()
        Me.IdentifPrenom = New System.Windows.Forms.Label()
        Me.IdentifMatriculeCandidat = New System.Windows.Forms.Label()
        Me.PrénomEntré = New System.Windows.Forms.TextBox()
        Me.NomEntré = New System.Windows.Forms.TextBox()
        Me.MatriculeEntré = New System.Windows.Forms.TextBox()
        Me.IdentifBouton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SeparationFormulaireAccueil
        '
        Me.SeparationFormulaireAccueil.AutoSize = True
        Me.SeparationFormulaireAccueil.Font = New System.Drawing.Font("Bahnschrift Condensed", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SeparationFormulaireAccueil.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.SeparationFormulaireAccueil.Location = New System.Drawing.Point(-34, 67)
        Me.SeparationFormulaireAccueil.Name = "SeparationFormulaireAccueil"
        Me.SeparationFormulaireAccueil.Size = New System.Drawing.Size(1370, 78)
        Me.SeparationFormulaireAccueil.TabIndex = 5
        Me.SeparationFormulaireAccueil.Text = "---------------------------------------------------------------------------------" &
    "------------------------------------------" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TitreModifierSupprimer
        '
        Me.TitreModifierSupprimer.AutoSize = True
        Me.TitreModifierSupprimer.Font = New System.Drawing.Font("Bahnschrift Condensed", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitreModifierSupprimer.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TitreModifierSupprimer.Location = New System.Drawing.Point(281, 9)
        Me.TitreModifierSupprimer.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TitreModifierSupprimer.Name = "TitreModifierSupprimer"
        Me.TitreModifierSupprimer.Size = New System.Drawing.Size(588, 58)
        Me.TitreModifierSupprimer.TabIndex = 6
        Me.TitreModifierSupprimer.Text = "Modifier/Supprimer une inscription"
        '
        'RetourMenuPrincipal
        '
        Me.RetourMenuPrincipal.BackColor = System.Drawing.Color.Gray
        Me.RetourMenuPrincipal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RetourMenuPrincipal.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RetourMenuPrincipal.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RetourMenuPrincipal.Location = New System.Drawing.Point(28, 558)
        Me.RetourMenuPrincipal.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.RetourMenuPrincipal.Name = "RetourMenuPrincipal"
        Me.RetourMenuPrincipal.Size = New System.Drawing.Size(190, 79)
        Me.RetourMenuPrincipal.TabIndex = 69
        Me.RetourMenuPrincipal.Text = "Retour au menu principal"
        Me.RetourMenuPrincipal.UseVisualStyleBackColor = False
        '
        'SousTitreModifierInscrip
        '
        Me.SousTitreModifierInscrip.AutoSize = True
        Me.SousTitreModifierInscrip.Font = New System.Drawing.Font("Bahnschrift Condensed", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SousTitreModifierInscrip.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.SousTitreModifierInscrip.Location = New System.Drawing.Point(139, 106)
        Me.SousTitreModifierInscrip.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.SousTitreModifierInscrip.Name = "SousTitreModifierInscrip"
        Me.SousTitreModifierInscrip.Size = New System.Drawing.Size(894, 39)
        Me.SousTitreModifierInscrip.TabIndex = 70
        Me.SousTitreModifierInscrip.Text = "Veuillez renseigner votre nom et prénom ou matricule candidat pour vous identifie" &
    "r"
        '
        'IdentifNom
        '
        Me.IdentifNom.AutoSize = True
        Me.IdentifNom.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdentifNom.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.IdentifNom.Location = New System.Drawing.Point(329, 176)
        Me.IdentifNom.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.IdentifNom.Name = "IdentifNom"
        Me.IdentifNom.Size = New System.Drawing.Size(69, 33)
        Me.IdentifNom.TabIndex = 71
        Me.IdentifNom.Text = "-Nom:"
        '
        'IdentifPrenom
        '
        Me.IdentifPrenom.AutoSize = True
        Me.IdentifPrenom.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdentifPrenom.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.IdentifPrenom.Location = New System.Drawing.Point(329, 228)
        Me.IdentifPrenom.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.IdentifPrenom.Name = "IdentifPrenom"
        Me.IdentifPrenom.Size = New System.Drawing.Size(103, 33)
        Me.IdentifPrenom.TabIndex = 72
        Me.IdentifPrenom.Text = "-Prénom :"
        '
        'IdentifMatriculeCandidat
        '
        Me.IdentifMatriculeCandidat.AutoSize = True
        Me.IdentifMatriculeCandidat.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdentifMatriculeCandidat.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.IdentifMatriculeCandidat.Location = New System.Drawing.Point(662, 176)
        Me.IdentifMatriculeCandidat.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.IdentifMatriculeCandidat.Name = "IdentifMatriculeCandidat"
        Me.IdentifMatriculeCandidat.Size = New System.Drawing.Size(202, 33)
        Me.IdentifMatriculeCandidat.TabIndex = 73
        Me.IdentifMatriculeCandidat.Text = "-Matricule Candidat :"
        '
        'PrénomEntré
        '
        Me.PrénomEntré.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrénomEntré.Location = New System.Drawing.Point(436, 235)
        Me.PrénomEntré.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PrénomEntré.Name = "PrénomEntré"
        Me.PrénomEntré.Size = New System.Drawing.Size(150, 26)
        Me.PrénomEntré.TabIndex = 74
        Me.PrénomEntré.Tag = ""
        '
        'NomEntré
        '
        Me.NomEntré.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomEntré.Location = New System.Drawing.Point(402, 183)
        Me.NomEntré.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.NomEntré.Name = "NomEntré"
        Me.NomEntré.Size = New System.Drawing.Size(150, 26)
        Me.NomEntré.TabIndex = 75
        Me.NomEntré.Tag = ""
        '
        'MatriculeEntré
        '
        Me.MatriculeEntré.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MatriculeEntré.Location = New System.Drawing.Point(868, 183)
        Me.MatriculeEntré.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.MatriculeEntré.Name = "MatriculeEntré"
        Me.MatriculeEntré.Size = New System.Drawing.Size(74, 26)
        Me.MatriculeEntré.TabIndex = 76
        Me.MatriculeEntré.Tag = ""
        '
        'IdentifBouton
        '
        Me.IdentifBouton.BackColor = System.Drawing.Color.Gray
        Me.IdentifBouton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.IdentifBouton.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdentifBouton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.IdentifBouton.Location = New System.Drawing.Point(499, 293)
        Me.IdentifBouton.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.IdentifBouton.Name = "IdentifBouton"
        Me.IdentifBouton.Size = New System.Drawing.Size(190, 79)
        Me.IdentifBouton.TabIndex = 77
        Me.IdentifBouton.Text = "S'identifier"
        Me.IdentifBouton.UseVisualStyleBackColor = False
        '
        'ModifierSupprimerInscription
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(1092, 664)
        Me.Controls.Add(Me.IdentifBouton)
        Me.Controls.Add(Me.MatriculeEntré)
        Me.Controls.Add(Me.NomEntré)
        Me.Controls.Add(Me.PrénomEntré)
        Me.Controls.Add(Me.IdentifMatriculeCandidat)
        Me.Controls.Add(Me.IdentifPrenom)
        Me.Controls.Add(Me.IdentifNom)
        Me.Controls.Add(Me.SousTitreModifierInscrip)
        Me.Controls.Add(Me.RetourMenuPrincipal)
        Me.Controls.Add(Me.TitreModifierSupprimer)
        Me.Controls.Add(Me.SeparationFormulaireAccueil)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ModifierSupprimerInscription"
        Me.Text = "Modifier/Supprimer Inscription"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SeparationFormulaireAccueil As Label
    Friend WithEvents TitreModifierSupprimer As Label
    Friend WithEvents RetourMenuPrincipal As Button
    Friend WithEvents SousTitreModifierInscrip As Label
    Friend WithEvents IdentifNom As Label
    Friend WithEvents IdentifPrenom As Label
    Friend WithEvents IdentifMatriculeCandidat As Label
    Friend WithEvents PrénomEntré As TextBox
    Friend WithEvents NomEntré As TextBox
    Friend WithEvents MatriculeEntré As TextBox
    Friend WithEvents IdentifBouton As Button
End Class
