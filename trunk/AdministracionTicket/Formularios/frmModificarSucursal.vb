Public Class frmModificarSucursal

    Private _idSucursal As Integer
    Public Property idSucursal() As Integer
        Get
            Return _idSucursal
        End Get
        Set(ByVal value As Integer)
            _idSucursal = value
        End Set
    End Property

    Private Sub frmAgregarSucursal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim su As SUCURSALES = EntityTablas.obtenerSucural(idSucursal)
        lblEmpresa.Text = su.EMPRESAS.NOMBRE
        txtNombreS.Text = su.NOMBRE
        txtDireccionS.Text = su.DIRECCION
        txtIDM.Text = su.MUNICIPIOS.CODIGO_MPIO
        txtNombreM.Text = su.MUNICIPIOS.NOMBRE_MPIO
        txtLongitud.Text = su.LONGITUD
        txtLatitud.Text = su.LATITUD
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        EntityTablas.ActualizaSucursal(idSucursal, txtNombreS.Text, txtDireccionS.Text, txtLatitud.Text, txtLongitud.Text)
        Close()
        frmSucursales.cargarSucursales()
    End Sub
End Class