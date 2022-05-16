<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_main
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
        Me.lbox_users = New System.Windows.Forms.ListBox()
        Me.btn_createuser = New System.Windows.Forms.Button()
        Me.lbl_listeusers = New System.Windows.Forms.Label()
        Me.btn_resetmdp = New System.Windows.Forms.Button()
        Me.btn_reloadlst = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbox_users
        '
        Me.lbox_users.FormattingEnabled = True
        Me.lbox_users.ItemHeight = 16
        Me.lbox_users.Location = New System.Drawing.Point(16, 50)
        Me.lbox_users.Margin = New System.Windows.Forms.Padding(4)
        Me.lbox_users.Name = "lbox_users"
        Me.lbox_users.Size = New System.Drawing.Size(159, 116)
        Me.lbox_users.TabIndex = 0
        '
        'btn_createuser
        '
        Me.btn_createuser.Location = New System.Drawing.Point(16, 191)
        Me.btn_createuser.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_createuser.Name = "btn_createuser"
        Me.btn_createuser.Size = New System.Drawing.Size(213, 28)
        Me.btn_createuser.TabIndex = 2
        Me.btn_createuser.Text = "Création d'un utilisateur"
        Me.btn_createuser.UseVisualStyleBackColor = True
        '
        'lbl_listeusers
        '
        Me.lbl_listeusers.AutoSize = True
        Me.lbl_listeusers.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_listeusers.Location = New System.Drawing.Point(-1, 22)
        Me.lbl_listeusers.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_listeusers.Name = "lbl_listeusers"
        Me.lbl_listeusers.Size = New System.Drawing.Size(187, 25)
        Me.lbl_listeusers.TabIndex = 19
        Me.lbl_listeusers.Text = "Liste des utilisateurs"
        '
        'btn_resetmdp
        '
        Me.btn_resetmdp.Location = New System.Drawing.Point(230, 105)
        Me.btn_resetmdp.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_resetmdp.Name = "btn_resetmdp"
        Me.btn_resetmdp.Size = New System.Drawing.Size(285, 28)
        Me.btn_resetmdp.TabIndex = 27
        Me.btn_resetmdp.Text = "Réinitialisation du mot de passe"
        Me.btn_resetmdp.UseVisualStyleBackColor = True
        '
        'btn_reloadlst
        '
        Me.btn_reloadlst.Location = New System.Drawing.Point(183, 155)
        Me.btn_reloadlst.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_reloadlst.Name = "btn_reloadlst"
        Me.btn_reloadlst.Size = New System.Drawing.Size(46, 28)
        Me.btn_reloadlst.TabIndex = 28
        Me.btn_reloadlst.Text = "🔄"
        Me.btn_reloadlst.UseVisualStyleBackColor = True
        '
        'frm_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 246)
        Me.Controls.Add(Me.btn_reloadlst)
        Me.Controls.Add(Me.btn_resetmdp)
        Me.Controls.Add(Me.lbl_listeusers)
        Me.Controls.Add(Me.btn_createuser)
        Me.Controls.Add(Me.lbox_users)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_main"
        Me.Text = "GSB-Admin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbox_users As System.Windows.Forms.ListBox
    Friend WithEvents btn_createuser As System.Windows.Forms.Button
    Friend WithEvents lbl_listeusers As System.Windows.Forms.Label
    Friend WithEvents btn_resetmdp As System.Windows.Forms.Button
    Friend WithEvents btn_reloadlst As System.Windows.Forms.Button

End Class
