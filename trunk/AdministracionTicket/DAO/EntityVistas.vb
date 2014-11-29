Public Class EntityVistas
    Shared ctxTablas As New EntidadesTablas(My.Settings.CadenaAPPCATablas)
    Shared ctxVistas As New EntidadesVistas(My.Settings.CadenaAPPCAVistas)

    Shared Sub CargarDeptos(cbo As ComboBox)
        cbo.DataSource = (From d In ctxTablas.DEPARTAMENTOS Select d.IDDEPARTAMENTO, d.NOMBRE_DEPTO).ToList()
        cbo.DisplayMember = "NOMBRE_DEPTO"
        cbo.ValueMember = "IDDEPARTAMENTO"
        cbo.SelectedValue = -1
    End Sub

    Shared Sub CargarMpios(cbo As ComboBox, idd As Integer)
        cbo.DataSource = (From m In ctxTablas.MUNICIPIOS Where m.IDDEPARTAMENTO = idd Select m.IDMUNICIPIO, m.NOMBRE_MPIO).ToList()
        cbo.DisplayMember = "NOMBRE_MPIO"
        cbo.ValueMember = "IDMUNICIPIO"
        cbo.SelectedValue = -1
    End Sub

    Shared Sub CargarSucursales(cbo As ComboBox, idm As Integer)
        cbo.DataSource = (From s In ctxTablas.SUCURSALES Where s.IDMUNICIPIO = idm Select s.IDSUCURSAL, s.NOMBRE).ToList()
        cbo.DisplayMember = "NOMBRE"
        cbo.ValueMember = "IDSUCURSAL"
        cbo.SelectedValue = -1
    End Sub

    Shared Sub CargarOficinas(cbo As ComboBox, ids As Integer)
        cbo.DataSource = (From so In ctxTablas.DETALLE_SUCURSAL_OFICINA Where so.IDSUCURSAL = ids Select so.IDDETALLE_SUCURSAL_OFICINA, so.OFICINAS.NOMBRE_OFICINA).ToList()
        cbo.DisplayMember = "NOMBRE_OFICINA"
        cbo.ValueMember = "IDDETALLE_SUCURSAL_OFICINA"
        cbo.SelectedValue = -1
    End Sub

    Shared Sub reporteAtencion(grid As DataGridView, ByVal idso As Integer, ByVal finicio As Date, ByVal ffin As Date)
        Dim datos = (From d In ctxVistas.V_ATENCIONXOFICINA
                       Where d.IDDETALLE_SUCURSAL_OFICINA = 1 And d.FECHAHORA_PETICION >= finicio And d.FECHAHORA_PETICION <= ffin And d.PROMEDIO_ESPERA IsNot Nothing And d.PROMEDIO_ATENCION IsNot Nothing
                       Group By d.DEPARTAMENTO, d.MUNICIPIO, d.SUCURSAL, d.OFICINA, d.NOMBRE_EMPLEADO, d.GESTION
                       Into promedioEspera = Average(d.PROMEDIO_ESPERA), promedioAtencion = Average(d.PROMEDIO_ATENCION)
                       Select New With {DEPARTAMENTO, MUNICIPIO, SUCURSAL, OFICINA, NOMBRE_EMPLEADO, GESTION, promedioAtencion, promedioEspera}).ToList()



        grid.DataSource = datos
        'Dim lista As List(Of ATENCION_X_OFICINA)
        'Dim id As Integer = 0
        'For Each r In datos
        '    lista.
        '    id += 1
        'Next

    End Sub

End Class
