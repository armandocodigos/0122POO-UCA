using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimeraGUI
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            //Lo que se coloque aquí, se ejecutará cuando se presione el botón
            //Es decir, cuando suceda el evento "Click" para el control "btnSaludar"

            lblSaludo.Text = "Hola " + txtNombre.Text + "!";
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            //Este evento se ejecuta cada vez que el usuario modifica el Text del TextBox
            lblSaludo.Text = "Escribiendo...";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int edad = Convert.ToInt32(nudEdad.Value);

            if (edad >= 18)
                //Mostrar mensaje de mayor de edad
                MessageBox.Show("Usted es mayor de edad!", "POO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                //Mostrar mensaje de menor de edad
                MessageBox.Show("Usted es menor de edad?", "POO", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}