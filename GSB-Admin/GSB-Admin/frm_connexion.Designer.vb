<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_connexion
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
        Me.input_mdp = New System.Windows.Forms.TextBox()
        Me.lbl_connexion = New System.Windows.Forms.Label()
        Me.btn_connexion = New System.Windows.Forms.Button()
        Me.lbl_mdp = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'input_mdp
        '
        Me.input_mdp.Location = New System.Drawing.Point(12, 89)
        Me.input_mdp.Name = "input_mdp"
        Me.input_mdp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.input_mdp.Size = New System.Drawing.Size(182, 20)
        Me.input_mdp.TabIndex = 0
        '
        'lbl_connexion
        '
        Me.lbl_connexion.AutoSize = True
        Me.lbl_connexion.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_connexion.Location = New System.Drawing.Point(46, 28)
        Me.lbl_connexion.Name = "lbl_connexion"
        Me.lbl_connexion.Size = New System.Drawing.Size(115, 25)
        Me.lbl_connexion.TabIndex = 1
        Me.lbl_connexion.Text = "Connexion"
        '
        'btn_connexion
        '
        Me.btn_connexion.Location = New System.Drawing.Point(51, 156)
        Me.btn_connexion.Name = "btn_connexion"
        Me.btn_connexion.Size = New System.Drawing.Size(110, 23)
        Me.btn_connexion.TabIndex = 2
        Me.btn_connexion.Text = "Se connecter"
        Me.btn_connexion.UseVisualStyleBackColor = True
        '
        'lbl_mdp
        '
        Me.lbl_mdp.AutoSize = True
        Me.lbl_mdp.Location = New System.Drawing.Point(12, 73)
        Me.lbl_mdp.Name = "lbl_mdp"
        Me.lbl_mdp.Size = New System.Drawing.Size(71, 13)
        Me.lbl_mdp.TabIndex = 3
        Me.lbl_mdp.Text = "Mot de passe"
        '
        'frm_connexion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(206, 224)
        Me.Controls.Add(Me.lbl_mdp)
        Me.Controls.Add(Me.btn_connexion)
        Me.Controls.Add(Me.lbl_connexion)
        Me.Controls.Add(Me.input_mdp)
        Me.Name = "frm_connexion"
        Me.Text = "Connexion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents input_mdp As System.Windows.Forms.TextBox
    Friend WithEvents lbl_connexion As System.Windows.Forms.Label
    Friend WithEvents btn_connexion As System.Windows.Forms.Button
    Friend WithEvents lbl_mdp As System.Windows.Forms.Label
End Class
