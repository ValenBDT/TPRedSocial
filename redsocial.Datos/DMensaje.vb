Imports System.Data.SqlClient

Public Class DMensaje
    Inherits Conexion

    'Devuelve tabla de mensajes donde hayan participado el usuario A y el usuario B
    Public Function Listar(idA As Integer, idB As Integer) As DataTable

        Try

            Dim Comando As New SqlCommand("mensaje_listar", MyBase.conn)
            Dim Tabla As New DataTable
            Dim Respuesta As SqlDataReader

            Comando.CommandType = CommandType.StoredProcedure

            Comando.Parameters.Add("@idA", SqlDbType.Int).Value = idA
            Comando.Parameters.Add("@idB", SqlDbType.Int).Value = idB

            MyBase.conn.Open()

            Respuesta = Comando.ExecuteReader

            Tabla.Load(Respuesta)


            MyBase.conn.Close()
            Return Tabla

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    'Inserta un mensaje
    Public Sub Insertar(idEmisor As Integer, idReceptor As Integer, detalle As String)
        Try

            Dim Comando As New SqlCommand("mensaje_insertar", MyBase.conn)

            Comando.CommandType = CommandType.StoredProcedure

            Comando.Parameters.Add("@idEmisor", SqlDbType.Int).Value = idEmisor
            Comando.Parameters.Add("@idReceptor", SqlDbType.Int).Value = idReceptor
            Comando.Parameters.Add("@detalle", SqlDbType.VarChar).Value = detalle
            MyBase.conn.Open()
            Comando.ExecuteNonQuery()
            MyBase.conn.Close()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

End Class
