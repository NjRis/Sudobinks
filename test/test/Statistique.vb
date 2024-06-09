Public Class Statistique
    'Load du formulaire
    'Chargement des données des joueurs depuis le tableau des joueurs
    Private Sub Statistique_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ModuleInterface.ForbidResize(Me)
        For i As Integer = 0 To ModuleJoueur.getNbJoueurs() - 1
            ComboBoxNomJoueur.Items.Add(Trim(ModuleJoueur.getNomJoueur(i)))
            ListBoxJoueurs.Items.Add(Trim(ModuleJoueur.getNomJoueur(i)))
            ListBoxTemps.Items.Add(Trim(ModuleJoueur.getMeilleurTpsJoueur(i)))
        Next
    End Sub
    'Click du bouton détail
    'Msg qui donne toutes les infos d'un joueur
    Private Sub BtnInfo_Click(sender As Object, e As EventArgs) Handles BtnInfo.Click
        If ComboBoxNomJoueur.Text <> "" Then
            Dim currentJoueur As Integer
            For i As Integer = 0 To ModuleJoueur.getNbJoueurs() - 1
                If ComboBoxNomJoueur.Text = Trim(ModuleJoueur.getNomJoueur(i)) Then
                    currentJoueur = i
                End If
            Next            MsgBox("Nom : " & ModuleJoueur.getNomJoueur(currentJoueur) & vbCrLf & "Meilleur Temps : " & ModuleJoueur.getMeilleurTpsJoueur(currentJoueur) & vbCrLf &
                    "Nombre de parties jouées : " & ModuleJoueur.getNbPartiesJoueur(currentJoueur) & vbCrLf & "Temps de Jeu : " & ModuleJoueur.getTpsJoueJoueur(currentJoueur) \ 60 & ":" & ModuleJoueur.getTpsJoueJoueur(currentJoueur) Mod 60 & vbCrLf, MsgBoxStyle.OkOnly)
        Else
            MsgBox("Veuillez séléctionner un joueur", MsgBoxStyle.OkOnly)
        End If
    End Sub
    'Synchronisation entre la combobox des nom et la séléction dans la listeBox
    Private Sub ListBoxJoueurs_SelectedIndexChanged(sender As ListBox, e As EventArgs) Handles ListBoxJoueurs.SelectedIndexChanged
        'Accueil.ComboBoxNomJoueur = ComboBoxNomJoueur
        ComboBoxNomJoueur.Text = sender.SelectedItem.ToString
    End Sub
    'Bouton retour Click
    'Ferme se formulaire et ouvre l'accueil
    Private Sub BtnRetour_Click(sender As Object, e As EventArgs) Handles BtnRetour.Click
        Me.Close()
        Accueil.Show()
    End Sub
    'Synchronisation entre la combobox des nom et la séléction dans la listeBox
    Private Sub ComboBoxNomJoueur_SelectedIndexChanged(sender As ComboBox, e As EventArgs) Handles ComboBoxNomJoueur.SelectedIndexChanged
        ListBoxJoueurs.SelectedItem = sender.Text
    End Sub
    'Tri de manière alphabétique les nom des joueurs dans la listBox des joueurs
    'Synchronisation avec la listebox des temps
    Private Sub BtnAlpha_Click(sender As Object, e As EventArgs) Handles BtnAlpha.Click
        Dim fait As Boolean = True
        Do
            fait = True
            For j As Integer = 0 To ListBoxJoueurs.Items.Count - 2
                If ListBoxJoueurs.Items(j + 1) < ListBoxJoueurs.Items(j) Then
                    fait = False
                    Dim temp1 As String = ListBoxJoueurs.Items(j + 1)
                    ListBoxJoueurs.Items(j + 1) = ListBoxJoueurs.Items(j)
                    ListBoxJoueurs.Items(j) = temp1
                    Dim temp2 As String = ListBoxTemps.Items(j + 1)
                    ListBoxTemps.Items(j + 1) = ListBoxTemps.Items(j)
                    ListBoxTemps.Items(j) = temp2
                End If
            Next
        Loop Until fait
    End Sub

    Private Sub ListBoxTemps_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxTemps.SelectedIndexChanged

    End Sub
End Class