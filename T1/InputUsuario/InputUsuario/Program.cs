using System;

namespace InputUsuario
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            String inputCadena = "";
            Console.Write("Digite una cadena: ");
            inputCadena = Console.ReadLine();

            int inputEntero = 0;
            Console.Write("Digite un entero: ");
            inputEntero = Convert.ToInt32(Console.ReadLine());

            double inputDouble = 0.0;
            Console.Write("Digite un real: ");
            inputDouble = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Cadena: " + inputCadena);
            Console.WriteLine("Doble entero: " + (2 * inputEntero));
            Console.WriteLine("Triple punto flotante: " + (3 * inputDouble));
        }
    }
}