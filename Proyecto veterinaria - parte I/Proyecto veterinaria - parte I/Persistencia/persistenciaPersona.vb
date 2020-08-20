Public Class persistenciaPersona

    Dim localConn = New Npgsql.NpgsqlConnection

    Public Sub altaPersona(newPersona As classPersona)
        Try
            Dim conn As New Conexion
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

                    cadenaDeComandos = "insert into telefono (personaci, telefono) values (@ci, @telefono)"
                    cmd.CommandText = cadenaDeComandos
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

    Public Function getUserByCi(ci As Integer) As classPersona
        Dim newPersona As New classPersona
        Try
            Dim conn As New Conexion
            localConn = conn.InitConn
            Dim cmd As New Npgsql.NpgsqlCommand
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

    Public Function getUsers() As List(Of classPersona)
        Dim list As New List(Of classPersona)
        Try
            Dim conn As New Conexion
            localConn = conn.InitConn
            Dim cmd As New Npgsql.NpgsqlCommand
            cmd.Connection = localConn

            Dim cadenaDeComandos = "select * from persona"
            cmd.CommandText = cadenaDeComandos

            Dim Lector As Npgsql.NpgsqlDataReader = cmd.ExecuteReader

            If Lector.HasRows Then
                While Lector.Read()
                    Dim user As New classPersona
                    user.Ci = Convert.ToInt32(Lector(0).ToString)
                    user.Name = Lector(1).ToString
                    user.Dir = Lector(2).ToString

                    list.Add(user)
                End While
            End If
        Catch ex As Exception
            Throw ex
        Finally
            localConn.close
        End Try

        Return list
    End Function

End Class