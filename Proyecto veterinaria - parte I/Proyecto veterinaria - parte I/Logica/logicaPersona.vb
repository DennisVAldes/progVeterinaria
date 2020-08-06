Public Class LogicaPersona
    Public Sub altaPersona(newPersona As classPersona)
        Dim persistencia = New persistenciaPersona
        persistencia.altaPersona(newPersona)
    End Sub

    Public Function getPersona(ci As Integer) As classPersona
        Dim persistencia = New persistenciaPersona

        Return persistencia.buscarPersona(ci)

    End Function

End Class