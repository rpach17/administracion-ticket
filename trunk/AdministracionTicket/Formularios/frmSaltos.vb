Imports System.Xml
Public Class frmSaltos
    Dim ido As Integer
    Dim idg As Integer
    Dim esNuevo As Boolean
    Dim esNuevoP As Boolean
    Dim idp As Integer
    Dim idpro As Integer
    Dim NombreGestion As String

#Region "Propiedades"
    Public Property Idg1() As Integer
        Get
            Return idg
        End Get
        Set(ByVal value As Integer)
            idg = Value
        End Set
    End Property
    Public Property Ido1() As Integer
        Get
            Return ido
        End Get
        Set(ByVal value As Integer)
            ido = Value
        End Set
    End Property
    Public Property NombreGestion1() As String
        Get
            Return NombreGestion
        End Get
        Set(ByVal value As String)
            NombreGestion = Value
        End Set
    End Property
#End Region

    Private Sub frmSaltos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Text = String.Format("Pasos de la gestión {0}", NombreGestion)

        EntityTablas.CargarPuestos(cboPuesto, ido)
        EntityTablas.CargarSaltos(dgvPasos, idg)
        EntityTablas.CargarSaltosCbo(cboPasoNo, idg)
        EntityTablas.CargarSaltosCbo(cboPasoSi, idg)

        Try
            idp = dgvPasos.SelectedRows(0).Cells(0).Value
        Catch ex As Exception
            idp = ObtenerDatoGrid(dgvPasos)
        End Try

        EntityTablas.CargarProcesos(dgvProcesos, idp)

        lblNo.Visible = False
        lblSi.Visible = False
        cboPasoNo.Enabled = False
        cboPasoSi.Enabled = False
        esNuevo = True

        'Botones pasos
        Nuevo.Enabled = False
        'Actualizar.Enabled = False

        'Botones procesos
        GuardarP.Enabled = False
        CancelarP.Enabled = False


    End Sub

    Private Sub cboPasoNo_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkDecision.CheckedChanged
        If chkDecision.Checked Then
            lblNo.Visible = True
            lblSi.Visible = True
            cboPasoNo.Enabled = True
            cboPasoSi.Enabled = True
        Else
            lblNo.Visible = False
            lblSi.Visible = False
            cboPasoNo.Enabled = False
            cboPasoSi.Enabled = False
        End If


    End Sub

    Private Sub Guardar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Guardar.Click
        If txtNumPaso.Value < 1 Then
            txtNumPaso.Focus()
            Exit Sub
        End If

        If txtDuracion.Value < 1 Then
            txtDuracion.Focus()
            Exit Sub
        End If

        If esNuevo Then 'Nuevo paso
            EntityTablas.AgregarSalto(New SALTOS With _
            {
                .IDGESTION = idg,
                .NUMERO_SALTO = txtNumPaso.Value, _
                .IDPUESTO = cboPuesto.SelectedValue, _
                .ULTIMOSALTO = If(chkUltimoPaso.Checked, 1, 0), _
                .MINUTOS = txtDuracion.Value, _
                .DECISION = If(chkDecision.Checked, 1, 0), _
                .IDSALTOV = CDec(If(cboPasoSi.Text = Nothing, -1, cboPasoSi.SelectedValue)), _
                .IDSALTOF = CDec(If(cboPasoNo.Text = Nothing, -1, cboPasoNo.SelectedValue))
            })

            '.IDSALTOV = If(cboPasoSi.Text = Nothing, -1, cboPasoSi.SelectedValue), _
            '.IDSALTOF = If(cboPasoNo.Text = Nothing, -1, cboPasoNo.SelectedValue)

            'MsgBox(String.Format("{0}:{1}:{2}:{3}", idg, txtNumPaso.Value, If(cboPasoSi.Text = Nothing, -1, cboPasoSi.SelectedValue), If(cboPasoNo.Text = Nothing, -1, cboPasoNo.SelectedValue)))
            'Exit Sub

            EntityTablas.CargarSaltos(dgvPasos, idg)
            EntityTablas.CargarSaltosCbo(cboPasoNo, idg)
            EntityTablas.CargarSaltosCbo(cboPasoSi, idg)

            BuscarEnGrid(dgvPasos, 1, txtNumPaso.Value)
            txtNumPaso.Value += 1

            'CARGAR PROCESOS DEL PASO
            idp = dgvPasos.SelectedRows(0).Cells(0).Value
            EntityTablas.CargarProcesos(dgvProcesos, idp)
        Else 'Actualizar info de paso
            If BuscarEnGrid(dgvPasos, 1, txtNumPaso.Value) Then
                Exit Sub
            End If

            EntityTablas.ActualizarSalto(idp, txtNumPaso.Value, cboPuesto.SelectedValue, If(chkUltimoPaso.Checked, 1, 0), txtDuracion.Value, If(chkDecision.Checked, 1, 0), If(cboPasoSi.Text = Nothing, -1, cboPasoSi.SelectedValue), If(cboPasoNo.Text = Nothing, -1, cboPasoNo.SelectedValue))
            EntityTablas.CargarSaltos(dgvPasos, idg)
            MsgBox("Información del paso actualizado!", MsgBoxStyle.Information, String.Format("Paso #{0}", txtNumPaso.Value))
        End If

        cambiarEstado(False)
    End Sub

    Private Sub Actualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Actualizar.Click
        'idp = ObtenerDatoGrid(dgvPasos) 'ID del salto seleccionado
        idp = dgvPasos.SelectedRows(0).Cells(0).Value
        Dim salto As SALTOS = EntityTablas.obtenerSalto(idp)

        txtNumPaso.Value = salto.NUMERO_SALTO
        cboPuesto.SelectedValue = salto.IDPUESTO
        chkUltimoPaso.Checked = IIf(salto.ULTIMOSALTO = 1, True, False)
        txtDuracion.Value = salto.MINUTOS
        chkDecision.Checked = IIf(salto.DECISION = 1, True, False)

        cboPasoNo.SelectedValue = salto.IDSALTOF
        cboPasoSi.SelectedValue = salto.IDSALTOV

        esNuevo = False

        cambiarEstado(True)
    End Sub

    Private Sub Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nuevo.Click
        esNuevo = True
        cambiarEstado(True)
    End Sub

    Private Sub cambiarEstado(ByVal var As Boolean)
        If var Then
            Nuevo.Enabled = False
            Actualizar.Enabled = False
            'dgvOficinas.Enabled = False
            Guardar.Enabled = True
            Cancelar.Enabled = True
        Else
            Nuevo.Enabled = True
            Actualizar.Enabled = True
            'dgvOficinas.Enabled = True
            Guardar.Enabled = False
            Cancelar.Enabled = False
        End If
    End Sub

    Private Sub cambiarEstadoP(ByVal var As Boolean)
        If var Then
            NuevoP.Enabled = False
            ActualizarP.Enabled = False
            'dgvOficinas.Enabled = False
            GuardarP.Enabled = True
            CancelarP.Enabled = True
        Else
            NuevoP.Enabled = True
            ActualizarP.Enabled = True
            'dgvOficinas.Enabled = True
            GuardarP.Enabled = False
            CancelarP.Enabled = False
        End If
    End Sub

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar.Click
        cambiarEstado(False)
    End Sub

    Private Sub Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar.Click
        If dgvPasos.Rows.Count > 0 Then
            Dim msg As String = String.Format("Este proceso va a eliminar solamente el úlmito paso de ésta gestión{0}{0}¿Está seguro de eliminar este paso?", vbCrLf)
            If MsgBox(msg, MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirme") = MsgBoxResult.Yes Then
                EntityTablas.EliminarSalto(idg)
                EntityTablas.CargarSaltos(dgvPasos, idg)
                MsgBox("El paso ha sigo eliminado de la gestión", MsgBoxStyle.Information, "Paso eliminado")
            End If
        End If
    End Sub

    Private Sub dgvPasos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvPasos.Click
        idp = ObtenerDatoGrid(dgvPasos)
        EntityTablas.CargarProcesos(dgvProcesos, idp)
    End Sub

    Private Sub NuevoP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoP.Click
        cambiarEstadoP(True)
        txtNumProceso.Text = Nothing
        txtDescripcion.Text = Nothing
        txtNumProceso.Focus()
        esNuevoP = True
    End Sub

    Private Sub ActualizarP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualizarP.Click
        cambiarEstadoP(True)
        txtNumProceso.Text = ObtenerDatoGrid(dgvProcesos, 1)
        txtDescripcion.Text = ObtenerDatoGrid(dgvProcesos, 2)
        idpro = ObtenerDatoGrid(dgvProcesos)
        esNuevoP = False
    End Sub

    Private Sub GuardarP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarP.Click
        idp = dgvPasos.SelectedRows(0).Cells(0).Value
        If esNuevoP Then
            If BuscarEnGrid(dgvProcesos, 1, txtNumProceso.Text) Then
                Exit Sub
            End If

            'idp = dgvPasos.SelectedRows(0).Cells(0).Value
            EntityTablas.AgregarProceso(New PROCESOS() With { _
                .NUMERO = txtNumProceso.Text, _
                .DESCRIPCION = txtDescripcion.Text, _
                .IDSALTO = idp
            })
            EntityTablas.CargarProcesos(dgvProcesos, idp)
            txtNumProceso.Text = Val(txtNumProceso.Text) + 1
            txtDescripcion.Text = ""
            txtDescripcion.Focus()
        Else
            EntityTablas.ActualizarProceso(idpro, txtNumProceso.Text, txtDescripcion.Text)
            EntityTablas.CargarProcesos(dgvProcesos, idp)
        End If
        cambiarEstadoP(False)
        'txtNumProceso.Text = ""
        'txtDescripcion.Text = ""
    End Sub

    Private Sub CancelarP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarP.Click
        cambiarEstadoP(False)
        txtNumProceso.Text = ""
        txtDescripcion.Text = ""
    End Sub

    Private Sub txtNumProceso_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumProceso.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub EliminarP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarP.Click
        If dgvProcesos.Rows.Count > 0 Then
            Dim msg As String = String.Format("Esta acción va a eliminar solamente el úlmito proceso de este paso{0}{0}¿Está seguro de eliminar este proceso?", vbCrLf)
            'idp = ObtenerDatoGrid(dgvPasos)
            idp = dgvPasos.SelectedRows(0).Cells(0).Value
            If MsgBox(msg, MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirme") = MsgBoxResult.Yes Then
                EntityTablas.EliminarProceso(idp)
                EntityTablas.CargarProcesos(dgvProcesos, idp)
                MsgBox("El proceso ya no es parte del paso", MsgBoxStyle.Information, "Proceso eliminado")
            End If
        End If
    End Sub
End Class
