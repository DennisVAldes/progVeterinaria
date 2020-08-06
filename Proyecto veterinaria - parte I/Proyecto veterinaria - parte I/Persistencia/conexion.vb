Public Class Conexion

    Public Function initConn() As Npgsql.NpgsqlConnection
        Dim conn As Npgsql.NpgsqlConnection
        Try
            conn = New Npgsql.NpgsqlConnection()
            Dim cadenaDeComandos As String

            conn.ConnectionString = cadenaDeComandos
            conn.Open()

        Catch ex As exception
            Throw ex

        End Try

        Return conn

    End Function

End Class
