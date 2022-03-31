using System;

namespace MultiplesInterfaces
{
    public class Superman : IHeroe, IVolador
    {
        public void salvarPersonas(){
            Console.WriteLine("Super fuerza y velocidad");
        }
    
        public void vencerVillanos(){
            Console.WriteLine("Rayos de sus ojos");
        }
    
        public void volar(){
            Console.WriteLine("Lo hace de manera nata");
        }
    }
}