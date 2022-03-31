using System;

namespace CuentaBancaria_B
{
    public class CuentaBancaria
    {
        // Atributos de instancia
        public double balance{ get; private set; }
        public int numeroCuenta{ get; private set; }
    
        // Constructor
        public CuentaBancaria(){
            balance = 0;
            numeroCuenta = GeneradorIDs.nuevoID();
        }
    
        public void depositar(double monto){
            if(monto >= 0)
                balance += monto;
            else
                Console.WriteLine("Error!");
        }
    
        public void retirar(double monto){
            if(monto <= balance)
                balance -= monto;
            else
                Console.WriteLine("Error!");
        }
    }
}