using System;

namespace MultiplesInterfaces
{
    public class IronMan : IHeroe, IVolador
    {
        public void salvarPersonas(){
            Console.WriteLine("Usando su propia tecnologia");
        }
    
        public void vencerVillanos(){
            Console.WriteLine("Rayos de sus manos y diversas armas");
        }
    
        public void volar(){
            Console.WriteLine("Lo hace gracias a su traje");
        }
    }
}