using System;

namespace Monedero_C
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Monedero unMonedero = new Monedero();

            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("Menú:");
                Console.WriteLine("\t0:Salir");
                Console.WriteLine("\t1:Agregar un dólar");
                Console.WriteLine("\t2:Agregar otra moneda");
                Console.WriteLine("\t3:Consultar total");
                Console.Write("\tOpción: ");
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 0:
                        continuar = false;
                        break;
                    case 1:
                        // Creando moneda de a dólar...
                        Moneda unaMoneda = new Moneda();
                        // Agregando al monedero...
                        unMonedero.añadirMoneda(unaMoneda);

                        Console.WriteLine("Moneda añadida!\n");
                        break;
                    case 2:
                        // Solicitar valor y nombre
                        Console.Write("Valor: $");
                        double valor = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Nombre: ");
                        string nombre = Console.ReadLine();

                        // Creando moneda y agregar al monedero...
                        unMonedero.añadirMoneda(new Moneda(valor, nombre));
                        // Es posible instanciar un objeto sin la necesidad
                        // de guardar su dirección de memoria en una variable
                        // esto es útil cuando se envía a un método o función

                        Console.WriteLine("Moneda añadida!\n");
                        break;
                    case 3:
                        Console.WriteLine("Dinero: $" + unMonedero.consultarTotal() + "\n");
                        break;
                    default:
                        Console.WriteLine("Opcion errónea!" + "\n");
                        break;
                }
            }
        }
    }
}