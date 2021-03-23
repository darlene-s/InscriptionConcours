<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EtatActuelInscriptions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EtatActuelInscriptions))
        Me.SeparationFormulaireAccueil = New System.Windows.Forms.Label()
        Me.TitreEtatActuel = New System.Windows.Forms.Label()
        Me.LIST_EtatActuelInscrip = New System.Windows.Forms.ListBox()
        Me.RetourMenuPrincipal = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SeparationFormulaireAccueil
        '
        Me.SeparationFormulaireAccueil.AutoSize = True
        Me.SeparationFormulaireAccueil.Font = New System.Drawing.Font("Bahnschrift Condensed", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SeparationFormulaireAccueil.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.SeparationFormulaireAccueil.Location = New System.Drawing.Point(-163, 67)
        Me.SeparationFormulaireAccueil.Name = "SeparationFormulaireAccueil"
        Me.SeparationFormulaireAccueil.Size = New System.Drawing.Size(1370, 78)
        Me.SeparationFormulaireAccueil.TabIndex = 4
        Me.SeparationFormulaireAccueil.Text = "---------------------------------------------------------------------------------" &
    "------------------------------------------" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TitreEtatActuel
        '
        Me.TitreEtatActuel.AutoSize = True
        Me.TitreEtatActuel.Font = New System.Drawing.Font("Bahnschrift Condensed", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitreEtatActuel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TitreEtatActuel.Location = New System.Drawing.Point(386, 9)
        Me.TitreEtatActuel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TitreEtatActuel.Name = "TitreEtatActuel"
        Me.TitreEtatActuel.Size = New System.Drawing.Size(462, 58)
        Me.TitreEtatActuel.TabIndex = 5
        Me.TitreEtatActuel.Text = "Etat actuel des inscriptions"
        '
        'LIST_EtatActuelInscrip
        '
        Me.LIST_EtatActuelInscrip.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LIST_EtatActuelInscrip.FormattingEnabled = True
        Me.LIST_EtatActuelInscrip.ItemHeight = 19
        Me.LIST_EtatActuelInscrip.Location = New System.Drawing.Point(20, 106)
        Me.LIST_EtatActuelInscrip.Name = "LIST_EtatActuelInscrip"
        Me.LIST_EtatActuelInscrip.Size = New System.Drawing.Size(1142, 574)
        Me.LIST_EtatActuelInscrip.TabIndex = 6
        '
        'RetourMenuPrincipal
        '
        Me.RetourMenuPrincipal.BackColor = System.Drawing.Color.Gray
        Me.RetourMenuPrincipal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RetourMenuPrincipal.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RetourMenuPrincipal.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RetourMenuPrincipal.Location = New System.Drawing.Point(20, 707)
        Me.RetourMenuPrincipal.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.RetourMenuPrincipal.Name = "RetourMenuPrincipal"
        Me.RetourMenuPrincipal.Size = New System.Drawing.Size(190, 79)
        Me.RetourMenuPrincipal.TabIndex = 68
        Me.RetourMenuPrincipal.Text = "Retour au menu principal"
        Me.RetourMenuPrincipal.UseVisualStyleBackColor = False
        '
        'EtatActuelInscriptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(1174, 815)
        Me.Controls.Add(Me.RetourMenuPrincipal)
        Me.Controls.Add(Me.LIST_EtatActuelInscrip)
        Me.Controls.Add(Me.TitreEtatActuel)
        Me.Controls.Add(Me.SeparationFormulaireAccueil)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EtatActuelInscriptions"
        Me.Text = "Etat actuel des inscriptions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SeparationFormulaireAccueil As Label
    Friend WithEvents TitreEtatActuel As Label
    Friend WithEvents LIST_EtatActuelInscrip As ListBox
    Friend WithEvents RetourMenuPrincipal As Button
End Class
