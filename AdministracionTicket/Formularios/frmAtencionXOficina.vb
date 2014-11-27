Imports DevExpress.XtraReports.UI

Public Class frmAtencionXOficina

    Private Sub frmAtencionXOficina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EntityVistas.CargarDeptos(cboDepto)
    End Sub

    Private Sub cboDepto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDepto.SelectedIndexChanged
        Try
            EntityVistas.CargarMpios(cboMunic, cboDepto.SelectedValue)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cboMunic_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMunic.SelectedIndexChanged
        Try
            EntityVistas.CargarSucursales(cboSucursal, cboMunic.SelectedValue)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cboSucursal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSucursal.SelectedIndexChanged
        Try
            EntityVistas.CargarOficinas(cboOficina, cboSucursal.SelectedValue)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Dim reporte As rptAtencionXOficina

        If cboOficina.SelectedValue Is Nothing Then
            reporte = New rptAtencionXOficina()
        Else
            reporte = New rptAtencionXOficina(cboOficina.SelectedValue)
        End If

        DocumentViewer1.DocumentSource = reporte
        reporte.CreateDocument(False)
    End Sub
End Class