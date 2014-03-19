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
End Class