Public Class frmSQL
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        frmCrearFormularios.SQLQuery = txtSQL.Text
        Close()
    End Sub
End Class