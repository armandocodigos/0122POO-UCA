using System;
using System.Data.SqlClient;
using LoginCONIA.Properties;

namespace LoginCONIA
{
    public static class UsuarioDAO
    {
        public static bool CrearNuevo(Usuario u)
        {
            bool exito = true;
            try {
                string cadena = Resources.cadena_conexion;
                using (SqlConnection connection = new SqlConnection(cadena)){
                    string query = "INSERT INTO USUARIO (usuario, contra, f_nacimiento) VALUES " + 
                                   "(@usuario, @contra, @fecha)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@usuario", u.usuario);
                    command.Parameters.AddWithValue("@contra", u.contra);
                    command.Parameters.AddWithValue("@fecha", u.f_nacimiento);
                    
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception) {
                exito = false;
            }
            return exito;
        }

        public static Usuario BuscarUsuario(string usuario, DateTime nacimiento)
        {
            string cadena = Resources.cadena_conexion;
            Usuario u = null;

            using (SqlConnection connection = new SqlConnection(cadena)){
                string query = "SELECT id, usuario, f_nacimiento FROM USUARIO " +
                               "WHERE usuario = @usuario AND f_nacimiento = @nacimiento";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@usuario", usuario);
                command.Parameters.AddWithValue("@nacimiento", nacimiento);
                
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader()){
                    while (reader.Read())
                    {
                        u = new Usuario();
                        u.id = Convert.ToInt32(reader["id"].ToString());
                        u.usuario = reader["usuario"].ToString();
                        u.f_nacimiento = Convert.ToDateTime(reader["f_nacimiento"].ToString());
                    }   }
                connection.Close();
            }
            return u;
        }

        public static bool Actualizar(Usuario u)
        {
            bool exito = true;
            try {
                string cadena = Resources.cadena_conexion;
                using (SqlConnection connection = new SqlConnection(cadena)){
                    string query = "UPDATE USUARIO SET contra = @nuevacontra WHERE id = @id";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nuevacontra", u.contra);
                    command.Parameters.AddWithValue("@id", u.id);
               
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception) {
                exito = false;
            }
            return exito;
        }
    }
}