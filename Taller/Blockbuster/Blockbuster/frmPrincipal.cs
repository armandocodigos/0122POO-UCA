using System;
using System.Drawing;
using System.Windows.Forms;

namespace Blockbuster
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            tabPrincipal.ItemSize = new Size(0, 1);
            tabInterior.ItemSize = new Size(0, 1);
            cmbTipoBusqueda.Text = "Título";
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
    }
}