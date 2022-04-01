using System;

namespace ExcepcionPersonalizada_B
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1) Bienvenido!");
        
            Console.WriteLine("2) Creando codigo postal...");
            PostCodeManager aPostCode = new PostCodeManager();
		
            // El bucle se repetirá indefinidamente hasta
            // que el usuario digite un codigo correcto
            bool continuar = true;
            do{
                try {
                    Console.Write("\n3) Favor digite un código válido: ");
                    String aCode = Console.ReadLine();
                    aPostCode.setPostCode(aCode);
                
                    Console.WriteLine("Operación exitosa!");
                    continuar = false;
                }
                catch (BadPostCodeException e) {
                    // Sucedio un error
                    Console.WriteLine("Error: " + e.Message);
                }
            }
            while(continuar);
	    
            Console.WriteLine("\n4) Tenga un buen día!");
        }
    }
}