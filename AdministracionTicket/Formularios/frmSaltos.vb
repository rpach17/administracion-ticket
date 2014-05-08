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
        lblNo.Visible = False
        lblSi.Visible = False
        cboPasoNo.Enabled = False
        cboPasoSi.Enabled = False
    End Sub

    Private Sub cboPasoNo_CheckedChanged(sender As Object, e As EventArgs) Handles chkDecision.CheckedChanged
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

    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles Guardar.Click
        EntityTablas.AgregarSalto(New SALTOS With {.IDGESTION = idg, .NUMERO_SALTO = txtNumPaso.Value, .IDPUESTO = cboPuesto.SelectedValue,
                                                  .ULTIMOSALTO = IIf(chkUltimoPaso.Checked, 1, 0), .MINUTOS = txtDuracion.Value,
                                                  .DECISION = IIf(chkDecision.Checked, 1, 0), .IDSALTOV = cboPasoSi.SelectedValue,
                                                  .IDSALTOF = cboPasoNo.SelectedValue})
    End Sub
End Class