Public Class frmVincularMarcadores
    Private idArchivo As Integer
    Public Property IdArchivo1 As Integer
        Get
            Return idArchivo
        End Get
        Set(ByVal value As Integer)
            idArchivo = value
        End Set
    End Property

    Private idForm As Integer
    Public Property IdForm1 As Integer
        Get
            Return idForm
        End Get
        Set(ByVal value As Integer)
            idForm = value
        End Set
    End Property


    Private Sub frmVincularMarcadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            EntityTablas.CargarComboCampos(cboCampos, idForm)
            EntityTablas.CargarGridMarcadores(dgvMarcadoresCampos, idArchivo)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If txtMarcador.Text.Trim = Nothing Then
            txtMarcador.Focus()
            Exit Sub
        End If

        If cboCampos.Text = Nothing Then
            cboCampos.Focus()
            Exit Sub
        End If

        EntityTablas.AgregarMarcadores(New MARCADORES With
        {
            .IDARCHIVO = idArchivo,
            .IDCAMPO_FORM = cboCampos.SelectedValue,
            .MARCADOR = txtMarcador.Text
        })

        EntityTablas.CargarGridMarcadores(dgvMarcadoresCampos, idArchivo)
        txtMarcador.Text = ""
        cboCampos.SelectedValue = -1
        txtMarcador.Focus()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim idm As Integer = dgvMarcadoresCampos.CurrentRow().Cells(0).Value
        EntityTablas.EliminarMarcador(idm)
        EntityTablas.CargarGridMarcadores(dgvMarcadoresCampos, idArchivo)
    End Sub
End Class