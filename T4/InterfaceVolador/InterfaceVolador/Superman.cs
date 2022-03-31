using System;

namespace InterfaceVolador
{
    public class Superman : PuedeVolar
    {
        public void despegar(){
            Console.WriteLine("Levanta un brazo");
        }
        public void volar(){
            Console.WriteLine("Busca algún crimen");
        }
        public void aterrizar(){
            Console.WriteLine("Cae encima de algún criminal");
        }
    }
}