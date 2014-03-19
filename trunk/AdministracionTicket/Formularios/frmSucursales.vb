Public Class frmSucursales

    Public Sub cargarSucursales()
        EntityTablas.CargarSucursales(dgvSucursales)
    End Sub

    Private Sub frmOficinas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarSucursales()
    End Sub


    Private Sub Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar.Click
        If MsgBox(String.Format("Desea eliminar la Sucursal de: {0}", ObtenerDatoGrid(dgvSucursales, 1)), MsgBoxStyle.YesNo, "Eliminar Sucursal"
                  ) = MsgBoxResult.Yes Then
            EntityTablas.eliminarSucursal(ObtenerDatoGrid(dgvSucursales))
            cargarSucursales()
        End If
    End Sub

    Private Sub Actualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Actualizar.Click
        With frmModificarSucursal
            .idSucursal = ObtenerDatoGrid(dgvSucursales)
            .ShowDialog()
        End With
    End Sub

    Private Sub ToolStripTextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSucursal.KeyPress
        If e.KeyChar = ChrW(13) Then
            EntityTablas.CargarSucursales(dgvSucursales, txtSucursal.Text.Trim)
        End If
    End Sub


    Private Sub Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buscar.Click
        EntityTablas.CargarSucursales(dgvSucursales, txtSucursal.Text.Trim)
    End Sub
End Class