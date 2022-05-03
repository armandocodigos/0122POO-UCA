using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormIntermedio
{
    public partial class frmPrincipal : Form
    {
        private List<Película> listaPelículas;
        
        public frmPrincipal()
        {
            InitializeComponent();
            listaPelículas = new List<Película>();
            listaPelículas.Add(new Película(1, "El conjuro", "Terror"));
            listaPelículas.Add(new Película(2, "Dr Strange", "Acción"));
            listaPelículas.Add(new Película(3, "Son como niños", "Comedia"));
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            actualizarCombo();
        }

        private void actualizarCombo()
        {
            cmbPeliculas.DataSource = null;
            
            cmbPeliculas.ValueMember = "id";
            cmbPeliculas.DisplayMember = "nombre";
            cmbPeliculas.DataSource = listaPelículas;
        }

        private void cmbPeliculas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Película unaPelicula = (Película) cmbPeliculas.SelectedItem;

            lblID.Text = "ID:" + unaPelicula.id;
            lblNombre.Text = "Nombre: " + unaPelicula.nombre;
            lblGenero.Text = "Género: " + unaPelicula.genero;
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            using (frmSecundario otraVentana = new frmSecundario())
            {
                DialogResult resultado = otraVentana.ShowDialog();

                if (resultado == DialogResult.Yes)
                {
                    Película nuevaPelicula = otraVentana.nuevaPelicula;
                    listaPelículas.Add(nuevaPelicula);
                    actualizarCombo();
                }
            }
        }
    }
}