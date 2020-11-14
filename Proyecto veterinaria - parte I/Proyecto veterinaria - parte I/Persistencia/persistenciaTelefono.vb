Public Class persistenciaTelefono
    Dim localConn = New Npgsql.NpgsqlConnection

    Public Sub altaTelefono(ci As Integer, telefono As Integer)

        Try
            Dim conn As New Conexion
            localConn = conn.InitConn
            Dim cadenaDeComandos As String

            Dim cmd As New Npgsql.NpgsqlCommand
            cmd.Connection = localConn

            cadenaDeComandos = "insert into telefono (personaci, telefono) values (@ci, @telefono)"
            cmd.CommandText = cadenaDeComandos
            cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = ci
            cmd.Parameters.Add("@telefono", NpgsqlTypes.NpgsqlDbType.Integer).Value = telefono

            cmd.ExecuteNonQuery()

        Catch ex As Exception
            Throw ex
        Finally
            localConn.close
        End Try

    End Sub

    Public Function getTelefonos(ci As Integer) As List(Of Integer)
        Try
            Dim telefonos As New List(Of Integer)

            Dim conn As New Conexion
            localConn = conn.InitConn

            Dim cadenaDeComandos As String

            Dim cmd As New Npgsql.NpgsqlCommand
            cmd.Connection = localConn

            cadenaDeComandos = "select telefono from telefono where personaci = @ci"
            cmd.CommandText = cadenaDeComandos
            cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = ci

            cmd.ExecuteNonQuery()
            Dim Lector As Npgsql.NpgsqlDataReader = cmd.ExecuteReader

            If Lector.HasRows Then
                While Lector.Read()
                    Dim telefono = Lector(0).ToString
                    telefonos.Add(telefono)
                End While
            End If

            Lector.Close()

            Return telefonos
        Catch ex As Exception
            Throw ex
        Finally
            localConn.close
        End Try
    End Function

    Public Sub deleteTelefonos(ci As Integer)
        Try
            Dim conn As New Conexion
            localConn = conn.InitConn

            Dim cadenaDeComandos As String

            Dim cmd As New Npgsql.NpgsqlCommand
            cmd.Connection = localConn

            cadenaDeComandos = "delete from telefono where personaci = @ci"
            cmd.CommandText = cadenaDeComandos
            cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = ci

            cmd.ExecuteNonQuery()

        Catch ex As Exception
            Throw ex
        Finally
            localConn.close
        End Try
    End Sub
End Class
