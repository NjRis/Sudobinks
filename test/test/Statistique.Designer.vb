<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Statistique
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
        Me.Label_Stat = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ListBoxJoueurs = New System.Windows.Forms.ListBox()
        Me.ListBoxTemps = New System.Windows.Forms.ListBox()
        Me.ComboBoxNomJoueur = New System.Windows.Forms.ComboBox()
        Me.BtnAlpha = New System.Windows.Forms.Button()
        Me.BtnTps = New System.Windows.Forms.Button()
        Me.BtnRetour = New System.Windows.Forms.Button()
        Me.BtnInfo = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label_Stat
        '
        Me.Label_Stat.AutoSize = True
        Me.Label_Stat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Stat.Location = New System.Drawing.Point(69, 25)
        Me.Label_Stat.Name = "Label_Stat"
        Me.Label_Stat.Size = New System.Drawing.Size(172, 25)
        Me.Label_Stat.TabIndex = 0
        Me.Label_Stat.Text = "STATISTIQUES"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Panel1.Controls.Add(Me.Label_Stat)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel1.Location = New System.Drawing.Point(228, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(318, 77)
        Me.Panel1.TabIndex = 1
        '
        'ListBoxJoueurs
        '
        Me.ListBoxJoueurs.FormattingEnabled = True
        Me.ListBoxJoueurs.ItemHeight = 16
        Me.ListBoxJoueurs.Location = New System.Drawing.Point(12, 162)
        Me.ListBoxJoueurs.Name = "ListBoxJoueurs"
        Me.ListBoxJoueurs.Size = New System.Drawing.Size(233, 276)
        Me.ListBoxJoueurs.TabIndex = 2
        '
        'ListBoxTemps
        '
        Me.ListBoxTemps.FormattingEnabled = True
        Me.ListBoxTemps.ItemHeight = 16
        Me.ListBoxTemps.Location = New System.Drawing.Point(543, 162)
        Me.ListBoxTemps.Name = "ListBoxTemps"
        Me.ListBoxTemps.Size = New System.Drawing.Size(245, 276)
        Me.ListBoxTemps.TabIndex = 3
        '
        'ComboBoxNomJoueur
        '
        Me.ComboBoxNomJoueur.FormattingEnabled = True
        Me.ComboBoxNomJoueur.Location = New System.Drawing.Point(262, 96)
        Me.ComboBoxNomJoueur.Name = "ComboBoxNomJoueur"
        Me.ComboBoxNomJoueur.Size = New System.Drawing.Size(253, 24)
        Me.ComboBoxNomJoueur.TabIndex = 4
        '
        'BtnAlpha
        '
        Me.BtnAlpha.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.BtnAlpha.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAlpha.Location = New System.Drawing.Point(12, 125)
        Me.BtnAlpha.Name = "BtnAlpha"
        Me.BtnAlpha.Size = New System.Drawing.Size(156, 31)
        Me.BtnAlpha.TabIndex = 5
        Me.BtnAlpha.Text = "Tri alphabétique"
        Me.BtnAlpha.UseVisualStyleBackColor = False
        '
        'BtnTps
        '
        Me.BtnTps.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.BtnTps.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTps.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTps.Location = New System.Drawing.Point(624, 125)
        Me.BtnTps.Name = "BtnTps"
        Me.BtnTps.Size = New System.Drawing.Size(164, 31)
        Me.BtnTps.TabIndex = 6
        Me.BtnTps.Text = "Tri par temps"
        Me.BtnTps.UseVisualStyleBackColor = False
        '
        'BtnRetour
        '
        Me.BtnRetour.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.BtnRetour.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRetour.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRetour.Location = New System.Drawing.Point(302, 377)
        Me.BtnRetour.Name = "BtnRetour"
        Me.BtnRetour.Size = New System.Drawing.Size(188, 50)
        Me.BtnRetour.TabIndex = 7
        Me.BtnRetour.Text = "RETOUR"
        Me.BtnRetour.UseVisualStyleBackColor = False
        '
        'BtnInfo
        '
        Me.BtnInfo.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.BtnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInfo.Location = New System.Drawing.Point(302, 147)
        Me.BtnInfo.Name = "BtnInfo"
        Me.BtnInfo.Size = New System.Drawing.Size(188, 38)
        Me.BtnInfo.TabIndex = 8
        Me.BtnInfo.Text = "DETAILS"
        Me.BtnInfo.UseVisualStyleBackColor = False
        '
        'Statistique
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Ivory
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnInfo)
        Me.Controls.Add(Me.BtnRetour)
        Me.Controls.Add(Me.BtnTps)
        Me.Controls.Add(Me.BtnAlpha)
        Me.Controls.Add(Me.ComboBoxNomJoueur)
        Me.Controls.Add(Me.ListBoxTemps)
        Me.Controls.Add(Me.ListBoxJoueurs)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Statistique"
        Me.Text = "Statistique"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label_Stat As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ListBoxJoueurs As ListBox
    Friend WithEvents ListBoxTemps As ListBox
    Friend WithEvents ComboBoxNomJoueur As ComboBox
    Friend WithEvents BtnAlpha As Button
    Friend WithEvents BtnTps As Button
    Friend WithEvents BtnRetour As Button
    Friend WithEvents BtnInfo As Button
End Class
