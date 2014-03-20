Public Class frmVentanillas

    Private Sub frmVentanillas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EntityTablas.CargarCombos(cboPais)
        EntityTablas.CargarCombos(cboDepto, cboPais.SelectedValue)
    End Sub

    Private Sub cboDepto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDepto.SelectedIndexChanged
        Try
            EntityTablas.CargarCombos(cboMunicipio, cboDepto.SelectedValue)
            EntityTablas.CargarVentanillas(dgvVentanillas, 0) 'Para limpiar el grid de Ventanillas
            EntityTablas.CargarCombos(cboOficinas, 0) 'Para limpiar el combo de oficinas
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cboMunicipio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMunicipio.SelectedIndexChanged
        Try
            EntityTablas.CargarCombos(cboSucursales, cboMunicipio.SelectedValue)
            EntityTablas.CargarVentanillas(dgvVentanillas, 0) 'Para limpiar el grid de Ventanillas
            EntityTablas.CargarCombos(cboOficinas, 0) 'Para limpiar el combo de oficinas
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cboSucursales_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSucursales.SelectedIndexChanged
        Try
            EntityTablas.CargarCombos(cboOficinas, cboSucursales.SelectedValue)
            EntityTablas.CargarVentanillas(dgvVentanillas, 0) 'Para limpiar el grid de Ventanillas
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cboOficinas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboOficinas.SelectedIndexChanged
        Try
            EntityTablas.CargarVentanillas(dgvVentanillas, cboOficinas.SelectedValue)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        If nudNumeroVent.Value > 0 AndAlso cboOficinas.Text <> "" Then
            If BuscarEnGrid(dgvVentanillas, 1, nudNumeroVent.Value) Then
                Exit Sub
            End If

            EntityTablas.AgregarVentanilla(New VENTANILLAS() With _
            {
                .IDDETALLE_SUCURSAL_OFICINA = cboOficinas.SelectedValue, _
                .NUMERO_VENTANILLA = nudNumeroVent.Value
            })
            EntityTablas.CargarVentanillas(dgvVentanillas, cboOficinas.SelectedValue)
        End If
    End Sub

    Private Sub dgvVentanillas_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvVentanillas.CellClick
        Dim idv As Integer = ObtenerDatoGrid(dgvVentanillas)

        If idv <> 0 Then
            EntityTablas.CargarGestionesNoAsignadas(dgvGestionesNoAsignadas, cboOficinas.SelectedValue, idv)
            EntityTablas.CargarGestionesAsignadas(dgvGestionesAsignadas, idv)
        End If
    End Sub

    Private Sub dgvGestionesNoAsignadas_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvGestionesNoAsignadas.CellDoubleClick
        Dim idv As Integer = ObtenerDatoGrid(dgvVentanillas)
        EntityTablas.AgregarGestionVentanilla(idv, ObtenerDatoGrid(dgvGestionesNoAsignadas))
        EntityTablas.CargarGestionesNoAsignadas(dgvGestionesNoAsignadas, cboOficinas.SelectedValue, idv)
        EntityTablas.CargarGestionesAsignadas(dgvGestionesAsignadas, idv)
    End Sub

    Private Sub dgvGestionesAsignadas_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvGestionesAsignadas.CellDoubleClick
        Dim idv As Integer = ObtenerDatoGrid(dgvVentanillas)
        EntityTablas.QuitarGestionVentanilla(idv, ObtenerDatoGrid(dgvGestionesAsignadas))
        EntityTablas.CargarGestionesNoAsignadas(dgvGestionesNoAsignadas, cboOficinas.SelectedValue, idv)
        EntityTablas.CargarGestionesAsignadas(dgvGestionesAsignadas, idv)
    End Sub

    Private Sub btnAsignarTodas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsignarTodas.Click
        Dim IDV As Integer = dgvVentanillas.CurrentRow().Cells(0).Value

        For Each fila As DataGridViewRow In dgvGestionesNoAsignadas.Rows
            EntityTablas.AgregarGestionVentanilla(IDV, fila.Cells(0).Value)
        Next
        EntityTablas.CargarGestionesNoAsignadas(dgvGestionesNoAsignadas, cboOficinas.SelectedValue, IDV)
        EntityTablas.CargarGestionesAsignadas(dgvGestionesAsignadas, IDV)
    End Sub

    Private Sub btnAsignarSeleccion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsignarSeleccion.Click
        Dim IDV As Integer = dgvVentanillas.CurrentRow().Cells(0).Value

        For Each fila As DataGridViewRow In dgvGestionesNoAsignadas.Rows
            If fila.Selected Then
                EntityTablas.AgregarGestionVentanilla(IDV, fila.Cells(0).Value)
            End If
        Next
        EntityTablas.CargarGestionesNoAsignadas(dgvGestionesNoAsignadas, cboOficinas.SelectedValue, IDV)
        EntityTablas.CargarGestionesAsignadas(dgvGestionesAsignadas, IDV)
    End Sub

    Private Sub btnQuitarTodas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarTodas.Click
        Dim IDV As Integer = dgvVentanillas.CurrentRow().Cells(0).Value

        For Each fila As DataGridViewRow In dgvGestionesAsignadas.Rows
            EntityTablas.QuitarGestionVentanilla(IDV, fila.Cells(0).Value)
        Next
        EntityTablas.CargarGestionesNoAsignadas(dgvGestionesNoAsignadas, cboOficinas.SelectedValue, IDV)
        EntityTablas.CargarGestionesAsignadas(dgvGestionesAsignadas, IDV)
    End Sub

    Private Sub btnQuitarSeleccion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarSeleccion.Click
        Dim IDV As Integer = dgvVentanillas.CurrentRow().Cells(0).Value

        For Each fila As DataGridViewRow In dgvGestionesAsignadas.Rows
            If fila.Selected Then
                EntityTablas.QuitarGestionVentanilla(IDV, fila.Cells(0).Value)
            End If
        Next
        EntityTablas.CargarGestionesNoAsignadas(dgvGestionesNoAsignadas, cboOficinas.SelectedValue, IDV)
        EntityTablas.CargarGestionesAsignadas(dgvGestionesAsignadas, IDV)
    End Sub
End Class