using System;

namespace Monedero_A
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Monedero miBolsillo = new Monedero();
	    
            miBolsillo.agregarDolares(2);
            miBolsillo.agregarCoras(2);
	    
            Console.WriteLine("Dinero: $" + miBolsillo.consultarTotal());
        }
    }
}