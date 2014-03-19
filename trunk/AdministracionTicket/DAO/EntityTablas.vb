Public Class EntityTablas
    Shared ctx As New EntidadesTablas(My.Settings.CadenaAPPCATablas)

#Region "Sucursales"

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

    Public Shared Function obtenerSucural(ByVal ids As Integer)
        Dim su = (From s In ctx.SUCURSALES Where s.IDSUCURSAL = ids Select s).SingleOrDefault
        Return su
    End Function

    Public Shared Sub ActualizaSucursal(ByVal ids As Integer, ByVal nombre As String,
                                        ByVal direccion As String, ByVal la As Decimal, ByVal lo As Decimal)
        Dim su = (From s In ctx.SUCURSALES Where s.IDSUCURSAL = ids).SingleOrDefault
        Try
            su.NOMBRE = nombre
            su.DIRECCION = direccion
            su.LATITUD = la
            su.LONGITUD = lo
            ctx.SaveChanges()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Shared Sub eliminarSucursal(ByVal ids As Integer)
        Dim su = (From s In ctx.SUCURSALES Where s.IDSUCURSAL = ids).SingleOrDefault
        Try
            ctx.SUCURSALES.DeleteObject(su)
            ctx.SaveChanges()
            MsgBox("Sucursal eliminada")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region

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


#Region "Oficinas por Sucursales"

    Public Shared Sub CargarSucursales(ByVal grid As DataGridView, Optional ByVal filtro As String = "")
        If filtro = "" Then
            Dim su = (From suc In ctx.SUCURSALES.ToList
                       Order By suc.NOMBRE
                       Select suc.IDSUCURSAL, Sucursal = suc.NOMBRE, Municipio = suc.MUNICIPIOS.NOMBRE_MPIO).ToList()
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

    Public Shared Sub CargarCboOficinas(ByVal cbo As ComboBox)
        Dim off = (From o In ctx.OFICINAS.ToList Select o).ToList()
        cbo.DataSource = off
        cbo.DisplayMember = "NOMBRE_OFICINA"
        cbo.ValueMember = "IDOFICINA"
        cbo.SelectedIndex = -1
    End Sub

    Public Shared Sub CargarSucursalesOf(ByVal grid As DataGridView, ByVal filtro As Integer)
        Dim suOf = (From sucof In ctx.DETALLE_SUCURSAL_OFICINA
                    Where sucof.IDSUCURSAL = filtro
                   Order By sucof.IDOFICINA
                   Select sucof.IDDETALLE_SUCURSAL_OFICINA, sucof.OFICINAS.NOMBRE_OFICINA).ToList()
        grid.DataSource = suOf
        grid.Columns(0).Visible = False
    End Sub

    Public Shared Sub AgregarSuOf(ByVal SuOf As DETALLE_SUCURSAL_OFICINA)
        Try
            ctx.DETALLE_SUCURSAL_OFICINA.AddObject(SuOf)
            ctx.SaveChanges()
        Catch ex As UpdateException
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Shared Sub EliminarDeSuOf(ByVal idDeSuOf As Integer)
        Dim DeSuOf = (From SuOf In ctx.DETALLE_SUCURSAL_OFICINA.ToList Where SuOf.IDDETALLE_SUCURSAL_OFICINA = idDeSuOf Select SuOf).SingleOrDefault
        Try
            ctx.DETALLE_SUCURSAL_OFICINA.DeleteObject(DeSuOf)
            ctx.SaveChanges()
        Catch ex As UpdateException
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region

