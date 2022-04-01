using System;

namespace EjemploThrow_A
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            try {
                Console.Write("Para poder votar, favor digite su edad: ");
                int edad = Convert.ToInt32(Console.ReadLine());
		    
                ValidadorEdad.validar(edad);
                Console.WriteLine("Bienvenido, usted sí puede votar!");
		    
            } catch(ArithmeticException e) {
                // Por ser menor de edad
                Console.WriteLine("Lo sentimos, usted no puede votar!");
            }
        }
    }
}