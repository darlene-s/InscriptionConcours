Public Class MenuPrincipal
    Private Sub BTN_EnregistrerInscription_Click(sender As Object, e As EventArgs) Handles BTN_EnregistrerInscription.Click
        Me.Hide()
        FormulaireInscription.Show()
    End Sub

    Private Sub ModifierSupprimerInscrip_Click(sender As Object, e As EventArgs) Handles ModifierSupprimerInscrip.Click
        Me.Hide()
        ModifierSupprimerInscription.Show()
    End Sub
    Private Sub AfficherEtatInscriptions_Click(sender As Object, e As EventArgs) Handles AfficherEtatInscriptions.Click
        Me.Hide()
        EtatActuelInscriptions.Show()
    End Sub
    Private Sub QuitterApplication_Click(sender As Object, e As EventArgs) Handles QuitterApplication.Click
        End
    End Sub

    Private Sub BilanInscripMatières_Click(sender As Object, e As EventArgs) Handles BilanInscripMatières.Click
        Me.Hide()
        BilanInscriptionsMatieres.Show()
    End Sub

    Private Sub BilanIndividuel_Click(sender As Object, e As EventArgs) Handles BilanIndividuel.Click
        Me.Hide()
        BilanIndividuelCandidature.Show()
    End Sub
End Class

