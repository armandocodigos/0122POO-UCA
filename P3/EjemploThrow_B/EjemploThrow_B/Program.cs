using System;

namespace EjemploThrow_B
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            try{
                ClaseA.generarExcepciones();
            }
            catch (IndexOutOfRangeException e){
                //Recapturando la excepción
                Console.WriteLine("ERROR - Programa terminado");
            }
        }
    }
}