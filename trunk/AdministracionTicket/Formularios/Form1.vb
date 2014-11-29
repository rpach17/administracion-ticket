Imports Oracle.DataAccess.Client
Imports Oracle.DataAccess.Types

Public Class Form1
    Public idso As Decimal
    Public finicio As String
    Public ffin As String
    Dim cnn As New OracleConnection(My.Settings.MiConexion)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Using myCMD As New OracleCommand() With {.Connection = cnn, .CommandText = "SP_RTE_ATENCIONXOFICINA", .CommandType = CommandType.StoredProcedure}

                myCMD.Parameters.Add("VIDDETALLE_SUCURSAL_OFICINA", OracleDbType.Int32, 10, Nothing, ParameterDirection.Input).Value = idso
                myCMD.Parameters.Add("DESDE", OracleDbType.NVarchar2, Nothing, ParameterDirection.Input).Value = finicio
                myCMD.Parameters.Add("HASTA", OracleDbType.NVarchar2, Nothing, ParameterDirection.Input).Value = ffin

                Dim refCursor As OracleParameter = New OracleParameter With
                {
                    .OracleDbType = OracleDbType.RefCursor,
                    .Direction = ParameterDirection.Output
                }

                myCMD.Parameters.Add(refCursor)
                cnn.Open()
                myCMD.ExecuteNonQuery()

                Dim cursor As OracleRefCursor = DirectCast(refCursor.Value, OracleRefCursor)
                Dim reader As OracleDataReader = cursor.GetDataReader

                Dim lista As List(Of ATENCION_X_OFICINA) = New List(Of ATENCION_X_OFICINA)

                If reader.HasRows Then
                    While reader.Read
                        Dim objeto As New ATENCION_X_OFICINA() With
                        {
                            .NUMFILA = reader("NUMFILA").ToString,
                            .DEPARTAMENTO = reader("DEPARTAMENTO").ToString,
                            .MUNICIPIO = reader("MUNICIPIO").ToString,
                            .SUCURSAL = reader("SUCURSAL").ToString,
                            .OFICINA = reader("OFICINA").ToString,
                            .NOMBRE_EMPLEADO = reader("NOMBRE_EMPLEADO").ToString,
                            .GESTION = reader("GESTION").ToString,
                            .GESTIONES_ATENDIDAS = reader("GESTIONES_ATENDIDAS"),
                            .PROMEDIO_ESPERA = reader("PROMEDIO_ESPERA"),
                            .PROMEDIO_ATENCION = reader("PROMEDIO_ATENCION")
                        }

                        lista.Add(objeto)
                    End While
                    reader.Close()
                    refCursor.Dispose()
                    DataGridView1.DataSource = lista
                End If
            End Using
        Catch ex As Exception
        Finally
            cnn.Close()
        End Try
    End Sub
End Class