using System;
using System.Windows.Forms;

namespace LoginCONIA
{
    public partial class frmCambioContra : Form
    {
        public Usuario usu { get; set; }
        
        public frmCambioContra()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            DateTime nacimiento = dtpFechaNacimiento.Value.Date;

            this.usu = UsuarioDAO.BuscarUsuario(usuario, nacimiento);
            
            if (this.usu == null)
                MessageBox.Show("Error! El usuario no existe!", "CONIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                pnlContraseña.Visible = true;
        }

        private void btnCambiarContra_Click(object sender, EventArgs e)
        {
            if (txtContra1.Text.Length > 0 &&
                txtContra1.Text.CompareTo(txtContra2.Text) == 0)
            {
                this.usu.contra = txtContra1.Text;

                if (UsuarioDAO.Actualizar(this.usu))
                {
                    MessageBox.Show("Contraseña actualizada exitosamente!", "CONIA", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                    MessageBox.Show("La contraseña no se pudo actualizar!", "CONIA", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Las contraseñas no coinciden!", "CONIA", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}