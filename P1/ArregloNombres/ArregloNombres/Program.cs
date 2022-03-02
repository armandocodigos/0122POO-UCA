using System;

namespace ArregloNombres
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Solicitar al usuario
            Console.Write("Digite varios nombres separados por coma: ");
      
            // Recibir datos del usuario
            string nombres = Console.ReadLine();
      
            // Quitar espacios por cualquier cosa
            nombres = nombres.Trim();
      
            // Separar la cadena de texto
            // Almacenar cada nombre individualmente en una casilla de un arreglo
            string[] arreglo = nombres.Split(',');
      
            // Recorrer el arreglo
            foreach(string nombre in arreglo){
                Console.WriteLine("Nombre: " + nombre);
            }
        }
    }
}