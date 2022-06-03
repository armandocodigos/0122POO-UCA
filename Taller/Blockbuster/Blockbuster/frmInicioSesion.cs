using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Blockbuster.Properties;

namespace Blockbuster
{
    public partial class frmInicioSesion : Form
    {
        public frmInicioSesion()
        {
            InitializeComponent();
        }

        private void frmInicioSesion_Load(object sender, EventArgs e)
        {
            
        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            string nombre = txtUsuario.Text;
            string contraseña = txtContraseña.Text;
            Usuario usu = UsuarioDAO.Existe(nombre, contraseña);

            if (usu.nombre.Length > 0)
            {
                MessageBox.Show("Bienvenido!", "Blockbuster",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmPrincipal ventana = new frmPrincipal(usu);
                ventana.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Credenciales erróneas!", "Blockbuster",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}