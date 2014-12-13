Imports DevExpress.XtraReports.UI

Public Class RibbonMain
    Sub GestionarPanel()
        If XtraTabManager.Pages.Count = 0 Then
            ClientPanel.Visible = True
        Else
            ClientPanel.Visible = False
        End If
    End Sub

    Private Sub XtraTabManager_Page(sender As Object, e As DevExpress.XtraTabbedMdi.MdiTabPageEventArgs) Handles XtraTabManager.PageAdded, XtraTabManager.PageRemoved
        GestionarPanel()
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        With frmGestionesOficina
            .MdiParent = Me
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        With frmVentanillas
            .MdiParent = Me
            .Show()
            .Focus()
        End With
    End Sub
    Private Sub BarButtonItem15_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem15.ItemClick
        With frmConfig
            .MdiParent = Me
            .Show()
            .Focus()
        End With
    End Sub


    Private Sub BarButtonItem7_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        With frmAgregarSucursal
            .MdiParent = Me
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub BarButtonItem8_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        With frmSucursales
            .MdiParent = Me
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub BarButtonItem9_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        With frmOficinas
            .MdiParent = Me
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub BarButtonItem10_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        With frmSucursalesOficinas
            .MdiParent = Me
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub BarButtonItem6_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        frmLogin.Show()
        Close()
    End Sub

    Private Sub BarButtonItem11_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem11.ItemClick
        Close()
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        With frmUsuarios
            .MdiParent = Me
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub BarButtonItem5_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        With frmUsuariosSucursal
            .MdiParent = Me
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub RibbonMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblInfoConexion.Caption = String.Format("{0} ({1})", SesionActiva.Nombre, SesionActiva.Usuario)
        lblInfoUbicacion.Caption = String.Format("{0}, {1}", SesionActiva.Sucursal, SesionActiva.Oficina)
    End Sub

    Private Sub BarButtonItem12_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem12.ItemClick
        With frmGrupoSaltos
            .MdiParent = Me
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub BarButtonItem13_ItemClick1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem13.ItemClick
        frmConfigURL.ShowDialog()
    End Sub

    'Private Sub BarButtonItem14_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem14.ItemClick
    'Using report As New rptUbicacion
    '    Using pr As New ReportPrintTool(report)
    '        pr.ShowPreviewDialog()
    '    End Using
    'End Using
    'End Sub
   
    Private Sub BarButtonItem16_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem16.ItemClick
        With frmAtencionXOficina
            .MdiParent = Me
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub BarButtonItem17_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem17.ItemClick
        With frmTramitesRecibidos
            .MdiParent = Me
            .Show()
            .Focus()
        End With
    End Sub
End Class