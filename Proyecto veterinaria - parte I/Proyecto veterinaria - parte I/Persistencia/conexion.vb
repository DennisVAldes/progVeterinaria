Public Class conexion

    Public Function initCon() As Npgsql.NpgsqlConnection
        Dim conn as Npgsql.NpgsqlConnection
        Try
            conn = New Npgsql.NpgsqlConnection()
            Dim cadenaDeComandos As String
            
            conn.ConnectionString = cadenaDeComandos
            conn.Open()
            
        Catch ex as exception
            throw ex
            
        End Try
    End Function

End Class
