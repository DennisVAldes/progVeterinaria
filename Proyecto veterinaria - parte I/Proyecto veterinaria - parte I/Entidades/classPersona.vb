Public Class classPersona
    Private _name As String
    Private _ci As Integer
    Private _dir As String
    Private _telefonos As List(Of Integer)

    Public Sub altaPersona(ci_ As Integer, name_ As String, dir_ As String, tel_ As List(Of Integer))
        Ci = ci_
        Name = name_
        Dir = dir_
        Telefonos = tel_
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

    Public Property Telefonos As List(Of Integer)
        Get
            Return _telefonos
        End Get
        Set(value As List(Of Integer))
            _telefonos = value
        End Set
    End Property

End Class
