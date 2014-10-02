Public Class frmConfigURL

    Private Sub frmConfigURL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtURL.Text = EntityTablas.ObtenerURL(1)
        txtURL.Select(txtURL.Text.Length, 0)
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        EntityTablas.ActualizarURL(txtURL.Text, 1)
        MsgBox("URL actualizada", MsgBoxStyle.Information, "Formularios")
    End Sub

    Private Sub btnSetting_Click(sender As Object, e As EventArgs) Handles btnSetting.Click
        My.Settings.URLForm = txtURL.Text
        My.Settings.Save()
        MsgBox("URL almacenada en settings", MsgBoxStyle.Information, "Formularios")
    End Sub
End Class