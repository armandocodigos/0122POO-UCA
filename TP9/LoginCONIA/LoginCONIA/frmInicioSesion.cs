using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginCONIA
{
    public partial class frmInicioSesion : Form
    {
        public frmInicioSesion()
        {
            InitializeComponent();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            frmRegistro otraVentana = new frmRegistro();
            otraVentana.ShowDialog();
        }

        private void btnCambiarContra_Click(object sender, EventArgs e)
        {
            frmCambioContra otraVentana = new frmCambioContra();
            otraVentana.ShowDialog();
        }
    }
}