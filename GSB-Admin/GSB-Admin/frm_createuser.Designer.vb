<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_createuser
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
        Me.rdbtn_comptable = New System.Windows.Forms.RadioButton()
        Me.rdbtn_visiteur = New System.Windows.Forms.RadioButton()
        Me.input_adr = New System.Windows.Forms.TextBox()
        Me.input_dateEmbauche = New System.Windows.Forms.DateTimePicker()
        Me.lbl_dateembauche = New System.Windows.Forms.Label()
        Me.lbl_ville = New System.Windows.Forms.Label()
        Me.lbl_cp = New System.Windows.Forms.Label()
        Me.lbl_adr = New System.Windows.Forms.Label()
        Me.lbl_mdp = New System.Windows.Forms.Label()
        Me.lbl_prenom = New System.Windows.Forms.Label()
        Me.lbl_nom = New System.Windows.Forms.Label()
        Me.btn_confirmcreate = New System.Windows.Forms.Button()
        Me.input_ville = New System.Windows.Forms.TextBox()
        Me.input_cp = New System.Windows.Forms.TextBox()
        Me.input_mdp = New System.Windows.Forms.TextBox()
        Me.input_prenom = New System.Windows.Forms.TextBox()
        Me.input_nom = New System.Windows.Forms.TextBox()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'rdbtn_comptable
        '
        Me.rdbtn_comptable.AutoSize = True
        Me.rdbtn_comptable.Location = New System.Drawing.Point(580, 156)
        Me.rdbtn_comptable.Margin = New System.Windows.Forms.Padding(4)
        Me.rdbtn_comptable.Name = "rdbtn_comptable"
        Me.rdbtn_comptable.Size = New System.Drawing.Size(96, 21)
        Me.rdbtn_comptable.TabIndex = 39
        Me.rdbtn_comptable.TabStop = True
        Me.rdbtn_comptable.Text = "Comptable"
        Me.rdbtn_comptable.UseVisualStyleBackColor = True
        '
        'rdbtn_visiteur
        '
        Me.rdbtn_visiteur.AutoSize = True
        Me.rdbtn_visiteur.Location = New System.Drawing.Point(580, 127)
        Me.rdbtn_visiteur.Margin = New System.Windows.Forms.Padding(4)
        Me.rdbtn_visiteur.Name = "rdbtn_visiteur"
        Me.rdbtn_visiteur.Size = New System.Drawing.Size(76, 21)
        Me.rdbtn_visiteur.TabIndex = 38
        Me.rdbtn_visiteur.TabStop = True
        Me.rdbtn_visiteur.Text = "Visiteur"
        Me.rdbtn_visiteur.UseVisualStyleBackColor = True
        '
        'input_adr
        '
        Me.input_adr.Location = New System.Drawing.Point(162, 219)
        Me.input_adr.Margin = New System.Windows.Forms.Padding(4)
        Me.input_adr.Name = "input_adr"
        Me.input_adr.Size = New System.Drawing.Size(132, 22)
        Me.input_adr.TabIndex = 37
        Me.input_adr.Visible = False
        '
        'input_dateEmbauche
        '
        Me.input_dateEmbauche.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.input_dateEmbauche.Location = New System.Drawing.Point(162, 270)
        Me.input_dateEmbauche.Margin = New System.Windows.Forms.Padding(4)
        Me.input_dateEmbauche.Name = "input_dateEmbauche"
        Me.input_dateEmbauche.Size = New System.Drawing.Size(265, 22)
        Me.input_dateEmbauche.TabIndex = 36
        Me.input_dateEmbauche.Value = New Date(2022, 5, 15, 18, 30, 51, 0)
        '
        'lbl_dateembauche
        '
        Me.lbl_dateembauche.AutoSize = True
        Me.lbl_dateembauche.Location = New System.Drawing.Point(33, 270)
        Me.lbl_dateembauche.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_dateembauche.Name = "lbl_dateembauche"
        Me.lbl_dateembauche.Size = New System.Drawing.Size(119, 17)
        Me.lbl_dateembauche.TabIndex = 35
        Me.lbl_dateembauche.Text = "Date d'embauche"
        '
        'lbl_ville
        '
        Me.lbl_ville.AutoSize = True
        Me.lbl_ville.Location = New System.Drawing.Point(537, 222)
        Me.lbl_ville.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_ville.Name = "lbl_ville"
        Me.lbl_ville.Size = New System.Drawing.Size(34, 17)
        Me.lbl_ville.TabIndex = 34
        Me.lbl_ville.Text = "Ville"
        '
        'lbl_cp
        '
        Me.lbl_cp.AutoSize = True
        Me.lbl_cp.Location = New System.Drawing.Point(304, 222)
        Me.lbl_cp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_cp.Name = "lbl_cp"
        Me.lbl_cp.Size = New System.Drawing.Size(83, 17)
        Me.lbl_cp.TabIndex = 33
        Me.lbl_cp.Text = "Code postal"
        '
        'lbl_adr
        '
        Me.lbl_adr.AutoSize = True
        Me.lbl_adr.Location = New System.Drawing.Point(33, 222)
        Me.lbl_adr.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_adr.Name = "lbl_adr"
        Me.lbl_adr.Size = New System.Drawing.Size(60, 17)
        Me.lbl_adr.TabIndex = 32
        Me.lbl_adr.Text = "Adresse"
        '
        'lbl_mdp
        '
        Me.lbl_mdp.AutoSize = True
        Me.lbl_mdp.Location = New System.Drawing.Point(33, 175)
        Me.lbl_mdp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_mdp.Name = "lbl_mdp"
        Me.lbl_mdp.Size = New System.Drawing.Size(93, 17)
        Me.lbl_mdp.TabIndex = 31
        Me.lbl_mdp.Text = "Mot de passe"
        Me.lbl_mdp.Visible = False
        '
        'lbl_prenom
        '
        Me.lbl_prenom.AutoSize = True
        Me.lbl_prenom.Location = New System.Drawing.Point(304, 129)
        Me.lbl_prenom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_prenom.Name = "lbl_prenom"
        Me.lbl_prenom.Size = New System.Drawing.Size(57, 17)
        Me.lbl_prenom.TabIndex = 30
        Me.lbl_prenom.Text = "Prénom"
        Me.lbl_prenom.Visible = False
        '
        'lbl_nom
        '
        Me.lbl_nom.AutoSize = True
        Me.lbl_nom.Location = New System.Drawing.Point(33, 129)
        Me.lbl_nom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_nom.Name = "lbl_nom"
        Me.lbl_nom.Size = New System.Drawing.Size(37, 17)
        Me.lbl_nom.TabIndex = 29
        Me.lbl_nom.Text = "Nom"
        Me.lbl_nom.Visible = False
        '
        'btn_confirmcreate
        '
        Me.btn_confirmcreate.Location = New System.Drawing.Point(29, 313)
        Me.btn_confirmcreate.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_confirmcreate.Name = "btn_confirmcreate"
        Me.btn_confirmcreate.Size = New System.Drawing.Size(213, 28)
        Me.btn_confirmcreate.TabIndex = 28
        Me.btn_confirmcreate.Text = "Créer l'utilisateur"
        Me.btn_confirmcreate.UseVisualStyleBackColor = True
        '
        'input_ville
        '
        Me.input_ville.Location = New System.Drawing.Point(580, 219)
        Me.input_ville.Margin = New System.Windows.Forms.Padding(4)
        Me.input_ville.Name = "input_ville"
        Me.input_ville.Size = New System.Drawing.Size(132, 22)
        Me.input_ville.TabIndex = 27
        '
        'input_cp
        '
        Me.input_cp.Location = New System.Drawing.Point(396, 219)
        Me.input_cp.Margin = New System.Windows.Forms.Padding(4)
        Me.input_cp.Name = "input_cp"
        Me.input_cp.Size = New System.Drawing.Size(132, 22)
        Me.input_cp.TabIndex = 26
        '
        'input_mdp
        '
        Me.input_mdp.Location = New System.Drawing.Point(162, 175)
        Me.input_mdp.Margin = New System.Windows.Forms.Padding(4)
        Me.input_mdp.Name = "input_mdp"
        Me.input_mdp.Size = New System.Drawing.Size(132, 22)
        Me.input_mdp.TabIndex = 25
        Me.input_mdp.Visible = False
        '
        'input_prenom
        '
        Me.input_prenom.Location = New System.Drawing.Point(396, 125)
        Me.input_prenom.Margin = New System.Windows.Forms.Padding(4)
        Me.input_prenom.Name = "input_prenom"
        Me.input_prenom.Size = New System.Drawing.Size(132, 22)
        Me.input_prenom.TabIndex = 24
        Me.input_prenom.Visible = False
        '
        'input_nom
        '
        Me.input_nom.Location = New System.Drawing.Point(162, 125)
        Me.input_nom.Margin = New System.Windows.Forms.Padding(4)
        Me.input_nom.Name = "input_nom"
        Me.input_nom.Size = New System.Drawing.Size(132, 22)
        Me.input_nom.TabIndex = 23
        Me.input_nom.Visible = False
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(12, 9)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(319, 29)
        Me.lbl_title.TabIndex = 40
        Me.lbl_title.Text = "Créer un nouvel utilisateur"
        '
        'frm_createuser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 466)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.rdbtn_comptable)
        Me.Controls.Add(Me.rdbtn_visiteur)
        Me.Controls.Add(Me.input_adr)
        Me.Controls.Add(Me.input_dateEmbauche)
        Me.Controls.Add(Me.lbl_dateembauche)
        Me.Controls.Add(Me.lbl_ville)
        Me.Controls.Add(Me.lbl_cp)
        Me.Controls.Add(Me.lbl_adr)
        Me.Controls.Add(Me.lbl_mdp)
        Me.Controls.Add(Me.lbl_prenom)
        Me.Controls.Add(Me.lbl_nom)
        Me.Controls.Add(Me.btn_confirmcreate)
        Me.Controls.Add(Me.input_ville)
        Me.Controls.Add(Me.input_cp)
        Me.Controls.Add(Me.input_mdp)
        Me.Controls.Add(Me.input_prenom)
        Me.Controls.Add(Me.input_nom)
        Me.Name = "frm_createuser"
        Me.Text = "Création d'un utilisateur"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rdbtn_comptable As System.Windows.Forms.RadioButton
    Friend WithEvents rdbtn_visiteur As System.Windows.Forms.RadioButton
    Friend WithEvents input_adr As System.Windows.Forms.TextBox
    Friend WithEvents input_dateEmbauche As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_dateembauche As System.Windows.Forms.Label
    Friend WithEvents lbl_ville As System.Windows.Forms.Label
    Friend WithEvents lbl_cp As System.Windows.Forms.Label
    Friend WithEvents lbl_adr As System.Windows.Forms.Label
    Friend WithEvents lbl_mdp As System.Windows.Forms.Label
    Friend WithEvents lbl_prenom As System.Windows.Forms.Label
    Friend WithEvents lbl_nom As System.Windows.Forms.Label
    Friend WithEvents btn_confirmcreate As System.Windows.Forms.Button
    Friend WithEvents input_ville As System.Windows.Forms.TextBox
    Friend WithEvents input_cp As System.Windows.Forms.TextBox
    Friend WithEvents input_mdp As System.Windows.Forms.TextBox
    Friend WithEvents input_prenom As System.Windows.Forms.TextBox
    Friend WithEvents input_nom As System.Windows.Forms.TextBox
    Friend WithEvents lbl_title As System.Windows.Forms.Label
End Class
