Public Class frmOficinas

    Private Sub frmOficinas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EntityTablas.CargarOficinas(dgvOficinas)
        txtOficina.Enabled = False
    End Sub


    Private Sub Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nuevo.Click
        With txtOficina
            .Enabled = True
            .Focus()
        End With
        
    End Sub

    Private Sub Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar.Click
        EntityTablas.AgregarOficina(New OFICINAS() With {.NOMBRE_OFICINA = txtOficina.Text})
        With txtOficina
            .Enabled = False
            .Text = ""
        End With
        EntityTablas.CargarOficinas(dgvOficinas)
    End Sub

    Private Sub Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar.Click
        If MsgBox(String.Format("Desea eliminar la oficina de: {0}", ObtenerDatoGrid(dgvOficinas, 1)), MsgBoxStyle.YesNo, "Eliminar Oficina"
                  ) = MsgBoxResult.Yes Then
            EntityTablas.EliminarOficina(ObtenerDatoGrid(dgvOficinas))
            EntityTablas.CargarOficinas(dgvOficinas)
        End If
    End Sub
End Class