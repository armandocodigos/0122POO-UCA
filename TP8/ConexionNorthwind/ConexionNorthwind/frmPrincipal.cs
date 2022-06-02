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

        //Esto enlazaba con el TextBox (que se sustituyó por un DataGridView)
        /*private void btnCategorias_Click(object sender, EventArgs e)
        {
            txtCategoriasTodas.Clear();
            List<Categoría> lista = CategoríaDAO.ObtenerCategorías();
            foreach (Categoría cat in lista)
            {
                txtCategoriasTodas.AppendText(cat.CategoryID + ": " + cat.CategoryName + " - ");
                txtCategoriasTodas.AppendText(cat.Description + Environment.NewLine);
            }
        }*/
        
        private void btnCategorias_Click(object sender, EventArgs e)
        {
            dgvCategorías.DataSource = null;
            dgvCategorías.DataSource = CategoríaDAO.ObtenerCategorías();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            txtCategoriaFiltrada.Clear();
            int id = Convert.ToInt32(nudCategoryID.Value);
            Categoría cat = CategoríaDAO.FiltrarID(id);
            
            txtCategoriaFiltrada.AppendText(cat.CategoryID + ": " + cat.CategoryName + " - ");
            txtCategoriaFiltrada.AppendText(cat.Description + Environment.NewLine);
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            cmbCategoryName.DataSource = null;
            cmbCategoryName.ValueMember = "CategoryID";
            cmbCategoryName.DisplayMember = "CategoryName";
            cmbCategoryName.DataSource = CategoríaDAO.ObtenerCategorías();
        }

        private void btnFiltrarNombre_Click(object sender, EventArgs e)
        {
            txtFiltroNombre.Clear();
            string nombre = cmbCategoryName.Text;
            Categoría cat = CategoríaDAO.FiltrarName(nombre);
            
            txtFiltroNombre.AppendText(cat.CategoryID + ": " + cat.CategoryName + " - ");
            txtFiltroNombre.AppendText(cat.Description + Environment.NewLine);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string descripción = txtDescripcion.Text;

            //Validar los campos (en el formulario)
            if (nombre.Length > 0 && descripción.Length > 0)
            {
                if (CategoríaDAO.AgregarCategoría(nombre, descripción)){
                    MessageBox.Show("Categoría agregada exitosamente!", "POO",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombre.Clear();
                    txtDescripcion.Clear();
                }else
                    MessageBox.Show("Error! Pruebe más tarde!", "POO",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Error! Los campos están vacíos!", "POO",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}