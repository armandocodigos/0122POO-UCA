using System;

namespace CuentaHerencia_A
{
    public class CuentaBancaria
    {
        protected double balance;
    
        public double getBalance(){
            return balance;
        }

        public virtual void depositar(double cantidad) {
            if(cantidad >= 0)
                balance += cantidad;
            else
                Console.WriteLine("Error!");
        }

        public virtual void retirar(double cantidad) {
            if(cantidad <= balance)
                balance -= cantidad;
            else
                Console.WriteLine("Error!");
        }
    }
}