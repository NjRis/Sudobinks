Imports System.IO
Public Class Jeu

    Private remainingTime As Integer

    Private Sub ConfigureTimer()
        ' Configure the timer to tick every 1000 milliseconds (1 second)
        Timer1.Interval = 1000
        AddHandler Timer1.Tick, AddressOf TimerTick
    End Sub

    ' Timer tick event handler
    Private Sub TimerTick(sender As Object, e As EventArgs)
        If remainingTime > 0 Then
            remainingTime -= 1
            Label_Temps.Text = "Temps restant : " & FormatTime(remainingTime)

            If remainingTime <= 60 Then
                Label_Temps.ForeColor = Color.Red
            End If
        Else
            Timer1.Stop()
            Label_Temps.ForeColor = Color.Red
            MessageBox.Show("La partie est finie!", "Fin de la partie", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim result As DialogResult = MessageBox.Show("Souhaitez-vous voir la solution?", "Fin de la partie", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                ShowSolution()
            Else
                ClearGame()
            End If
        End If
    End Sub

    Public lblN() As Label  ' Tableau des labels de nombres sur le terrain
    Public lblKlav(10) As Label  ' Tableau des labels de nombres de 1 à 9 + del

    Dim full As Byte        ' full - taille du tableau, full = razmer * razmer - 1
    Dim r As New Random     ' nombre aléatoire

    ' éléments pour le label
    ' taille de la police
    Dim bolwoiWrift = 14
    ' taille de l'élément
    Public Wir As Byte = 50
    Public Dlin As Byte = 50

    Dim rasst As Byte = 3
    Dim startPosL As Byte = 40 ' position initiale du premier label en X
    Dim startPosH As Byte = 40 ' position initiale du premier label en Y
    Dim intervalH,
        intervalW

    ' prendre un nouveau layout à partir du fichier
    Dim origMasFile = "rasklad.ssv"
    Dim massOrig As String() = IO.File.ReadAllLines(origMasFile, System.Text.Encoding.Default)

    ' couleurs du terrain
    Dim fonColor = Color.Silver
    Dim fonColor2 = Color.Wheat

    ' couleurs de la police
    Dim wriftOtv = Color.Blue
    Dim wriftOrig = Color.Black

    '
    Dim mass4is(81)
    Dim chislo As Byte
    Dim isto4nik
    Dim rezerv As String

    'Dim ti = 0 ' temps écoulé

    '---------------------------------------------

    '--- SUB ------------

    '--- démarrer - construire le tableau
    Sub start(razmer As Integer)
        Label_NomJoueur.Text = "Nom : " & Accueil.ComboBoxNomJoueur.Text
        remainingTime = Integer.Parse(Options.TextBox_Temps.Text) * 60 ' Convert minutes to seconds
        Label_Temps.Text = "Temps restant : " & Options.TextBox_Temps.Text
        ' Configure and start the timer
        ConfigureTimer()
        Timer1.Start()
        'Label_Temps.Text = "Temps restant : " & Options.ComboBox_Timer.Text
        intervalW = rasst + Wir ' décalage du label voisin en X
        intervalH = rasst + Dlin ' décalage du label voisin en Y

        ' razmer = Val(frmTablNastr.num.Value)      ' razmer - dimension du carré de la numérotation num
        full = razmer * razmer - 1   ' full - taille du tableau

        ' modifier la taille du tableau
        ReDim lblN(full)


        ' placer nos labels sur le formulaire et leur attribuer des nombres
        For i = 0 To full             ' de 0 à la dernière élément
            lblN(i) = New Label       ' chaque élément du tableau - un nouveau label

            ' toutes les tailles sont les mêmes)
            lblN(i).Height = Dlin
            lblN(i).Width = Wir

            Select Case i
                Case 0 To (razmer - 1) ' 1ère ligne de labels
                    lblN(i).Left = startPosL + i * intervalW
                    lblN(i).Top = startPosH


                Case (razmer) To (razmer * 2 - 1) ' 2ème ligne de labels
                    lblN(i).Left = startPosL + (i - razmer) * intervalW
                    lblN(i).Top = startPosH + intervalH


                Case (razmer * 2) To (razmer * 3 - 1) ' 3ème ligne de labels
                    lblN(i).Left = startPosL + (i - razmer * 2) * intervalW
                    lblN(i).Top = startPosH + intervalH * 2


                Case (razmer * 3) To (razmer * 4 - 1) ' 4ème ligne de labels
                    lblN(i).Left = startPosL + (i - razmer * 3) * intervalW
                    lblN(i).Top = startPosH + intervalH * 3


                Case (razmer * 4) To (razmer * 5 - 1) ' 5ème ligne de labels
                    lblN(i).Left = startPosL + (i - razmer * 4) * intervalW
                    lblN(i).Top = startPosH + intervalH * 4

                Case (razmer * 5) To (razmer * 6 - 1) ' 6ème ligne de labels
                    lblN(i).Left = startPosL + (i - razmer * 5) * intervalW
                    lblN(i).Top = startPosH + intervalH * 5

                Case (razmer * 6) To (razmer * 7 - 1) ' 7ème ligne de labels
                    lblN(i).Left = startPosL + (i - razmer * 6) * intervalW
                    lblN(i).Top = startPosH + intervalH * 6

                Case (razmer * 7) To (razmer * 8 - 1) ' 8ème ligne de labels
                    lblN(i).Left = startPosL + (i - razmer * 7) * intervalW
                    lblN(i).Top = startPosH + intervalH * 7

                Case (razmer * 8) To (razmer * 9 - 1) ' 9ème ligne de labels
                    lblN(i).Left = startPosL + (i - razmer * 8) * intervalW
                    lblN(i).Top = startPosH + intervalH * 8
            End Select

            '-------------
            lblN(i).Text = Str(massOrig(i)) '+ Str(i)
            '--------

            lblN(i).TextAlign = ContentAlignment.MiddleCenter    ' centrer le texte
            lblN(i).Font = New System.Drawing.Font("Arial", bolwoiWrift)  ' définir la police

            lblN(i).ForeColor = Color.Black

            lblN(i).BackColor = Color.Silver                     ' définir le fond


            ' cliquer - obtenir l'index de l'élément
            AddHandler lblN(i).Click, AddressOf lblNClick
            Me.Controls.AddRange(Me.lblN)
            ' FIN --- cliquer - obtenir l'index
            ' traitement de cet événement ci-dessous


            lblN(i).Visible = True                               ' les rendre visibles
            Me.Controls.Add(lblN(i))                             ' les ajouter au formulaire
        Next


    End Sub

    Private Sub ConfigureTimer1()
        ' Configure the timer to tick every 1000 milliseconds (1 second)
        Timer1.Interval = 1000
        AddHandler Timer1.Tick, AddressOf TimerTick
    End Sub

    ' Timer tick event handler


    ' Clear game
    Private Sub ClearGame()
        For i = 0 To 80
            lblN(i).Text = ""
            lblN(i).ForeColor = wriftOrig
        Next
    End Sub

    ' Helper function to format time as mm:ss
    Private Function FormatTime(seconds As Integer) As String
        Dim minutes As Integer = seconds \ 60
        Dim remainingSeconds As Integer = seconds Mod 60
        Return String.Format("{0:D2}:{1:D2}", minutes, remainingSeconds)
    End Function

    ' Show solution
    Private Sub ShowSolution()
        For i = 0 To 80
            lblN(i).Text = massOrig(i)
            lblN(i).ForeColor = wriftOrig
        Next
    End Sub

    ' clavier - boutons
    Sub klavka()

        ' placer nos labels sur le formulaire et leur attribuer des nombres
        For i = 0 To 9             ' de 0 à la dernière élément
            lblKlav(i) = New Label       ' chaque élément du tableau - un nouveau label

            Dim interval = 45
            Dim startPosLKl = 10
            Dim startPosHKl = 10

            ' toutes les tailles sont les mêmes)
            lblKlav(i).Height = 40
            lblKlav(i).Width = 40

            Select Case i
                Case 0 To 2 ' 1ère ligne de labels
                    lblKlav(i).Left = startPosLKl + i * interval
                    lblKlav(i).Top = startPosHKl

                Case 3 To 5 ' 2ème ligne de labels
                    lblKlav(i).Left = startPosLKl + (i - 3) * interval
                    lblKlav(i).Top = startPosHKl + interval

                Case 6 To 8 ' 3ème ligne de labels
                    lblKlav(i).Left = startPosLKl + (i - 6) * interval
                    lblKlav(i).Top = startPosHKl + interval * 2

                Case 9
                    lblKlav(i).Width = 40 * 3 + 10
                    lblKlav(i).Left = startPosLKl
                    lblKlav(i).Top = startPosHKl + interval * 3


            End Select

            '-------------
            lblKlav(i).Text = i + 1
            If i = 9 Then
                lblKlav(i).Text = "Supp"
            End If

            '--------

            lblKlav(i).TextAlign = ContentAlignment.MiddleCenter    ' centrer le texte
            lblKlav(i).Font = New System.Drawing.Font("Arial", bolwoiWrift)  ' définir la police

            lblKlav(i).ForeColor = Color.Black

            lblKlav(i).BackColor = (Color.FromArgb(255 * Rnd(), 255 * Rnd(), 255 * Rnd()))                    ' définir le fond
            'Else
            'lblKlav(i).BackColor = Color.Silver                     ' définir le fond
            'End If

            ' cliquer - obtenir l'index de l'élément
            AddHandler lblKlav(i).Click, AddressOf lblKlavClick
            'Me.Controls.AddRange(Me.lblN)
            Me.grKlava.Controls.AddRange(Me.lblKlav)
            ' FIN --- cliquer - obtenir l'index
            ' traitement de cet événement ci-dessous


            lblKlav(i).Visible = True                               ' les rendre visibles
            Me.grKlava.Controls.Add(lblKlav(i))                             ' les ajouter au groupbox
        Next

    End Sub

    '--- cliquer - obtenir l'index - nombres sur le terrain
    Private Sub lblNClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim i As Integer
        'Dim isto4nik, nexts

        ' Si vous avez besoin de connaître l'index dans le tableau,
        ' recherchez l'objet envoyeur
        i = Array.IndexOf(lblN, sender)
        'isto4nik = lblN(i).Text
        isto4nik = i

        grKlava.Visible = False
        ' si ce n'est pas un chiffre noir
        If lblN(i).Text = "" Or lblN(i).ForeColor = wriftOtv Then

            If grKlava.Visible = True Then
                grKlava.Visible = False
            Else
                grKlava.Visible = True
            End If

            ' position du clavier
            If i < 40 Then
                grKlava.Top = lblN(i).Top + 80 'grKlava.Height
                grKlava.Left = lblN(i).Left
            Else
                grKlava.Top = lblN(i).Top - grKlava.Height
                grKlava.Left = lblN(i).Left
            End If
        Else

        End If

    End Sub

    '--- cliquer - obtenir l'index - clavier
    Private Sub lblKlavClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim i As Integer
        ' Si vous avez besoin de connaître l'index dans le tableau,
        ' recherchez l'objet envoyeur
        i = Array.IndexOf(lblKlav, sender)

        If i <> 9 Then
            lblN(isto4nik).Text = lblKlav(i).Text
            lblN(isto4nik).ForeColor = wriftOtv
        Else
            lblN(isto4nik).Text = ""
        End If

        'MsgBox(isto4nik)

        grKlava.Visible = False
    End Sub

    '-- mélanger les combinaisons
    ' lignes
    Sub mixStroki(c1 As Integer, c2 As Integer)
        'Dim c1 = 9 * r.Next(0, 9) ' 9 * 3 '4
        'Dim c2 = 9 * r.Next(0, 9) ' 9 * 5 '6

        Dim msX_(10)
        Dim msY_(10)

        '4->x '6->Y 'Y->4 'x->6

        '4=>X
        For i = c1 To c1 + 8
            msX_(i - c1) = massOrig(i)
        Next

        '6=>Y
        For i = c2 To c2 + 8
            msY_(i - c2) = massOrig(i)
        Next

        'Y->4
        For i = c1 To c1 + 8
            massOrig(i) = msY_(i - c1)
        Next

        'x=>6
        For i = c2 To c2 + 8
            massOrig(i) = msX_(i - c2)
        Next


        For i = 0 To 80
            lblN(i).Text = massOrig(i)
        Next

    End Sub

    ' lignes PLUS
    Sub mixStrokiPlus()
        Dim c01, c02
        Dim xzw

        xzw = Int(Rnd() * 100)

        If xzw < 30 Then
            c01 = r.Next(0, 3)
            c02 = r.Next(0, 3)
        End If

        If xzw > 30 And xzw < 60 Then
            c01 = r.Next(3, 6)
            c02 = r.Next(3, 6)
        End If

        If xzw > 60 Then
            c01 = r.Next(6, 9)
            c02 = r.Next(6, 9)
        End If

        mixStroki(9 * c01, 9 * c02)
    End Sub

    ' colonnes
    Sub mixStolb(c1 As Integer, c2 As Integer)
        Randomize()
        'r.Next(min2, max2)
        Dim x(10)
        Dim y(10)
        'Dim c1 = r.Next(0, 9) '4
        'Dim c2 = r.Next(0, 9) '6

        For i = 0 To 8
            x(i) = lblN(c1 + 9 * i).Text
            y(i) = lblN(c2 + 9 * i).Text
        Next

        For i = 0 To 8
            lblN(c2 + 9 * i).Text = x(i)
            lblN(c1 + 9 * i).Text = y(i)
        Next

    End Sub

    ' colonnes PLUS
    Sub mixStolbPlus()
        Dim c01, c02
        Dim xzw '= 65

        xzw = Int(Rnd() * 100)

        If xzw < 30 Then
            c01 = r.Next(0, 3)
            c02 = r.Next(0, 3)
        End If

        If xzw > 30 And xzw < 60 Then
            c01 = r.Next(3, 6)
            c02 = r.Next(3, 6)
        End If

        If xzw > 60 Then
            c01 = r.Next(6, 9)
            c02 = r.Next(6, 9)
        End If
        mixStolb(c01, c02)
    End Sub
    '--

    ' coloration
    Sub colorTabl()
        For i = 0 To 80
            lblN(i).BackColor = fonColor
            lblN(i).ForeColor = wriftOrig
        Next

        For i = 3 To 5
            For j = 0 To 2
                lblN(i + 9 * j).BackColor = fonColor2
            Next
        Next

        For i = 27 To 29
            For j = 0 To 2
                lblN(i + 9 * j).BackColor = fonColor2
            Next
        Next

        For i = 33 To 35
            For j = 0 To 2
                lblN(i + 9 * j).BackColor = fonColor2
            Next
        Next

        For i = 57 To 59
            For j = 0 To 2
                lblN(i + 9 * j).BackColor = fonColor2
            Next
        Next

    End Sub

    ' création du tableau d'indices
    Sub mass4isCreat()
        For i = 0 To 80
            mass4is(i) = i
        Next
    End Sub

    ' mélanger le tableau 
    Public Sub mixx(mas As Array)
        Dim element1, element2, x, y
        Randomize()
        For i = 0 To 10000
            x = Int(Rnd() * mas.Length)  'Définir un élément aléatoire du tableau avec le numéro x
            y = Int(Rnd() * mas.Length)  'Définir un élément aléatoire du tableau avec le numéro y
            element1 = mas(x)           'Mémoriser la valeur de l'élément x aléatoire du tableau
            element2 = mas(y)           'Mémoriser la valeur de l'élément y aléatoire du tableau
            mas(y) = element1           'Attribuer à l'élément x aléatoire la valeur de l'élément y
            mas(x) = element2           'Attribuer à l'élément y aléatoire la valeur de l'élément x
        Next
    End Sub


    ' supprimer certains éléments
    Sub del4is(kolvoYd_ As Integer)
        mass4isCreat()
        mixx(mass4is)

        For i = 0 To kolvoYd_
            lblN(mass4is(i)).Text = ""
        Next
    End Sub

    ' supprimer des éléments aléatoires SELON LA DIFFICULTÉ
    Sub delElemz()
        Dim delElem = 0

        If RadioButton1.Checked = True Then
            delElem = r.Next(25, 30)
        End If
        If RadioButton2.Checked = True Then
            delElem = r.Next(30, 35)
        End If
        If RadioButton3.Checked = True Then
            delElem = r.Next(35, 45)
        End If
        If RadioButton4.Checked = True Then
            delElem = r.Next(45, 55)
        End If
        If RadioButton5.Checked = True Then
            delElem = r.Next(55, 65)
        End If

        del4is(delElem)
    End Sub

    ' sauvegarde de fichier
    Sub saveFile()
        ' Définir le dossier de départ
        SFD1.InitialDirectory = Application.StartupPath '+ "\bin"
        ' Définir le titre
        SFD1.Title = "Sauvegarder la partie"
        ' Avec un filtre, vous pouvez filtrer les types de fichiers inutiles
        SFD1.Filter = "Sauvegarder|*.ssv|Tous|*.*"
        ' Si vous avez une liste déroulante des types, vous pouvez spécifier quel type sera sélectionné lors de l'ouverture de la boîte de dialogue
        SFD1.FilterIndex = 1

        If SFD1.ShowDialog = DialogResult.OK Then
            ' rezerv - variable avec les valeurs
            IO.File.WriteAllText(SFD1.FileName, rezerv, System.Text.Encoding.Default)

        End If

    End Sub

    ' ouvrir un fichier
    Sub openFile()
        ' Définir le dossier de départ
        OFD1.InitialDirectory = Application.StartupPath '+ "\bin"
        ' Définir le titre
        OFD1.Title = "Ouvrir une sauvegarde"
        ' Avec un filtre, vous pouvez filtrer les types de fichiers inutiles
        OFD1.Filter = "Sauvegarder|*.ssv|Tous|*.*"
        ' Si vous avez une liste déroulante des types, vous pouvez spécifier quel type sera sélectionné lors de l'ouverture de la boîte de dialogue
        OFD1.FilterIndex = 1

        If OFD1.ShowDialog = DialogResult.OK Then
            Dim masSav() = IO.File.ReadAllLines(OFD1.FileName, System.Text.Encoding.Default)
            For i = 0 To 80
                If masSav(i) > 0 Then
                    If masSav(i) > 10 Then
                        lblN(i).Text = Val(masSav(i)) Mod 10
                        lblN(i).ForeColor = wriftOtv
                    Else
                        lblN(i).Text = masSav(i)
                    End If
                Else
                    lblN(i).Text = ""
                End If
            Next
        End If
    End Sub

    '---éléments

    ' chargement
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        start(9)
        klavka()
        colorTabl()
        For j = 0 To 100
            mixStrokiPlus()
            mixStolbPlus()
        Next

        delElemz()

    End Sub



    ' Nouveau jeu
    Private Sub NouvellePartieToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NouvellePartieToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        colorTabl()
        For j = 0 To 100
            mixStrokiPlus()
            mixStolbPlus()
        Next

        rezerv = ""
        For i = 0 To 80
            rezerv += massOrig(i) + vbCrLf
        Next

        IO.File.WriteAllText(origMasFile, rezerv, System.Text.Encoding.Default)

        delElemz()
        Me.Cursor = Cursors.Default
    End Sub

    ' chargement
    Private Sub ChargerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChargerToolStripMenuItem.Click
        openFile()
    End Sub

    ' sauvegarder
    Private Sub SauvegarderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SauvegarderToolStripMenuItem.Click
        rezerv = ""
        For i = 0 To 80

            If lblN(i).Text = "" Then
                rezerv += "0" + vbCrLf
            Else
                If lblN(i).ForeColor = wriftOtv Then
                    rezerv += "1" + lblN(i).Text + vbCrLf
                Else
                    rezerv += lblN(i).Text + vbCrLf
                End If

            End If
        Next

        saveFile()
    End Sub

    ' Paramètres
    Private Sub ParamètresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ParamètresToolStripMenuItem.Click
        ' au centre de l'écran
        GroupBox1.Top = (Me.Height / 2) - (GroupBox1.Height / 2)
        GroupBox1.Left = (Me.Width / 2) - (GroupBox1.Width / 2)

        GroupBox1.Visible = True

    End Sub

    ' enregistrer les paramètres et commencer une nouvelle partie
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Cursor = Cursors.WaitCursor
        GroupBox1.Visible = False
        colorTabl()
        For j = 0 To 100
            mixStrokiPlus()
            mixStolbPlus()
        Next

        rezerv = ""
        For i = 0 To 80
            rezerv += massOrig(i) + vbCrLf
        Next

        IO.File.WriteAllText(origMasFile, rezerv, System.Text.Encoding.Default)

        delElemz()

        Me.Cursor = Cursors.Default

    End Sub

    ' Sortir
    Private Sub SortirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SortirToolStripMenuItem.Click
        Me.Close()
        Accueil.Show()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub




    ' réponse
    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        For i = 0 To 80
            lblN(i).Text = massOrig(i)

        Next
        'mixStolb(0, 2)

    End Sub
End Class