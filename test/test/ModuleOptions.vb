Imports System.IO

Module ModuleOptions

    Dim temps As Integer = 1
    Dim mode As String = "Temps Limité"
    Dim BtnPauseActivé As String = "Non"
    'Getter pour le temps
    Public Function getTemps()
        Return temps
    End Function
    'Getter pour le mode
    Public Function getMode()
        Return mode
    End Function
    'Getter pour l'activation du bouton pause
    Public Function getBtnPauseActive()
        Return BtnPauseActivé
    End Function
    'setter pour le temps
    Public Sub setTemps(t As Integer)
        temps = t
    End Sub
    'Setter pour le mode
    Public Sub setMode(m As String)
        mode = m
    End Sub
    'Setter pour l'activation du bouton pause
    Public Sub setBtnPauseActive(p As String)
        BtnPauseActivé = p
    End Sub
End Module