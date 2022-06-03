using System.Collections.Generic;
using System.Data.SqlClient;
using Blockbuster.Properties;

namespace Blockbuster
{
    public static class UsuarioDAO
    {
        public static Usuario Existe(string nombre, string contraseña)
        {
            string cadena = Resources.cadena_conexion;
            Usuario usu = new Usuario();

            using (SqlConnection connection = new SqlConnection(cadena)){
                string query = "SELECT USUARIO.nombre AS 'usuario', apellido, ROL.nombre AS 'rol' " +
                               "FROM USUARIO " +
                               "INNER JOIN ROL ON ROL.code = USUARIO.id_rol " +
                               "WHERE USUARIO.nombre like @nombre AND " +
                               "apellido like @apellido";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@apellido", contraseña);
                
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader()){
                    while (reader.Read())
                    {
                        usu.nombre = reader["usuario"].ToString();
                        usu.apellido = reader["apellido"].ToString();
                        usu.rol = reader["rol"].ToString();
                    }   }
                connection.Close();
            }
            return usu;
        }
    }
}