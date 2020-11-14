Public Class LogicaPersona

    Public Sub altaPersona(newPersona As classPersona)

        Try
            Dim persistenciaPersona As New persistenciaPersona
            Dim persistenciaTel As New persistenciaTelefono

            persistenciaPersona.altaPersona(newPersona)
            For index As Integer = 0 To newPersona.Telefonos.Count() - 1
                persistenciaTel.altaTelefono(newPersona.Ci, newPersona.Telefonos(index))
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function checkIfPersonExists(ci As Integer)
        Try
            Dim persistencia = New persistenciaPersona
            Dim persona As New classPersona
            persona = persistencia.getUserByCi(ci)

            If persona.Ci Then
                Return True
            End If

            Return False
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function getPersona(ci As Integer)
        Try
            Dim persistencia = New persistenciaPersona
            Dim persona As New classPersona
            persona = persistencia.getUserByCi(ci)

            Return persona
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function getPersonas()
        Dim personas As New List(Of classPersona)
        Try
            Dim persistencia As New persistenciaPersona

            personas = persistencia.getUsers
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return personas
    End Function

    Public Sub updatePersona(persona As classPersona)
        Try
            Dim persistenciaPersona As New persistenciaPersona
            Dim persistenciaTel As New persistenciaTelefono

            persistenciaPersona.updatePersona(persona)
            persistenciaTel.deleteTelefonos(persona.Ci)

            For index As Integer = 0 To persona.Telefonos.Count() - 1
                persistenciaTel.altaTelefono(persona.Ci, persona.Telefonos(index))
            Next
        Catch ex As Exception

        End Try
    End Sub

    Public Sub deletePersona(ci As Integer)
        Try
            Dim persistenciaPersona As New persistenciaPersona
            Dim persistenciaTel As New persistenciaTelefono

            persistenciaTel.deleteTelefonos(ci)
            persistenciaPersona.deletePersona(ci)

        Catch ex As Exception

        End Try
    End Sub
End Class