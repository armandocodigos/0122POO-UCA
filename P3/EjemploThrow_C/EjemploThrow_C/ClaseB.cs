using System;

namespace EjemploThrow_C
{
    public static class ClaseB
    {
        public static void metodoB() 
        {
            Console.WriteLine("5) Inicia el método B de la clase B.");
		
            Console.WriteLine("6) Sucede un error, se procede a lanzar una excepcion.");
            throw new ArithmeticException();
        }
    }
}