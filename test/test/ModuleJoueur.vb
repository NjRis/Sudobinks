Imports System.IO

Module ModuleJoueur
    'Tableau qui contient les joueurs
    Dim joueurs(0) As Joueur
    'Structure joueur
    Public Structure Joueur
        <VBFixedString(20)> Dim Nom As String
        Dim MeilleurTemps As Integer
        Dim nbPartiesJouees As Integer
        Dim tpsJoue As Integer
    End Structure
    'Mise à joueur des statistiques d'un joueur en fin de partie
    Public Sub majStatJoueur(noJoueur As Integer, temps As Integer, tpsJoue As Integer)
        joueurs(noJoueur).nbPartiesJouees += 1
        If joueurs(noJoueur).MeilleurTemps > temps Then
            joueurs(noJoueur).MeilleurTemps = temps
        End If
        joueurs(noJoueur).tpsJoue += tpsJoue
    End Sub
    'Getter du nombre de joueurs
    Function getNbJoueurs()
        Return joueurs.Length
    End Function
    'Getter d'un joueur
    Public Function getJoueur(i As Integer)
        Return joueurs(i)
    End Function
    'Permet de savoir si un joueur est déjà enregistré par son nom
    Public Function isNouveau(Nom As String)
        For Each j As Joueur In joueurs
            If Trim(Nom) = Trim(j.Nom) Then
                Return False
            End If
        Next
        Return True
    End Function
    'Getter pour le nom d'un joueur
    Public Function getNomJoueur(i As Integer) As String
        Return joueurs(i).Nom
    End Function
    'Getter pour le meilleur temps d'un joueur
    Public Function getMeilleurTpsJoueur(i As Integer) As Integer
        Return joueurs(i).MeilleurTemps
    End Function
    'Getter pour le temps de jeu d'un joueur
    Public Function getTpsJoueJoueur(i As Integer) As Integer
        Return joueurs(i).tpsJoue
    End Function
    'Getter pour le nombre de parties jouées par un joueur
    Public Function getNbPartiesJoueur(i As Integer) As Integer
        Return joueurs(i).nbPartiesJouees
    End Function
    'ajout d'un joueur
    Public Sub ajoutJoueur(Nom As String)
        If isNouveau(Nom) Then
            Accueil.ComboBoxNomJoueur.Items.Add(Nom)
            Dim j As Joueur
            j.Nom = Nom
            j.MeilleurTemps = 61
            j.nbPartiesJouees = 0
            j.tpsJoue = 0
            ReDim Preserve joueurs(getNbJoueurs)
            joueurs(getNbJoueurs() - 1) = j
        End If
    End Sub
    'Programme principal
    Sub Main()
        'Lecture des joueurs dans la sauvegarde
        ReDim joueurs(0)
        Dim num As Integer = FreeFile()
        FileOpen(num, "joueurs.sav", OpenMode.Random, , , Len(New Joueur))
        Dim i As Integer = 0
        While Not EOF(num)
            ReDim Preserve joueurs(i)
            FileGet(num, joueurs(i), i + 1)
            i += 1
        End While
        'Lecture des options dans le fichier-
        Try
            Dim input As StreamReader = New StreamReader("Options.txt")
            ModuleOptions.setTemps(input.ReadLine)
            ModuleOptions.setMode(input.ReadLine)
            ModuleOptions.setBtnPauseActive(input.ReadLine)
            input.Close()
        Catch
        End Try
        'Lancement de l'application
        Application.Run(Accueil)
        'Ecriture des options dans le fichier
        File.Delete("Options.txt")
        Dim output As StreamWriter
        output = My.Computer.FileSystem.OpenTextFileWriter("Options.txt", True)
        output.WriteLine(ModuleOptions.getTemps())
        output.WriteLine(ModuleOptions.getMode())
        output.WriteLine(ModuleOptions.getBtnPauseActive())
        output.Close()
        'Ecriture des joueurs dans la sauvegarde
        For j As Integer = 0 To getNbJoueurs() - 1
            FilePut(num, joueurs(j), j + 1)
        Next
        FileClose()
    End Sub
End Module