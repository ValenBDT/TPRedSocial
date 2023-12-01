Public Class Usuario
    Private _id As Integer
    Private _nombreUsuario As String
    Private _contraseña As String
    Private _idrol As Integer

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property NombreUsuario As String
        Get
            Return _nombreUsuario
        End Get
        Set(value As String)
            _nombreUsuario = value
        End Set
    End Property

    Public Property Contraseña As String
        Get
            Return _contraseña
        End Get
        Set(value As String)
            _contraseña = value
        End Set
    End Property

    Public Property Idrol As Integer
        Get
            Return _idrol
        End Get
        Set(value As Integer)
            _idrol = value
        End Set
    End Property
End Class
