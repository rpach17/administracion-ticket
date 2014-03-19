

Public Class frmUsuarios

    Private Sub frmUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EntityTablas.CargarDepartamentos(DEPARTAMENTOSDataGridView)
    End Sub

    Private Sub DEPARTAMENTOSDataGridView_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DEPARTAMENTOSDataGridView.SelectionChanged
        EntityTablas.CargarMunicipiosDep(MUNICIPIOSDataGridView, ObtenerDatoGrid(DEPARTAMENTOSDataGridView))
    End Sub

    Private Sub MUNICIPIOSDataGridView_SelectionChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MUNICIPIOSDataGridView.SelectionChanged
        EntityTablas.CargarSucursalesMu(dgvSucursales, ObtenerDatoGrid(MUNICIPIOSDataGridView))
    End Sub

    Private Sub dgvSucursales_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvSucursales.SelectionChanged
        cargarUsuarios()
    End Sub

    Public Sub cargarUsuarios()
        EntityTablas.CargarUsuariosSu(USUARIOS_SUCURSALDataGridView, ObtenerDatoGrid(dgvSucursales))
    End Sub


    Private Sub AgregarNuevoUsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarNuevoUsuarioToolStripMenuItem.Click
        Dim ID As Integer = ObtenerDatoGrid(dgvSucursales)

        If ID = 0 Then
            MsgBox("Seleccione una sucursal primero", MsgBoxStyle.Exclamation, "Nuevo usuario")
            Exit Sub
        End If

        With frmPerfiles
            .EsNuevo = True
            .IdSucursal = ID
            .ShowDialog()
        End With
    End Sub

    Private Sub EditarUsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarUsuarioToolStripMenuItem.Click
        Dim IDU As Integer = ObtenerDatoGrid(USUARIOS_SUCURSALDataGridView)
        Dim IDS As Integer = ObtenerDatoGrid(dgvSucursales)
        With frmPerfiles
            .EsNuevo = False
            .IdUsuario = IDU
            .IdSucursal = IDS
            .ShowDialog()
        End With
    End Sub

    Private Sub ResetearContraseñaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetearContraseñaToolStripMenuItem.Click
        Dim nombre As String = String.Format("{0} {1}", ObtenerDatoGrid(USUARIOS_SUCURSALDataGridView, 2), ObtenerDatoGrid(USUARIOS_SUCURSALDataGridView, 3))
        If MsgBox(String.Format("¿Está seguro que desea reestablecer la contraseña de {0}?", nombre), MsgBoxStyle.Question + vbYesNo, "Confirme") = vbYes Then

            EntityTablas.ActualizarUsuarioPass(ObtenerDatoGrid(USUARIOS_SUCURSALDataGridView), SHA1(String.Format("{0}123!", ObtenerDatoGrid(USUARIOS_SUCURSALDataGridView, 1))))
            MsgBox(String.Format("La contraseña fue establecida a: {0}123!", ObtenerDatoGrid(USUARIOS_SUCURSALDataGridView, 1), MsgBoxStyle.Information, "Correcto"))

        End If
    End Sub
End Class