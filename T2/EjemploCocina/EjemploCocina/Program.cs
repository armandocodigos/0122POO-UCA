using System;

namespace EjemploCocina
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Clase: Cocina
            // Objetos (instancias): cocina01 y cocina 02
            // Parámetros de construcción: "verde" y "gris" (color),
            // 4 y 6 (cant ornillas), false y true (tiene horno) y 
            // "LG" y "mabe" (marca)
            // Atributos: color, cantOrnillas, tieneHorno y marca
            // Métodos: encender, apagar y hornear
            // Constructores: solo tengo 1 (esto lo explicaré después)
        
            Console.WriteLine("Cocina 1:");
            Cocina cocina01 =
                new Cocina("verde", 4, false, "LG");
            cocina01.encender();
            cocina01.apagar();
            cocina01.hornear();
        
            Console.WriteLine("Cocina 2:");
            Cocina cocina02 =
                new Cocina("gris", 6, true, "Mabe");
            cocina02.encender();
            cocina02.apagar();
            cocina02.hornear();
        }
    }
}