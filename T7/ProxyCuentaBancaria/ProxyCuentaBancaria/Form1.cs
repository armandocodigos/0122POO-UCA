using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProxyCuentaBancaria
{
    public partial class Form1 : Form
    {
        private ISujeto cajero;
        public Form1()
        {
            InitializeComponent();
            cajero = new CProxy.Cajero();
        }

        private void btnConsultarBalance_Click(object sender, EventArgs e)
        {
            //Opcion 01
            //Consultar balance, input:void, output:double
            double balance = (double)cajero.Peticion(1, null);
            MessageBox.Show("Balance: $" + balance);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //Opcion 02
            //Ingresar dinero, input:double, output:void
            double monto = Convert.ToDouble(nudMonto.Value);
            cajero.Peticion(2, new List<object>() { monto });
            MessageBox.Show("Operación exitosa!");
        }

        private void btnExtraña_Click(object sender, EventArgs e)
        {
            //Opción 03
            bool bandera = chkBandera.Checked;
            double cantidad = Convert.ToDouble(nudCantidad.Value);
            string apellido = txtApellido.Text;

            bool resultado = Convert.ToBoolean(
                cajero.Peticion(3, new List<object>() { bandera, cantidad, apellido }));

            if (resultado)
                MessageBox.Show("Promoción aplicada! Felicidades!");
            else
                MessageBox.Show("Más suerte la próxima vez! :(");
        }
    }
}