﻿Imports redsocial.Datos

Public Class NRol
    'Lista todos los roles
    Public Function Listar() As DataTable
        Try
            Dim Datos As New DRol()

            Return Datos.Listar()

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
End Class
