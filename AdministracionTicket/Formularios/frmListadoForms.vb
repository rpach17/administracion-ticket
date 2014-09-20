Public Class frmListadoForms
    Dim idp As Integer
    Public Property Idp1 As Integer
        Get
            Return idp
        End Get
        Set(ByVal value As Integer)
            idp = value
        End Set
    End Property

    Dim nombrep As String
    Public Property Nombrep1 As String
        Get
            Return nombrep
        End Get
        Set(ByVal value As String)
            nombrep = value
        End Set
    End Property

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            frmCrearFormularios.Close()
        Catch ex As Exception
        End Try

        With frmCrearFormularios
            .MdiParent = Me.MdiParent
            .IdSalto1 = idp
            .Titulo1 = nombrep
            .Editar1 = False
            .Show()
            .Focus()
        End With

        Close()
    End Sub

    Private Sub frmListadoForms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitulo.Text = nombrep
        EntityTablas.CargarFormsSalto(dgvForms, idp)
    End Sub

    Private Sub dgvForms_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvForms.CellClick
        Dim ID As Integer = ObtenerDatoGrid(dgvForms)

        With frmCrearFormularios
            .MdiParent = Me.MdiParent
            .IdSalto1 = idp
            .Titulo1 = nombrep
            .Idf1 = ID
            .Editar1 = True
            .Show()
            .Focus()
        End With

    End Sub
End Class