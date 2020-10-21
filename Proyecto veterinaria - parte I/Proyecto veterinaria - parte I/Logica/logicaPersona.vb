Public Class LogicaPersona

    Public Sub altaPersona(newPersona As classPersona)
        Dim persistenciaPersona As New persistenciaPersona
        Dim persistenciaTel As New persistenciaTelefono

        Try
            persistenciaPersona.altaPersona(newPersona)
            persistenciaTel.altaTelefono(newPersona.Ci, newPersona.Telefonos)
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function getPersona(ci As Integer) As classPersona
        Dim persistencia = New persistenciaPersona

        Return persistencia.getUserByCi(ci)

    End Function

End Class