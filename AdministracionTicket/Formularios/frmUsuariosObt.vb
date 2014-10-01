Public Class frmUsuariosSucursalObt
    Dim sucursal As Integer

    Public Property Sucursal1 As Integer
        Get
            Return sucursal
        End Get
        Set(ByVal value As Integer)
            sucursal = value
        End Set
    End Property

    Private Sub txtBuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscar.KeyPress
        If e.KeyChar = ChrW(13) Then
            EntityTablas.CargarUsuariosSucursal(dgvUsuarios, sucursal, txtBuscar.Text)
        End If
    End Sub


    Private Sub frmUsuariosSucursal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EntityTablas.CargarUsuariosSu(dgvUsuarios, sucursal)
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
    
    Private Sub dgvUsuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsuarios.CellContentClick
        Dim idUsuario As Integer = ObtenerDatoGrid(dgvUsuarios)
        frmPerfiles.VinculadoCon = idUsuario
        frmPerfiles.usuarioVinculado = ObtenerDatoGrid(dgvUsuarios, 1)
        Close()
    End Sub
End Class