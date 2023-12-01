Imports System.Data.SqlClient

Public Class Conexion
    Public conn As SqlConnection

    Public Sub New()
        Me.conn = New SqlConnection("Data Source=DESKTOP-7DJ61SU\SQLEXPRESS;Initial Catalog=dbsocial;User ID=sa;Password=admin;Encrypt=True;TrustServerCertificate=True")
    End Sub

End Class


