Imports System.Data.SqlClient

Public Class Conexion
    Public conn As SqlConnection
    ' Establezco conexion con la base de datos (Poner aca la cadena de conexion)
    Public Sub New()
        Me.conn = New SqlConnection("Data Source=Valen;Initial Catalog=dbsocial;User ID=sa;Password=Banegas1234")
    End Sub

End Class


