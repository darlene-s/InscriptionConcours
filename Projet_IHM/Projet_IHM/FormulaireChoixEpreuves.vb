Public Class FormulaireChoixEpreuves
    Private Sub FormulaireChoixEpreuves_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Minuteur2.Interval = 100
        LimiteTemps1 = Date.Now.Add(Decompte1)
        Minuteur2.Enabled = True
        'Rappel nom & prénom candidat
        NomCandidat1.Text = FormulaireInscription.NomCandidat.Text
        PrenomCandidat1.Text = FormulaireInscription.PrenomCandidat.Text
        'RadioButtons & Combo box invisibles au chargement
        GRP_Facultatif.Visible = False
        GRP_EpreuvesFacultatives.Visible = False
        'ComboBox Régions de passage
        CMB_Regions.DropDownStyle = ComboBoxStyle.DropDownList
        CMB_Facultatif.DropDownStyle = ComboBoxStyle.DropDownList
        CMB_Regions.Items.Clear()
        CMB_Regions.Items.Add("Auvergne")
        CMB_Regions.Items.Add("Bordelais")
        CMB_Regions.Items.Add("Bourgogne")
        CMB_Regions.Items.Add("Bretagne")
        CMB_Regions.Items.Add("Corse")
        CMB_Regions.Items.Add("Nord")
        CMB_Regions.Items.Add("Normandie")
        CMB_Regions.Items.Add("Paris")
        CMB_Regions.Items.Add("Poitou")
        CMB_Regions.Items.Add("Roussillon")
        CMB_Facultatif.Items.Clear()
    End Sub
    'Limite de temps + Date & heure actuelle
    Private LimiteTemps1 As Date
    Private Decompte1 As TimeSpan = TimeSpan.FromSeconds(91) '91
    Private Sub Minuteur2_Tick(sender As Object, e As EventArgs) Handles Minuteur2.Tick
        Dim ts1 As TimeSpan = LimiteTemps1.Subtract(Date.Now)
        If ts1.TotalMilliseconds > 0 Then
            TempsRestant1.Text = ts1.ToString("mm\:ss") & "s"
        Else
            TempsRestant1.Text = "00:00"
            Minuteur2.Stop()
            MsgBox("Temps écoulé. Retour au menu principal", MsgBoxStyle.Information)
            Me.Close()
            FormulaireInscription.Close()
            MenuPrincipal.Show()
        End If
        DateHeure1.Text = Date.Now.ToString("dd-MM-yyyy HH:mm:ss")
    End Sub
    'Bouton Abandonner Inscription
    Private Sub AbandonnerInscrip_Click(sender As Object, e As EventArgs) Handles AbandonnerInscrip1.Click
        Me.Close()
        FormulaireInscription.Close()
        MenuPrincipal.Show()
    End Sub
    Private NbChoixRestantsEcrit As Integer = 4
    Private Sub CasesCochesEcrit(ByVal sender As Object, ByVal e As EventArgs) _
       Handles Algorithmique.CheckedChanged,
               BaseDeDonnées.CheckedChanged,
               Droit.CheckedChanged,
               Expression.CheckedChanged,
               Gestion.CheckedChanged,
               LangageC.CheckedChanged,
               LangageJava.CheckedChanged,
               Mathématiques.CheckedChanged,
               ProgrammationWEB.CheckedChanged,
               Réseau.CheckedChanged,
               Système.CheckedChanged,
               VisualBasicNET.CheckedChanged
        If sender.Checked Then
            NbChoixRestantsEcrit -= 1

            If NbChoixRestantsEcrit < 0 Then
                MsgBox("Vous ne pouvez sélectionner que 4 matières", MsgBoxStyle.Exclamation)
                sender.Checked = False
            End If
        Else
            NbChoixRestantsEcrit += 1
        End If
        ChoixRestantEcrit.Text = NbChoixRestantsEcrit.ToString("0")
    End Sub
    Private NbChoixRestantsOral As Integer = 3
    Private Sub CasesCochesOral(ByVal sender As Object, ByVal e As EventArgs) _
       Handles Anglais.CheckedChanged,
               Chinois.CheckedChanged,
               Droit1.CheckedChanged,
               Espagnol.CheckedChanged,
               Expression1.CheckedChanged,
               Gestion1.CheckedChanged,
               Mathématiques1.CheckedChanged,
               Réseau1.CheckedChanged,
               Système1.CheckedChanged
        If sender.Checked Then
            NbChoixRestantsOral -= 1

            If NbChoixRestantsOral < 0 Then
                MsgBox("Vous ne pouvez sélectionner que 3 matières", MsgBoxStyle.Exclamation)
                sender.Checked = False
            End If
        Else
            NbChoixRestantsOral += 1
        End If
        ChoixRestantOral.Text = NbChoixRestantsOral.ToString("0")
    End Sub
    Private Sub Indeterminé(ByVal sender As Object, ByVal e As EventArgs) _
      Handles Anglais.CheckedChanged,
               Chinois.CheckedChanged,
               Espagnol.CheckedChanged,
               Droit.CheckedChanged,
               Expression.CheckedChanged,
               Gestion.CheckedChanged,
               Mathématiques.CheckedChanged,
               Réseau.CheckedChanged,
               Système.CheckedChanged,
               Droit1.CheckedChanged,
               Expression1.CheckedChanged,
               Gestion1.CheckedChanged,
               Mathématiques1.CheckedChanged,
               Réseau1.CheckedChanged,
               Système1.CheckedChanged
        CMB_Facultatif.Items.Clear()
        If Droit.Checked = True Then
            Droit1.Enabled = False
            CMB_Facultatif.Items.Remove(Droit.Text)
        Else
            Droit1.Enabled = True
            CMB_Facultatif.Items.Add(Droit.Text)
        End If
        If Droit1.Checked = True Then
            Droit.Enabled = False
            CMB_Facultatif.Items.Remove(Droit.Text)
        Else
            Droit.Enabled = True
        End If

        If Expression.Checked = True Then
            Expression1.Enabled = False
            CMB_Facultatif.Items.Remove(Expression.Text)
        Else
            Expression1.Enabled = True
            CMB_Facultatif.Items.Add(Expression.Text)
        End If
        If Expression1.Checked = True Then
            Expression.Enabled = False
            CMB_Facultatif.Items.Remove(Expression.Text)
        Else
            Expression.Enabled = True
        End If

        If Gestion.Checked = True Then
            CMB_Facultatif.Items.Remove(Gestion.Text)
            Gestion1.Enabled = False
        Else
            Gestion1.Enabled = True
            CMB_Facultatif.Items.Add(Gestion.Text)
        End If
        If Gestion1.Checked = True Then
            Gestion.Enabled = False
            CMB_Facultatif.Items.Remove(Gestion.Text)
        Else
            Gestion.Enabled = True
        End If
        If Mathématiques.Checked = True Then
            CMB_Facultatif.Items.Remove(Mathématiques.Text)
            Mathématiques1.Enabled = False
        Else
            Mathématiques1.Enabled = True
            CMB_Facultatif.Items.Add(Mathématiques.Text)
        End If
        If Mathématiques1.Checked = True Then
            Mathématiques.Enabled = False
            CMB_Facultatif.Items.Remove(Mathématiques.Text)
        Else
            Mathématiques.Enabled = True
        End If
        If Réseau.Checked = True Then
            CMB_Facultatif.Items.Remove(Réseau.Text)
            Réseau1.Enabled = False
        Else
            Réseau1.Enabled = True
            CMB_Facultatif.Items.Add(Réseau.Text)
        End If
        If Réseau1.Checked = True Then
            Réseau.Enabled = False
            CMB_Facultatif.Items.Remove(Réseau.Text)
        Else
            Réseau.Enabled = True
        End If
        If Système.Checked = True Then
            Système1.Enabled = False
            CMB_Facultatif.Items.Remove(Système.Text)
        Else
            Système1.Enabled = True
            CMB_Facultatif.Items.Add(Système.Text)
        End If
        If Système1.Checked = True Then
            Système.Enabled = False
            CMB_Facultatif.Items.Remove(Système.Text)
        Else
            Système.Enabled = True
        End If
        If Anglais.Checked = False Then
            CMB_Facultatif.Items.Add(Anglais.Text)
        End If
        If Espagnol.Checked = False Then
            CMB_Facultatif.Items.Add(Espagnol.Text)
        End If
        If Chinois.CheckState = False Then
            CMB_Facultatif.Items.Add(Chinois.Text)
        End If
    End Sub
    Private Sub MatieresFacultatives(ByVal sender As Object, ByVal e As EventArgs) _
       Handles Anglais.CheckedChanged,
               Chinois.CheckedChanged,
               Droit1.CheckedChanged,
               Espagnol.CheckedChanged,
               Expression1.CheckedChanged,
               Gestion1.CheckedChanged,
               Mathématiques1.CheckedChanged,
               Réseau1.CheckedChanged,
               Système1.CheckedChanged,
               Algorithmique.CheckedChanged,
               BaseDeDonnées.CheckedChanged,
               Droit.CheckedChanged,
               Expression.CheckedChanged,
               Gestion.CheckedChanged,
               LangageC.CheckedChanged,
               LangageJava.CheckedChanged,
               Mathématiques.CheckedChanged,
               ProgrammationWEB.CheckedChanged,
               Réseau.CheckedChanged,
               Système.CheckedChanged,
               VisualBasicNET.CheckedChanged,
               RADIO_Oui.CheckedChanged,
               RADIO_Non.CheckedChanged

        If NbChoixRestantsOral + NbChoixRestantsEcrit = 0 Then
            GRP_Facultatif.Visible = True
            RADIO_Non.Enabled = True
            RADIO_Oui.Enabled = True

            If RADIO_Oui.Checked = True Then
                GRP_EpreuvesFacultatives.Visible = True
            End If
            If RADIO_Non.Checked = True Then
                GRP_EpreuvesFacultatives.Visible = False
                MsgBox("Vous avez choisi 7 épreuves obligatoires et aucune épreuve facultative")
            End If
        Else
            GRP_Facultatif.Visible = False
            GRP_EpreuvesFacultatives.Visible = False
            RADIO_Non.Enabled = False
            RADIO_Oui.Enabled = False
            RADIO_Non.Checked = False
            RADIO_Oui.Checked = False
        End If
    End Sub
    Private Sub ValidInscrip1_Click(sender As Object, e As EventArgs) Handles ValidInscrip1.Click
        If CMB_Regions.SelectedItem = Nothing Then
            MsgBox("Vous devez choisir une région de passage", MsgBoxStyle.Information)
        ElseIf NbChoixRestantsOral + NbChoixRestantsEcrit <> 0 Then
            MsgBox("Vous devez choisir 7 épreuves à passer", MsgBoxStyle.Information)
        ElseIf (RADIO_Oui.Checked = False And RADIO_Non.Checked = False) Then
            MsgBox("Vous devez indiquer si vous souhaitez participer à une épreuve facultative", MsgBoxStyle.Information)
        Else
            MsgBox("Votre inscription est enregistrée", MsgBoxStyle.Information)
            Me.Hide()
            Formulaire_Récapitulatif_Inscription.Show()
            Minuteur2.Stop()
        End If
    End Sub
End Class

