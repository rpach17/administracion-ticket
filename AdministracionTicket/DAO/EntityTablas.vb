Public Class EntityTablas
    Shared ctx As New EntidadesTablas(My.Settings.CadenaAPPCATablas)

    Public Shared Sub CargarEmpresas(ByVal cbo As ComboBox)
        Dim emps = (From e In ctx.EMPRESAS.ToList Select e).ToList()
        cbo.DataSource = emps
        cbo.DisplayMember = "NOMBRE"
        cbo.ValueMember = "IDEMPRESA"
    End Sub

    Public Shared Sub CargarMunicipios(ByVal grid As DataGridView, Optional ByVal filtro As String = "")
        If filtro = "" Then
            Dim mun = (From e In ctx.MUNICIPIOS.ToList
                       Order By e.DEPARTAMENTOS.CODIGO_DEPTO
                       Select e.IDMUNICIPIO, Codigo = e.CODIGO_MPIO, Nombre = e.NOMBRE_MPIO, Departamento = e.DEPARTAMENTOS.NOMBRE_DEPTO).ToList()
            grid.DataSource = mun
            grid.Columns(0).Visible = False
        Else
            Dim mun = (From e In ctx.MUNICIPIOS.ToList
                       Where e.NOMBRE_MPIO.StartsWith(filtro) OrElse e.DEPARTAMENTOS.NOMBRE_DEPTO.StartsWith(filtro)
                       Order By e.DEPARTAMENTOS.CODIGO_DEPTO
                       Select e.IDMUNICIPIO, Codigo = e.CODIGO_MPIO, Nombre = e.NOMBRE_MPIO, Departamento = e.DEPARTAMENTOS.NOMBRE_DEPTO).ToList()
            grid.DataSource = mun
            grid.Columns(0).Visible = False
        End If
    End Sub

    Public Shared Sub AgregarSucursal(ByVal su As SUCURSALES)
        Try
            ctx.SUCURSALES.AddObject(su)
            ctx.SaveChanges()
        Catch ex As UpdateException
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Shared Sub CargarOficinas(ByVal grid As DataGridView, Optional ByVal filtro As String = "")
        If filtro = "" Then
            Dim ofi = (From o In ctx.OFICINAS.ToList
                       Order By o.IDOFICINA
                       Select o.IDOFICINA, Nombre = o.NOMBRE_OFICINA).ToList()
            grid.DataSource = ofi
            grid.Columns(0).Visible = False
        Else
            Dim ofi = (From o In ctx.OFICINAS.ToList
                       Where o.NOMBRE_OFICINA
                       Order By o.IDOFICINA
                       Select o.IDOFICINA, Nombre = o.NOMBRE_OFICINA).ToList()
            grid.DataSource = ofi
            grid.Columns(0).Visible = False
        End If
    End Sub

    Public Shared Sub AgregarOficina(ByVal off As OFICINAS)
        Try
            ctx.OFICINAS.AddObject(off)
            ctx.SaveChanges()
        Catch ex As UpdateException
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Shared Sub ActualizarOficina(ByVal idof As Integer, ByVal nombre As String)
        Dim offi As OFICINAS = (From a In ctx.OFICINAS Where a.IDOFICINA = idof).First
        Try
            offi.NOMBRE_OFICINA = nombre
            ctx.SaveChanges()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Shared Sub EliminarOficina(ByVal idof As Integer)
        Dim offi = (From off In ctx.OFICINAS.ToList Where off.IDOFICINA = idof Select off).SingleOrDefault
        Try
            ctx.OFICINAS.DeleteObject(offi)
            ctx.SaveChanges()
            MsgBox("Oficina Eliminada")
        Catch ex As UpdateException
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Shared Sub CargarSucursales(ByVal grid As DataGridView, Optional ByVal filtro As String = "")
        If filtro = "" Then
            Dim su = (From suc In ctx.SUCURSALES.ToList
                       Order By suc.NOMBRE
                       Select suc.IDSUCURSAL, suc.NOMBRE, suc.MUNICIPIOS.NOMBRE_MPIO).ToList()
            grid.DataSource = su
            grid.Columns(0).Visible = False
        Else
            Dim su = (From suc In ctx.SUCURSALES.ToList
                       Where suc.NOMBRE.StartsWith(filtro) OrElse suc.MUNICIPIOS.NOMBRE_MPIO.StartsWith(filtro)
                       Order By suc.NOMBRE
                       Select suc.IDSUCURSAL, suc.NOMBRE, suc.MUNICIPIOS.NOMBRE_MPIO).ToList()
            grid.DataSource = su
            grid.Columns(0).Visible = False
        End If
    End Sub

    Dim prueba As Integer

End Class
