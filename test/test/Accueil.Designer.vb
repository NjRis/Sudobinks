<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Accueil
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Accueil))
        Me.Button_Jouer = New System.Windows.Forms.Button()
        Me.Button_Options = New System.Windows.Forms.Button()
        Me.Button_Score = New System.Windows.Forms.Button()
        Me.Button_Quitter = New System.Windows.Forms.Button()
        Me.Label_Nom = New System.Windows.Forms.Label()
        Me.Label_Sudoku = New System.Windows.Forms.Label()
        Me.Panel_Sudoku = New System.Windows.Forms.Panel()
        Me.Panel_Nom = New System.Windows.Forms.Panel()
        Me.ComboBoxNomJoueur = New System.Windows.Forms.ComboBox()
        Me.Panel_Sudoku.SuspendLayout()
        Me.Panel_Nom.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button_Jouer
        '
        Me.Button_Jouer.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Button_Jouer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Jouer.Location = New System.Drawing.Point(403, 358)
        Me.Button_Jouer.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_Jouer.Name = "Button_Jouer"
        Me.Button_Jouer.Size = New System.Drawing.Size(201, 28)
        Me.Button_Jouer.TabIndex = 1
        Me.Button_Jouer.Text = "JOUER"
        Me.Button_Jouer.UseVisualStyleBackColor = False
        '
        'Button_Options
        '
        Me.Button_Options.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Button_Options.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Options.Location = New System.Drawing.Point(403, 394)
        Me.Button_Options.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_Options.Name = "Button_Options"
        Me.Button_Options.Size = New System.Drawing.Size(201, 28)
        Me.Button_Options.TabIndex = 3
        Me.Button_Options.Text = "OPTIONS"
        Me.Button_Options.UseVisualStyleBackColor = False
        '
        'Button_Score
        '
        Me.Button_Score.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Button_Score.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Score.Location = New System.Drawing.Point(403, 430)
        Me.Button_Score.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_Score.Name = "Button_Score"
        Me.Button_Score.Size = New System.Drawing.Size(201, 28)
        Me.Button_Score.TabIndex = 4
        Me.Button_Score.Text = "SCORE"
        Me.Button_Score.UseVisualStyleBackColor = False
        '
        'Button_Quitter
        '
        Me.Button_Quitter.BackColor = System.Drawing.Color.Brown
        Me.Button_Quitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Quitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Quitter.Location = New System.Drawing.Point(403, 465)
        Me.Button_Quitter.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_Quitter.Name = "Button_Quitter"
        Me.Button_Quitter.Size = New System.Drawing.Size(201, 28)
        Me.Button_Quitter.TabIndex = 5
        Me.Button_Quitter.Text = "QUITTER"
        Me.Button_Quitter.UseVisualStyleBackColor = False
        '
        'Label_Nom
        '
        Me.Label_Nom.AutoSize = True
        Me.Label_Nom.Location = New System.Drawing.Point(37, 17)
        Me.Label_Nom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_Nom.Name = "Label_Nom"
        Me.Label_Nom.Size = New System.Drawing.Size(44, 16)
        Me.Label_Nom.TabIndex = 6
        Me.Label_Nom.Text = "NOM :"
        '
        'Label_Sudoku
        '
        Me.Label_Sudoku.AutoSize = True
        Me.Label_Sudoku.Location = New System.Drawing.Point(124, 22)
        Me.Label_Sudoku.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_Sudoku.Name = "Label_Sudoku"
        Me.Label_Sudoku.Size = New System.Drawing.Size(64, 16)
        Me.Label_Sudoku.TabIndex = 7
        Me.Label_Sudoku.Text = "SUDOKU"
        '
        'Panel_Sudoku
        '
        Me.Panel_Sudoku.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Panel_Sudoku.Controls.Add(Me.Label_Sudoku)
        Me.Panel_Sudoku.Location = New System.Drawing.Point(335, 90)
        Me.Panel_Sudoku.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel_Sudoku.Name = "Panel_Sudoku"
        Me.Panel_Sudoku.Size = New System.Drawing.Size(324, 64)
        Me.Panel_Sudoku.TabIndex = 8
        '
        'Panel_Nom
        '
        Me.Panel_Nom.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Panel_Nom.Controls.Add(Me.Label_Nom)
        Me.Panel_Nom.Location = New System.Drawing.Point(449, 217)
        Me.Panel_Nom.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel_Nom.Name = "Panel_Nom"
        Me.Panel_Nom.Size = New System.Drawing.Size(121, 52)
        Me.Panel_Nom.TabIndex = 9
        '
        'ComboBoxNomJoueur
        '
        Me.ComboBoxNomJoueur.FormattingEnabled = True
        Me.ComboBoxNomJoueur.Location = New System.Drawing.Point(335, 276)
        Me.ComboBoxNomJoueur.Name = "ComboBoxNomJoueur"
        Me.ComboBoxNomJoueur.Size = New System.Drawing.Size(323, 24)
        Me.ComboBoxNomJoueur.TabIndex = 10
        '
        'Accueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.ComboBoxNomJoueur)
        Me.Controls.Add(Me.Panel_Nom)
        Me.Controls.Add(Me.Panel_Sudoku)
        Me.Controls.Add(Me.Button_Quitter)
        Me.Controls.Add(Me.Button_Score)
        Me.Controls.Add(Me.Button_Options)
        Me.Controls.Add(Me.Button_Jouer)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Accueil"
        Me.Text = "Form1"
        Me.Panel_Sudoku.ResumeLayout(False)
        Me.Panel_Sudoku.PerformLayout()
        Me.Panel_Nom.ResumeLayout(False)
        Me.Panel_Nom.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button_Jouer As Button
    Friend WithEvents Button_Options As Button
    Friend WithEvents Button_Score As Button
    Friend WithEvents Button_Quitter As Button
    Friend WithEvents Label_Nom As Label
    Friend WithEvents Label_Sudoku As Label
    Friend WithEvents Panel_Sudoku As Panel
    Friend WithEvents Panel_Nom As Panel
    Friend WithEvents ComboBoxNomJoueur As ComboBox
End Class
