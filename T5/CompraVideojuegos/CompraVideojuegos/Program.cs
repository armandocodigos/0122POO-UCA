using System;

namespace CompraVideojuegos
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            EntidadBancaria unaEntidad = menuEntidad();
        
            bool continuar = true;
            do{
                Console.Write(menu());
                int opcion = Convert.ToInt32(Console.ReadLine());
            
                switch(opcion){
                    case 1: unaEntidad.registrarTarjeta(); break;
                    case 2: unaEntidad.consultarTarjetas(); break;
                    case 3: ConsolaJuegos.comprarJuego(unaEntidad); break;
                    case 4: ConsolaJuegos.jugar(); break;
                    case 5: continuar = false; break;
                    default: Console.WriteLine("Opcion errónea!"); break;
                }
            }while(continuar);
            Console.WriteLine("\nTenga un buen día!");
        }
        
        public static string menu(){
            return "\nBienvenido:\n" +
                   "1) Registrar tarjeta (entidad).\n" +
                   "2) Consultar tarjetas (entidad).\n" +
                   "3) Comprar videojuego (consola).\n" +
                   "4) Jugar videojuego (consola).\n" +
                   "5) Salir.\n" +
                   "Opción elegida: ";
        }
        
        public static EntidadBancaria menuEntidad(){
            Console.Write("Bienvenido:\n" +
                          "1) Seleccionar Banco.\n" +
                          "2) Seleccionar Cooperativa.\n" +
                          "Opción elegida: ");
            int opcion = Convert.ToInt32(Console.ReadLine());
        
            if(opcion == 1)
                return new Banco("Scotiabank");
            else
                return new Cooperativa("ACEUCA");
        }
    }
}