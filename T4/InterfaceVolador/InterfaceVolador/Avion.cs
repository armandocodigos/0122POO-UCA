using System;

namespace InterfaceVolador
{
    public class Avion : PuedeVolar
    {
        public void despegar(){
            Console.WriteLine("Enciende el motor");
        }
        public void volar(){
            Console.WriteLine("Gasta gasolina");
        }
        public void aterrizar(){
            Console.WriteLine("Cae en una pista de aterrizaje");
        }
    }
}