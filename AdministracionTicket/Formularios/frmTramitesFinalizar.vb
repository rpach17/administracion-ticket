Public Class frmTramitesFinalizar


    Private Sub txtCodTramite_EditValueChanged(sender As Object, e As EventArgs) Handles txtCodTramite.EditValueChanged
        If txtCodTramite.Text.Length = 12 Then
            EntityTablas.CargarErrores(cboErrorTramite, txtCodTramite.Text)
        End If
    End Sub

    Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click
        If txtCodTramite.Text.Length = 12 Then
            EntityTablas.AsignarErrorTramite(txtCodTramite.Text, cboErrorTramite.SelectedValue.ToString)
            txtCodTramite.Text = ""
            cboErrorTramite.Refresh()
        End If
    End Sub
End Class