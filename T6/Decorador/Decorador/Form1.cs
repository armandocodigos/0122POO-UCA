using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decorador
{
    public partial class Form1 : Form
    {
        public IComponente miAuto { get; set; }
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            miAuto = new CAuto("Honda", "Civic", 25000);
                
            btnNitrogeno.Visible = true;
            btnSonido.Visible = true;
            btnSuspension.Visible = true;
            grbCosto.Visible = true;
            grbDescripcion.Visible = true;
            btnAuto.Enabled = false;
        }

        private void btnSonido_Click(object sender, EventArgs e)
        {
            miAuto = new CSonido(miAuto);
            btnSonido.Enabled = false;
        }

        private void btnNitrogeno_Click(object sender, EventArgs e)
        {
            miAuto = new CNitrogeno(miAuto);
            btnNitrogeno.Enabled = false;
        }

        private void btnSuspension_Click(object sender, EventArgs e)
        {
            miAuto = new CSuspension(miAuto);
            btnSuspension.Enabled = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            lblCosto.Text = "Costo: $" + miAuto.Costo();
        }

        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            lblDescripcion.Text = "Descripción: " + miAuto.Descripción();
        }
    }
}