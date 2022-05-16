Imports MySql.Data.MySqlClient
Public Class frm_createuser

    Private Sub frm_createuser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_nom.Visible = True
        lbl_adr.Visible = True
        lbl_cp.Visible = True
        lbl_dateembauche.Visible = True
        lbl_mdp.Visible = True
        lbl_prenom.Visible = True
        lbl_ville.Visible = True
        input_adr.Visible = True
        input_cp.Visible = True
        input_dateEmbauche.Visible = True
        input_mdp.Visible = True
        input_nom.Visible = True
        input_prenom.Visible = True
        input_ville.Visible = True
        rdbtn_visiteur.Checked = True
    End Sub

    Private Sub btn_confirmcreate_Click(sender As Object, e As EventArgs) Handles btn_confirmcreate.Click
        Dim uneErreur As Boolean
        uneErreur = False
        If input_nom.Text = "" Or input_nom.Text.StartsWith(" ") Then
            uneErreur = True
        End If
        If input_prenom.Text = "" Or input_prenom.Text.StartsWith(" ") Then
            uneErreur = True
        End If
        If input_mdp.Text = "" Or input_mdp.Text.StartsWith(" ") Then
            uneErreur = True
        End If
        If input_cp.Text = "" Or input_cp.Text.StartsWith(" ") Then
            uneErreur = True
        End If
        If input_ville.Text = "" Or input_ville.Text.StartsWith(" ") Then
            uneErreur = True
        End If
        If input_adr.Text = "" Or input_adr.Text.StartsWith(" ") Then
            uneErreur = True
        End If

        If input_dateEmbauche.Text = "" Or input_dateEmbauche.Text.StartsWith(" ") Then
            uneErreur = True
        End If
        If uneErreur Then
            MsgBox("Prière de bien vouloir vérifier si tous les champs sont saisis...", vbOKOnly, "Une erreur est survenue")
        Else
            'Créer un utilisateur
            Dim lbox_users = frm_main.lbox_users
            Dim conn = frm_connexion.conn
            Dim sqlQuery As String = "INSERT INTO utilisateur VALUES ('" & input_prenom.Text.Substring(0, 1) & input_nom.Text.Substring(0, 3) & "','" & input_nom.Text & "','" & input_prenom.Text & "','" & input_prenom.Text.Substring(0) & input_nom.Text & "',SHA1('" & input_mdp.Text & "'),'" & input_adr.Text & "','" & input_cp.Text & "','" & input_cp.Text & "','" & (input_dateEmbauche.Value.Year & "-" & input_dateEmbauche.Value.Month & "-" & input_dateEmbauche.Value.Day) & "');"

            Try
                conn.Open()
                Dim cmdSQL As New MySqlCommand()
                cmdSQL.Connection = conn
                cmdSQL.CommandText = sqlQuery
                Try
                    cmdSQL.ExecuteNonQuery()
                    conn.Close()
                    Try
                        conn = frm_connexion.conn
                        sqlQuery = "SELECT id FROM utilisateur WHERE nom='" & input_nom.Text & "' AND prenom='" & input_prenom.Text & "';"
                        conn.Open()
                        cmdSQL = New MySqlCommand()
                        cmdSQL.Connection = conn
                        cmdSQL.CommandText = sqlQuery
                        Dim reader As MySqlDataReader
                        reader = cmdSQL.ExecuteReader()

                        While reader.Read()
                            'Les champs à recup. Les tables commencent à 0.
                            Dim id = reader.GetString(0)
                            If Not id = "" Then
                                conn.Close()
                                If rdbtn_comptable.Checked Then
                                    Try
                                        conn = frm_connexion.conn
                                        sqlQuery = "INSERT INTO `comptable`(`idUtilisateur`, `nbFicheRefusee`) VALUES ('" & id & "',0)"
                                        conn.Open()
                                        cmdSQL = New MySqlCommand()
                                        cmdSQL.Connection = conn
                                        cmdSQL.CommandText = sqlQuery
                                        Try
                                            cmdSQL.ExecuteNonQuery()
                                            Me.Close()
                                            frm_main.Show()
                                            Exit While
                                        Catch ex As Exception
                                            MsgBox("ERREUR : Ajout impossible." + Chr(13) + ex.Message, vbCritical)
                                        End Try
                                        conn.Close()
                                    Catch ex As Exception
                                        MsgBox("ERREUR : Ajout impossible." + Chr(13) + ex.Message, vbCritical)
                                    End Try
                                Else
                                    Try
                                        conn = frm_connexion.conn
                                        sqlQuery = "INSERT INTO `visiteur`(`idUtilisateur`) VALUES ('" & id & "')"
                                        conn.Open()
                                        cmdSQL = New MySqlCommand()
                                        cmdSQL.Connection = conn
                                        cmdSQL.CommandText = sqlQuery
                                        Try
                                            cmdSQL.ExecuteNonQuery()
                                            Me.Close()
                                            frm_main.Show()
                                            Exit While
                                        Catch ex As Exception
                                            MsgBox("ERREUR : Ajout impossible." + Chr(13) + ex.Message, vbCritical)
                                        End Try
                                        conn.Close()
                                    Catch ex As Exception
                                        MsgBox("ERREUR : Ajout impossible." + Chr(13) + ex.Message, vbCritical)
                                    End Try
                                End If
                            End If
                        End While

                        reader.Close()
                        conn.Close()
                    Catch ex As Exception
                        MsgBox("ERREUR : Ajout impossible." + Chr(13) + ex.Message, vbCritical)
                    End Try
                    Me.Close()
                    frm_main.Show()
                Catch ex As Exception
                    MsgBox("ERREUR : Ajout impossible." + Chr(13) + ex.Message, vbCritical)
                End Try
                conn.Close()
            Catch ex As Exception
                MsgBox("ERREUR : Ajout impossible." + Chr(13) + ex.Message, vbCritical)
            End Try
        End If

    End Sub

    Private Sub btn_retour_Click(sender As Object, e As EventArgs) Handles btn_retour.Click
        frm_main.Show()
        Me.Close()
    End Sub
End Class