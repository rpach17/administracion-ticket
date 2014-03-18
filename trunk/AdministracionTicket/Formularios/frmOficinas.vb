Public Class frmOficinas
    Dim tarea As Integer = 0
    Private Sub frmOficinas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EntityTablas.CargarOficinas(dgvOficinas)
        txtOficina.Enabled = False
        Guardar.Enabled = False
        Cancelar.Enabled = False
    End Sub


    Private Sub Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nuevo.Click
        tarea = 1
        cambiarEstado(True)
    End Sub

    Private Sub Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar.Click
        If tarea = 1 Then
            EntityTablas.AgregarOficina(New OFICINAS() With {.NOMBRE_OFICINA = txtOficina.Text})
        ElseIf tarea = 2 Then
            EntityTablas.ActualizarOficina(ObtenerDatoGrid(dgvOficinas), txtOficina.Text)
        End If
        cambiarEstado(False)
        EntityTablas.CargarOficinas(dgvOficinas)
    End Sub

    Private Sub Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar.Click
        If MsgBox(String.Format("Desea eliminar la oficina de: {0}", ObtenerDatoGrid(dgvOficinas, 1)), MsgBoxStyle.YesNo, "Eliminar Oficina"
                  ) = MsgBoxResult.Yes Then
            EntityTablas.EliminarOficina(ObtenerDatoGrid(dgvOficinas))
            EntityTablas.CargarOficinas(dgvOficinas)
        End If
    End Sub

    Private Sub Actualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Actualizar.Click
        tarea = 2
        txtOficina.Text = ObtenerDatoGrid(dgvOficinas, 1)
        cambiarEstado(True)
    End Sub

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar.Click
        cambiarEstado(False)
    End Sub

    Private Sub cambiarEstado(ByVal var As Boolean)
        If var Then
            With txtOficina
                .Enabled = True
                .Focus()
            End With
            Nuevo.Enabled = False
            Actualizar.Enabled = False
            Guardar.Enabled = True
            Cancelar.Enabled = True
        Else
            With txtOficina
                .Enabled = False
                .Text = ""
            End With
            Nuevo.Enabled = True
            Actualizar.Enabled = True
            Guardar.Enabled = False
            Cancelar.Enabled = False
        End If
    End Sub

End Class