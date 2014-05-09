Public Class frmContrasenia
    Dim idUsuario As Integer
    Public Property IdUsuario1 As Integer
        Get
            Return idUsuario
        End Get
        Set(ByVal value As Integer)
            idUsuario = value
        End Set
    End Property

    Dim User As USUARIOS

    Private Sub frmContrasenia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            User = EntityTablas.Usuario(idUsuario)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        lblUser.Text = User.USUARIO
        lblNombre.Text = User.NOMBRE
        lblApellidos.Text = User.APELLIDOS
    End Sub


    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        EntityTablas.ActualizarContrasenia(idUsuario, SHA1(txtPass.Text))
        MsgBox("Cambio realizado correctamente", MsgBoxStyle.Information)
        Close()
    End Sub

End Class