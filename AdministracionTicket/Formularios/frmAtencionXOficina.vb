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
        If cboOficina.Text = "" Then
            Exit Sub
        End If

        pickerHasta2.Value = pickerHasta.Value.AddDays(1)

        'If CheckBox1.Checked Then
        Dim reporte As New rptAtencionXOficina(cboOficina.SelectedValue, pickerDesde.Text, pickerHasta.Text, pickerHasta2.Text)
        DocumentViewer1.DocumentSource = reporte
        reporte.CreateDocument(False)
        'Else
        '    With Form1
        '        .idso = cboOficina.SelectedValue
        '        .finicio = pickerDesde.Text
        '        .ffin = pickerHasta.Text
        '        '.finicio = pickerDesde.Value.ToShortDateString
        '        '.ffin = pickerHasta.Value.ToShortDateString
        '        .ShowDialog()
        '    End With
        'End If
    End Sub
End Class