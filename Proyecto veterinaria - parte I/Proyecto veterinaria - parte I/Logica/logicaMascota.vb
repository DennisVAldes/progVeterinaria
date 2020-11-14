Public Class logicaMascota

    Public Sub altaMascota(newMascota As classMascota)
        Try
            Dim persistenciaMascota As New persistenciaMascota

            persistenciaMascota.altaMascota(newMascota)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function getMascota(id As Integer) As classMascota
        Dim mascota As New classMascota

        Try
            Dim persistenciaMascota As New persistenciaMascota

            mascota = persistenciaMascota.getMascotaById(id)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return Mascota
    End Function

    Public Function checkMascota(id As Integer)
        Try
            Dim persistencia As New persistenciaMascota
            Dim mascota As New classMascota
            mascota = persistencia.getMascotaById(id)

            If mascota.id Then
                Return True
            End If

            Return False
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function getMascotas()
        Dim mascotas As New List(Of classMascota)
        Try
            Dim persistencia As New persistenciaMascota

            mascotas = persistencia.getMascotas
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return mascotas
    End Function

    Public Sub updateMascota(mascota As classMascota)
        Try
            Dim persistenciaMascota As New persistenciaMascota
            Dim persistenciaTel As New persistenciaTelefono

            persistenciaMascota.updateMascota(mascota)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub deleteMascota(id As Integer)
        Try
            Dim persistenciaMascota As New persistenciaMascota

            persistenciaMascota.deleteMascota(id)

        Catch ex As Exception

        End Try
    End Sub
End Class
