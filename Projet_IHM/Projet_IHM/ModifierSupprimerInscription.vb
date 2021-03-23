Public Class ModifierSupprimerInscription
    Private Sub RetourMenuPrincipal_Click(sender As Object, e As EventArgs) Handles RetourMenuPrincipal.Click
        Me.Close()
        MenuPrincipal.Show()
    End Sub
    Private Sub ModifierSupprimerInscription_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NomEntré.MaxLength = 15
        PrénomEntré.MaxLength = 20
    End Sub
    Private Sub NomPrenomCandidat_keypress(sender As Object, e As KeyPressEventArgs) _
    Handles NomEntré.KeyPress,
            PrénomEntré.KeyPress
        If e.KeyChar = vbBack Then Exit Sub
        If Not Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub MatriculeCandidat(sender As Object, e As KeyPressEventArgs) _
    Handles MatriculeEntré.KeyPress
        If e.KeyChar = vbBack Then Exit Sub
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub IdentifBouton_Click(sender As Object, e As EventArgs) Handles IdentifBouton.Click

        If (NomEntré.Text = "" And PrénomEntré.Text = "") Or MatriculeEntré.Text = "" Then
            MsgBox("Vous devez renseigner votre nom et prénom ou votre matricule candidat pour vous identifier", MsgBoxStyle.Information)
        ElseIf NomEntré.Text <> GetCandidat().NomCandidat AndAlso PrénomEntré <> GetCandidat().PrenomCandidat Then
            MsgBox("Vos noms et prénoms ne correspondent à aucune inscription", MsgBoxStyle.Information)
        ElseIf MatriculeEntré.Text <> GetCandidat().MatriculeCandidat Then
            MsgBox("Votre matricule ne correspond à aucune inscription", MsgBoxStyle.Information)
        End If

    End Sub
End Class