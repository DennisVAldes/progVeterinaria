Public Class persistenciaMascota

    Dim localConn = New Npgsql.NpgsqlConnection

    Public Sub altaMascota(newMascota As classMascota)
        Try
            Dim conn As New Conexion
            localConn = conn.InitConn
            Dim cadenaDeComandos As String

            cadenaDeComandos = "insert into mascota(id, nombre, añonacimiento, personaci) values (@id, @nombre, @añonacimiento, @personaci);"

            Dim cmd As New Npgsql.NpgsqlCommand
            cmd.CommandText = cadenaDeComandos
            cmd.Connection = localConn

            cmd.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = newMascota.id
            cmd.Parameters.Add("@nombre", NpgsqlTypes.NpgsqlDbType.Varchar, 100).Value = newMascota.name
            cmd.Parameters.Add("@añonacimiento", NpgsqlTypes.NpgsqlDbType.Varchar, 100).Value = newMascota.añoNacimiento
            cmd.Parameters.Add("@personaci", NpgsqlTypes.NpgsqlDbType.Integer).Value = newMascota.dueño.Ci

            cmd.ExecuteNonQuery()

        Catch ex As Exception
            Throw ex
        Finally
            localConn.close
        End Try
    End Sub

    Public Function getMascotaById(id As Integer) As classMascota
        Try
            Dim conn As New Conexion
            Dim persistenciaPersona As New persistenciaPersona
            localConn = conn.InitConn

            Dim newMascota As New classMascota

            Dim cmd As New Npgsql.NpgsqlCommand
            cmd.Connection = localConn

            Dim cadenaDeComandos = "select * from mascotas where id = @id"
            cmd.CommandText = cadenaDeComandos

            cmd.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = id

            cmd.ExecuteNonQuery()

            Dim Lector As Npgsql.NpgsqlDataReader = cmd.ExecuteReader

            If Lector.HasRows Then
                Lector.Read()
                Dim persona As New classPersona
                persona = persistenciaPersona.getUserByCi(Convert.ToInt32(Lector(3).ToString))

                newMascota.id = Convert.ToInt32(Lector(0).ToString)
                newMascota.name = Lector(1).ToString
                newMascota.añoNacimiento = Lector(2).ToString
                newMascota.dueño = persona
            End If

            Lector.Close()

            Return newMascota

        Catch ex As Exception
            Throw ex
        Finally
            localConn.close
        End Try
    End Function

    Public Sub updateMascota(newMascota As classMascota)
        Try
            Dim conn As New Conexion
            localConn = conn.InitConn
            Dim cadenaDeComandos As String

            cadenaDeComandos = "UPDATE mascotas SET id = @id, nombre = @nombre, añonacimiento = @añonacimiento, personaci = @personaci where id = @id"

            Dim cmd As New Npgsql.NpgsqlCommand
            cmd.CommandText = cadenaDeComandos
            cmd.Connection = localConn

            cmd.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = newMascota.id
            cmd.Parameters.Add("@nombre", NpgsqlTypes.NpgsqlDbType.Varchar, 100).Value = newMascota.name
            cmd.Parameters.Add("@añonacimiento", NpgsqlTypes.NpgsqlDbType.Varchar, 100).Value = newMascota.añoNacimiento
            cmd.Parameters.Add("@personaci", NpgsqlTypes.NpgsqlDbType.Integer).Value = newMascota.dueño.Ci

            cmd.ExecuteNonQuery()

        Catch ex As Exception
            Throw ex
        Finally
            localConn.close
        End Try
    End Sub

    Public Function getMascotas() As List(Of classMascota)
        Try
            Dim persistenciaPersona As New persistenciaPersona
            Dim mascotas As New List(Of classMascota)

            Dim conn As New Conexion
            localConn = conn.InitConn
            Dim cmd As New Npgsql.NpgsqlCommand
            cmd.Connection = localConn

            Dim cadenaDeComandos = "select * from mascotas"
            cmd.CommandText = cadenaDeComandos

            Dim Lector As Npgsql.NpgsqlDataReader = cmd.ExecuteReader

            If Lector.HasRows Then
                While Lector.Read()
                    Dim persona As New classPersona
                    persona = persistenciaPersona.getUserByCi(Convert.ToInt32(Lector(3).ToString))

                    Dim mascota = New classMascota With {
                        .id = Convert.ToInt32(Lector(0).ToString),
                        .name = Lector(1).ToString,
                        .añoNacimiento = Lector(2).ToString,
                        .dueño = persona
                    }

                    mascotas.Add(mascota)
                End While
            End If

            Lector.Close()

            Return mascotas
        Catch ex As Exception
            Throw ex
        Finally
            localConn.close
        End Try
    End Function

    Public Sub deleteMascota(id As Integer)
        Try
            Dim conn As New Conexion
            localConn = conn.InitConn
            Dim cmd As New Npgsql.NpgsqlCommand
            cmd.Connection = localConn

            Dim cadenaDeComandos = "DELETE FROM mascotas where id = @id"
            cmd.CommandText = cadenaDeComandos
            cmd.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = id

            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            localConn.close
        End Try
    End Sub
End Class