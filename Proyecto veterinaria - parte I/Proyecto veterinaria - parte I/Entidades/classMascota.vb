Public Class classMascota
    Private _id As Integer
    Private _name As String
    Private _añoNacimiento As Integer
    Private _dueño As classPersona

    Public Sub altaMascota(name_ As String, añoNacimiento_ As Integer, dueño_ As classPersona)
        name = name_
        añoNacimiento = añoNacimiento_
        dueño = dueño_
    End Sub

    Public Sub altaMascota()

    End Sub

    Public Property id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    Public Property añoNacimiento As Integer
        Get
            Return _añoNacimiento
        End Get
        Set(value As Integer)
            _añoNacimiento = value
        End Set
    End Property

    Public Property dueño As classPersona
        Get
            Return _dueño
        End Get
        Set(value As classPersona)
            _dueño = value
        End Set
    End Property

End Class
