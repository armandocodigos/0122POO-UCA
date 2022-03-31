using System;

namespace InterfaceVolador
{
    public class Gaviota : PuedeVolar
    {
        public void despegar(){
            Console.WriteLine("Da un pequeño salto");
        }
        public void volar(){
            Console.WriteLine("Aletea");
        }
        public void aterrizar(){
            Console.WriteLine("Cae en la tierra");
        }
    }
}