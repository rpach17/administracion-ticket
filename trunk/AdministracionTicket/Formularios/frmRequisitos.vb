Imports System.Xml
Public Class frmRequisitos
    Dim IdGestion As Integer
    Dim tarea As Integer = 0

    Public Property IdGestion1() As Integer
        Get
            Return IdGestion
        End Get
        Set(ByVal value As Integer)
            IdGestion = Value
        End Set
    End Property


    Private Sub Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar.Click
        If tarea = 1 Then
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

        ElseIf tarea = 2 Then
            EntityTablas.ActualizarRequisito(ObtenerDatoGrid(dgvRequisitos), IdGestion, txtRequisito.Text, IIf(chkOpcional.Checked, 1, 0))
        End If
        cambiarEstado(False)
        EntityTablas.CargarRequisitos(dgvRequisitos, IdGestion)
        LimpiarControles(txtRequisito, chkOpcional)
        txtRequisito.Focus()
    End Sub

    Private Sub frmRequisitos_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        EntityTablas.CargarRequisitos(dgvRequisitos, IdGestion)
    End Sub


    Private Sub frmRequisitos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EntityTablas.CargarRequisitos(dgvRequisitos, IdGestion)
        Guardar.Enabled = False
        Cancelar.Enabled = False
        txtRequisito.Enabled = False
    End Sub

    Private Sub dgvRequisitos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvRequisitos.Click
        Dim idr As Integer = ObtenerDatoGrid(dgvRequisitos)
        Dim nombre As String = ObtenerDatoGrid(dgvRequisitos, 1)

    End Sub

    Private Sub cambiarEstado(ByVal var As Boolean)
        If var Then
            With txtRequisito
                .Enabled = True
                .Focus()
            End With
            Nuevo.Enabled = False
            Actualizar.Enabled = False
            dgvRequisitos.Enabled = False
            Guardar.Enabled = True
            Cancelar.Enabled = True
        Else
            With txtRequisito
                .Enabled = False
                .Text = ""
            End With
            Nuevo.Enabled = True
            Actualizar.Enabled = True
            dgvRequisitos.Enabled = True
            Guardar.Enabled = False
            Cancelar.Enabled = False
        End If
    End Sub
    
    Private Sub Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nuevo.Click
        tarea = 1
        cambiarEstado(True)
    End Sub

    Private Sub Actualizar_Click(sender As Object, e As EventArgs) Handles Actualizar.Click
        tarea = 2
        txtRequisito.Text = ObtenerDatoGrid(dgvRequisitos, 1)
        chkOpcional.Checked = ObtenerDatoGrid(dgvRequisitos, 2)
        cambiarEstado(True)
    End Sub

    Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles Cancelar.Click
        cambiarEstado(False)
    End Sub

    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        Dim idr As Integer = ObtenerDatoGrid(dgvRequisitos)
        If MsgBox(String.Format("Desea eliminar el requisito: {0}", ObtenerDatoGrid(dgvRequisitos, 1)), MsgBoxStyle.YesNo, "Eliminar Oficina"
                  ) = MsgBoxResult.Yes Then
            EntityTablas.eliminarRequisito(idr)
            EntityTablas.CargarRequisitos(dgvRequisitos, IdGestion)
        End If
    End Sub
End Class