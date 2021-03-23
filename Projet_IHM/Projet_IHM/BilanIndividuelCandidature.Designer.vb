<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BilanIndividuelCandidature
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BilanIndividuelCandidature))
        Me.TitreBilanIndividuel = New System.Windows.Forms.Label()
        Me.SeparationFormulaireAccueil = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TitreBilanIndividuel
        '
        Me.TitreBilanIndividuel.AutoSize = True
        Me.TitreBilanIndividuel.Font = New System.Drawing.Font("Bahnschrift Condensed", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitreBilanIndividuel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TitreBilanIndividuel.Location = New System.Drawing.Point(137, 9)
        Me.TitreBilanIndividuel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TitreBilanIndividuel.Name = "TitreBilanIndividuel"
        Me.TitreBilanIndividuel.Size = New System.Drawing.Size(570, 58)
        Me.TitreBilanIndividuel.TabIndex = 6
        Me.TitreBilanIndividuel.Text = "Bilan individuel d'une candidature"
        '
        'SeparationFormulaireAccueil
        '
        Me.SeparationFormulaireAccueil.AutoSize = True
        Me.SeparationFormulaireAccueil.Font = New System.Drawing.Font("Bahnschrift Condensed", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SeparationFormulaireAccueil.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.SeparationFormulaireAccueil.Location = New System.Drawing.Point(-260, 58)
        Me.SeparationFormulaireAccueil.Name = "SeparationFormulaireAccueil"
        Me.SeparationFormulaireAccueil.Size = New System.Drawing.Size(1370, 78)
        Me.SeparationFormulaireAccueil.TabIndex = 7
        Me.SeparationFormulaireAccueil.Text = "---------------------------------------------------------------------------------" &
    "------------------------------------------" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'BilanIndividuelCandidature
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.SeparationFormulaireAccueil)
        Me.Controls.Add(Me.TitreBilanIndividuel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "BilanIndividuelCandidature"
        Me.Text = "Bilan individuel d'une candidature"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TitreBilanIndividuel As Label
    Friend WithEvents SeparationFormulaireAccueil As Label
End Class
