using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProxyCocina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSencilla01_Click(object sender, EventArgs e)
        {
            CProxy.ISujeto recetario = new CProxy.ProxySencilla();
            recetario.Peticion(1);

            //La vista (los formularios) no tienen acceso, está oculta
            //CProxy.RecetasSecretas cocina = new CProxy.RecetasSecretas();
        }

        private void btnSencilla02_Click(object sender, EventArgs e)
        {
            CProxy.ISujeto recetario = new CProxy.ProxySencilla();
            recetario.Peticion(2);
        }
    }
}