#Region "Gestiones por oficina"

    Public Shared Sub CargarOficinas(ByVal cbo As ComboBox)
        Dim ofi = (From o In ctx.OFICINAS.ToList()
                   Select o).ToList()

        cbo.DataSource = ofi
        cbo.DisplayMember = "NOMBRE_OFICINA"
        cbo.ValueMember = "IDOFICINA"
        cbo.SelectedValue = -1
    End Sub

    Public Shared Sub CargarGestionesXOficinas(ByVal grid As DataGridView, ByVal ido As Integer)
        Dim ofi = (From o In ctx.DETALLE_OFICINA_GESTIONES.ToList()
                   Where o.OFICINAS.IDOFICINA = ido
                   Select o.GESTIONES.IDGESTION, Código = o.GESTIONES.CODIGO, Gestión = o.GESTIONES.NOMBRE, Tiempo = o.GESTIONES.TIEMPO).ToList()

        grid.DataSource = ofi
        grid.Columns(0).Visible = False
    End Sub

    Public Shared Function AgregarGestion(ByVal ges As GESTIONES)
        Try
            ctx.GESTIONES.AddObject(ges)
            ctx.SaveChanges()
            Return ges.IDGESTION 'Después de SaveChanges(), EntityFramework carga el objeto 'ges' con los datos y así retornamos el ID recien agregado
        Catch ex As UpdateException
            Return ex.Message
        End Try
    End Function

    Public Shared Sub AgregarOFGE(ByVal ges As DETALLE_OFICINA_GESTIONES)
        Try
            ctx.DETALLE_OFICINA_GESTIONES.AddObject(ges)
            ctx.SaveChanges()
        Catch ex As UpdateException
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Shared Sub ActualizarGestion(ByVal idg As Integer, ByVal cod As String, ByVal nombre As String, ByVal tiempo As Integer)
        Dim gest As GESTIONES = (From g In ctx.GESTIONES.ToList() Where g.IDGESTION = idg).SingleOrDefault()
        Try
            With gest
                .CODIGO = cod
                .NOMBRE = nombre
                .TIEMPO = tiempo
            End With
            ctx.SaveChanges()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "Gestion de ventanillas"

    Public Shared Sub CargarCombos(ByVal cbo As ComboBox, Optional ByVal ID As Integer = 0)
        Select Case cbo.Name
            Case "cboPais"
                Dim paises = (From p In ctx.PAIS.ToList() Select p).ToList()
                cbo.DataSource = paises
                cbo.DisplayMember = "NOMBRE"
                cbo.ValueMember = "IDPAIS"
            Case "cboDepto"
                Dim deptos = (From dept In ctx.DEPARTAMENTOS.ToList() Where dept.IDPAIS = ID Select dept).ToList()
                cbo.DataSource = deptos
                cbo.DisplayMember = "NOMBRE_DEPTO"
                cbo.ValueMember = "IDDEPARTAMENTO"
                cbo.SelectedValue = -1
            Case "cboMunicipio"
                Dim munic = (From mun In ctx.MUNICIPIOS.ToList() Where mun.IDDEPARTAMENTO = ID Select mun).ToList()
                cbo.DataSource = munic
                cbo.DisplayMember = "NOMBRE_MPIO"
                cbo.ValueMember = "IDMUNICIPIO"
                cbo.SelectedValue = -1
            Case "cboSucursales"
                Dim sucur = (From su In ctx.SUCURSALES.ToList() Where su.IDMUNICIPIO = ID Select su).ToList()
                cbo.DataSource = sucur
                cbo.DisplayMember = "NOMBRE"
                cbo.ValueMember = "IDSUCURSAL"
                cbo.SelectedValue = -1
            Case "cboOficinas"
                Dim ofic = (From ofi In ctx.DETALLE_SUCURSAL_OFICINA.ToList()
                            Where ofi.IDSUCURSAL = ID
                            Select ofi.IDDETALLE_SUCURSAL_OFICINA, ofi.OFICINAS.NOMBRE_OFICINA).ToList()

                cbo.DataSource = ofic
                cbo.DisplayMember = "NOMBRE_OFICINA"
                cbo.ValueMember = "IDDETALLE_SUCURSAL_OFICINA"
                cbo.SelectedValue = -1
        End Select
    End Sub

    Public Shared Sub CargarVentanillas(ByVal grid As DataGridView, ByVal ID As Integer)
        Dim vent = (From ve In ctx.VENTANILLAS.ToList()
                    Where ve.IDDETALLE_SUCURSAL_OFICINA = ID
                    Select ve.IDVENTANILLA, Ventanilla = ve.NUMERO_VENTANILLA).ToList()

        grid.DataSource = vent
        grid.Columns(0).Visible = False
    End Sub

    Public Shared Sub AgregarVentanilla(ByVal ventanilla As VENTANILLAS)
        ctx.VENTANILLAS.AddObject(ventanilla)
        ctx.SaveChanges()
    End Sub

    Public Shared Sub CargarGestionesNoAsignadas(ByVal grid As DataGridView, ByVal ido As Integer, ByVal idv As Integer)
        Dim lista As List(Of Decimal) = New List(Of Decimal)

        Using ctx2 As New EntidadesInsert
            Dim ges1 = (From gv In ctx2.GESTIONES_VENTANILLAS Where gv.IDVENTANILLA = idv Select gv.IDDETALLE_GESTION_OFICINA).ToList()
            lista = ges1
        End Using

        Dim ges2 = (From g In ctx.DETALLE_OFICINA_GESTIONES
                       Where g.IDOFICINA = ido AndAlso Not lista.Contains(g.IDDETALLE_OFICINA_GESTION)
                       Select g.IDDETALLE_OFICINA_GESTION, g.GESTIONES.NOMBRE).ToList()

        grid.DataSource = ges2
        grid.Columns(0).Visible = False
    End Sub

#End Region

