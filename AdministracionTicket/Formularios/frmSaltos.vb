Imports System.Xml
Public Class frmSaltos
    Dim ido As Integer
    Dim idg As Integer
    Dim esNuevo As Boolean
    Dim idp As Integer

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

    Private Sub frmSaltos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EntityTablas.CargarPuestos(cboPuesto, ido)
        EntityTablas.CargarSaltos(dgvPasos, idg)
        EntityTablas.CargarSaltosCbo(cboPasoNo, idg)
        EntityTablas.CargarSaltosCbo(cboPasoSi, idg)

        lblNo.Visible = False
        lblSi.Visible = False
        cboPasoNo.Enabled = False
        cboPasoSi.Enabled = False
        esNuevo = True

        'Botones
        Nuevo.Enabled = False
        Actualizar.Enabled = False

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
        Else 'Actualizar info de paso
            EntityTablas.ActualizarSalto(idp, txtNumPaso.Value, cboPuesto.SelectedValue, If(chkUltimoPaso.Checked, 1, 0), txtDuracion.Value, If(chkDecision.Checked, 1, 0), If(cboPasoSi.Text = Nothing, -1, cboPasoSi.SelectedValue), If(cboPasoNo.Text = Nothing, -1, cboPasoNo.SelectedValue))
            MsgBox("Información del paso actualizado!", MsgBoxStyle.Information, String.Format("Paso #{0}", txtNumPaso.Value))
        End If

        cambiarEstado(False)
    End Sub

    Private Sub Actualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Actualizar.Click
        idp = ObtenerDatoGrid(dgvPasos) 'ID del salto seleccionado
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

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar.Click
        cambiarEstado(False)
    End Sub

    Private Sub Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar.Click
        idp = ObtenerDatoGrid(dgvPasos)

    End Sub
End Class
