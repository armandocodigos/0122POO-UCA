using System;

namespace CuentaBancaria_A
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CuentaBancaria cuenta1 = new CuentaBancaria();
            Console.WriteLine("No. de cuenta: " + cuenta1.numeroCuenta);
        
            CuentaBancaria cuenta2 = new CuentaBancaria();
            Console.WriteLine("No. de cuenta: " + cuenta2.numeroCuenta);
        
            CuentaBancaria cuenta3 = new CuentaBancaria();
            Console.WriteLine("No. de cuenta: " + cuenta3.numeroCuenta);
        }
    }
}