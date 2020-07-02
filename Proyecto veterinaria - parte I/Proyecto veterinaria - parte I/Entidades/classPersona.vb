Public Class classPersona
    Private _name As String
    Private _ci As Integer
    Private _dir As String
    Private _tel As Integer

    Public Sub altaPersona(ci, name, dir, tel)
        ci = Me._ci
        name = Me._name
        dir = Me._dir
        tel = Me._tel
    End Sub

    Public Sub altaPersona()

    End Sub

    Public Property name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    Public Property ci As Integer
        Get
            Return _ci
        End Get
        Set(value As Integer)
            _ci = value
        End Set
    End Property

    Public Property dir As String
        Get
            Return _dir
        End Get
        Set(value As String)
            _dir = value
        End Set
    End Property

    Public Property tel As Integer
        Get
            Return _tel
        End Get
        Set(value As Integer)
            _tel = value
        End Set
    End Property

End Class
