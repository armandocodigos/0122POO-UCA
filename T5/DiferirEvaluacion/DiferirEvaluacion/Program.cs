using System;

namespace DiferirEvaluación
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Ingrese su nombre: ");
            string nombre = Console.ReadLine();
    
            Console.Write("Ingrese su carné: ");
            string carné = Console.ReadLine();
    
            Console.Write("Ingrese su carrera: ");
            string carrera = Console.ReadLine();
    
            Estudiante e = new Estudiante(nombre, carné, carrera);
    
            bool continuar = true;
            do{
                Console.Write("Desea diferir? (s/n): ");
                char opcion = Console.ReadLine()[0];
        
                if(opcion=='s'){
                    if(Decanato.solicitarDiferido(e))
                        Console.WriteLine("Operación exitosa!");
                    else
                        Console.WriteLine("Ni modo :'v");
                }
                else{
                    continuar = false;
                }
            }while(continuar);
            Console.WriteLine("Que tenga un buen día");
        }
    }
}