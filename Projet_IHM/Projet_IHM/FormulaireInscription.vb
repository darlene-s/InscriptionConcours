Public Class FormulaireInscription
  Private Sub FormulaireInscription_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Minuteur1.Interval = 100
        LimiteTemps = Date.Now.Add(Decompte)
        Minuteur1.Enabled = True
        'Conditions longueur entrées texte
        NomCandidat.MaxLength = 15
        PrenomCandidat.MaxLength = 20
        AdresseCandidat.MaxLength = 30
        CodePostalCandidat.MaxLength = 5
        VilleCandidat.MaxLength = 15
    End Sub
    'Limite de temps + Date & heure actuelle
    Private LimiteTemps As Date
    Private Decompte As TimeSpan = TimeSpan.FromSeconds(61)
    Private Sub Minuteur1_Tick(sender As Object, e As EventArgs) Handles Minuteur1.Tick
        Dim ts As TimeSpan = LimiteTemps.Subtract(Date.Now)
        If ts.TotalMilliseconds > 0 Then
            TempsRestant.Text = ts.ToString("mm\:ss") & "s"
        Else
            TempsRestant.Text = "00:00"
            Minuteur1.Stop()
            MsgBox("Temps écoulé. Retour au menu principal", MsgBoxStyle.Information)
            Me.Close()
            MenuPrincipal.Show()
        End If
        DateHeure.Text = Date.Now.ToString("dd-MM-yyyy HH:mm:ss")
    End Sub
    'Nom & Prenom Candidat
    Private Sub NomCandidat_keypress(sender As Object, e As KeyPressEventArgs) _
    Handles NomCandidat.KeyPress,
            PrenomCandidat.KeyPress
        If e.KeyChar = vbBack Then Exit Sub
        If Not Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    'Adresse Candidat
    Private Sub AdresseCandidat_keypress(sender As Object, e As KeyPressEventArgs) _
   Handles AdresseCandidat.KeyPress
        If e.KeyChar = vbBack Then Exit Sub
        If Not Char.IsLetterOrDigit(e.KeyChar) And Not Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    'Code Postal Candidat
    Private Sub CodePostalCandidat_keypress(sender As Object, e As KeyPressEventArgs) _
    Handles CodePostalCandidat.KeyPress
        If e.KeyChar = vbBack Then Exit Sub
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    ' Ville Candidat
    Private Sub VilleCandidat_keypress(sender As Object, e As KeyPressEventArgs) _
    Handles VilleCandidat.KeyPress
        If e.KeyChar = vbBack Then Exit Sub
        If Not Char.IsLetter(e.KeyChar) And Not Asc(e.KeyChar) = 45 Then
            e.Handled = True
        End If
    End Sub
    'Age Candidat
    Public Sub ObtenirAge()
        Dim ageC As Integer
        ageC = AgeCandidat.Value
    End Sub
    Private Sub AgeCandidat_Scroll(sender As Object, e As ScrollEventArgs) Handles AgeCandidat.Scroll
        If e.Type = ScrollEventType.EndScroll Then ObtenirAge()
        LBL_Age.Text = AgeCandidat.Value.ToString("##") & "ans"
    End Sub
    'Bouton Abandonner Inscription
    Private Sub AbandonnerInscrip_Click(sender As Object, e As EventArgs) Handles AbandonnerInscrip.Click
        Me.Close()
        MenuPrincipal.Show()
    End Sub
    'Bouton Valider Inscription 
    Private Sub ValidInscription_Click(sender As Object, e As EventArgs) Handles ValidInscription.Click
        'Condition adresse facultative
        If NomCandidat.Text = "" Or PrenomCandidat.Text = "" Or CodePostalCandidat.Text = "" Or VilleCandidat.Text = "" Or LBL_Age.Text = "? ans" Then
            MsgBox("Certains champs obligatoires sont manquants", MsgBoxStyle.Information)
            'Condition deux premières valeurs du code postal différentes de 0
        ElseIf CodePostalCandidat.Text = CodePostalCandidat.Text.StartsWith("00") Then
            MsgBox("Code postal invalide", MsgBoxStyle.Information)
        Else
            Me.Hide()
            FormulaireChoixEpreuves.Show()
            Minuteur1.Stop()
        End If
    End Sub
End Class
