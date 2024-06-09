<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Options
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel_Options = New System.Windows.Forms.Panel()
        Me.Label_Options = New System.Windows.Forms.Label()
        Me.Button_Retour = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label_Temps = New System.Windows.Forms.Label()
        Me.Label_MDJ = New System.Windows.Forms.Label()
        Me.ComboBoxMode = New System.Windows.Forms.ComboBox()
        Me.TextBox_Temps = New System.Windows.Forms.TextBox()
        Me.Label_ModeDeJeu = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ComboBoxBtnPause = New System.Windows.Forms.ComboBox()
        Me.Label_Pause = New System.Windows.Forms.Label()
        Me.Label_BoutonPause = New System.Windows.Forms.Label()
        Me.Label_Minutes = New System.Windows.Forms.Label()
        Me.Panel_Options.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_Options
        '
        Me.Panel_Options.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Panel_Options.Controls.Add(Me.Label_Options)
        Me.Panel_Options.Location = New System.Drawing.Point(401, 39)
        Me.Panel_Options.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel_Options.Name = "Panel_Options"
        Me.Panel_Options.Size = New System.Drawing.Size(263, 90)
        Me.Panel_Options.TabIndex = 0
        '
        'Label_Options
        '
        Me.Label_Options.AutoSize = True
        Me.Label_Options.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Options.Location = New System.Drawing.Point(67, 32)
        Me.Label_Options.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_Options.Name = "Label_Options"
        Me.Label_Options.Size = New System.Drawing.Size(130, 29)
        Me.Label_Options.TabIndex = 0
        Me.Label_Options.Text = "OPTIONS"
        '
        'Button_Retour
        '
        Me.Button_Retour.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Button_Retour.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Retour.Location = New System.Drawing.Point(439, 474)
        Me.Button_Retour.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_Retour.Name = "Button_Retour"
        Me.Button_Retour.Size = New System.Drawing.Size(164, 50)
        Me.Button_Retour.TabIndex = 1
        Me.Button_Retour.Text = "RETOUR"
        Me.Button_Retour.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Panel1.Controls.Add(Me.Label_Minutes)
        Me.Panel1.Controls.Add(Me.Label_Temps)
        Me.Panel1.Controls.Add(Me.Label_MDJ)
        Me.Panel1.Controls.Add(Me.ComboBoxMode)
        Me.Panel1.Controls.Add(Me.TextBox_Temps)
        Me.Panel1.Controls.Add(Me.Label_ModeDeJeu)
        Me.Panel1.Location = New System.Drawing.Point(212, 205)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(251, 191)
        Me.Panel1.TabIndex = 2
        '
        'Label_Temps
        '
        Me.Label_Temps.AutoSize = True
        Me.Label_Temps.Location = New System.Drawing.Point(56, 117)
        Me.Label_Temps.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_Temps.Name = "Label_Temps"
        Me.Label_Temps.Size = New System.Drawing.Size(126, 16)
        Me.Label_Temps.TabIndex = 4
        Me.Label_Temps.Text = "Choisissez le temps"
        '
        'Label_MDJ
        '
        Me.Label_MDJ.AutoSize = True
        Me.Label_MDJ.Location = New System.Drawing.Point(36, 60)
        Me.Label_MDJ.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_MDJ.Name = "Label_MDJ"
        Me.Label_MDJ.Size = New System.Drawing.Size(183, 16)
        Me.Label_MDJ.TabIndex = 3
        Me.Label_MDJ.Text = "Choisissez votre mode de jeu"
        '
        'ComboBoxMode
        '
        Me.ComboBoxMode.FormattingEnabled = True
        Me.ComboBoxMode.Location = New System.Drawing.Point(40, 80)
        Me.ComboBoxMode.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxMode.Name = "ComboBoxMode"
        Me.ComboBoxMode.Size = New System.Drawing.Size(160, 24)
        Me.ComboBoxMode.TabIndex = 2
        '
        'TextBox_Temps
        '
        Me.TextBox_Temps.Location = New System.Drawing.Point(53, 137)
        Me.TextBox_Temps.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox_Temps.Name = "TextBox_Temps"
        Me.TextBox_Temps.Size = New System.Drawing.Size(132, 22)
        Me.TextBox_Temps.TabIndex = 1
        '
        'Label_ModeDeJeu
        '
        Me.Label_ModeDeJeu.AutoSize = True
        Me.Label_ModeDeJeu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_ModeDeJeu.Location = New System.Drawing.Point(63, 20)
        Me.Label_ModeDeJeu.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_ModeDeJeu.Name = "Label_ModeDeJeu"
        Me.Label_ModeDeJeu.Size = New System.Drawing.Size(113, 17)
        Me.Label_ModeDeJeu.TabIndex = 0
        Me.Label_ModeDeJeu.Text = "MODE DE JEU"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Panel2.Controls.Add(Me.ComboBoxBtnPause)
        Me.Panel2.Controls.Add(Me.Label_Pause)
        Me.Panel2.Controls.Add(Me.Label_BoutonPause)
        Me.Panel2.Location = New System.Drawing.Point(597, 205)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(251, 191)
        Me.Panel2.TabIndex = 3
        '
        'ComboBoxBtnPause
        '
        Me.ComboBoxBtnPause.BackColor = System.Drawing.SystemColors.Window
        Me.ComboBoxBtnPause.FormattingEnabled = True
        Me.ComboBoxBtnPause.Location = New System.Drawing.Point(44, 80)
        Me.ComboBoxBtnPause.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxBtnPause.Name = "ComboBoxBtnPause"
        Me.ComboBoxBtnPause.Size = New System.Drawing.Size(160, 24)
        Me.ComboBoxBtnPause.TabIndex = 2
        '
        'Label_Pause
        '
        Me.Label_Pause.AutoSize = True
        Me.Label_Pause.Location = New System.Drawing.Point(40, 48)
        Me.Label_Pause.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_Pause.Name = "Label_Pause"
        Me.Label_Pause.Size = New System.Drawing.Size(149, 16)
        Me.Label_Pause.TabIndex = 1
        Me.Label_Pause.Text = "Activez le bouton pause"
        '
        'Label_BoutonPause
        '
        Me.Label_BoutonPause.AutoSize = True
        Me.Label_BoutonPause.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_BoutonPause.Location = New System.Drawing.Point(63, 20)
        Me.Label_BoutonPause.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_BoutonPause.Name = "Label_BoutonPause"
        Me.Label_BoutonPause.Size = New System.Drawing.Size(130, 17)
        Me.Label_BoutonPause.TabIndex = 0
        Me.Label_BoutonPause.Text = "BOUTON PAUSE"
        '
        'Label_Minutes
        '
        Me.Label_Minutes.AutoSize = True
        Me.Label_Minutes.Location = New System.Drawing.Point(192, 137)
        Me.Label_Minutes.Name = "Label_Minutes"
        Me.Label_Minutes.Size = New System.Drawing.Size(53, 16)
        Me.Label_Minutes.TabIndex = 5
        Me.Label_Minutes.Text = "minutes"
        '
        'Options
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Ivory
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button_Retour)
        Me.Controls.Add(Me.Panel_Options)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Options"
        Me.Text = "Options"
        Me.Panel_Options.ResumeLayout(False)
        Me.Panel_Options.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_Options As Panel
    Friend WithEvents Label_Options As Label
    Friend WithEvents Button_Retour As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label_ModeDeJeu As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label_BoutonPause As Label
    Friend WithEvents Label_MDJ As Label
    Friend WithEvents ComboBoxMode As ComboBox
    Friend WithEvents TextBox_Temps As TextBox
    Friend WithEvents Label_Temps As Label
    Friend WithEvents ComboBoxBtnPause As ComboBox
    Friend WithEvents Label_Pause As Label
    Friend WithEvents Label_Minutes As Label
End Class
