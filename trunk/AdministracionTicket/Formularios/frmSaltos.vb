Imports System.Xml
Public Class frmSaltos
    Dim ido As Integer
    Dim idg As Integer
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

        lblNo.Visible = False
        lblSi.Visible = False
        cboPasoNo.Enabled = False
        cboPasoSi.Enabled = False
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

        EntityTablas.AgregarSalto(New SALTOS With _
        {
            .IDGESTION = idg,
            .NUMERO_SALTO = txtNumPaso.Value, _
            .IDPUESTO = cboPuesto.SelectedValue, _
            .ULTIMOSALTO = If(chkUltimoPaso.Checked, 1, 0), _
            .MINUTOS = txtDuracion.Value, _
            .DECISION = If(chkDecision.Checked, 1, 0), _
            .IDSALTOV = cboPasoSi.SelectedValue, _
            .IDSALTOF = cboPasoNo.SelectedValue
        })

        EntityTablas.CargarSaltos(dgvPasos, idg)
        BuscarEnGrid(dgvPasos, 1, txtNumPaso.Value)
        txtNumPaso.Value += 1
    End Sub
End Class