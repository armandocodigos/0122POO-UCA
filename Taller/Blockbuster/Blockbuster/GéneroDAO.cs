using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Blockbuster.Properties;

namespace Blockbuster
{
    public static class GéneroDAO
    {
        public static List<Género> ObtenerTodos()
        {
            string cadena = Resources.cadena_conexion;
            List<Género> lista = new List<Género>();

            using (SqlConnection connection = new SqlConnection(cadena)){
                string query = "SELECT code, nombre FROM GENERO";
                SqlCommand command = new SqlCommand(query, connection);
                
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader()){
                    while (reader.Read())
                    {
                        Género gen = new Género();
                        gen.code = reader["code"].ToString();
                        gen.nombre = reader["nombre"].ToString();
                        lista.Add(gen);
                    }   }
                connection.Close();
            }
            return lista;
        }
    }
}