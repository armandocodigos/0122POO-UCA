using System;

namespace EjemploThrow_C
{
    public static class ClaseA
    {
        public static void metodoA() 
        {
            Console.WriteLine("3) Inicia el método A de la clase A.");
            try{
                Console.WriteLine("4) Se ejecuta el método B de la clase B.");
                ClaseB.metodoB();
            }
            catch (ArithmeticException e){
                Console.WriteLine("7) La clase A captura la excepción.");
                Console.WriteLine("8) Pero no puede manejarla, procede a re-lanzarla.");
                throw e;
            }
        }
    }
}