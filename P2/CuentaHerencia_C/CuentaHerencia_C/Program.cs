using System;

namespace CuentaHerencia_C
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Se instancia un objeto con <100> como parámetro de construcción
            Console.WriteLine("Abriendo CuentaBancaria con $100");
            CuentaBancaria cuenta1 = new CuentaBancaria(100);
		
            Console.WriteLine("Retirando $50");
            cuenta1.retirar(50);
        
            Console.WriteLine("Balance: $" + cuenta1.getBalance());
        
            // Se instancia un objeto con <250> como parámetro de construcción
            // Dentro, se llamará al constructor de la clase padre (y se le enviará el 250)
            // Y también se inicializará el contador de transacciones a cero
            Console.WriteLine("\nAbriendo CuentaChequera con $250");
            CuentaChequera cuenta2 = new CuentaChequera(250);
        
            Console.WriteLine("Retirando $100");
            cuenta2.retirar(100);
        
            Console.WriteLine("Balance: $" + cuenta2.getBalance());
            Console.WriteLine("Transacciones: " + cuenta2.getTransacciones());
            // Ahora hay una sola transacción porque solo ha habido 1 retiro
        }
    }
}