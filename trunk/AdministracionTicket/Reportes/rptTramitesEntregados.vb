Imports Oracle.DataAccess.Types
Imports Oracle.DataAccess.Client

Public Class rptTramitesEntregados
    Dim cnn As New OracleConnection(My.Settings.MiConexion)

    Public Sub New(depto As String, munic As String, suc As String, ofi As String, Optional idso As Decimal = 0, Optional finicio As String = Nothing, Optional ffin As String = Nothing)

        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        lblDesde.Text = finicio
        lblHasta.Text = ffin


        lblDepto.Text = depto
        lblMunic.Text = munic
        lblSuc.Text = suc
        lblOfi.Text = ofi

        Try
            Using myCMD As New OracleCommand() With {.Connection = cnn, .CommandText = "SP_RTE_TRAMITES_ENTREGADOS", .CommandType = CommandType.StoredProcedure}

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

                Dim lista As List(Of TRAMITES_ENTREGADOS) = New List(Of TRAMITES_ENTREGADOS)

                If reader.HasRows Then
                    While reader.Read
                        Dim objeto As New TRAMITES_ENTREGADOS() With
                        {
                            .NUMFILA = reader("NUMFILA").ToString,
                            .NUM_RECIBO = reader("NUM_RECIBO").ToString,
                            .MONTO_RECIBO = reader("MONTO_RECIBO").ToString,
                            .NOMBRE = reader("NOMBRE").ToString
                        }

                        lista.Add(objeto)
                    End While
                    reader.Close()
                    refCursor.Dispose()
                    BindingSource1.DataSource = lista
                End If
            End Using
        Catch ex As Exception
        Finally
            cnn.Close()
        End Try
    End Sub
End Class