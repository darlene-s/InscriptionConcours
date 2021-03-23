<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuPrincipal))
        Me.TitreFormulaireAccueil = New System.Windows.Forms.Label()
        Me.SeparationFormulaireAccueil = New System.Windows.Forms.Label()
        Me.SousTitreFormulaireAccueil = New System.Windows.Forms.Label()
        Me.IconeAccueil = New System.Windows.Forms.PictureBox()
        Me.MsgBienvenue = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTN_EnregistrerInscription = New System.Windows.Forms.Button()
        Me.QuitterApplication = New System.Windows.Forms.Button()
        Me.ModifierSupprimerInscrip = New System.Windows.Forms.Button()
        Me.AfficherEtatInscriptions = New System.Windows.Forms.Button()
        Me.BilanInscripMatières = New System.Windows.Forms.Button()
        Me.BilanIndividuel = New System.Windows.Forms.Button()
        CType(Me.IconeAccueil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TitreFormulaireAccueil
        '
        Me.TitreFormulaireAccueil.AutoSize = True
        Me.TitreFormulaireAccueil.Font = New System.Drawing.Font("Bahnschrift Condensed", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitreFormulaireAccueil.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TitreFormulaireAccueil.Location = New System.Drawing.Point(417, 88)
        Me.TitreFormulaireAccueil.Name = "TitreFormulaireAccueil"
        Me.TitreFormulaireAccueil.Size = New System.Drawing.Size(141, 58)
        Me.TitreFormulaireAccueil.TabIndex = 1
        Me.TitreFormulaireAccueil.Text = "Accueil"
        '
        'SeparationFormulaireAccueil
        '
        Me.SeparationFormulaireAccueil.AutoSize = True
        Me.SeparationFormulaireAccueil.Font = New System.Drawing.Font("Bahnschrift Condensed", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SeparationFormulaireAccueil.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.SeparationFormulaireAccueil.Location = New System.Drawing.Point(-3, 191)
        Me.SeparationFormulaireAccueil.Name = "SeparationFormulaireAccueil"
        Me.SeparationFormulaireAccueil.Size = New System.Drawing.Size(1370, 78)
        Me.SeparationFormulaireAccueil.TabIndex = 3
        Me.SeparationFormulaireAccueil.Text = "---------------------------------------------------------------------------------" &
    "------------------------------------------" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'SousTitreFormulaireAccueil
        '
        Me.SousTitreFormulaireAccueil.AutoSize = True
        Me.SousTitreFormulaireAccueil.Font = New System.Drawing.Font("Bahnschrift Condensed", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SousTitreFormulaireAccueil.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.SousTitreFormulaireAccueil.Location = New System.Drawing.Point(419, 146)
        Me.SousTitreFormulaireAccueil.Name = "SousTitreFormulaireAccueil"
        Me.SousTitreFormulaireAccueil.Size = New System.Drawing.Size(241, 45)
        Me.SousTitreFormulaireAccueil.TabIndex = 4
        Me.SousTitreFormulaireAccueil.Text = "Concours National"
        '
        'IconeAccueil
        '
        Me.IconeAccueil.Image = CType(resources.GetObject("IconeAccueil.Image"), System.Drawing.Image)
        Me.IconeAccueil.Location = New System.Drawing.Point(666, -13)
        Me.IconeAccueil.Name = "IconeAccueil"
        Me.IconeAccueil.Size = New System.Drawing.Size(315, 220)
        Me.IconeAccueil.TabIndex = 5
        Me.IconeAccueil.TabStop = False
        '
        'MsgBienvenue
        '
        Me.MsgBienvenue.AutoSize = True
        Me.MsgBienvenue.Font = New System.Drawing.Font("Bahnschrift Condensed", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MsgBienvenue.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.MsgBienvenue.Location = New System.Drawing.Point(321, 233)
        Me.MsgBienvenue.Name = "MsgBienvenue"
        Me.MsgBienvenue.Size = New System.Drawing.Size(777, 45)
        Me.MsgBienvenue.TabIndex = 6
        Me.MsgBienvenue.Text = "Bienvenue sur l'application d'inscription au concours national !"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift Condensed", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(322, 307)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(298, 39)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Que souhaitez-vous faire ?"
        '
        'BTN_EnregistrerInscription
        '
        Me.BTN_EnregistrerInscription.BackColor = System.Drawing.Color.Gray
        Me.BTN_EnregistrerInscription.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTN_EnregistrerInscription.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_EnregistrerInscription.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BTN_EnregistrerInscription.Location = New System.Drawing.Point(297, 407)
        Me.BTN_EnregistrerInscription.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.BTN_EnregistrerInscription.Name = "BTN_EnregistrerInscription"
        Me.BTN_EnregistrerInscription.Size = New System.Drawing.Size(190, 79)
        Me.BTN_EnregistrerInscription.TabIndex = 56
        Me.BTN_EnregistrerInscription.Text = "Enregistrer une inscription"
        Me.BTN_EnregistrerInscription.UseVisualStyleBackColor = False
        '
        'QuitterApplication
        '
        Me.QuitterApplication.BackColor = System.Drawing.Color.Gray
        Me.QuitterApplication.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.QuitterApplication.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuitterApplication.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.QuitterApplication.Location = New System.Drawing.Point(66, 515)
        Me.QuitterApplication.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.QuitterApplication.Name = "QuitterApplication"
        Me.QuitterApplication.Size = New System.Drawing.Size(190, 79)
        Me.QuitterApplication.TabIndex = 57
        Me.QuitterApplication.Text = "Quitter l'application"
        Me.QuitterApplication.UseVisualStyleBackColor = False
        '
        'ModifierSupprimerInscrip
        '
        Me.ModifierSupprimerInscrip.BackColor = System.Drawing.Color.Gray
        Me.ModifierSupprimerInscrip.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ModifierSupprimerInscrip.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ModifierSupprimerInscrip.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ModifierSupprimerInscrip.Location = New System.Drawing.Point(505, 407)
        Me.ModifierSupprimerInscrip.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ModifierSupprimerInscrip.Name = "ModifierSupprimerInscrip"
        Me.ModifierSupprimerInscrip.Size = New System.Drawing.Size(190, 79)
        Me.ModifierSupprimerInscrip.TabIndex = 58
        Me.ModifierSupprimerInscrip.Text = "Modifier/Supprimer une inscription"
        Me.ModifierSupprimerInscrip.UseVisualStyleBackColor = False
        '
        'AfficherEtatInscriptions
        '
        Me.AfficherEtatInscriptions.BackColor = System.Drawing.Color.Gray
        Me.AfficherEtatInscriptions.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.AfficherEtatInscriptions.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AfficherEtatInscriptions.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.AfficherEtatInscriptions.Location = New System.Drawing.Point(709, 407)
        Me.AfficherEtatInscriptions.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.AfficherEtatInscriptions.Name = "AfficherEtatInscriptions"
        Me.AfficherEtatInscriptions.Size = New System.Drawing.Size(190, 79)
        Me.AfficherEtatInscriptions.TabIndex = 59
        Me.AfficherEtatInscriptions.Text = "Afficher état actuel des inscriptions"
        Me.AfficherEtatInscriptions.UseVisualStyleBackColor = False
        '
        'BilanInscripMatières
        '
        Me.BilanInscripMatières.BackColor = System.Drawing.Color.Gray
        Me.BilanInscripMatières.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BilanInscripMatières.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BilanInscripMatières.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BilanInscripMatières.Location = New System.Drawing.Point(918, 407)
        Me.BilanInscripMatières.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.BilanInscripMatières.Name = "BilanInscripMatières"
        Me.BilanInscripMatières.Size = New System.Drawing.Size(190, 79)
        Me.BilanInscripMatières.TabIndex = 60
        Me.BilanInscripMatières.Text = "Bilan des inscriptions dans une matière"
        Me.BilanInscripMatières.UseVisualStyleBackColor = False
        '
        'BilanIndividuel
        '
        Me.BilanIndividuel.BackColor = System.Drawing.Color.Gray
        Me.BilanIndividuel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BilanIndividuel.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BilanIndividuel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BilanIndividuel.Location = New System.Drawing.Point(1123, 407)
        Me.BilanIndividuel.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.BilanIndividuel.Name = "BilanIndividuel"
        Me.BilanIndividuel.Size = New System.Drawing.Size(190, 79)
        Me.BilanIndividuel.TabIndex = 61
        Me.BilanIndividuel.Text = "Bilan individuel d'une candidature"
        Me.BilanIndividuel.UseVisualStyleBackColor = False
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(1354, 621)
        Me.Controls.Add(Me.BilanIndividuel)
        Me.Controls.Add(Me.BilanInscripMatières)
        Me.Controls.Add(Me.AfficherEtatInscriptions)
        Me.Controls.Add(Me.ModifierSupprimerInscrip)
        Me.Controls.Add(Me.QuitterApplication)
        Me.Controls.Add(Me.BTN_EnregistrerInscription)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MsgBienvenue)
        Me.Controls.Add(Me.SousTitreFormulaireAccueil)
        Me.Controls.Add(Me.SeparationFormulaireAccueil)
        Me.Controls.Add(Me.TitreFormulaireAccueil)
        Me.Controls.Add(Me.IconeAccueil)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MenuPrincipal"
        Me.Text = "Accueil"
        CType(Me.IconeAccueil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TitreFormulaireAccueil As Label
    Friend WithEvents SeparationFormulaireAccueil As Label
    Friend WithEvents SousTitreFormulaireAccueil As Label
    Friend WithEvents IconeAccueil As PictureBox
    Friend WithEvents MsgBienvenue As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BTN_EnregistrerInscription As Button
    Friend WithEvents QuitterApplication As Button
    Friend WithEvents ModifierSupprimerInscrip As Button
    Friend WithEvents AfficherEtatInscriptions As Button
    Friend WithEvents BilanInscripMatières As Button
    Friend WithEvents BilanIndividuel As Button
End Class
