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
        Try
            Dim persistencia = New persistenciaPersona

            Return persistencia.getUserByCi(ci)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

    Public Function checkIfPersonExists(ci As Integer)
        Dim persistencia = New persistenciaPersona
        Dim persona As New classPersona
        persona = persistencia.getUserByCi(ci)

        If persona.Ci Then
            Return True
        End If

        Return False
    End Function

    Public Function getPersonas()
        Try
            Dim persistencia = New persistenciaPersona

            Return persistencia.getUsers
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function
End Class