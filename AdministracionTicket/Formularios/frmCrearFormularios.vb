Public Class frmCrearFormularios
    Private IdSalto As Integer
    Public Property IdSalto1 As Integer
        Get
            Return IdSalto
        End Get
        Set(ByVal value As Integer)
            IdSalto = value
        End Set
    End Property

    Private Titulo As String
    Public Property Titulo1 As String
        Get
            Return Titulo
        End Get
        Set(ByVal value As String)
            Titulo = value
        End Set
    End Property

    ' ID del form retornado al guardar el formulario
    Dim idf As Object = Nothing

    Private Sub chkEsGrid_CheckedChanged(sender As Object, e As EventArgs) Handles chkEsGrid.CheckedChanged
        If chkEsGrid.Checked Then
            EntityTablas.CargarFormsPadres(cboFormPadre, IdSalto)
            cboFormPadre.Enabled = True
        Else
            cboFormPadre.Enabled = False
        End If
    End Sub

    Private Sub frmCrearFormularios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboFormPadre.Enabled = False
        panelCampos.Enabled = False

        lblTitulo.Text = Titulo
    End Sub

    Private Sub btnGuardarForm_Click(sender As Object, e As EventArgs) Handles btnGuardarForm.Click
        If txtTitulo.Text.Trim = "" Then
            txtTitulo.Focus()
            Exit Sub
        End If

        If chkEsGrid.Checked Then
            If cboFormPadre.Text = "" Then
                MsgBox("Seleccione el formulario padre", MsgBoxStyle.Exclamation, "Formulario")
                Exit Sub
            End If
        End If

        Try
            idf = EntityTablas.AgregarFormulario(New FORMULARIOS With _
            {
                .TITULO = txtTitulo.Text,
                .IDSALTO = IdSalto1,
                .GRID = If(chkEsGrid.Checked, 1, 0),
                .ACTIVO = If(chkActivo.Checked, 1, 0),
                .FORMULARIO_PADRE = If(chkEsGrid.Checked, cboFormPadre.SelectedValue, Nothing)
            })

            If TypeOf (idf) Is String Then
                MsgBox(idf.ToString)
            End If

            panelCampos.Enabled = True

            ' Cargar los tipos de campos
            EntityTablas.CargarTiposcampos(cboTiposCampo)
            EntityTablas.CargarValidaciones(cboValidacion)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cboTiposCampo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTiposCampo.SelectedIndexChanged
        If cboTiposCampo.Text = "Lista desplegable" Then
            btnAsignarDatosCampo.Visible = True
        Else
            btnAsignarDatosCampo.Visible = False
        End If
    End Sub

    Private Sub btnAgregarCampo_Click(sender As Object, e As EventArgs) Handles btnAgregarCampo.Click
        Dim msj As String = EntityTablas.AgregarCampos(New CAMPOS_FORM With _
        {
            .IDFORMULARIO = idf,
            .NOMBRE_CAMPO = txtNombreCampo.Text,
            .ETIQUETA = txtEtiqueta.Text,
            .IDTIPO_CAMPO = cboTiposCampo.SelectedValue,
            .LONGITUD = numLogitud.Value,
            .IDVALIDACION = cboValidacion.SelectedValue,
            .MASCARA = txtMascara.Text,
            .REQUERIDO = If(chkRequerido.Checked, 1, 0),
            .SOLO_LECTURA = If(chkSoloLectura.Checked, 1, 0),
            .IDCOMBOBOX = Nothing
        })

        If msj = "OK" Then
            EntityTablas.CargarCamposGrid(dgvCampos, idf)
        Else
            MsgBox(msj)
        End If
    End Sub
End Class