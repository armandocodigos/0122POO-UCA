using System;

namespace CuentaHerencia_B
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Instanciación de un objeto de la clase CuentaBancaria (súper-clase)
            Console.WriteLine("-----CuentaBancaria-----");
            CuentaBancaria cuenta1 = new CuentaBancaria();
            cuenta1.depositar(100);
            cuenta1.retirar(50);
            Console.WriteLine("Balance: $" + cuenta1.getBalance());
        
            // Instanciación de un objeto de la clase CuentaChequera (sub-clase)
            Console.WriteLine("-----CuentaChequera-----");
            CuentaChequera cuenta2 = new CuentaChequera();
            cuenta2.depositar(250);
            cuenta2.retirar(100);
            Console.WriteLine("Balance: $" + cuenta2.getBalance());
            Console.WriteLine("Transacciones: " + cuenta2.getTransacciones());
        }
    }
}