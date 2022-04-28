using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeteriaUCA
{
    public partial class frmPrincipal : Form
    {
        //burrito, lasaña, lomito, sopa
        private double[] precios = { 2.0, 2.25, 2.25, 2.8 };
        private double[] subtotal = { 0, 0, 0, 0 };
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //Este evento se ejecuta al mostrarse mi formulario
            
            //rgba(235,92,13,255)
            picBanner.BackColor = Color.FromArgb(235, 92, 13);
            lblWhatsApp.BackColor = Color.FromArgb(235, 92, 13);
            btnComprar.BackColor = Color.FromArgb(235, 92, 13);
            
            //rgba(204,103,1,255)
            picBurrito.BackColor = Color.FromArgb(204,103,1);
            picLasana.BackColor = Color.FromArgb(204,103,1);
            picLomito.BackColor = Color.FromArgb(204,103,1);
            picSopa.BackColor = Color.FromArgb(204,103,1);
            
            //Mostrar precios
            lblPrecioBurrito.Text = "$" + precios[0];
            lblPrecioLasana.Text = "$" + precios[1];
            lblPrecioLomito.Text = "$" + precios[2];
            lblPrecioSopa.Text = "$" + precios[3];
        }

        private void nudBurrito_ValueChanged(object sender, EventArgs e)
        {
            subtotal[0] = precios[0] * Convert.ToInt32(nudBurrito.Value);
            lblSubtotalBurrito.Text = "$" + Math.Round(subtotal[0], 2);
            calcularTotal();
        }

        private void nudLasana_ValueChanged(object sender, EventArgs e)
        {
            subtotal[1] = precios[1] * Convert.ToInt32(nudLasana.Value);
            lblSubtotalLasana.Text = "$" + Math.Round(subtotal[1], 2);
            calcularTotal();
        }

        private void nudLomito_ValueChanged(object sender, EventArgs e)
        {
            subtotal[2] = precios[2] * Convert.ToInt32(nudLomito.Value);
            lblSubtotalLomito.Text = "$" + Math.Round(subtotal[2], 2);
            calcularTotal();
        }

        private void nudSopa_ValueChanged(object sender, EventArgs e)
        {
            subtotal[3] = precios[3] * Convert.ToInt32(nudSopa.Value);
            lblSubtotalSopa.Text = "$" + Math.Round(subtotal[3], 2);
            calcularTotal();
        }

        private void calcularTotal()
        {
            double total = subtotal.Sum();
            double descuento = radEmpleado.Checked == true ? 0.1 : 0;
            lblTotal.Text = "Total de la compra: $" + Math.Round(total * (1 - descuento), 2);
        }

        private void radEstudiante_CheckedChanged(object sender, EventArgs e)
        {
            calcularTotal();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            double total = subtotal.Sum();

            if (total > 0)
            {
                double descuento = radEmpleado.Checked == true ? 0.1 : 0;
                string mensaje = "Hola " + txtNombre.Text + "\n" + "Su total es $" + Math.Round(total * (1 - descuento), 2);
                MessageBox.Show(mensaje, "Cafetería UCA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtNombre.Text.Length == 0)
                MessageBox.Show("Favor escriba su nombre!", "Cafetería UCA",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                MessageBox.Show("Usted no ha comprado nada", "Cafetería UCA",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void limpiar()
        {
            txtNombre.Clear();
            nudBurrito.Value = 0;
            nudLasana.Value = 0;
            nudLomito.Value = 0;
            nudSopa.Value = 0;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}