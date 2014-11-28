Public Class Form1
    Public idso As Decimal
    Public finicio As String
    Public ffin As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim ctx As New EntidadesVistas(My.Settings.CadenaAPPCAVistas)
            Dim datos = ctx.SP_RTE_ATENCIONXOFICINA1(idso, finicio, ffin)
            DataGridView1.DataSource = datos
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        
    End Sub
End Class