#Region "Usuarios por Region"

    Public Shared Sub CargarDepartamentos(ByVal grid As DataGridView)
        Dim dep = (From d In ctx.DEPARTAMENTOS.ToList
                       Order By d.CODIGO_DEPTO
                       Select d.IDDEPARTAMENTO, COD = d.CODIGO_DEPTO, Nombre = d.NOMBRE_DEPTO).ToList()
        grid.DataSource = dep
        grid.Columns(0).Visible = False
    End Sub

    Public Shared Sub CargarMunicipiosDep(ByVal grid As DataGridView, ByVal filtro As Integer)
        Dim mun = (From m In ctx.MUNICIPIOS
                    Where m.IDDEPARTAMENTO = filtro
                   Order By m.CODIGO_MPIO
                   Select m.IDMUNICIPIO, COD = m.CODIGO_MPIO, Municipio = m.NOMBRE_MPIO).ToList()
        grid.DataSource = mun
        grid.Columns(0).Visible = False
    End Sub

    Public Shared Sub CargarSucursalesMu(ByVal grid As DataGridView, ByVal filtro As Integer)
        Dim mun = (From m In ctx.SUCURSALES
                    Where m.IDMUNICIPIO = filtro
                   Order By m.NOMBRE
                   Select m.IDSUCURSAL, Nombre = m.NOMBRE).ToList()
        grid.DataSource = mun
        grid.Columns(0).Visible = False
    End Sub

    Public Shared Sub CargarUsuariosSu(ByVal grid As DataGridView, ByVal filtro As Integer)
        Dim mun = (From m In ctx.USUARIOS
                    Where m.DETALLE_SUCURSAL_OFICINA.IDSUCURSAL = filtro
                   Order By m.NOMBRE
                   Select m.IDUSUARIO, Usuario = m.USUARIO, Nombre = m.NOMBRE, Apellidos = m.APELLIDOS, Estado = If(m.ESTADO = 1, True, False)).ToList()
        grid.DataSource = mun
        grid.Columns(0).Visible = False
    End Sub

    Public Shared Sub CargarCboPerfiles(ByVal cbo As ComboBox)
        Dim off = (From o In ctx.PERFILES.ToList Select o).ToList()
        cbo.DataSource = off
        cbo.DisplayMember = "NOMBRE_PERFIL"
        cbo.ValueMember = "IDPERFIL"
        cbo.SelectedIndex = -1
    End Sub

    Public Shared Function AgregarUsuario(ByVal u As USUARIOS)
        Try
            ctx.USUARIOS.AddObject(u)
            ctx.SaveChanges()
            Return u.IDUSUARIO 'Después de SaveChanges(), EntityFramework carga el objeto 'ges' con los datos y así retornamos el ID recien agregado
        Catch ex As UpdateException
            Return ex.Message
        End Try
    End Function

    Public Shared Sub ActualizarUsuario(ByVal idu As Integer, ByVal usuario As String, ByVal nombre As String, _
                                        ByVal apellidos As String, ByVal estado As Integer)
        Dim user As USUARIOS = (From u In ctx.USUARIOS.ToList Where u.IDUSUARIO = idu).SingleOrDefault
        Try
            With user
                .USUARIO = usuario
                .NOMBRE = nombre
                .APELLIDOS = apellidos
                .ESTADO = estado
            End With
            ctx.SaveChanges()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Shared Function SelectUsuario(ByVal id As Integer)
        Dim user As USUARIOS = (From u In ctx.USUARIOS.ToList Where u.IDUSUARIO = id Select u).SingleOrDefault
        Return user
    End Function

    Public Shared Sub CargarPerfiles(ByVal grid As DataGridView, ByVal idu As Integer)
        Dim per = (From p In ctx.PERFILES
                  From u In p.USUARIOS()
                  Where u.IDUSUARIO = idu
                  Select p.IDPERFIL, Perfil = p.NOMBRE_PERFIL)
        grid.DataSource = per
        grid.Columns(0).Visible = False
    End Sub

    Public Shared Sub AgregarPerfilUser(ByVal idu As Integer, ByVal idp As Integer)
        Dim user = (From u In ctx.USUARIOS
                   Where u.IDUSUARIO = idu
                   Select u).SingleOrDefault
        Dim perfil = (From p In ctx.PERFILES
                     Where p.IDPERFIL = idp
                     Select p).SingleOrDefault
        user.PERFILES.Add(perfil)
        ctx.SaveChanges()
    End Sub

    Public Shared Sub QuitarPerfilUser(ByVal idu As Integer, ByVal idp As Integer)
        Dim user = (From u In ctx.USUARIOS
                   Where u.IDUSUARIO = idu
                   Select u).SingleOrDefault
        Dim perfil = (From p In ctx.PERFILES
                     Where p.IDPERFIL = idp
                     Select p).SingleOrDefault
        user.PERFILES.Remove(perfil)
        ctx.SaveChanges()
    End Sub

    Public Shared Sub ActualizarUsuarioPass(ByVal idu As Integer, ByVal pass As String)
        Dim user As USUARIOS = (From u In ctx.USUARIOS.ToList Where u.IDUSUARIO = idu).SingleOrDefault
        Try
            With user
                .CONTRASENA = pass
            End With
            ctx.SaveChanges()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region




End Class
