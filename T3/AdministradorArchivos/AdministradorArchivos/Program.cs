using System;

namespace AdministradorArchivos
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Gestor de archivos");
        
            bool continuar = true;
            do{
                Console.Write(menu());
                int opcion = Convert.ToInt32(Console.ReadLine());
            
                switch(opcion){
                    case 1: 
                        string contenido = GestorArchivos.Leer("archivo.txt");
                        Console.WriteLine(contenido);
                        break;
                    case 2: 
                        Console.Write("Texto a agregar: ");
                        string texto = Console.ReadLine();
                        GestorArchivos.Anexar("archivo.txt", texto);
                        break;
                    case 3: continuar = false; break;
                    default: Console.WriteLine("Opcion errónea!"); break;
                }
            }while(continuar);
        
            Console.WriteLine("\nTenga un buen día!");
        }
        
        public static string menu(){
            return "\nBienvenido:\n" +
                   "1) Leer archivo.\n" +
                   "2) Anexar frase a archivo.\n" +
                   "3) Salir.\n" +
                   "Opción elegida: ";
        }
    }
}