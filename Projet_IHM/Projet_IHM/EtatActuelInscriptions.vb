Public Class EtatActuelInscriptions
    Private FormatTexte As String = "{0,-30}{1,-30}{2,-30}{3,-50}{4,-50}{5,-50}"
    Private Sub EtatActuelInscriptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LIST_EtatActuelInscrip.Items.Add(String.Format(FormatTexte, "Matricule N°", "Nom", "Prénom", "Epreuves Ecrites choisies", "Epreuves Orales choisies", "Epreuve Facultative"))
        ModuleCandidat.LinkListEtatActuel()
    End Sub

    Private Sub RetourMenuPrincipal_Click(sender As Object, e As EventArgs) Handles RetourMenuPrincipal.Click
        Me.Close()
        MenuPrincipal.Show()
    End Sub

End Class