using System;

namespace InterfaceVolador
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Forma de implementar de una Gaviota:");
            Gaviota juanSalvador = new Gaviota();
            juanSalvador.despegar();
            juanSalvador.volar();
            juanSalvador.aterrizar();
        
            Console.WriteLine("\nForma de implementar de un avión:");
            Avion unAvion = new Avion();
            unAvion.despegar();
            unAvion.volar();
            unAvion.aterrizar();
		
            Console.WriteLine("\nForma de implementar de una libélula:");
            Libelula unaLibelula = new Libelula();
            unaLibelula.despegar();
            unaLibelula.volar();
            unaLibelula.aterrizar();
		
            Console.WriteLine("\nForma de implementar de superman:");
            Superman clarkKent = new Superman();
            clarkKent.despegar();
            clarkKent.volar();
            clarkKent.aterrizar();
        }
    }
}