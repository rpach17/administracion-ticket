Public Class frmListadoMunicipios

    Private Sub frmListadoMunicipios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EntityTablas.CargarMunicipios(dgvMunicipios)
    End Sub

    Private Sub txtBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscar.KeyPress
        If e.KeyChar = ChrW(13) Then
            EntityTablas.CargarMunicipios(dgvMunicipios, txtBuscar.Text.Trim)
        End If
    End Sub

    Sub CargarMunic()
        EntityTablas.CargarMunicipios(dgvMunicipios)
    End Sub

    Private Sub dgvMunicipios_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvMunicipios.DoubleClick
        Dim ID As Integer = ObtenerDatoGrid(dgvMunicipios)
        Dim Codigo As String = ObtenerDatoGrid(dgvMunicipios, 1)
        Dim Nombre As String = ObtenerDatoGrid(dgvMunicipios, 2)

        With frmAgregarSucursal
            .txtNombreM.Text = Nombre
            .txtIDM.Text = Codigo
            .IdMunicipio = ID
        End With

        Close()
    End Sub
End Class