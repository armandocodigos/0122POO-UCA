using System;
using System.Windows.Forms;

namespace TalleresGraficos
{
    public partial class frmEncuadernado : Form
    {
        //Tenemos que hacer una propiedad pública
        public Encuadernado detalle { get; set; }
        //propiedad 2
        //propiedad 3
        //propiedad N
        
        public frmEncuadernado()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            /*if(<validacion>)
            {
                <instanciar mi propiedad >
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                <Mensaje de error>
            }*/

            string pegado =
                radHotMelt.Checked ? "Hot Melt" :
                radAnillado.Checked ? "Anillado" : "Engrapado";
            string empastado = 
                radLujo.Checked ? "De Lujo" : "Rústica";
            detalle = new Encuadernado(pegado, empastado);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}