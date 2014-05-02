Public Class frmGestionesOficina
    Dim _idgestion As Integer

    Private Sub frmGestionesOficina_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EntityTablas.CargarOficinas(cboOficina)
    End Sub

    Private Function ValidarForm() As Boolean
        If txtCodigo.Text.Trim = "" Then
            MsgBox("Debe ingresar el código de la gestión", MsgBoxStyle.Exclamation, "Código")
            txtCodigo.Focus()
            Return False
        End If

        If txtGestion.Text.Trim = "" Then
            MsgBox("Debe ingresar el nombre de la gestión", MsgBoxStyle.Exclamation, "Nombre")
            txtGestion.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        If Not ValidarForm() Then
            Exit Sub
        End If

        If btnAgregar.Text = "Agregar gestión" Then
            Dim ID As Integer = EntityTablas.AgregarGestion(New GESTIONES() With _
           {
               .CODIGO = txtCodigo.Text, _
               .NOMBRE = txtGestion.Text, _
               .TIEMPO = txtTiempo.Value _
           })

            EntityTablas.AgregarOFGE(New DETALLE_OFICINA_GESTIONES() With _
            {
                .IDOFICINA = cboOficina.SelectedValue, _
                .IDGESTION = ID _
            })

            EntityTablas.CargarGestionesXOficinas(dgvGestionesXOficina, cboOficina.SelectedValue)
            LimpiarControles(txtCodigo, txtGestion, txtTiempo)
            txtCodigo.Focus()
        Else
            EntityTablas.ActualizarGestion(_idgestion, txtCodigo.Text, txtGestion.Text, txtTiempo.Value)
            EntityTablas.CargarGestionesXOficinas(dgvGestionesXOficina, cboOficina.SelectedValue)
            LimpiarControles(txtCodigo, txtGestion, txtTiempo)
            MsgBox("Los datos de la gestión se actualizaron con éxito", MsgBoxStyle.Information, "Gestión")
            btnAgregar.Text = "Agregar gestión"
        End If
    End Sub

    Private Sub cboOficina_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboOficina.SelectedIndexChanged
        Try
            EntityTablas.CargarGestionesXOficinas(dgvGestionesXOficina, cboOficina.SelectedValue)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dgvGestionesXOficina_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvGestionesXOficina.DoubleClick
        _idgestion = ObtenerDatoGrid(dgvGestionesXOficina)
        Dim _codigo As String = ObtenerDatoGrid(dgvGestionesXOficina, 1)
        Dim _gestion As String = ObtenerDatoGrid(dgvGestionesXOficina, 2)
        Dim _tiempo As Integer = ObtenerDatoGrid(dgvGestionesXOficina, 3)

        txtCodigo.Text = _codigo
        txtGestion.Text = _gestion
        txtTiempo.Value = _tiempo

        btnAgregar.Text = "Actualizar gestión"
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarToolStripMenuItem.Click
        EntityTablas.EliminarGestion(ObtenerDatoGrid(dgvGestionesXOficina))
        EntityTablas.CargarGestionesXOficinas(dgvGestionesXOficina, cboOficina.SelectedValue)
    End Sub

    Private Sub dgvGestionesXOficina_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgvGestionesXOficina.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            With dgvGestionesXOficina
                Dim Hiselect As DataGridView.HitTestInfo = .HitTest(e.X, e.Y)
                If Hiselect.Type = DataGridViewHitTestType.Cell Then
                    .CurrentCell = .Rows(Hiselect.RowIndex).Cells(Hiselect.ColumnIndex)
                End If
            End With
        End If
    End Sub


    Private Sub RequisitosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RequisitosToolStripMenuItem.Click
        Dim idg As Integer = ObtenerDatoGrid(dgvGestionesXOficina)

        With frmRequisitos
            .IdGestion1 = idg
            .ShowDialog()
        End With
    End Sub
End Class