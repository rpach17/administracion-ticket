﻿Public Class frmConfig


    Private Sub btnProbar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnProbar.Click
        Dim _cadena As String = String.Format("DATA SOURCE={0};PASSWORD={1};PERSIST SECURITY INFO=True;USER ID={2}", txtDS.Text, txtPass.Text, txtUserID.Text)

        If ProbarConexion(_cadena) Then
            MsgBox("Conexión correcta", MsgBoxStyle.Information, "OK")
        Else
            MsgBox("Error de conexión", MsgBoxStyle.Critical, "ERROR")
        End If
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnGuardar.Click
        Dim _cadena As String = String.Format("DATA SOURCE={0};PASSWORD={1};PERSIST SECURITY INFO=True;USER ID={2}", txtDS.Text, txtPass.Text, txtUserID.Text)

        If ProbarConexion(_cadena) Then
            My.Settings.CadenaAPPCATablas = "metadata=res://*/EntityFramework.appcatablas.csdl|res://*/EntityFramework.appcatablas.ssdl|" _
                & "res://*/EntityFramework.appcatablas.msl;provider=Oracle.DataAccess.Client;provider connection string= '" & _cadena & "'"
            My.Settings.Save()
            MsgBox("Nueva configuración guardada", MsgBoxStyle.Information, "OK")
            frmLogin.Show()
            Close()
        Else
            MsgBox("Error de conexión", MsgBoxStyle.Critical, "ERROR")
        End If
    End Sub
End Class