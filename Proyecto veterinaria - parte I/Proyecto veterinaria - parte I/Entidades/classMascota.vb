﻿Public Class classMascota
    Private _name As String
    Private _añoNacimiento As Integer
    Private _ciDueño As Integer

    Public Sub altaMascota(name_ As String, añoNacimiento As Integer, ciDueño As Integer)
        name = name_
        añoNacimiento = añoNacimiento_
        ciDueño = ciDueño_
    End Sub

    Public Sub altaMascota()

    End Sub

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

    Public Property ciDueño As Integer
        Get
            Return _ciDueño
        End Get
        Set(value As Integer)
            _ciDueño = value
        End Set
    End Property

End Class
