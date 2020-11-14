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

            cmd.ExecuteNonQuery()

        Catch ex As Exception
            Throw ex
        Finally
            localConn.close
        End Try
    End Sub

    Public Function getUserByCi(ci As Integer) As classPersona
        Try
            Dim conn As New Conexion
            localConn = conn.InitConn

            Dim newPersona As New classPersona

            Dim cmd As New Npgsql.NpgsqlCommand
            cmd.Connection = localConn

            Dim cadenaDeComandos = "select * from persona where ci = @ci"
            cmd.CommandText = cadenaDeComandos

            cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = ci

            cmd.ExecuteNonQuery()

            Dim Lector As Npgsql.NpgsqlDataReader = cmd.ExecuteReader

            If Lector.HasRows Then
                Lector.Read()
                newPersona.Ci = Convert.ToInt32(Lector(0).ToString)
                newPersona.Name = Lector(1).ToString
                newPersona.Dir = Lector(2).ToString
            End If

            Lector.Close()

            Return newPersona

        Catch ex As Exception
            Throw ex
        Finally
            localConn.close
        End Try
    End Function

    Public Sub updatePersona(newPersona As classPersona)
        Try
            Dim conn As New Conexion
            localConn = conn.InitConn
            Dim cadenaDeComandos As String

            cadenaDeComandos = "UPDATE persona SET ci = @ci, nombre = @nombre, direccion = @direccion  where ci = @ci"

            Dim cmd As New Npgsql.NpgsqlCommand
            cmd.CommandText = cadenaDeComandos
            cmd.Connection = localConn

            cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = newPersona.Ci
            cmd.Parameters.Add("@nombre", NpgsqlTypes.NpgsqlDbType.Varchar, 100).Value = newPersona.Name
            cmd.Parameters.Add("@direccion", NpgsqlTypes.NpgsqlDbType.Varchar, 100).Value = newPersona.Dir

            cmd.ExecuteNonQuery()

        Catch ex As Exception
            Throw ex
        Finally
            localConn.close
        End Try
    End Sub

    Public Function getUsers() As List(Of classPersona)
        Try
            Dim personas As New List(Of classPersona)

            Dim conn As New Conexion
            localConn = conn.InitConn
            Dim cmd As New Npgsql.NpgsqlCommand
            cmd.Connection = localConn

            Dim cadenaDeComandos = "select * from persona"
            cmd.CommandText = cadenaDeComandos

            Dim Lector As Npgsql.NpgsqlDataReader = cmd.ExecuteReader

            If Lector.HasRows Then
                While Lector.Read()
                    Dim persona = New classPersona With {
                        .Ci = Convert.ToInt32(Lector(0).ToString),
                        .Name = Lector(1).ToString,
                        .Dir = Lector(2).ToString
                    }

                    personas.Add(persona)
                End While
            End If

            Lector.Close()

            Return personas
        Catch ex As Exception
            Throw ex
        Finally
            localConn.close
        End Try
    End Function

    Public Sub deletePersona(ci As Integer)
        Try
            Dim conn As New Conexion
            localConn = conn.InitConn
            Dim cmd As New Npgsql.NpgsqlCommand
            cmd.Connection = localConn

            Dim cadenaDeComandos = "DELETE FROM persona where ci = @ci"
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