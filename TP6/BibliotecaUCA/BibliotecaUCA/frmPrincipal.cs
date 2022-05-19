using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaUCA
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void tsbYoutube_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/user/BibliotecaUCAsv");
        }

        private void tsbTwitter_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/LaBiblioUCA");
        }

        private void tsbFacebook_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/LaBiblioUCA/");
        }

        private void tsbInstagram_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/accounts/login/?next=/labibliouca/");
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabContenedor.SelectedIndex = 0;
        }

        private void misiónYVisiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabContenedor.SelectedIndex = 1;
        }

        private void cifras2016ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabContenedor.SelectedIndex = 2;
        }

        private void coleccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabContenedor.SelectedIndex = 3;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //Para esconder las pestañas del TabControl
            tabContenedor.ItemSize = new Size(0, 1);
            
            //Mandar a llenar mi tabla (data grid view) con mi biblioteca
            configurarTabla(MotorBusqueda.biblioteca());
            
            //Configurar búsqueda por defecto
            cmbBusqueda.Text = "Título";
        }

        private void configurarTabla(List<Libro> libros)
        {
            //Enlazar mi lista de libros con mi tabla
            dgvBusqueda.DataSource = null;
            dgvBusqueda.DataSource = libros;
            
            //Configurar la Imagen
            DataGridViewImageColumn columna = (DataGridViewImageColumn)dgvBusqueda.Columns["Imagen"];
            columna.ImageLayout = DataGridViewImageCellLayout.Zoom;
            
            //Configurar el alto de las filas
            dgvBusqueda.RowTemplate.Height = 100;
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            List<Libro> resultados;

            if(cmbBusqueda.Text == "Título")
                resultados = MotorBusqueda.buscarTitulo(txtBusqueda.Text.Trim());
            else
                resultados = MotorBusqueda.buscarAutor(txtBusqueda.Text.Trim());
            
            configurarTabla(resultados);

            if (resultados.Count == 0)
                MessageBox.Show("No se encontraron Registros", "Biblioteca UCA",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvBusqueda_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Para evitar errores al dar clic a encabezados, etc.
            //Para que se solo se ejecute en celdas "válidas"
            if (e.RowIndex != -1)
            {
                //Obtener el libro en cuestión
                Libro libro = dgvBusqueda.SelectedRows[0].DataBoundItem as Libro;

                //Mostrar la info del libro en la otra pestaña (resultados)
                lblTitulo.Text = libro.Titulo;
                lblAutor.Text = libro.Autor;
                lblTema.Text = libro.Tema;
                lblClasificacion.Text = libro.Clasificación;
                picImagenLibro.Image = libro.Imagen;

                //Cambiar la pestaña
                tabContenedor.SelectedIndex = 4;
            }
        }
    }
}