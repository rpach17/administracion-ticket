﻿Public Class frmSaltos
    Dim ido As Integer
    Dim idgs As Integer
    Dim esNuevo As Boolean
    Dim esNuevoP As Boolean
    Dim idp As Integer
    Dim idpro As Integer
    Dim NombreGestion As String

#Region "Propiedades"
    Public Property Idg1() As Integer
        Get
            Return idgs
        End Get
        Set(ByVal value As Integer)
            idgs = value
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
        Text = String.Format("Pasos del Prcoceso {0}", NombreGestion)

        EntityTablas.CargarPuestos(cboPuesto, EntityTablas.fidOficina(ido))
        EntityTablas.CargarSaltos(dgvPasos, idgs)
        EntityTablas.CargarSaltosCbo(cboPasoNo, idgs)
        EntityTablas.CargarSaltosCbo(cboPasoSi, idgs)

        Try
            idp = dgvPasos.SelectedRows(0).Cells(0).Value
        Catch ex As Exception
            idp = ObtenerDatoGrid(dgvPasos)
        End Try

        lblNo.Visible = False
        lblSi.Visible = False
        cboPasoNo.Enabled = False
        cboPasoSi.Enabled = False
        txtDecision.Enabled = False
        esNuevo = True

        'Botones pasos
        Nuevo.Enabled = True
        Guardar.Enabled = False
        Cancelar.Enabled = False
        If dgvPasos.Rows.Count = 0 Then
            Actualizar.Enabled = False
        End If

    End Sub

    Private Sub chkDecision_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkDecision.CheckedChanged
        If chkDecision.Checked Then
            lblNo.Visible = True
            lblSi.Visible = True
            cboPasoNo.Enabled = True
            cboPasoSi.Enabled = True
            txtDecision.Enabled = True
        Else
            lblNo.Visible = False
            lblSi.Visible = False
            cboPasoNo.Enabled = False
            cboPasoSi.Enabled = False
            txtDecision.Text = ""
            txtDecision.Enabled = False
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

        If chkDecision.Checked Then
            If txtDecision.Text.Trim = "" Then
                txtDecision.Focus()
                Exit Sub
            End If
        End If

        If esNuevo Then 'Nuevo paso
            EntityTablas.AgregarSalto(New SALTOS With _
            {
                .IDGRUPO_SALTOS = idgs,
                .NUMERO_SALTO = txtNumPaso.Value, _
                .IDPUESTO = cboPuesto.SelectedValue, _
                .ULTIMOSALTO = If(chkUltimoPaso.Checked, 1, 0), _
                .MINUTOS = txtDuracion.Value, _
                .DECISION = If(chkDecision.Checked, 1, 0), _
                .IDSALTOV = CDec(If(cboPasoSi.Text = Nothing, -1, cboPasoSi.SelectedValue)), _
                .IDSALTOF = CDec(If(cboPasoNo.Text = Nothing, -1, cboPasoNo.SelectedValue)), _
                .DESCRIPCION_DECISION = txtDecision.Text,
                .DESCRIPCION_SALTO = txtDescripcionPaso.Text
            })

            '.IDSALTOV = If(cboPasoSi.Text = Nothing, -1, cboPasoSi.SelectedValue), _
            '.IDSALTOF = If(cboPasoNo.Text = Nothing, -1, cboPasoNo.SelectedValue)

            'MsgBox(String.Format("{0}:{1}:{2}:{3}", idg, txtNumPaso.Value, If(cboPasoSi.Text = Nothing, -1, cboPasoSi.SelectedValue), If(cboPasoNo.Text = Nothing, -1, cboPasoNo.SelectedValue)))
            'Exit Sub

            EntityTablas.CargarSaltos(dgvPasos, idgs)
            EntityTablas.CargarSaltosCbo(cboPasoNo, idgs)
            EntityTablas.CargarSaltosCbo(cboPasoSi, idgs)

            BuscarEnGrid(dgvPasos, 1, txtNumPaso.Value)
            txtNumPaso.Value += 1

            'CARGAR PROCESOS DEL PASO
            idp = dgvPasos.SelectedRows(0).Cells(0).Value
            txtNumPaso.Enabled = True
        Else 'Actualizar info de paso           
            EntityTablas.ActualizarSalto(idp, txtNumPaso.Value, txtDescripcionPaso.Text, cboPuesto.SelectedValue, If(chkUltimoPaso.Checked, 1, 0), txtDuracion.Value, If(chkDecision.Checked, 1, 0), If(cboPasoSi.Text = Nothing, -1, cboPasoSi.SelectedValue), If(cboPasoNo.Text = Nothing, -1, cboPasoNo.SelectedValue), txtDecision.Text)
            EntityTablas.CargarSaltos(dgvPasos, idgs)
            BuscarEnGrid(dgvPasos, 1, txtNumPaso.Value) ' Para seleccionar nuevamente el paso editado
            MsgBox("Información del paso actualizado!", MsgBoxStyle.Information, String.Format("Paso #{0}", txtNumPaso.Value))
            txtNumPaso.Enabled = True
        End If

        cambiarEstado(False)
    End Sub

    Private Sub Actualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Actualizar.Click
        'idp = ObtenerDatoGrid(dgvPasos) 'ID del salto seleccionado
        idp = dgvPasos.SelectedRows(0).Cells(0).Value
        Dim salto As SALTOS = EntityTablas.obtenerSalto(idp)

        txtNumPaso.Value = salto.NUMERO_SALTO
        txtNumPaso.Enabled = False
        txtDescripcionPaso.Text = salto.DESCRIPCION_SALTO
        cboPuesto.SelectedValue = salto.IDPUESTO
        chkUltimoPaso.Checked = IIf(salto.ULTIMOSALTO = 1, True, False)
        txtDuracion.Value = salto.MINUTOS
        chkDecision.Checked = IIf(salto.DECISION = 1, True, False)

        cboPasoNo.SelectedValue = salto.IDSALTOF
        cboPasoSi.SelectedValue = salto.IDSALTOV
        txtDecision.Text = salto.DESCRIPCION_DECISION

        esNuevo = False

        cambiarEstado(True)
    End Sub

    Private Sub Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nuevo.Click
        esNuevo = True
        cambiarEstado(True)
    End Sub

    Private Sub cambiarEstado(ByVal var As Boolean)
        If var Then
            dgvPasos.Enabled = False
            Nuevo.Enabled = False
            Actualizar.Enabled = False
            'dgvOficinas.Enabled = False
            Guardar.Enabled = True
            Cancelar.Enabled = True
            Eliminar.Enabled = False
        Else
            dgvPasos.Enabled = True
            Nuevo.Enabled = True
            If dgvPasos.Rows.Count > 0 Then
                Actualizar.Enabled = True
            End If
            'dgvOficinas.Enabled = True
            Guardar.Enabled = False
            Cancelar.Enabled = False
            Eliminar.Enabled = True
        End If
    End Sub

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar.Click
        cambiarEstado(False)
        txtNumPaso.Enabled = True
    End Sub

    Private Sub Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar.Click
        If dgvPasos.Rows.Count > 0 Then
            Dim msg As String = String.Format("Este proceso va a eliminar solamente el úlmito paso de ésta gestión{0}{0}¿Está seguro de eliminar este paso?", vbCrLf)
            If MsgBox(msg, MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirme") = MsgBoxResult.Yes Then
                EntityTablas.EliminarSalto(idgs)
                EntityTablas.CargarSaltos(dgvPasos, idgs)
                MsgBox("El paso ha sigo eliminado de la gestión", MsgBoxStyle.Information, "Paso eliminado")
            End If
        End If
    End Sub

    Private Sub dgvPasos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvPasos.CellClick
        idp = ObtenerDatoGrid(dgvPasos)
        EntityTablas.CargarUsuarios(dgvUsuarios, ObtenerDatoGrid(dgvPasos, 1))
        EntityTablas.CargarUsuariosAsignados(dgvAsigUser, ObtenerDatoGrid(dgvPasos))
    End Sub

    Private Sub txtNumProceso_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


    Private Sub dgvPasos_Click(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPasos.CellClick
        'EntityTablas.CargarUsuariosAsignados(dgvAsigUser, ObtenerDatoGrid(dgvPasos))
    End Sub

End Class