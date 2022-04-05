using System;

namespace EjemploWhile
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Instrucciones antes del try.");
        
            bool finalizado = false;
            while(!finalizado){
                try{
                    // Podría generar excepciones
                    Console.Write("\n\nDigite el numerador: ");
                    int numerador = Convert.ToInt32(Console.ReadLine());
    	        
                    Console.Write("Digite el denominador: ");
                    int denominador = Convert.ToInt32(Console.ReadLine());
    	        
                    double resultado = numerador / denominador;
    	        
                    Console.WriteLine("Resultado: " + resultado);
                    finalizado = true;
                }
                catch(DivideByZeroException ex){
                    Console.WriteLine("Error, división entre cero!");
                    Console.WriteLine("Favor intente con otros valores.");
                }
                catch(FormatException ex){
                    Console.WriteLine("Error, tipo de dato no válido.");
                }
            }
        
            Console.WriteLine("Instrucciones después del try.");
        }
    }
}