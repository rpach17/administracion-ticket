Public Class frmUsuariosSucursal

    Private Sub txtBuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscar.KeyPress
        If e.KeyChar = ChrW(13) Then
            EntityTablas.CargarUsuariosSucursal(dgvUsuarios, SesionActiva.IdSucursalOficina, txtBuscar.Text)
        End If
    End Sub


    Private Sub frmUsuariosSucursal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EntityTablas.CargarUsuariosSu(dgvUsuarios, SesionActiva.IdSucursalOficina)
    End Sub
End Class