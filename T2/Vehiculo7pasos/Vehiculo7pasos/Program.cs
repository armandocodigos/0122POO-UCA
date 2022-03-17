using System;

namespace Vehiculo7pasos
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Carro unCarro = new Carro(10);

            unCarro.ponerGasolina(20);
            unCarro.avanzar(100);
            Console.Write("Gasolina restante: ");
            Console.Write(unCarro.consultarGasolina());
            Console.WriteLine(" galones.");

            
        }
    }
}