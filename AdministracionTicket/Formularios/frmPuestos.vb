Public Class frmPuestos
    Dim ido As Integer
    Dim nomOfi As String
    Dim tarea As Integer = 0
    Public Property Ido1() As Integer
        Get
            Return ido
        End Get
        Set(ByVal value As Integer)
            ido = Value
        End Set
    End Property

    Public Property NomOfi1() As String
        Get
            Return nomOfi
        End Get
        Set(ByVal value As String)
            nomOfi = Value
        End Set
    End Property

    Private Sub frmPuestos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Text = String.Format("Puestos de la oficina {0}", nomOfi)
        EntityTablas.CargarPuestos(dgvPuestos, ido)
        txtPuesto.Enabled = False
        Guardar.Enabled = False
        Cancelar.Enabled = False
        txtPuesto.Enabled = False
    End Sub

    Private Sub Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nuevo.Click
        tarea = 1
        cambiarEstado(True)
    End Sub

    Private Sub Actualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Actualizar.Click
        tarea = 2
        txtPuesto.Text = ObtenerDatoGrid(dgvPuestos, 1)
        cambiarEstado(True)
    End Sub

    Private Sub Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar.Click
        If tarea = 1 Then
            EntityTablas.AgregarPuesto(New PUESTO() With {.NOMBRE_PUESTO = txtPuesto.Text, .IDOFICINA = ido})
        ElseIf tarea = 2 Then
            EntityTablas.ActualizarPuesto(ObtenerDatoGrid(dgvPuestos), txtPuesto.Text)
        End If
        cambiarEstado(False)
        EntityTablas.CargarPuestos(dgvPuestos, ido)
    End Sub

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar.Click
        cambiarEstado(False)
    End Sub

    Private Sub Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar.Click
        If MsgBox(String.Format("Desea eliminar el puesto de: {0}", ObtenerDatoGrid(dgvPuestos, 1)), MsgBoxStyle.YesNo, "Eliminar Oficina") = MsgBoxResult.Yes Then
            EntityTablas.EliminarPuesto(ObtenerDatoGrid(dgvPuestos))
            EntityTablas.CargarPuestos(dgvPuestos, ido)
            MsgBox("Puesto eliminado", MsgBoxStyle.Information, "Puesto")
        End If
    End Sub

    Private Sub cambiarEstado(ByVal var As Boolean)
        If var Then
            With txtPuesto
                .Enabled = True
                .Focus()
            End With
            Nuevo.Enabled = False
            Actualizar.Enabled = False
            dgvPuestos.Enabled = False
            Guardar.Enabled = True
            Cancelar.Enabled = True
        Else
            With txtPuesto
                .Enabled = False
                .Text = ""
            End With
            Nuevo.Enabled = True
            Actualizar.Enabled = True
            dgvPuestos.Enabled = True
            Guardar.Enabled = False
            Cancelar.Enabled = False
        End If
    End Sub

End Class