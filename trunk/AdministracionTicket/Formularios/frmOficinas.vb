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
        Dim ID As Integer = ObtenerDatoGrid(dgvOficinas)
        If tarea = 1 Then
            EntityTablas.AgregarOficina(New OFICINAS() With {.NOMBRE_OFICINA = txtOficina.Text})
        ElseIf tarea = 2 Then
            EntityTablas.ActualizarOficina(ID, txtOficina.Text)
        End If
        cambiarEstado(False)
        EntityTablas.CargarOficinas(dgvOficinas)
        BuscarEnGrid(dgvOficinas, 0, ID)
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
            dgvOficinas.Enabled = False
            Guardar.Enabled = True
            Cancelar.Enabled = True
            Eliminar.Enabled = False
        Else
            With txtOficina
                .Enabled = False
                .Text = ""
            End With
            Nuevo.Enabled = True
            Actualizar.Enabled = True
            dgvOficinas.Enabled = True
            Guardar.Enabled = False
            Cancelar.Enabled = False
            Eliminar.Enabled = True
        End If
    End Sub

    Private Sub PuestosDeEstaOficinaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PuestosDeEstaOficinaToolStripMenuItem.Click
        Dim ido As Integer = ObtenerDatoGrid(dgvOficinas)
        Dim nombreOfi As String = ObtenerDatoGrid(dgvOficinas, 1)

        With frmPuestos
            .Ido1 = ido
            .NomOfi1 = nombreOfi
            .ShowDialog()
        End With
    End Sub
End Class