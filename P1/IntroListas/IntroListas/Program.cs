using System;
using System.Collections.Generic;
using System.Linq;

namespace IntroListas
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Crear la lista
            List<int> lista = new List<int>();

            // Añadirle valores (insertar al inicio)
            lista.Add(1);
            lista.Add(2);
            lista.Add(3);

            // Recorrer todos los elementos
            foreach (int numero in lista)
                Console.Write(numero + " ");

            // Insertar en una posición en específico
            Console.WriteLine("\nInsertando...");
            lista.Insert(2, 5);

            foreach (int numero in lista)
                Console.Write(numero + " ");

            // Eliminar de una posición en específico
            Console.WriteLine("\nEliminando...");
            lista.RemoveAt(2);

            for (int i = 0; i < lista.Count; i++)
                Console.Write(lista.ElementAt(i) + " ");

            // Funciones útiles de System.Linq
            Console.WriteLine("\nMáximo: " + lista.Max());
            Console.WriteLine("Mínimo: " + lista.Min());
            Console.WriteLine("Suma: " + lista.Sum());
        }
    }
}