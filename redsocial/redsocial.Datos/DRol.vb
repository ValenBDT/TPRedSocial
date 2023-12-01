Imports System.Data.SqlClient

Public Class DRol
    Inherits Conexion
    Public Function Listar() As DataTable
        Try
            Dim Tabla As New DataTable
            Dim Resultado As SqlDataReader
            Dim Comando As New SqlCommand("rol_listar", MyBase.conn)

            Comando.CommandType = CommandType.StoredProcedure

            MyBase.conn.Open()

            Resultado = Comando.ExecuteReader
            Tabla.Load(Resultado)

            MyBase.conn.Close()

            Return Tabla

        Catch ex As Exception
            Throw ex
        End Try

    End Function
End Class
