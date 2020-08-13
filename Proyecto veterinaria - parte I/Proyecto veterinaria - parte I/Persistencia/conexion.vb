Public Class Conexion

    Public Function InitConn() As Npgsql.NpgsqlConnection
        Dim conn As Npgsql.NpgsqlConnection
        Try
            conn = New Npgsql.NpgsqlConnection()
            Dim cadenaDeComandos As String = "server=127.0.0.1;port=5432;user id='postgres';password='root';Database=veterinaria"

            conn.ConnectionString = cadenaDeComandos
            conn.Open()

        Catch ex As Exception
            Throw ex

        End Try

        Return conn

    End Function

End Class
