using System;

namespace InterfaceVendedor
{
    internal class Program
    {
        //Utilizando interface Vendedor
        public static void realizarVenta (Vendedor unVendedor) {
            //Utilizando método ofrecerVenta
            Console.WriteLine(unVendedor.ofrecerVenta());
        
            //Utilizando método ejecutarVenta
            Console.Write("Monto de la venta: ");
            int unValor = Convert.ToInt32(Console.ReadLine());
            unVendedor.ejecutarVenta(unValor);
        
            //Utilizando método consultarInfo
            Console.WriteLine("−−Datos del vendedor−−");
            Console.WriteLine(unVendedor.consultarInfo());
        }
        
        public static void Main(string[] args)
        {
            VendedorPeriodicos unVendedorPeriodicos = new VendedorPeriodicos();
            AgenteBienesRaices unAgenteBienesRaices = new AgenteBienesRaices(0.10);

            bool continuar = true;
            do{
                Console.WriteLine("\n¿Qué desea comprar?");
                Console.WriteLine("1) Un periódico.");
                Console.WriteLine("2) Una casa.");
                Console.WriteLine("3) Nada.");
                Console.Write("Opción: ");
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion) {
                    case 1: realizarVenta(unVendedorPeriodicos); break;
                    case 2: realizarVenta(unAgenteBienesRaices); break;
                    case 3: continuar = false; break;
                    default: Console.WriteLine("Opción no válida!"); break;
                }
            } while (continuar);

            Console.WriteLine("Que tenga un buen día!");
        }
    }
}