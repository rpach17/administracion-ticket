Public Class frmGrupoSaltos
    Private _idGestion As Integer
    Private _sucursal As String
    Private _idSucursal As Integer

#Region "Propiedades"
    Public Property IdSucursal As Integer
        Get
            Return _idSucursal
        End Get
        Set(ByVal Value As Integer)
            _idSucursal = Value
        End Set
    End Property

    Public Property Sucursal As String
        Get
            Return _sucursal
        End Get
        Set(ByVal Value As String)
            _sucursal = Value
        End Set
    End Property

    Public Property IdGestion As Integer
        Get
            Return _idGestion
        End Get
        Set(ByVal Value As Integer)
            _idGestion = Value
        End Set
    End Property
#End Region
    
    Private Sub btnBuscarS_Click(sender As Object, e As EventArgs) Handles btnBuscarS.Click
        frmSucursalesBusqueda.ShowDialog()
        txtSucursal.Text = Sucursal
        EntityTablas.CargarSucursalesOfi(cboOficina, IdSucursal)

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If txtDescripcion.Text.Length > 5 Then
            EntityTablas.AgregarGrupoSalto(New GRUPO_SALTOS With _
                                           {
                                           .DESCRIPCION = txtDescripcion.Text,
                                           .ACTIVO = IIf(chkActivo.Checked, 1, 0),
                                           .IDDETALLE_SUCURSAL_OFICINA = cboOficina.SelectedValue,
            .IDGESTION = IdGestion
                                       })
        Else
            MsgBox("Le falta una descripción")
        End If
        EntityTablas.CargarGrupoSaltos(dgvGrupoSaltos, IdGestion, cboOficina.SelectedValue)
    End Sub

    Private Sub cboOficina_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboOficina.SelectedIndexChanged
        Try
            EntityTablas.CargarCboGestiones(cboGestiones, cboOficina.SelectedValue)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cboGestiones_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGestiones.SelectedIndexChanged
        EntityTablas.CargarGrupoSaltos(dgvGrupoSaltos, cboGestiones.SelectedValue, cboOficina.SelectedValue)
    End Sub

    Private Sub dgvGrupoSaltos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGrupoSaltos.CellClick
        '        MsgBox(String.Format("Este es id del grupo de saltos {0}", ObtenerDatoGrid(dgvGrupoSaltos)))
        Try
            frmSaltos.Close()
        Catch ex As Exception

        End Try
        With frmSaltos
            .MdiParent = RibbonMain
            .NombreGestion1 = ObtenerDatoGrid(dgvGrupoSaltos, 1)
            .Ido1 = cboOficina.SelectedValue
            .Idg1 = ObtenerDatoGrid(dgvGrupoSaltos)
            .Show()
            .Focus()
        End With
    End Sub
End Class