Public Class frmUsuariosSucursal

    Private Sub txtBuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscar.KeyPress
        If e.KeyChar = ChrW(13) Then
            EntityTablas.CargarUsuariosSucursal(dgvUsuarios, SesionActiva.IdSucursalOficina, txtBuscar.Text)
        End If
    End Sub


    Private Sub frmUsuariosSucursal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EntityTablas.CargarUsuariosSu(dgvUsuarios, SesionActiva.IdSucursalOficina)
    End Sub

    Private Sub EditarUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarUsuarioToolStripMenuItem.Click
        Dim IDU As Integer = ObtenerDatoGrid(dgvUsuarios)
        With frmPerfiles
            .EsNuevo = False
            .IdUsuario = IDU
            .IdSucursal = SesionActiva.IdSucursalOficina
            .ShowDialog()
        End With
    End Sub

    Private Sub ResetearContraseñaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetearContraseñaToolStripMenuItem.Click
        Dim IDU As Integer = ObtenerDatoGrid(dgvUsuarios)
        With frmContrasenia
            .IdUsuario1 = ObtenerDatoGrid(dgvUsuarios)
            .ShowDialog()
        End With
    End Sub
End Class