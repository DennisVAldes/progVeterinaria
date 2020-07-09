Public Class classPersona
    Private _name As String
    Private _ci As Integer
    Private _dir As String
    Private _tel As Integer

    Public Sub altaPersona(ci_ As Integer, name_ As String, dir_ As String, tel_ As Integer)
        ci = ci_
        name = name_
        dir = dir_
        tel = tel_
    End Sub

    Public Sub altaPersona()

    End Sub

    Public Property Name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    Public Property Ci As Integer
        Get
            Return _ci
        End Get
        Set(value As Integer)
            _ci = value
        End Set
    End Property

    Public Property Dir As String
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
