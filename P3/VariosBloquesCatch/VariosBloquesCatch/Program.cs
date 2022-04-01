using System;

namespace VariosBloquesCatch
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido!");
        
            try {
                // Podría generar ArithmeticException
                Console.Write("Numerador: ");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.Write("Denominador: ");
                int den = Convert.ToInt32(Console.ReadLine());
                int resultado = num / den;
                Console.WriteLine("Resultado: " + resultado);
	        
                // Podría generar IndexOutOfRangeException
                int[] arreglo = {0, 1, 2, 3};
                Console.Write("Indice (del 0 al 3): ");
                int indice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Numero: " + arreglo[indice]);
	        
                // Hemos llegado al final del bloque try
                Console.WriteLine("No hubo errores!");
            }
            catch(DivideByZeroException e) {
                Console.WriteLine("Error aritmético, división entre cero!");
            }
            catch(IndexOutOfRangeException e) {
                Console.WriteLine("Indice erróneo, no existe esa casilla!");
            }
            catch(Exception e) {
                Console.WriteLine("Error de otro tipo!");
            }
	    
            Console.WriteLine("Tenga un buen día!");
        }
    }
}