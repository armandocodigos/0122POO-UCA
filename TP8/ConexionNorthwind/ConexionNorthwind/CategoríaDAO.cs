using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using ConexionNorthwind.Properties;

namespace ConexionNorthwind
{
    public static class CategoríaDAO
    {
        public static Categoría FiltrarID(int id)
        {
            Categoría cat = new Categoría();
            string cadena = Resources.cadena_conexion;
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query = "SELECT CategoryID, CategoryName, Description FROM Categories where CategoryID = @idbuscado";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@idbuscado", id);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {		
                        cat.CategoryID = Convert.ToInt32(reader["CategoryID"].ToString());
                        cat.CategoryName = reader["CategoryName"].ToString();
                        cat.Description = reader["Description"].ToString();
                    }
                }
                connection.Close();
            }
            return cat;
        }

        public static List<Categoría> ObtenerCategorías()
        {
            List<Categoría> lista = new List<Categoría>();
            string cadena = Resources.cadena_conexion;
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query = "SELECT CategoryID, CategoryName, Description " + 
                               "FROM Categories ORDER BY CategoryName ASC";
                SqlCommand command = new SqlCommand(query, connection);
                
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Categoría cat = new Categoría();
                        cat.CategoryID = Convert.ToInt32(reader["CategoryID"].ToString());
                        cat.CategoryName = reader["CategoryName"].ToString();
                        cat.Description = reader["Description"].ToString();
                        lista.Add(cat);
                    }
                }
                connection.Close();
            }
            return lista;
        }
        
        public static Categoría FiltrarName(string name)
        {
            Categoría cat = new Categoría();
            string cadena = Resources.cadena_conexion;
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query = "SELECT CategoryID, CategoryName, Description FROM Categories " + 
                               "WHERE CategoryName = @namebuscado";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@namebuscado", name);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {		
                        cat.CategoryID = Convert.ToInt32(reader["CategoryID"].ToString());
                        cat.CategoryName = reader["CategoryName"].ToString();
                        cat.Description = reader["Description"].ToString();
                    }
                }
                connection.Close();
            }
            return cat;
        }
        
        /*public static void AgregarCategoría(string nombre, string descripción)
        {
            string cadena = Resources.cadena_conexion;
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query = "INSERT INTO Categories (CategoryName, Description) " + 
                               "VALUES (@nombre, @descripcion)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@descripcion", descripción);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }*/
        
        public static bool AgregarCategoría(string nombre, string descripción)
        {
            bool resultado = true;
            try
            {
                string cadena = Resources.cadena_conexion;
                using (SqlConnection connection = new SqlConnection(cadena))
                {
                    string query = "INSERT INTO Categories (CategoryName, Description) " + 
                                   "VALUES (@nombre, @descripcion)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@descripcion", descripción);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                resultado = false;
            }
            return resultado;
        }
    }
}