using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bridge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTransporte_Click(object sender, EventArgs e)
        {
            CAbstracción puente = new CAbstracción(new TrenLujo());

            if (radLujo.Checked)
                puente.CambiarTipo(new TrenLujo());
            else if(radCarga.Checked)
                puente.CambiarTipo(new TrenCarga());
            else
                puente.CambiarTipo(new TrenBala());

            string resultado = puente.TransportarPersonas();
            MessageBox.Show("Forma: " + resultado);
        }
    }
}