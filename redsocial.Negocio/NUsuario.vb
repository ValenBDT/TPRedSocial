Imports redsocial.Datos
Imports redsocial.Entidades

Public Class NUsuario
    'Devuelve una datatable con todos los usuarios
    Public Function Listar() As DataTable
        Try
            Dim Datos As New DUsuario()

            Return Datos.Listar()

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    'Busca los usuarios que tengan una cadena en su nombre de usuario o en su nombre de rol
    Public Function Buscar(valor As String) As DataTable
        Try
            Dim Datos As New DUsuario()

            Return Datos.Buscar(valor)

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    'Alta de usuario
    Public Function Insertar(obj As Usuario) As Boolean
        Try
            Dim Datos As New DUsuario
            Datos.Insertar(obj)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    'Actualizacion de usuario
    Public Function Actualizar(obj As Usuario) As Boolean
        Try
            Dim Datos As New DUsuario
            Datos.Actualizar(obj)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    'Eliminacion de usuario
    Public Function Eliminar(id As Integer) As Boolean
        Try
            Dim Datos As New DUsuario
            Datos.Eliminar(id)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    'Valida credenciales de usuario
    Public Function Login(nombreUsuario As String, contraseña As String) As Usuario
        Try
            Dim Datos As New DUsuario()
            Dim User As New Usuario
            Dim Tabla As New DataTable

            Tabla = Datos.Login(nombreUsuario, contraseña)

            If (Tabla.Rows.Count = 1) Then
                User.Id = Tabla.Rows(0).Item(0).ToString
                User.NombreUsuario = Tabla.Rows(0).Item(1).ToString
                User.Rol = Tabla.Rows(0).Item(2).ToString
                User.Idrol = Tabla.Rows(0).Item(3).ToString
                Return User
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    'Busca usuario que tenga x nombre (ayuda a validar que los nombres de usuario sean unicos)
    Public Function BuscarNombreUsuario(nombreUsuario As String) As Boolean
        Try
            Dim Datos As New DUsuario()
            Dim User As New Usuario
            Dim Tabla As New DataTable

            Tabla = Datos.BuscarNombreUsuario(nombreUsuario)

            If (Tabla.Rows.Count = 0) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    'Devuelve todos los contactos de un usuario (contactos serian todos las personas en el sistema, el no aparece como contacto de si mismo)
    Public Function ListarContactos(idUsuario As Integer) As DataTable
        Try
            Dim Datos As New DUsuario()

            Return Datos.ListarContactos(idUsuario)

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    'Busca contacto en base a un valor (se busca en base a nombre de usuario y nombre de rol)
    Public Function BuscarContactos(idUsuario As Integer, valor As String) As DataTable
        Try
            Dim Datos As New DUsuario()

            Return Datos.BuscarContactos(idUsuario, valor)

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
End Class
