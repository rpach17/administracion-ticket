Public Class frmSaltos
    Dim ido As Integer
    Dim idg As Integer
    Public Property Idg1() As Integer
        Get
            Return idg
        End Get
        Set(ByVal value As Integer)
            idg = Value
        End Set
    End Property
    Public Property Ido1() As Integer
        Get
            Return ido
        End Get
        Set(ByVal value As Integer)
            ido = Value
        End Set
    End Property

    Private Sub frmSaltos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EntityTablas.CargarPuestos(cboPuesto, ido)
    End Sub
End Class