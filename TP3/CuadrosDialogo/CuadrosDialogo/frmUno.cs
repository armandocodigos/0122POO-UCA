using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuadrosDialogo
{
    public partial class frmUno : Form
    {
        public frmUno()
        {
            InitializeComponent();
        }

        private void trbValor_Scroll(object sender, EventArgs e)
        {
            lblValor.Text = "Valor: " + trbValor.Value;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            Producto repollo = new Producto(1, "Repollo Griego", 0.50, "Selectos");
            Producto soda = new Producto(2, "Coca Cola c/café", 0.75, "Cola Cola");
            Producto cereal = new Producto(3, "Fruit Loops", 3.50, "Kellogs");

            List<Producto> listaProductos = new List<Producto>();
            listaProductos.Add(repollo);
            listaProductos.Add(soda);
            listaProductos.Add(cereal);

            cmbProducto.ValueMember = "id";
            cmbProducto.DisplayMember = "marca";
            cmbProducto.DataSource = listaProductos;
        }

        private void btnPregunta_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = 
                MessageBox.Show("Ya compraron tickets para Dr. Strange?", "Marvel",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                MessageBox.Show("Disfruta de la película!", "Marvel",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No te demores más en comprarlos!", "Marvel",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            DialogResult resultado = cldColor.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                this.BackColor = cldColor.Color;
            }
        }
    }
}