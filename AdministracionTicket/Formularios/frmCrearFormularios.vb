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
        panelCampos.Enabled = True
    End Sub
End Class