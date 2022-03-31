using System;

namespace CuentaHerencia_A
{
    public class CuentaChequera : CuentaBancaria 
    {
        private int contadorTransacciones;

        public override void depositar(double cantidad) {
            if(cantidad >= 0){
                contadorTransacciones++;
                balance += cantidad;
            }else
                Console.WriteLine("Error!");
        }

        public override void retirar(double cantidad) {
            if(cantidad <= balance){
                contadorTransacciones++;
                balance -= cantidad;
            }else
                Console.WriteLine("Error!");
        }

        public int getTransacciones() {
            return contadorTransacciones;
        }
    }
}