Public Class frmCrearFormularios
    Dim NuevoCampo As Boolean
    Dim IdCampo As Integer
    Dim IdCbo As Object

    Dim Editar As Boolean
    Public Property Editar1 As Boolean
        Get
            Return Editar
        End Get
        Set(ByVal value As Boolean)
            Editar = value
        End Set
    End Property

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
    Public Property Idf1 As Object
        Get
            Return idf
        End Get
        Set(ByVal value As Object)
            idf = value
        End Set
    End Property

    Private Sub chkEsGrid_CheckedChanged(sender As Object, e As EventArgs) Handles chkEsGrid.CheckedChanged
        If chkEsGrid.Checked Then
            cboFormPadre.Enabled = True
        Else
            cboFormPadre.Enabled = False
        End If
    End Sub

    Private Sub frmCrearFormularios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EntityTablas.CargarFormsPadres(cboFormPadre, IdSalto)

        If Editar Then
            Dim frm As FORMULARIOS = EntityTablas.LlenarFrmForm(idf)

            txtTitulo.Text = frm.TITULO
            chkActivo.Checked = If(frm.ACTIVO = 1, True, False)
            chkEsGrid.Checked = If(frm.GRID = 1, True, False)

            If frm.FORMULARIO_PADRE IsNot Nothing Then
                cboFormPadre.SelectedValue = frm.FORMULARIO_PADRE
            End If

            EntityTablas.CargarCamposGrid(dgvCampos, idf)
            EntityTablas.CargarTiposcampos(cboTiposCampo)
            EntityTablas.CargarValidaciones(cboValidacion)
            panelCampos.Enabled = True
        Else
            cboFormPadre.Enabled = False
            panelCampos.Enabled = False
        End If

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

        If Editar Then
            EntityTablas.ActualizaFormulario(txtTitulo.Text, chkActivo.Checked, chkEsGrid.Checked, IIf(chkEsGrid.Checked, cboFormPadre.SelectedValue, Nothing), idf)
            MsgBox("Formulario guardado", MsgBoxStyle.Information, "Formulario")
        Else
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
                    Exit Sub
                End If

                panelCampos.Enabled = True
                btnNuevoForm.Visible = True
                btnGuardarForm.Enabled = False
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

        ' Para agregar nuevos campos
        NuevoCampo = True
        EntityTablas.CargarTiposcampos(cboTiposCampo)
        EntityTablas.CargarValidaciones(cboValidacion)
    End Sub

    Private Sub cboTiposCampo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTiposCampo.SelectedIndexChanged
        If cboTiposCampo.Text = "Lista desplegable" Then
            btnAsignarDatosCampo.Visible = True
            numLogitud.Enabled = False
            cboValidacion.Enabled = False
            txtMascara.Enabled = False
            chkSoloLectura.Enabled = False
            chkRequerido.Enabled = False
            btnSubir.Visible = False
            lblArchivo.Visible = False
        ElseIf cboTiposCampo.Text = "Archivo de descarga" Then
            btnAsignarDatosCampo.Visible = False
            numLogitud.Enabled = False
            cboValidacion.Enabled = False
            txtMascara.Enabled = False
            chkSoloLectura.Enabled = False
            btnSubir.Visible = True
            lblArchivo.Visible = True
            lblArchivo.Text = "Archivo de Word"
        Else
            btnAsignarDatosCampo.Visible = False
            numLogitud.Enabled = True
            cboValidacion.Enabled = True
            txtMascara.Enabled = True
            chkSoloLectura.Enabled = True
            btnSubir.Visible = False
            lblArchivo.Visible = False
        End If
    End Sub

    Private Sub btnAgregarCampo_Click(sender As Object, e As EventArgs) Handles btnAgregarCampo.Click
        If Not ValidarFormCampos() Then
            Exit Sub
        End If

        If NuevoCampo Then
            If txtIdComboBox.Text = "" Then
                IdCbo = Nothing
            Else
                IdCbo = Convert.ToDecimal(txtIdComboBox.Text)
            End If

            Dim msj As String = EntityTablas.AgregarCampos(New CAMPOS_FORM With _
                   {
                       .IDFORMULARIO = Convert.ToDecimal(idf),
                       .NOMBRE_CAMPO = txtNombreCampo.Text,
                       .ETIQUETA = txtEtiqueta.Text,
                       .IDTIPO_CAMPO = Convert.ToDecimal(cboTiposCampo.SelectedValue),
                       .IDVALIDACION = IIf(cboValidacion.Text = "", Nothing, Convert.ToDecimal(cboValidacion.SelectedValue)),
                       .LONGITUD = Convert.ToDecimal(numLogitud.Value),
                       .MASCARA = txtMascara.Text,
                       .ORDEN = Convert.ToDecimal(numOrden.Value),
                       .REQUERIDO = IIf(chkRequerido.Checked, Convert.ToDecimal(1), Convert.ToDecimal(0)),
                       .SOLO_LECTURA = IIf(chkRequerido.Checked, Convert.ToDecimal(1), Convert.ToDecimal(0)),
                       .IDCOMBOBOX = IdCbo
                   })

            If msj = "OK" Then
                EntityTablas.CargarCamposGrid(dgvCampos, idf)
                LimpiarControles(txtNombreCampo, txtEtiqueta, txtIdComboBox, cboTiposCampo, cboValidacion, txtMascara, chkRequerido, chkSoloLectura)
                numOrden.Value += 1
                cboTiposCampo.Focus()
            Else
                MsgBox(msj)
            End If
        Else
            If txtIdComboBox.Text = "" Then
                IdCbo = Nothing
            Else
                IdCbo = Convert.ToDecimal(txtIdComboBox.Text)
            End If

            EntityTablas.ActualizarCampo(cboTiposCampo.SelectedValue, _
                                         txtNombreCampo.Text, _
                                         txtEtiqueta.Text, _
                                         numLogitud.Value, _
                                         numOrden.Value, _
                                         cboValidacion.SelectedValue, _
                                         txtMascara.Text, _
                                         IIf(chkRequerido.Checked, 1, 0), _
                                         IIf(chkSoloLectura.Checked, 1, 0), _
                                         IdCbo, _
                                         IdCampo)

            EntityTablas.CargarCamposGrid(dgvCampos, idf)
            BuscarEnGrid(dgvCampos, 0, IdCampo)
            MsgBox("Campo actualizado", MsgBoxStyle.Information, "Formulario")
        End If
    End Sub

    Private Function ValidarFormCampos() As Boolean
        If cboTiposCampo.Text = "" Then
            cboTiposCampo.Focus()
            Return False
        End If

        If txtNombreCampo.Text.Trim = "" Then
            txtNombreCampo.Focus()
            Return False
        End If

        If txtEtiqueta.Text.Trim = "" Then
            txtEtiqueta.Focus()
            Return False
        End If

        If numOrden.Value = 0 Then
            numOrden.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub btnNuevoForm_Click(sender As Object, e As EventArgs) Handles btnNuevoForm.Click
        idf = Nothing
        btnGuardarForm.Enabled = True
        btnNuevoForm.Visible = False
        LimpiarControles(txtTitulo, chkActivo, chkEsGrid, cboFormPadre)
        txtTitulo.Focus()
        LimpiarControles(txtNombreCampo, txtEtiqueta, txtIdComboBox, cboTiposCampo, numOrden, cboValidacion, txtMascara, chkRequerido, chkSoloLectura)
        panelCampos.Enabled = False
    End Sub

    Private Sub btnAsignarDatosCampo_Click(sender As Object, e As EventArgs) Handles btnAsignarDatosCampo.Click
        With frmListasDesplegables
            .Idld1 = txtIdComboBox.Text
            .EsNuevo1 = NuevoCampo
            .ShowDialog()
        End With
    End Sub

    Private Sub dgvCampos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCampos.CellClick
        IdCampo = ObtenerDatoGrid(dgvCampos)
        Dim campo As CAMPOS_FORM = EntityTablas.LlenarCampos(IdCampo)

        cboTiposCampo.SelectedValue = campo.IDTIPO_CAMPO
        txtEtiqueta.Text = campo.ETIQUETA
        txtNombreCampo.Text = campo.NOMBRE_CAMPO
        numLogitud.Value = campo.LONGITUD
        numOrden.Value = campo.ORDEN
        chkRequerido.Checked = IIf(campo.REQUERIDO = 1, True, False)
        chkSoloLectura.Checked = IIf(campo.SOLO_LECTURA = 1, True, False)

        If campo.MASCARA IsNot Nothing Then
            txtMascara.Text = campo.MASCARA
        Else
            txtMascara.Text = Nothing
        End If

        If campo.IDVALIDACION IsNot Nothing Then
            cboValidacion.SelectedValue = campo.IDVALIDACION
        Else
            cboValidacion.SelectedValue = -1
        End If

        If campo.IDCOMBOBOX IsNot Nothing Then
            txtIdComboBox.Text = campo.IDCOMBOBOX
        Else
            txtIdComboBox.Text = Nothing
        End If

        NuevoCampo = False
        btnNuevoCampo.Visible = True
    End Sub

    Private Sub btnNuevoCampo_Click(sender As Object, e As EventArgs) Handles btnNuevoCampo.Click
        btnNuevoCampo.Visible = False
        NuevoCampo = True
        LimpiarControles(txtNombreCampo, txtEtiqueta, txtIdComboBox, cboTiposCampo, cboValidacion, txtMascara, chkRequerido, chkSoloLectura)
        cboTiposCampo.Focus()
    End Sub

    Private Sub btnSubir_Click(sender As Object, e As EventArgs) Handles btnSubir.Click
        OpenF.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenF.Filter = "Archivos de Word| *.doc; *.docx"
        OpenF.FileName = "Seleccione un archivo"

        If OpenF.ShowDialog = Windows.Forms.DialogResult.OK Then
            lblArchivo.Visible = True
            lblArchivo.Text = OpenF.FileName
        End If
    End Sub

End Class