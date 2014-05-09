Public Class frmPrincipal

    Private Sub CerrarSesiónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        frmLogin.Show()
        Close()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub NuevaSucursalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevaSucursalToolStripMenuItem.Click
        With frmAgregarSucursal
            .MdiParent = Me
            .StartPosition = FormStartPosition.CenterScreen
            .Show()
        End With
    End Sub

    Private Sub CatalogoDeOficinasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CatalogoDeOficinasToolStripMenuItem.Click
        With frmOficinas
            .MdiParent = Me
            .StartPosition = FormStartPosition.CenterScreen
            .Show()
        End With
    End Sub

    Private Sub CatalogoDeSucursalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CatalogoDeSucursalesToolStripMenuItem.Click
        With frmSucursales
            .MdiParent = Me
            .StartPosition = FormStartPosition.CenterScreen
            .Show()
        End With
    End Sub

    Private Sub GestionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestionesToolStripMenuItem.Click
        With frmGestionesOficina
            .MdiParent = Me
            .StartPosition = FormStartPosition.CenterScreen
            .Show()
        End With
    End Sub

    Private Sub AsignarOficinasASucursalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AsignarOficinasASucursalToolStripMenuItem.Click
        With frmSucursalesOficinas
            .MdiParent = Me
            .StartPosition = FormStartPosition.CenterScreen
            .Show()
        End With
    End Sub

    Private Sub VentanillasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VentanillasToolStripMenuItem.Click
        With frmVentanillas
            .MdiParent = Me
            .StartPosition = FormStartPosition.CenterScreen
            .Show()
        End With
    End Sub

    Private Sub ListaDeUsuariosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListaDeUsuariosToolStripMenuItem1.Click
        With frmUsuarios
            .MdiParent = Me
            .StartPosition = FormStartPosition.CenterScreen
            .Show()
        End With
    End Sub

    Private Sub frmPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblInfoConexion.Text = String.Format("{0} ({1})", SesionActiva.Nombre, SesionActiva.Usuario)
        lblInfoUbicacion.Text = String.Format("{0}, {1}", SesionActiva.Sucursal, SesionActiva.Oficina)

        Dim ctlMDI As MdiClient

        For Each ctl As Control In Controls
            Try
                ctlMDI = DirectCast(ctl, MdiClient)
                ctlMDI.BackColor = Me.BackColor
            Catch ex As InvalidCastException

            End Try
        Next
    End Sub

    Private Sub ListaDeUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaDeUsuariosToolStripMenuItem.Click
        With frmUsuariosSucursal
            .MdiParent = Me
            .StartPosition = FormStartPosition.CenterScreen
            .Show()
        End With
    End Sub
End Class