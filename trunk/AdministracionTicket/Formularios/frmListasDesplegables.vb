Public Class frmListasDesplegables
    Dim EsNuevo As Boolean
    Public Property EsNuevo1 As Boolean
        Get
            Return EsNuevo
        End Get
        Set(ByVal value As Boolean)
            EsNuevo = value
        End Set
    End Property

    Dim idld As Object = Nothing
    Public Property Idld1 As Object
        Get
            Return idld
        End Get
        Set(ByVal value As Object)
            idld = value
        End Set
    End Property


    Private Sub btnAgregarLista_Click(sender As Object, e As EventArgs) Handles btnAgregarLista.Click
        If txtNombreLista.Text.Trim = "" Then
            txtNombreLista.Focus()
            Exit Sub
        End If

        idld = EntityTablas.AgregarListaDesplegable(New LISTA_DESPLEGABLE() With {.DESCRIPCION = txtNombreLista.Text})

        If TypeOf (idld) Is String Then
            MsgBox(idld)
            Exit Sub
        End If

        btnAgregarLista.Enabled = False
        txtNombreLista.Enabled = False
        dgvOpcionesLista.Rows.Clear()
        txtValor.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If idld = Nothing Then
            Exit Sub
        Else
            frmCrearFormularios.txtIdComboBox.Text = CInt(idld)
            Close()
        End If
    End Sub

    Private Sub txtBuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscar.KeyPress
        If e.KeyChar = ChrW(13) Then
            EntityTablas.CargarListasDesplegables(dgvListasDesplegables, txtBuscar.Text)
        End If
    End Sub

    Private Sub frmListasDesplegables_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EntityTablas.CargarListasDesplegables(dgvListasDesplegables)
        If Not EsNuevo Then
            EntityTablas.CargarOpcionesLista(dgvOpcionesLista, idld, txtNombreLista)
        End If
    End Sub

    Private Sub txtValor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtValor.KeyPress, txtTexto.KeyPress
        If e.KeyChar = ChrW(13) Then
            AgregarOpcion()
        End If
    End Sub

    Private Sub btnAgregarOpcion_Click(sender As Object, e As EventArgs) Handles btnAgregarOpcion.Click
        AgregarOpcion()
    End Sub

    Private Sub AgregarOpcion()
        If idld = Nothing Then
            MsgBox("Primer debe ingresar y guardar el nombre de la lista", MsgBoxStyle.Exclamation, "Lista desplegable")
            Exit Sub
        End If

        If txtValor.Text.Trim = "" Then
            txtValor.Focus()
            Exit Sub
        End If

        If txtTexto.Text.Trim = "" Then
            txtTexto.Focus()
            Exit Sub
        End If

        EntityTablas.AgregarOpcionLista(New DETALLE_LISTA_DESPLEGABLE With
        {
            .IDLISTA_DESPLEGABLE = idld,
            .VALOR = txtValor.Text,
            .TEXTO = txtTexto.Text
        })

        EntityTablas.CargarOpcionesLista(dgvOpcionesLista, idld)

        txtValor.Text = ""
        txtTexto.Text = ""
        txtValor.Focus()
    End Sub

    Private Sub dgvListasDesplegables_Click(sender As Object, e As EventArgs) Handles dgvListasDesplegables.Click
        If MsgBox("¿Desea seleccionar esta lista?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirme") = MsgBoxResult.Yes Then
            idld = ObtenerDatoGrid(dgvListasDesplegables)
            EntityTablas.CargarOpcionesLista(dgvOpcionesLista, idld, txtNombreLista)
            TabControl1.SelectedTab = TabPage1
        End If
    End Sub
End Class