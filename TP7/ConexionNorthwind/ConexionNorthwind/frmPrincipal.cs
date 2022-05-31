using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConexionNorthwind.Properties;

namespace ConexionNorthwind
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            txtCategoriasTodas.Clear();
            
            //1. cadena de conexión
            string cadena = Resources.cadena_conexion;
            //2. conexión a la bdd
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                //3. configurando nuestra consulta SQL
                string query = "SELECT CategoryID, CategoryName, Description " + 
                               "FROM Categories ORDER BY CategoryName ASC";
                SqlCommand command = new SqlCommand(query, connection);
                
                //4.1 abrir la conexión
                connection.Open();
                
                //4.2 ejecutar la consulta SQL
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    //5. manejo de resultados
                    while (reader.Read())
                    {
                        int categoryID = Convert.ToInt32(reader["CategoryID"].ToString());
                        string categoryName = reader["CategoryName"].ToString();
                        string description = reader["Description"].ToString();
                        
                        txtCategoriasTodas.AppendText(categoryID + ": " + categoryName + " - ");
                        txtCategoriasTodas.AppendText(description + Environment.NewLine);
                    }
                }

                //4.3 cerrar la conexión
                connection.Close();
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            txtCategoriaFiltrada.Clear();
            string cadena = Resources.cadena_conexion;
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query = "SELECT CategoryID, CategoryName, Description FROM Categories where CategoryID = @idbuscado";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@idbuscado", Convert.ToInt32(nudCategoryID.Value));

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {		
                        int categoryID = Convert.ToInt32(reader["CategoryID"].ToString());
                        string categoryName = reader["CategoryName"].ToString();
                        string description = reader["Description"].ToString();

                        txtCategoriaFiltrada.AppendText(categoryID + ": " + categoryName + " - ");
                        txtCategoriaFiltrada.AppendText(description + Environment.NewLine);
                    }
                }
                connection.Close();
            }

        }
    }
}