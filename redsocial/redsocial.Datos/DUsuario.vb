Imports System.Data.SqlClient
Imports redsocial.Entidades

Public Class DUsuario
    Inherits Conexion

    Public Function Listar() As DataTable
        Try
            Dim Tabla As New DataTable
            Dim Resultado As SqlDataReader
            Dim Comando As New SqlCommand("usuario_listar", MyBase.conn)

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

    Public Function Buscar(valor As String) As DataTable

        Try
            Dim Tabla As New DataTable
            Dim Resultado As SqlDataReader
            Dim Comando As New SqlCommand("usuario_buscar", MyBase.conn)

            Comando.CommandType = CommandType.StoredProcedure

            Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = valor

            MyBase.conn.Open()

            Resultado = Comando.ExecuteReader
            Tabla.Load(Resultado)

            MyBase.conn.Close()

            Return Tabla
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub Insertar(obj As Usuario)
        Try
            Dim Comando As New SqlCommand("usuario_insertar", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure


            Comando.Parameters.Add("@nombreUsuario", SqlDbType.VarChar).Value = obj.NombreUsuario
            Comando.Parameters.Add("@contraseña", SqlDbType.VarChar).Value = obj.Contraseña
            Comando.Parameters.Add("@idrol", SqlDbType.Int).Value = obj.Idrol

            MyBase.conn.Open()

            Comando.ExecuteNonQuery()

            MyBase.conn.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Actualizar(obj As Usuario)
        Try
            Dim Comando As New SqlCommand("usuario_actualizar", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure

            Comando.Parameters.Add("@idusuario", SqlDbType.Int).Value = obj.Id
            Comando.Parameters.Add("@nombreUsuario", SqlDbType.VarChar).Value = obj.NombreUsuario
            Comando.Parameters.Add("@contraseña", SqlDbType.VarChar).Value = obj.Contraseña
            Comando.Parameters.Add("@idrol", SqlDbType.Int).Value = obj.Idrol

            MyBase.conn.Open()

            Comando.ExecuteNonQuery()

            MyBase.conn.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Eliminar(id As Integer)
        Try
            Dim Comando As New SqlCommand("usuario_eliminar", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@idusuario", SqlDbType.Int).Value = id
            MyBase.conn.Open()
            Comando.ExecuteNonQuery()
            MyBase.conn.Close()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class
