using System;
using System.Windows.Forms;

namespace LoginCONIA
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close( );
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Length > 0 &&
                txtContra1.Text.Length > 0 &&
                txtContra1.Text.CompareTo(txtContra2.Text) == 0 &&
                dtpFechaNacimiento.Value < DateTime.Today)
            {
                Usuario u = new Usuario();
                u.usuario = txtUsuario.Text;
                u.contra = txtContra1.Text;
                u.f_nacimiento = dtpFechaNacimiento.Value.Date;

                if (UsuarioDAO.CrearNuevo(u))
                {
                    MessageBox.Show("Usuario registrado exitosamente!", "CONIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close( );
                }
                else
                    MessageBox.Show("Error de la base de datos!", "CONIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("Datos inválidos!", "CONIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}