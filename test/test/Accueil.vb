Imports System.IO

Public Class Accueil
    Private Sub Button_Quitter_Click(sender As Object, e As EventArgs) Handles Button_Quitter.Click
        Dim result As DialogResult = MessageBox.Show("Voulez-vous vraiment quitter l'application ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub Button_Jouer_Click(sender As Object, e As EventArgs) Handles Button_Jouer.Click
        'Dim result As DialogResult = MessageBox.Show("Etes-vous prêt à jouer ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        'If result = DialogResult.Yes And ComboBoxNomJoueur.Text <> "" Then
        '    Me.Hide()
        '    Jeu.Show()
        'Else MessageBox.Show("Vous devez obligatoirement inscrire un nom de joueur ;)")
        'End If
        If ComboBoxNomJoueur.Text = "" Then
            MsgBox("Veuillez renseigner un nom", MsgBoxStyle.OkOnly)
        Else
            If ModuleJoueur.isNouveau(ComboBoxNomJoueur.Text) Then
                ajoutJoueur(ComboBoxNomJoueur.Text)
                Me.Hide()
                Jeu.Show()
            Else
                Me.Hide()
                Jeu.Show()
            End If
        End If

    End Sub

    Private Sub Button_Options_Click(sender As Object, e As EventArgs) Handles Button_Options.Click
        Dim result As DialogResult = MessageBox.Show("Voulez-vous vraiment accéder aux options ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Hide()
            Options.Show()
        End If
    End Sub

    Private Sub Button_Score_Click(sender As Object, e As EventArgs) Handles Button_Score.Click
        Dim result As DialogResult = MessageBox.Show("Voulez-vous vraiment accéder aux scores ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Hide()
            Statistique.Show()
        End If
    End Sub


    Private Sub ComboBoxNomJoueur_TextChanged(sender As Object, e As EventArgs) Handles ComboBoxNomJoueur.TextChanged
        If ComboBoxNomJoueur.Text.Length > 0 Then
            ComboBoxNomJoueur.Text = ComboBoxNomJoueur.Text.Substring(0, 1).ToUpper() + ComboBoxNomJoueur.Text.Substring(1)
            ComboBoxNomJoueur.SelectionStart = ComboBoxNomJoueur.Text.Length
        End If
    End Sub

    'Lancer du jeu si on tape enter dans la combobox de nom de joueur
    Private Sub ComboBoxNomJoueur_SelectedIndexChanged(sender As Object, e As KeyPressEventArgs) Handles ComboBoxNomJoueur.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            Button_Jouer.PerformClick()
            e.Handled = True
        End If
    End Sub

End Class
