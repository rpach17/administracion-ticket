﻿Imports Oracle.DataAccess.Client

Module ModuloFunciones

    Structure Sesion
        Public IdUsuario As Integer
        Public Usuario As String
        Public Nombre As String
        Public IdSucursalOficina As Integer
        Public Sucursal As String
        Public Oficina As String
    End Structure

    Public SesionActiva As Sesion

    Public Function SHA1(ByVal strToHash As String) As String
        Using sha1Obj As New Security.Cryptography.SHA1CryptoServiceProvider()
            Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(strToHash)
            bytesToHash = sha1Obj.ComputeHash(bytesToHash)
            Dim strResult As String = ""
            For Each b As Byte In bytesToHash
                strResult += b.ToString("x2")
            Next
            Return strResult
        End Using
    End Function

    Public Function SoloNumeros(ByVal txt As TextBox) As Boolean
        If IsNumeric(txt.Text) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function ProbarConexion(ByVal cadena As String) As Boolean
        Try
            Using conn As New OracleConnection(cadena)
                conn.Open()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function ObtenerDatoGrid(ByVal grid As DataGridView, Optional ByVal columna As Integer = 0)
        Try
            Return grid.CurrentRow().Cells(columna).Value
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
End Module
