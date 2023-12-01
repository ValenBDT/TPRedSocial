Imports redsocial.Datos
Imports redsocial.Entidades

Public Class NUsuario

    Public Function Listar() As DataTable
        Try
            Dim Datos As New DUsuario()

            Return Datos.Listar()

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function Buscar(valor As String) As DataTable
        Try
            Dim Datos As New DUsuario()

            Return Datos.Buscar(valor)

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

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

End Class
