using System;

namespace Propiedades
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Vendedor unaPersona = new Vendedor(1, "Juan");
            unaPersona.RealizarVenta();
        
            Console.WriteLine("Nombre: " + unaPersona.nombre);
            Console.WriteLine("Ventas: $" + unaPersona.ventas);
        
            unaPersona.ventas += 2;
            Console.WriteLine("Ventas: $" + unaPersona.ventas);
        }
    }
}