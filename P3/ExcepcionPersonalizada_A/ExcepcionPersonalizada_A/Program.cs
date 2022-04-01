using System;

namespace ExcepcionPersonalizada_A
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1) Bienvenido!");
		
            try {
                Console.WriteLine("2) Creando codigo postal...");
                PostCodeManager aPostCode = new PostCodeManager();
            
                Console.WriteLine("3) Agregando un codigo valido...");
                aPostCode.setPostCode("12345");
                Console.WriteLine("Operación exitosa!");
            
                Console.WriteLine("4) Agregando un codigo invalido...");
                aPostCode.setPostCode("abcde");
                Console.WriteLine("Operación exitosa!");// No será exitosa :(
            }
            catch (BadPostCodeException e) {
                // Sucedio un error
                Console.WriteLine("Error: " + e.Message);
            }
	    
            Console.WriteLine("5) Tenga un buen día!");
        }
    }
}