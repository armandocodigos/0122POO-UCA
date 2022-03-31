using System;

namespace CuentaBancaria_A
{
    public class CuentaBancaria
    {
        // Atributos de instancia (cada objeto tendrá los suyos exclusivos para el)
        public double balance{ get; private set; }
        public int numeroCuenta{ get; private set; }
    
        // Atributos de clase (solo existe uno, todos los objetos lo comparten)
        private static int contadorEstático = 0;
    
        // Constructor
        public CuentaBancaria(){
            balance = 0;
        
            contadorEstático++;
            numeroCuenta = contadorEstático;
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