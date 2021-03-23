Module ModuleCandidat
    Public Structure Candidat
        Public NomCandidat As String
        Public PrenomCandidat As String
        Public AdresseCandidat As String
        Public CodePostalCandidat As Integer
        Public Ville As String
        Public AgeCandidat As String
        Public EpreuvesEcrites As String
        Public EpreuvesOrales As String
        Public EpreuveFacultative As String
        Public MatriculeCandidat As Integer
    End Structure
    ReadOnly FormatTexte As String = "{0,-30}{1,-30}{2,-30}{3,-50}{4,-50}{5,-50}"
    Dim Candidats As Candidat()
    Private NbCandidats As Integer = 0
    Private c As Candidat
    Public Sub main()
        Application.Run(MenuPrincipal)
        ReDim Preserve Candidats(NbCandidats)
    End Sub
    Public Sub Init()
        ReDim Preserve Candidats(NbCandidats)
    End Sub
    Public Sub ajout(c)
        Candidats(NbCandidats) = c
        NbCandidats += 1
        ReDim Preserve Candidats(NbCandidats)
    End Sub
    Public Function GetCandidat()
        Return Candidats
    End Function
    Public Function GetNbCandidat() As Integer
        Return NbCandidats
    End Function
    Public Sub LinkListEtatActuel()
        Dim EtatActuel = ModuleCandidat.GetCandidat
        For i As Integer = 0 To NbCandidats - 1
            EtatActuelInscriptions.LIST_EtatActuelInscrip.Items.Add(String.Format(FormatTexte, EtatActuel(i).MatriculeCandidat, EtatActuel(i).NomCandidat, EtatActuel(i).PrenomCandidat, EtatActuel(i).EpreuvesEcrites, EtatActuel(i).EpreuvesOrales, EtatActuel(i).EpreuveFacultative))
        Next
    End Sub

End Module

