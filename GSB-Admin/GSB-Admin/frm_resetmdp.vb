Imports MySql.Data.MySqlClient
Public Class frm_resetmdp

    Private Sub frm_resetmdp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_reinit.Visible = True
        input_reinit.Visible = True
    End Sub

    Private Sub btn_reinit_Click(sender As Object, e As EventArgs) Handles btn_reinit.Click
        If input_reinit.Text = "" Or input_reinit.Text = " " Then
            MsgBox("Prière de bien vouloir vérifier si le champ nécessaire est saisis", vbOKOnly, "Une erreur est survenue")
            End
        End If


        'Modifier le mot de passe
        Dim conn = frm_connexion.conn
        Dim lbox_users = frm_main.lbox_users
        Dim sqlQuery As String = "UPDATE utilisateur SET mdp=SHA1('" & input_reinit.Text & "') WHERE nom='" & lbox_users.SelectedItem.ToString.Split(" ").GetValue(0) & "' AND prenom='" & lbox_users.SelectedItem.ToString.Split(" ").GetValue(1) & "';"

        Try
            Dim cmd As New MySqlCommand(sqlQuery, conn)
            conn.Open()
            Dim cmdSQL As New MySqlCommand()
            cmdSQL.Connection = conn
            cmdSQL.CommandText = sqlQuery
            Try
                cmdSQL.ExecuteNonQuery()
                frm_main.Visible = True
                Me.Close()
            Catch ex As Exception
                MsgBox("ERREUR : Ajout impossible." + Chr(13) + ex.Message, vbCritical)
            End Try
            conn.Close()
        Catch ex As Exception
            lbox_users.Items.Add(ex.Message)
        End Try
    End Sub
End Class