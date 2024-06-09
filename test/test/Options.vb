Imports System.IO

Public Class Options
    Private Sub Button_Retour_Click(sender As Object, e As EventArgs) Handles Button_Retour.Click
        Dim result As DialogResult = MessageBox.Show("Voulez-vous vraiment retourner à l'accueil ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Hide()
            Accueil.Show()
        End If
    End Sub

    Private Sub Options_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxMode.Items.Add("Temps limité")
        ComboBoxMode.Items.Add("Sans fin")
        ComboBoxBtnPause.Items.Add("Non")
        ComboBoxBtnPause.Items.Add("Oui")
        ComboBoxBtnPause.SelectedItem = ModuleOptions.getBtnPauseActive()
        ComboBoxMode.SelectedItem = ModuleOptions.getMode()
        TextBox_Temps.Text = ModuleOptions.getTemps()
        Label_Temps.Hide()
        TextBox_Temps.Hide()
    End Sub


    Private Sub TextBox_Temps_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Temps.TextChanged

    End Sub

    Private Sub ComboBoxMode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxMode.SelectedIndexChanged
        If ComboBoxMode.SelectedItem = "Temps limité" Then
            ' Afficher la TextBox_Temps et le Label_Temps si le mode est "Temps limité"
            TextBox_Temps.Show()
            Label_Temps.Show()
            Label_Minutes.Show()
        Else
            ' Masquer la TextBox_Temps et le Label_Temps pour les autres modes
            TextBox_Temps.Hide()
            Label_Temps.Hide()
            Label_Minutes.Hide()
        End If

        If ComboBoxMode.SelectedItem = "Sans fin" Then
            Jeu.Label_Temps.Hide()
        End If
    End Sub

    Private Sub TextBox_Temps_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_Temps.KeyPress
        If ((Not IsNumeric(e.KeyChar)) AndAlso Not e.KeyChar = ControlChars.Back) Then
            e.Handled = True
        End If
    End Sub
End Class