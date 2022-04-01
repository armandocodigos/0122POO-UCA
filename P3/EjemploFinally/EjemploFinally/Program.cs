using System;

namespace EjemploFinally
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Generando tres tipos de errores distintos");
        
            // Notar que en TODOS los casos, se ejecuta el bloque finally
            for (int i=0;i<3;i++){
                UsoFinally.generateException(i);
            }
        }
    }
}