Imports System.Data.SqlClient
Imports redsocial.Entidades

Public Class DUsuario
    Inherits Conexion

    'Devuelve una datatable con todos los usuarios
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
    'Busca los usuarios que tengan una cadena en su nombre de usuario o en su nombre de rol
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

    'Alta de usuario
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
    'Actualizacion de usuario
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
    'Eliminacion de usuario
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

    'Valida credenciales de usuario
    Public Function Login(nombreUsuario As String, contraseña As String) As DataTable

        Try

            Dim Comando As New SqlCommand("usuario_login", MyBase.conn)
            Dim Tabla As New DataTable
            Dim Resultado As SqlDataReader


            Comando.CommandType = CommandType.StoredProcedure

            Comando.Parameters.Add("@nombreUsuario", SqlDbType.VarChar).Value = nombreUsuario
            Comando.Parameters.Add("@contraseña", SqlDbType.VarChar).Value = contraseña

            MyBase.conn.Open()

            Resultado = Comando.ExecuteReader

            Tabla.Load(Resultado)

            MyBase.conn.Close()

            Return Tabla

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    'Busca usuario que tenga x nombre (ayuda a validar que los nombres de usuario sean unicos)
    Public Function BuscarNombreUsuario(nombreUsuario As String) As DataTable

        Try
            Dim Tabla As New DataTable
            Dim Resultado As SqlDataReader
            Dim Comando As New SqlCommand("usuario_buscar_nombreusuario", MyBase.conn)

            Comando.CommandType = CommandType.StoredProcedure

            Comando.Parameters.Add("@nombreusuario", SqlDbType.VarChar).Value = nombreUsuario

            MyBase.conn.Open()

            Resultado = Comando.ExecuteReader
            Tabla.Load(Resultado)

            MyBase.conn.Close()

            Return Tabla
        Catch ex As Exception
            Throw ex
        End Try

    End Function
    'Devuelve todos los contactos de un usuario (contactos serian todos las personas en el sistema, el no aparece como contacto de si mismo)
    Public Function ListarContactos(idUsuario As Integer) As DataTable

        Try
            Dim Tabla As New DataTable
            Dim Resultado As SqlDataReader
            Dim Comando As New SqlCommand("usuario_listar_contactos", MyBase.conn)

            Comando.CommandType = CommandType.StoredProcedure

            Comando.Parameters.Add("@idusuario", SqlDbType.Int).Value = idUsuario

            MyBase.conn.Open()

            Resultado = Comando.ExecuteReader
            Tabla.Load(Resultado)

            MyBase.conn.Close()

            Return Tabla
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    'Busca contacto en base a un valor (se busca en base a nombre de usuario y nombre de rol)
    Public Function BuscarContactos(idUsuario As Integer, valor As String) As DataTable

        Try
            Dim Tabla As New DataTable
            Dim Resultado As SqlDataReader
            Dim Comando As New SqlCommand("usuario_buscar_contactos", MyBase.conn)

            Comando.CommandType = CommandType.StoredProcedure

            Comando.Parameters.Add("@idusuario", SqlDbType.Int).Value = idUsuario
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

End Class
