Public Class frmAgregarSucursal
    Public Property IdMunicipio As Integer

    Private Sub frmAgregarSucursal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EntityTablas.CargarEmpresas(NOMBREComboBox)
    End Sub

    Private Sub btnBuscarM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarM.Click
        frmListadoMunicipios.ShowDialog()
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        If Not ValidarForm() Then
            Exit Sub
        End If

        EntityTablas.AgregarSucursal(New SUCURSALES() With _
        {
            .IDEMPRESA = NOMBREComboBox.SelectedValue, _
            .NOMBRE = txtNombreS.Text, _
            .DIRECCION = txtDireccionS.Text, _
            .IDMUNICIPIO = IdMunicipio, _
            .LATITUD = Val(txtLatitud.Text), _
            .LONGITUD = Val(txtLongitud.Text)
        })

        LimpiarControles(txtNombreS, txtDireccionS, txtLongitud, txtLatitud)
        txtNombreS.Focus()

        MsgBox("Sucursal agregada correctamente", MsgBoxStyle.Information, "Sucursal")
    End Sub

    Private Function ValidarForm() As Boolean
        If txtNombreM.Text.Trim = "" Then
            MsgBox("Debe agregar el nombre de la sucursal", MsgBoxStyle.Exclamation, "Falta nombre")
            txtNombreS.Focus()
            Return False
        End If

        If txtDireccionS.Text.Trim = "" Then
            MsgBox("Debe agregar la dirección de la sucursal", MsgBoxStyle.Exclamation, "Falta dirección")
            txtDireccionS.Focus()
            Return False
        End If

        If txtNombreM.Text = "" Then
            MsgBox("Debe seleccionar el municipio donde pertenece la sucursal", MsgBoxStyle.Exclamation, "Falta municipio")
            btnBuscarM.Focus()
            Return False
        End If

        Return True
    End Function
End Class