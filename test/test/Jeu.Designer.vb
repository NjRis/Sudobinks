<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Jeu
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.grKlava = New System.Windows.Forms.GroupBox()
        Me.SFD1 = New System.Windows.Forms.SaveFileDialog()
        Me.OFD1 = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PartieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NouvellePartieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChargerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SauvegarderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SortirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParamètresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label_Temps = New System.Windows.Forms.Label()
        Me.Label_NomJoueur = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.RadioButton5)
        Me.GroupBox1.Controls.Add(Me.RadioButton4)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(281, 204)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(344, 294)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Difficulté"
        Me.GroupBox1.Visible = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button1.Location = New System.Drawing.Point(100, 241)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(129, 41)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RadioButton5.Location = New System.Drawing.Point(41, 191)
        Me.RadioButton5.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(209, 29)
        Me.RadioButton5.TabIndex = 4
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "Très Difficile (55-65)"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RadioButton4.Location = New System.Drawing.Point(41, 153)
        Me.RadioButton4.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(164, 29)
        Me.RadioButton4.TabIndex = 3
        Me.RadioButton4.Text = "Difficile (45-55)"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Checked = True
        Me.RadioButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RadioButton3.Location = New System.Drawing.Point(41, 116)
        Me.RadioButton3.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(168, 29)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Moyen (35 -45)"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(41, 79)
        Me.RadioButton2.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(155, 29)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "Facile (30-35)"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(41, 42)
        Me.RadioButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(200, 29)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Très Facile (25-30)"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'grKlava
        '
        Me.grKlava.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grKlava.Location = New System.Drawing.Point(207, 258)
        Me.grKlava.Margin = New System.Windows.Forms.Padding(4)
        Me.grKlava.Name = "grKlava"
        Me.grKlava.Padding = New System.Windows.Forms.Padding(4)
        Me.grKlava.Size = New System.Drawing.Size(203, 240)
        Me.grKlava.TabIndex = 5
        Me.grKlava.TabStop = False
        Me.grKlava.Visible = False
        '
        'OFD1
        '
        Me.OFD1.FileName = "OpenFileDialog1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PartieToolStripMenuItem, Me.ParamètresToolStripMenuItem, Me.ToolStripMenuItem2})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1184, 28)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "Menu"
        '
        'PartieToolStripMenuItem
        '
        Me.PartieToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NouvellePartieToolStripMenuItem, Me.ChargerToolStripMenuItem, Me.SauvegarderToolStripMenuItem, Me.ToolStripMenuItem1, Me.SortirToolStripMenuItem})
        Me.PartieToolStripMenuItem.Name = "PartieToolStripMenuItem"
        Me.PartieToolStripMenuItem.Size = New System.Drawing.Size(60, 24)
        Me.PartieToolStripMenuItem.Text = "Partie"
        '
        'NouvellePartieToolStripMenuItem
        '
        Me.NouvellePartieToolStripMenuItem.Name = "NouvellePartieToolStripMenuItem"
        Me.NouvellePartieToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.NouvellePartieToolStripMenuItem.Text = "Nouvelle Partie"
        '
        'ChargerToolStripMenuItem
        '
        Me.ChargerToolStripMenuItem.Name = "ChargerToolStripMenuItem"
        Me.ChargerToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ChargerToolStripMenuItem.Text = "Telecharger"
        '
        'SauvegarderToolStripMenuItem
        '
        Me.SauvegarderToolStripMenuItem.Name = "SauvegarderToolStripMenuItem"
        Me.SauvegarderToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.SauvegarderToolStripMenuItem.Text = "Sauvegarder"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(221, 6)
        '
        'SortirToolStripMenuItem
        '
        Me.SortirToolStripMenuItem.Name = "SortirToolStripMenuItem"
        Me.SortirToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.SortirToolStripMenuItem.Text = "Quitter"
        '
        'ParamètresToolStripMenuItem
        '
        Me.ParamètresToolStripMenuItem.Name = "ParamètresToolStripMenuItem"
        Me.ParamètresToolStripMenuItem.Size = New System.Drawing.Size(96, 24)
        Me.ParamètresToolStripMenuItem.Text = "Parametres"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(78, 24)
        Me.ToolStripMenuItem2.Text = "Solution"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Wheat
        Me.Panel2.Controls.Add(Me.Label_Temps)
        Me.Panel2.Controls.Add(Me.Label_NomJoueur)
        Me.Panel2.Location = New System.Drawing.Point(917, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(267, 638)
        Me.Panel2.TabIndex = 11
        '
        'Label_Temps
        '
        Me.Label_Temps.AutoSize = True
        Me.Label_Temps.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Temps.Location = New System.Drawing.Point(44, 324)
        Me.Label_Temps.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_Temps.Name = "Label_Temps"
        Me.Label_Temps.Size = New System.Drawing.Size(122, 17)
        Me.Label_Temps.TabIndex = 1
        Me.Label_Temps.Text = "Temps restant :"
        '
        'Label_NomJoueur
        '
        Me.Label_NomJoueur.AutoSize = True
        Me.Label_NomJoueur.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_NomJoueur.Location = New System.Drawing.Point(40, 154)
        Me.Label_NomJoueur.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_NomJoueur.Name = "Label_NomJoueur"
        Me.Label_NomJoueur.Size = New System.Drawing.Size(55, 17)
        Me.Label_NomJoueur.TabIndex = 0
        Me.Label_NomJoueur.Text = "Nom : "
        '
        'Jeu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 671)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.grKlava)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Jeu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sudoku "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents grKlava As System.Windows.Forms.GroupBox
    Friend WithEvents SFD1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OFD1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents PartieToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NouvellePartieToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChargerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SauvegarderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SortirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ParamètresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label_Temps As Label
    Friend WithEvents Label_NomJoueur As Label
    Friend WithEvents Timer1 As Windows.Forms.Timer
End Class
