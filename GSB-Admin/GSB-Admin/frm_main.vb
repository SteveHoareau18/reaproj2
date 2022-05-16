
Imports MySql.Data.MySqlClient
Public Class frm_main

    Dim sender As Object
    Dim e As EventArgs

    Private Sub frm_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_resetmdp.Visible = False
        'Remplir la liste des utilisateurs
        Dim conn = frm_connexion.conn
        Dim sqlQuery As String = "SELECT nom, prenom FROM utilisateur;"
        Try
            Dim cmd As New MySqlCommand(sqlQuery, conn)
            conn.Open()

            Dim reader As MySqlDataReader
            reader = cmd.ExecuteReader()

            While reader.Read()
                'Les champs à recup. Les tables commencent à 0.
                If Not reader.GetString(0) = "" Then
                    lbox_users.Items.Add(reader.GetString(0) & " " & reader.GetString(1))
                End If
            End While

            reader.Close()
            conn.Close()
        Catch ex As Exception
            lbox_users.Items.Add(ex.Message)
        End Try

    End Sub

   

    Private Sub lbox_users_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbox_users.SelectedIndexChanged
        If Not btn_resetmdp.Visible Then
            btn_resetmdp.Visible = True
        End If
    End Sub

    Private Sub btn_resetmdp_Click(sender As Object, e As EventArgs) Handles btn_resetmdp.Click
        Me.Visible = False
        frm_resetmdp.Show()
    End Sub

    Private Sub btn_createuser_Click(sender As Object, e As EventArgs) Handles btn_createuser.Click
        Me.Visible = False
        frm_createuser.Show()
    End Sub

    Private Sub btn_reloadlst_Click(sender As Object, e As EventArgs) Handles btn_reloadlst.Click
        btn_resetmdp.Visible = False
        lbox_users.Items.Clear()
        'Remplir la liste des utilisateurs
        Dim conn = frm_connexion.conn
        Dim sqlQuery As String = "SELECT nom, prenom FROM utilisateur;"
        Try
            Dim cmd As New MySqlCommand(sqlQuery, conn)
            conn.Open()

            Dim reader As MySqlDataReader
            reader = cmd.ExecuteReader()

            While reader.Read()
                'Les champs à recup. Les tables commencent à 0.
                If Not reader.GetString(0) = "" Then
                    lbox_users.Items.Add(reader.GetString(0) & " " & reader.GetString(1))
                End If
            End While

            reader.Close()
            conn.Close()
        Catch ex As Exception
            lbox_users.Items.Add(ex.Message)
        End Try
    End Sub
End Class
