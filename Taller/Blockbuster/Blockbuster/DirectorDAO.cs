using System.Collections.Generic;
using System.Data.SqlClient;
using Blockbuster.Properties;

namespace Blockbuster
{
    public static class DirectorDAO
    {
        public static List<Director> ObtenerTodos()
        {
            string cadena = Resources.cadena_conexion;
            List<Director> lista = new List<Director>();

            using (SqlConnection connection = new SqlConnection(cadena)){
                string query = "SELECT code, nombre, apellido FROM DIRECTOR";
                SqlCommand command = new SqlCommand(query, connection);
                
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader()){
                    while (reader.Read())
                    {
                        Director dir = new Director();
                        dir.code = reader["code"].ToString();
                        dir.nombre = reader["nombre"].ToString();
                        dir.apellido = reader["apellido"].ToString();
                        lista.Add(dir);
                    }   }
                connection.Close();
            }
            return lista;
        }
    }
}