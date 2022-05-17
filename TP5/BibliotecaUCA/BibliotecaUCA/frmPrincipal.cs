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
            tabContenedor.ItemSize = new Size(0, 1);
        }
    }
}