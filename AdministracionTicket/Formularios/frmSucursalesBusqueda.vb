Public Class frmSucursalesBusqueda

    Public Sub cargarSucursales()
        EntityTablas.CargarSucursales(dgvSucursales)
    End Sub

    Private Sub frmOficinas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarSucursales()
    End Sub

    Private Sub ToolStripTextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSucursal.KeyPress
        If e.KeyChar = ChrW(13) Then
            EntityTablas.CargarSucursales(dgvSucursales, txtSucursal.Text.Trim)
        End If
    End Sub


    Private Sub Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buscar.Click
        EntityTablas.CargarSucursales(dgvSucursales, txtSucursal.Text.Trim)
    End Sub

    Private Sub dgvSucursales_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSucursales.CellClick
        frmGrupoSaltos.IdSucursal = ObtenerDatoGrid(dgvSucursales)
        frmGrupoSaltos.Sucursal = ObtenerDatoGrid(dgvSucursales, 1)
        Close()
    End Sub
End Class