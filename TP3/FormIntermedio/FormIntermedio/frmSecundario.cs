using System;
using System.Windows.Forms;

namespace FormIntermedio
{
    public partial class frmSecundario : Form
    {
        public Película nuevaPelicula { get; set; }
        
        public frmSecundario()
        {
            InitializeComponent();
            nuevaPelicula = new Película();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            nuevaPelicula.id = Convert.ToInt32(nudID.Value);
            nuevaPelicula.nombre = txtNombre.Text;
            nuevaPelicula.genero = cmbGenero.Text;
            this.Close();
        }
    }
}