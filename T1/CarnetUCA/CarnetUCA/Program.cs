using System;

namespace CarnetUCA
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Saludo
            Console.WriteLine("Estudiante UCA, bienvenido!");
            
            //Solicitar datos
            Console.Write("Digita tu nombre: ");
            String nombre = Console.ReadLine();
            
            Console.Write("Digita tu apellido: ");
            String apellido = Console.ReadLine();
            
            Console.Write("Digita tu edad: ");
            int edad = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Digita tu carné: ");
            int carné = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Digita tu carrera: ");
            String carrera = Console.ReadLine();
            
            //Mostrar resumen
            Console.WriteLine("---Datos de tu carné---");
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Apellido: " + apellido);
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Carné: " + carné);
            Console.WriteLine("Carrera: " + carrera);
        }
    }
}