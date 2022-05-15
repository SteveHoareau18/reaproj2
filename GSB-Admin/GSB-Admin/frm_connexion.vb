Imports MySql.Data.MySqlClient
Imports System.IO
Imports System
Public Class frm_connexion

    Public conn As MySqlConnection


    Private Sub btn_connexion_Click(sender As Object, e As EventArgs) Handles btn_connexion.Click
        Dim allLinesto As List(Of String) = File.ReadAllLines(Application.StartupPath() & "\.ini").ToList
        For Each line As String In allLinesto
            If line.Split("=").GetValue(0) = "passwordMachine" Then
                If input_mdp.Text = line.Split("=").GetValue(1) Then
                    frm_main.Visible = True
                    Me.Visible = False
                Else
                    MsgBox("Prière de bien vouloir entrer le mot de passe...", vbOKOnly, "Une erreur est survenue")
                End If
                Exit For
            End If
        Next
    End Sub

    Private Sub frm_connexion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim allLinesto As List(Of String) = File.ReadAllLines(Application.StartupPath() & "\.ini").ToList
        Dim sqlConnexText As String = ""
        Dim keyConnex As ArrayList = New ArrayList()
        keyConnex.Add("datasource")
        keyConnex.Add("port")
        keyConnex.Add("username")
        keyConnex.Add("password")
        keyConnex.Add("database")

        For Each line As String In allLinesto
            If keyConnex.Contains(line.Split("=").GetValue(0)) Then
                sqlConnexText &= line & ";"
            End If
        Next
        Me.conn = New MySqlConnection(sqlConnexText)
        Try
            conn.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
            'don't do the con.Close here either
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

End Class