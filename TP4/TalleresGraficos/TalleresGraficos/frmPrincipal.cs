using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TalleresGraficos.Properties;

namespace TalleresGraficos
{
    public partial class frmPrincipal : Form
    {
        private List<Bitmap> listaImagenes;

        public frmPrincipal()
        {
            InitializeComponent();
            
            listaImagenes = new List<Bitmap>();
            listaImagenes.Add(Resources.banner);
            listaImagenes.Add(Resources.banner02);
            listaImagenes.Add(Resources.banner03);
            listaImagenes.Add(Resources.banner04);
            listaImagenes.Add(Resources.banner05);
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            pnlEncabezado.BackColor = Color.FromArgb(107, 189, 69);
            sspInfo.BackColor = Color.FromArgb(107, 189, 69);
        }

        private void btnEncuadernado_Click(object sender, EventArgs e)
        {
            /*using (<el otro formulario>)
            {
                DialogResult resultado = <otro fomulario>.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    Propiedad x = <otro formulario>.x;
                    <hacer lo que quiero hacer>
                    <mostrar un mensaje>
                }
            }*/

            using (frmEncuadernado ventana = new frmEncuadernado())
            {
                DialogResult resultado = ventana.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    Encuadernado datoDevuelto = ventana.detalle;
                    //recibiendo propiedad 2
                    //recibiendo propiedad 3
                    //recibiendo propiedad N
                    
                    txtCarrito.AppendText("Encuadernado encargado!");
                    txtCarrito.AppendText(" Pegado: " + datoDevuelto.pegado);
                    txtCarrito.AppendText(" Empastado: " + datoDevuelto.empastado);
                    txtCarrito.AppendText(Environment.NewLine);

                    lblEstado.Text = "Encuadernado en espera.";

                    MessageBox.Show("Encuadernado encargado con éxito!", "Talleres gráficos UCA",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private int contadorBanner = 0;

        private void tmrBanner_Tick(object sender, EventArgs e)
        {
            if (contadorBanner < listaImagenes.Count)
            {
                picBanner.Image = listaImagenes[contadorBanner];
                contadorBanner++;

                if (contadorBanner == listaImagenes.Count)
                {
                    contadorBanner = 0;
                }
            }

            //txtCarrito.AppendText("Sucedió un Tick del Timer" + Environment.NewLine);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCarrito.Clear();
            lblEstado.Text = "No hay encuadernados encargados.";
        }
    }
}