<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_resetmdp
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
        Me.btn_reinit = New System.Windows.Forms.Button()
        Me.lbl_reinit = New System.Windows.Forms.Label()
        Me.input_reinit = New System.Windows.Forms.TextBox()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.lbl_user = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_reinit
        '
        Me.btn_reinit.Location = New System.Drawing.Point(391, 128)
        Me.btn_reinit.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_reinit.Name = "btn_reinit"
        Me.btn_reinit.Size = New System.Drawing.Size(137, 28)
        Me.btn_reinit.TabIndex = 29
        Me.btn_reinit.Text = "OK"
        Me.btn_reinit.UseVisualStyleBackColor = True
        '
        'lbl_reinit
        '
        Me.lbl_reinit.AutoSize = True
        Me.lbl_reinit.Location = New System.Drawing.Point(70, 134)
        Me.lbl_reinit.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_reinit.Name = "lbl_reinit"
        Me.lbl_reinit.Size = New System.Drawing.Size(93, 17)
        Me.lbl_reinit.TabIndex = 28
        Me.lbl_reinit.Text = "Mot de passe"
        Me.lbl_reinit.Visible = False
        '
        'input_reinit
        '
        Me.input_reinit.Location = New System.Drawing.Point(211, 131)
        Me.input_reinit.Margin = New System.Windows.Forms.Padding(4)
        Me.input_reinit.Name = "input_reinit"
        Me.input_reinit.Size = New System.Drawing.Size(132, 22)
        Me.input_reinit.TabIndex = 27
        Me.input_reinit.Visible = False
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(12, 9)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(386, 29)
        Me.lbl_title.TabIndex = 30
        Me.lbl_title.Text = "Réinitialisation du mot de passe"
        '
        'lbl_user
        '
        Me.lbl_user.AutoSize = True
        Me.lbl_user.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_user.Location = New System.Drawing.Point(68, 55)
        Me.lbl_user.Name = "lbl_user"
        Me.lbl_user.Size = New System.Drawing.Size(138, 29)
        Me.lbl_user.TabIndex = 31
        Me.lbl_user.Text = "Utilisateur:"
        '
        'frm_resetmdp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 253)
        Me.Controls.Add(Me.lbl_user)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.btn_reinit)
        Me.Controls.Add(Me.lbl_reinit)
        Me.Controls.Add(Me.input_reinit)
        Me.Name = "frm_resetmdp"
        Me.Text = "Réinitialisation du mot de passe"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_reinit As System.Windows.Forms.Button
    Friend WithEvents lbl_reinit As System.Windows.Forms.Label
    Friend WithEvents input_reinit As System.Windows.Forms.TextBox
    Friend WithEvents lbl_title As System.Windows.Forms.Label
    Friend WithEvents lbl_user As System.Windows.Forms.Label
End Class
