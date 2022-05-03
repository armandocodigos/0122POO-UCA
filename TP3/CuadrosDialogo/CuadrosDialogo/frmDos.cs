using System.Windows.Forms;

namespace CuadrosDialogo
{
    public partial class frmDos : Form
    {
        public frmDos()
        {
            InitializeComponent();
        }

        private void frmDos_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult respuesta =
                MessageBox.Show("Realmente desea salir?", "Probando xD",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}