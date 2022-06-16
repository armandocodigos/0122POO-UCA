using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estrategia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMovimiento_Click(object sender, EventArgs e)
        {
            IAjedrez ficha = null;

            if (radPeon.Checked)
                ficha = new Peón();
            else if (radTorre.Checked)
                ficha = new Torre();
            else if (radCaballo.Checked)
                ficha = new Caballo();
            else if (radAlfil.Checked)
                ficha = new Alfil();
            else
                ficha = new Dama();

            lblInfo.Text = "Movimiento: " + ficha.mover() + Environment.NewLine +
                           "Información: " + ficha.describir();
        }
        
        private void btnInfo2_Click(object sender, EventArgs e)
        {
            Pieza unaPieza = new Pieza();
            
            if (radPeon2.Checked)
                unaPieza.SetTipo(new Peón());
            else if (radTorre2.Checked)
                unaPieza.SetTipo(new Torre());
            else if (radCaballo2.Checked)
                unaPieza.SetTipo(new Caballo());
            else if (radAlfil2.Checked)
                unaPieza.SetTipo(new Alfil());
            else
                unaPieza.SetTipo(new Dama());
            
            lblInfo2.Text = "Movimiento: " + unaPieza.mover() + Environment.NewLine +
                            "Información: " + unaPieza.describir();
        }
    }
}