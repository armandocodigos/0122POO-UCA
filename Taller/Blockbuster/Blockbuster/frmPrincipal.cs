using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Blockbuster
{
    public partial class frmPrincipal : Form
    {
        private Usuario usu { get; set; }
        
        public frmPrincipal(Usuario usu)
        {
            InitializeComponent();
            this.usu = usu;
            lblBienvenida.Text = "Bienvenido " + usu.nombre + " " + usu.apellido + " (" + usu.rol + ")";
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            tabPrincipal.ItemSize = new Size(0, 1);
            tabInterior.ItemSize = new Size(0, 1);
            cmbTipoBusqueda.Text = "Título";

            cmbBusquedaGenero.DataSource = null;
            cmbBusquedaGenero.ValueMember = "code";
            cmbBusquedaGenero.DisplayMember = "nombre";
            cmbBusquedaGenero.DataSource = GéneroDAO.ObtenerTodos();

            cmbNGenero.DataSource = null;
            cmbNGenero.ValueMember = "code";
            cmbNGenero.DisplayMember = "nombre";
            cmbNGenero.DataSource = GéneroDAO.ObtenerTodos();

            cmbNDirector.DataSource = null;
            cmbNDirector.ValueMember = "code";
            cmbNDirector.DisplayMember = "nombre";
            cmbNDirector.DataSource = DirectorDAO.ObtenerTodos();

            if (usu.rol.CompareTo("Administrador") != 0)
            {
                btnMenuNuevaPelicula.Enabled = false;
            }
        }

        private void btnMenuInicio_Click(object sender, EventArgs e)
        {
            tabPrincipal.SelectedIndex = 0;
        }

        private void btnMenuBúsqueda_Click(object sender, EventArgs e)
        {
            tabPrincipal.SelectedIndex = 1;
        }

        private void btnMenuNuevaPelicula_Click(object sender, EventArgs e)
        {
            tabPrincipal.SelectedIndex = 2;
        }

        private void cmbTipoBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoBusqueda.Text == "Título")
                tabInterior.SelectedIndex = 0;
            else
                tabInterior.SelectedIndex = 1;
        }

        private void btnBusquedaTitulo_Click(object sender, EventArgs e)
        {
            string titulo = txtBusquedaTitulo.Text;
            List<Película> resultado = PelículaDAO.FiltrarPorTitulo(titulo);

            dgvTitulo.DataSource = null;
            dgvTitulo.DataSource = resultado;
        }

        private void btnBusquedaGenero_Click(object sender, EventArgs e)
        {
            string genero = cmbBusquedaGenero.Text;
            dgvGenero.DataSource = null;
            dgvGenero.DataSource = PelículaDAO.FiltrarPorGénero(genero);
        }

        private void btnAgregarNuevo_Click(object sender, EventArgs e)
        {
            Película peli = new Película();
            peli.code = txtNCodigo.Text;
            peli.titulo = txtNTitulo.Text;
            peli.estreno = dtpNEstreno.Value;
            peli.precio = Convert.ToDouble(nudNPrecio.Value);
            peli.duracion = Convert.ToInt32(nudNDuracion.Value);
            peli.stock = Convert.ToInt32(nudNStock.Value);
            peli.descripcion = txtNDescripcion.Text;
            peli.id_genero = ((Género)cmbNGenero.SelectedItem).code;
            peli.id_director = ((Director)cmbNDirector.SelectedItem).code;
            peli.id_usuario = "22577777-5";

            if (PelículaDAO.AgregarNueva(peli))
                MessageBox.Show("Película agregada exitosamente!", "Blockbuster",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Sucedió un error! :(", "Blockbuster",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            dgvNuevaPelicula.DataSource = null;
            dgvNuevaPelicula.DataSource = PelículaDAO.ObtenerTodos();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}