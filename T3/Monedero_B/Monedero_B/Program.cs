using System;

namespace Monedero_B
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Monedero miBolsillo = new Monedero();
	    
            miBolsillo.añadirMoneda(1, "dólar");
            miBolsillo.añadirMoneda(1, "dólar");
            miBolsillo.añadirMoneda(0.25, "cora");
            miBolsillo.añadirMoneda(0.25, "cora");
	    
            Console.WriteLine("Dinero: $" + miBolsillo.consultarTotal());
        }
    }
}