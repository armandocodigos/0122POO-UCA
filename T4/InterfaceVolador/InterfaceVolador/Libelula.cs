using System;

namespace InterfaceVolador
{
    public class Libelula : PuedeVolar
    {
        public void despegar(){
            Console.WriteLine("No se :v");
        }
        public void volar(){
            Console.WriteLine("Aletea");
        }
        public void aterrizar(){
            Console.WriteLine("Cae en alguna rama");
        }
    }
}