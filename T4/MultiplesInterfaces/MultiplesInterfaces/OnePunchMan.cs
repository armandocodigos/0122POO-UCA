using System;

namespace MultiplesInterfaces
{
    public class OnePunchMan : IHeroe, ICuerpoACuerpo
    {
        public void salvarPersonas(){
            Console.WriteLine("Eliminando villanos");
        }
    
        public void vencerVillanos(){
            Console.WriteLine("De un solo golpe");
        }
    
        public void golpear(){
            Console.WriteLine("Un solo golpe basta");
        }
    }
}