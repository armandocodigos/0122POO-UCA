using System;

namespace MultiplesInterfaces
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ejemplo de múltiples interfaces:\n");
        
            Superman clark = new Superman();
            CosasDeHeroes(clark);
            CosasDeVoladores(clark);
        }
        
        public static void CosasDeHeroes(IHeroe algunHeroe)
        {
            algunHeroe.salvarPersonas();
            algunHeroe.vencerVillanos();
        }
    
        public static void CosasDeVoladores(IVolador algunVolador)
        {
            algunVolador.volar();
        }
    }
}