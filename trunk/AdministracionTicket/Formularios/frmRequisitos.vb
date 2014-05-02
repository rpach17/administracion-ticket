Public Class frmRequisitos
    Dim IdGestion As Integer
    Public Property IdGestion1() As Integer
        Get
            Return IdGestion
        End Get
        Set(ByVal value As Integer)
            IdGestion = Value
        End Set
    End Property


    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        If btnAgregar.Text = "Agregar" Then
            If txtRequisito.Text.Trim = Nothing Then
                txtRequisito.Focus()
                Exit Sub
            End If

            Dim opt As Integer = IIf(chkOpcional.Checked, 1, 0)

            EntityTablas.AgregarRequisito(New REQUISITOS() With _
            {
                .IDGESTION = IdGestion,
                .NOMBRE_REQUISITO = txtRequisito.Text,
                .OPCIONAL = opt
            })

            EntityTablas.CargarRequisitos(dgvRequisitos, IdGestion)
            LimpiarControles(txtRequisito, chkOpcional)
            txtRequisito.Focus()
        Else

        End If
    End Sub

    Private Sub frmRequisitos_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        EntityTablas.CargarRequisitos(dgvRequisitos, IdGestion)
    End Sub

    Private Sub frmRequisitos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EntityTablas.CargarRequisitos(dgvRequisitos, IdGestion)
    End Sub

    Private Sub dgvRequisitos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvRequisitos.Click
        Dim idr As Integer = ObtenerDatoGrid(dgvRequisitos)
        Dim nombre As String = ObtenerDatoGrid(dgvRequisitos, 1)

    End Sub
End Class