Public Class Formulaire_Récapitulatif_Inscription
    Private EpreuvesEcrites As String
    Private EpreuvesOrales As String
    Private Sub Formulaire_Récapitulatif_Inscription_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NomCandidat2.Text = FormulaireInscription.NomCandidat.Text
        PrenomCandidat2.Text = FormulaireInscription.PrenomCandidat.Text
        AdresseCandidat2.Text = FormulaireInscription.AdresseCandidat.Text
        CodePostal2.Text = FormulaireInscription.CodePostalCandidat.Text
        VilleCandidat2.Text = FormulaireInscription.VilleCandidat.Text
        AgeCandidat2.Text = FormulaireInscription.LBL_Age.Text
        RégionPassage2.Text = FormulaireChoixEpreuves.CMB_Regions.Text

        If FormulaireChoixEpreuves.RADIO_Oui.Checked = True Then
            EpreuveFacultative2.Text = FormulaireChoixEpreuves.CMB_Facultatif.Text
        Else
            EpreuveFacultative2.Text = "Aucune"
        End If
        If FormulaireChoixEpreuves.Algorithmique.Checked = True Then
            LIST_TotalEcrit.Items.Add(FormulaireChoixEpreuves.Algorithmique.Text)
        End If
        If FormulaireChoixEpreuves.BaseDeDonnées.Checked = True Then
            LIST_TotalEcrit.Items.Add(FormulaireChoixEpreuves.BaseDeDonnées.Text)
        End If
        If FormulaireChoixEpreuves.LangageC.Checked = True Then
            LIST_TotalEcrit.Items.Add(FormulaireChoixEpreuves.LangageC.Text)
        End If
        If FormulaireChoixEpreuves.LangageJava.Checked = True Then
            LIST_TotalEcrit.Items.Add(FormulaireChoixEpreuves.LangageJava.Text)
        End If
        If FormulaireChoixEpreuves.ProgrammationWEB.Checked = True Then
            LIST_TotalEcrit.Items.Add(FormulaireChoixEpreuves.ProgrammationWEB.Text)
        End If
        If FormulaireChoixEpreuves.VisualBasicNET.Checked = True Then
            LIST_TotalEcrit.Items.Add(FormulaireChoixEpreuves.VisualBasicNET.Text)
        End If
        If FormulaireChoixEpreuves.Anglais.Checked = True Then
            LIST_TotalOral.Items.Add(FormulaireChoixEpreuves.Anglais.Text)
        End If
        If FormulaireChoixEpreuves.Espagnol.Checked = True Then
            LIST_TotalOral.Items.Add(FormulaireChoixEpreuves.Espagnol.Text)
        End If
        If FormulaireChoixEpreuves.Chinois.Checked = True Then
            LIST_TotalOral.Items.Add(FormulaireChoixEpreuves.Chinois.Text)
        End If
        If FormulaireChoixEpreuves.Droit.Checked = True Then
            LIST_TotalEcrit.Items.Add(FormulaireChoixEpreuves.Droit.Text)
        End If
        If FormulaireChoixEpreuves.Droit1.Checked = True Then
            LIST_TotalOral.Items.Add(FormulaireChoixEpreuves.Droit.Text)
        End If
        If FormulaireChoixEpreuves.Expression.Checked = True Then
            LIST_TotalEcrit.Items.Add(FormulaireChoixEpreuves.Expression.Text)
        End If
        If FormulaireChoixEpreuves.Expression1.Checked = True Then
            LIST_TotalOral.Items.Add(FormulaireChoixEpreuves.Expression.Text)
        End If
        If FormulaireChoixEpreuves.Gestion.Checked = True Then
            LIST_TotalEcrit.Items.Add(FormulaireChoixEpreuves.Gestion.Text)
        End If
        If FormulaireChoixEpreuves.Gestion1.Checked = True Then
            LIST_TotalOral.Items.Add(FormulaireChoixEpreuves.Gestion.Text)
        End If
        If FormulaireChoixEpreuves.Mathématiques.Checked = True Then
            LIST_TotalEcrit.Items.Add(FormulaireChoixEpreuves.Mathématiques.Text)
        End If
        If FormulaireChoixEpreuves.Mathématiques1.Checked = True Then
            LIST_TotalOral.Items.Add(FormulaireChoixEpreuves.Mathématiques.Text)
        End If
        If FormulaireChoixEpreuves.Réseau.Checked = True Then
            LIST_TotalEcrit.Items.Add(FormulaireChoixEpreuves.Réseau.Text)
        End If
        If FormulaireChoixEpreuves.Réseau1.Checked = True Then
            LIST_TotalOral.Items.Add(FormulaireChoixEpreuves.Réseau.Text)
        End If
        If FormulaireChoixEpreuves.Système.Checked = True Then
            LIST_TotalEcrit.Items.Add(FormulaireChoixEpreuves.Système1.Text)
        End If
        If FormulaireChoixEpreuves.Système1.Checked = True Then
            LIST_TotalOral.Items.Add(FormulaireChoixEpreuves.Système1.Text)
        End If

        ModuleCandidat.Init()
        ModuleCandidat.GetNbCandidat()
    End Sub
    Private Sub ModifierInscrip_Click(sender As Object, e As EventArgs) Handles ModifierInscrip1.Click
        Me.Close()
        FormulaireInscription.Show()
    End Sub


    Private Sub AnnulerInscrip_Click(sender As Object, e As EventArgs) Handles AnnulerInscrip.Click
        Me.Close()
        MenuPrincipal.Show()

    End Sub
    Private Sub EnregistrerInscrip_Click(sender As Object, e As EventArgs) Handles EnregistrerInscrip.Click
        Dim c As Candidat
        For Each MatieresOrales In LIST_TotalOral.Items
            EpreuvesOrales &= MatieresOrales.ToString & " "
        Next
        c.MatriculeCandidat = GetNbCandidat() + 1
        c.NomCandidat = NomCandidat2.Text
        c.PrenomCandidat = PrenomCandidat2.Text
        c.AdresseCandidat = AdresseCandidat2.Text
        c.CodePostalCandidat = CodePostal2.Text
        c.Ville = VilleCandidat2.Text
        c.AgeCandidat = AgeCandidat2.Text
        c.EpreuvesEcrites = EpreuvesEcrites
        c.EpreuvesOrales = EpreuvesOrales
        c.EpreuveFacultative = EpreuveFacultative2.Text
        ModuleCandidat.ajout(c)
        ModuleCandidat.GetCandidat()
        MsgBox("Votre numéro de candidat est : " & c.MatriculeCandidat)
        Me.Close()
        FormulaireInscription.Close()
        FormulaireChoixEpreuves.Close()
        MenuPrincipal.Show()

    End Sub
End Class