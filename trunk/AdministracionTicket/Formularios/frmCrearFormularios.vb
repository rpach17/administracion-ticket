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

    Private Sub chkEsGrid_CheckedChanged(sender As Object, e As EventArgs) Handles chkEsGrid.CheckedChanged
        If chkEsGrid.Checked Then
            cboFormPadre.Enabled = True
        Else
            cboFormPadre.Enabled = False
        End If
    End Sub

    Private Sub frmCrearFormularios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboFormPadre.Enabled = False
        panelCampos.Enabled = False
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

        Dim idf As Integer = EntityTablas.AgregarFormulario(New FORMULARIOS With _
                                                            {
                                                                .TITULO = txtTitulo.Text,
                                                                .IDSALTO = IdSalto1,
                                                                .GRID = IIf(chkEsGrid.Checked, 1, 0),
                                                                .FORMULARIO_PADRE = IIf(chkEsGrid.Checked, cboFormPadre.SelectedValue, 0)
                                                            })

                                                         

    End Sub
End Class