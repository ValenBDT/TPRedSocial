Public Class Mensaje
    Private _idMensaje As Integer
    Private _idEmisor As Integer
    Private _idReceptor As Integer
    Private _detalle As String
    Private _fecha As Date

    Public Property IdMensaje As Integer
        Get
            Return _idMensaje
        End Get
        Set(value As Integer)
            _idMensaje = value
        End Set
    End Property

    Public Property IdEmisor As Integer
        Get
            Return _idEmisor
        End Get
        Set(value As Integer)
            _idEmisor = value
        End Set
    End Property

    Public Property IdReceptor As Integer
        Get
            Return _idReceptor
        End Get
        Set(value As Integer)
            _idReceptor = value
        End Set
    End Property

    Public Property Detalle As String
        Get
            Return _detalle
        End Get
        Set(value As String)
            _detalle = value
        End Set
    End Property

    Public Property Fecha As Date
        Get
            Return _fecha
        End Get
        Set(value As Date)
            _fecha = value
        End Set
    End Property
End Class
