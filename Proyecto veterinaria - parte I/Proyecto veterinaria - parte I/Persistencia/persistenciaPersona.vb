Public Class persistenciaPersona

    Dim localConn = New Npgsql.NpgsqlConnection

    Public Sub altaPersona(newPersona As classPersona)
        Try
            Dim conn = New Conexion
            localConn = conn.InitConn
            Dim cadenaDeComandos As String

            cadenaDeComandos = "insert into persona(ci, nombre, direccion) values (@ci, @nombre, @direccion);"

            Dim cmd As New Npgsql.NpgsqlCommand
            cmd.CommandText = cadenaDeComandos
            cmd.Connection = localConn

            cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = newPersona.Ci
            cmd.Parameters.Add("@nombre", NpgsqlTypes.NpgsqlDbType.Varchar, 100).Value = newPersona.Name
            cmd.Parameters.Add("@direccion", NpgsqlTypes.NpgsqlDbType.Varchar, 100).Value = newPersona.Dir

            Dim res As Integer
            res = cmd.ExecuteNonQuery()

            If res = 1 Then
                Dim i = 0
                While i < newPersona.Telefonos.Count

                    cadenaDeComandos = "insert into telefonos (personaCi, telefono) values (@ci, @telefono)"

                    cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = newPersona.Ci
                    cmd.Parameters.Add("@telefono", NpgsqlTypes.NpgsqlDbType.Integer).Value = newPersona.Telefonos.Item(i)

                    res = cmd.ExecuteNonQuery()

                    i += 1
                End While
            End If

        Catch ex As Exception
            Throw ex

        End Try
    End Sub

    Public Function getPersona(ci As Integer) As classPersona
        Dim newPersona As classPersona
        Try
            Dim ClaseSnl As New Conexion
            localConn = ClaseSnl.InitConn
            Dim cmd As Npgsql.NpgsqlCommand
            cmd.Connection = localConn

            Dim cadenaDeComandos = "select * from persona where ci = @ci"
            cmd.CommandText = cadenaDeComandos
            cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = ci

            Dim Lector As Npgsql.NpgsqlDataReader = cmd.ExecuteReader

            If Lector.HasRows Then
                Lector.Read()
                newPersona.Ci = Convert.ToInt32(Lector(0).ToString)
                newPersona.Name = Lector(1).ToString
                newPersona.Dir = Lector(2).ToString
            End If
        Catch ex As Exception
            Throw ex
        Finally
            localConn.close
        End Try

        Return newPersona
    End Function


End Class
