using System;

namespace MultiplesInterfaces
{
    public class AllMight : IHeroe, ICuerpoACuerpo
    {
        public void salvarPersonas(){
            Console.WriteLine("Con una sonrisa");
        }
    
        public void vencerVillanos(){
            Console.WriteLine("Gracias al One for All");
        }
    
        public void golpear(){
            Console.WriteLine("Distintos golpes llamados smash!");
        }
    }
}