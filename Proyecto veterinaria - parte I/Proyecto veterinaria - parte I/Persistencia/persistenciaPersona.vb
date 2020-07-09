Public Class persistenciaPersona

    dim localConn = new npgsql.npgsqlConnection

    public sub altaPersona(newPersona as Persona)
      try
        dim conn = new Conexion
        localConn = conn.initConn
        dim cadenaDeComandos As String

        cadenaDeComandos = "insert into persona(ci, nombre, direccion) values (@ci, @nombre, @direccion);"

        dim cmd as New Npgsql.NpgsqlCommand
        cmd.Connection = localConn
            
            cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = newPersona.Ci
            cmd.Parameters.Add("@nombre", NpgsqlTypes.NpgsqlDbType.Varchar, 100).Value = newPersona.Nombre
            cmd.Parameters.Add("@direccion", NpgsqlTypes.NpgsqlDbType.Varchar, 100).Value = newPersona.Direccion
      catch ex as exception
        throw ex
    end sub
  
End Class
