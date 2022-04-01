using System;

namespace EjemploThrow_C
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1) Inicia el main.");
            try{
                Console.WriteLine("2) El main ejecuta el método A de la clase A.");
                ClaseA.metodoA();
            }
            catch (ArithmeticException e){
                Console.WriteLine("9) Finalmente el main la captura.");
            }
        
            Console.WriteLine("10) El programa termina normalmente (no de manera abrupta).");
        }
    }
}