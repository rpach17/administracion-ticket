Public Class frmSucursalesOficinas

    Private Sub frmSucursalesOficinas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EntityTablas.CargarSucursales(dgvSucursales)
        EntityTablas.CargarCboOficinas(cboOficicinas)
    End Sub

    Private Sub txtBuscarSucursal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscarSucursal.KeyPress
        If e.KeyChar = ChrW(13) Then
            EntityTablas.CargarSucursales(dgvSucursales, txtBuscarSucursal.Text.Trim)
        End If
    End Sub

    Private Sub dgvSucursales_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvSucursales.SelectionChanged
        EntityTablas.CargarSucursalesOf(dgvOficinas, ObtenerDatoGrid(dgvSucursales))
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        EntityTablas.AgregarSuOf(New DETALLE_SUCURSAL_OFICINA() With {.IDSUCURSAL = ObtenerDatoGrid(dgvSucursales), .IDOFICINA = cboOficicinas.SelectedValue})
        EntityTablas.CargarSucursalesOf(dgvOficinas, ObtenerDatoGrid(dgvSucursales))
    End Sub

    Private Sub btnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitar.Click
        EntityTablas.EliminarDeSuOf(ObtenerDatoGrid(dgvOficinas))
        EntityTablas.CargarSucursalesOf(dgvOficinas, ObtenerDatoGrid(dgvSucursales))
    End Sub

End Class