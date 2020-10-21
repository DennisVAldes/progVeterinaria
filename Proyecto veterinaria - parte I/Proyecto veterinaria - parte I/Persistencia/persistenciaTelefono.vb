Public Class persistenciaTelefono
    Dim localConn = New Npgsql.NpgsqlConnection

    Public Function altaTelefono(ci As Integer, telefonos As List(Of Integer))

        Try
            Dim conn As New Conexion
            localConn = conn.InitConn
            Dim cadenaDeComandos As String

            Dim cmd As New Npgsql.NpgsqlCommand
            cmd.Connection = localConn

            Dim i = 0
            While i < telefonos.Count

                cadenaDeComandos = "insert into telefono (personaci, telefono) values (@ci, @telefono)"
                cmd.CommandText = cadenaDeComandos
                cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = ci
                cmd.Parameters.Add("@telefono", NpgsqlTypes.NpgsqlDbType.Integer).Value = telefonos.Item(i)

                cmd.ExecuteNonQuery()

                i += 1
            End While

        Catch ex As Exception

        End Try

    End Function
End Class
