using System;

namespace MultiplesInterfaces
{
    public class VanHellsing : IHeroe, IPistolero
    {
        public void salvarPersonas(){
            Console.WriteLine("De los vampiros");
        }
    
        public void vencerVillanos(){
            Console.WriteLine("Cruces, agua bendita, balas y estacas");
        }
    
        public void disparar(){
            Console.WriteLine("Balas normales y de plata");
        }
    }
}