Public Class NMensaje

    'Devuelve tabla de mensajes donde hayan participado el usuario A y el usuario B
    Public Function Listar(idA As Integer, idB As Integer) As DataTable
        Try

            Dim Datos As New Datos.DMensaje

            Return Datos.Listar(idA, idB)

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    'Inserta un mensaje
    Public Function Insertar(idEmisor As Integer, idReceptor As Integer, detalle As String) As Boolean
        Try

            Dim Datos As New Datos.DMensaje

            Datos.Insertar(idEmisor, idReceptor, detalle)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Class
