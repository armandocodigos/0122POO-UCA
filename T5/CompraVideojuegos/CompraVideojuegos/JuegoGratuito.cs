using System;

namespace CompraVideojuegos
{
    public class JuegoGratuito : Juego 
    {
        public JuegoGratuito(string pNombre) : base(pNombre) {
            // nada
        }
    
        public override void jugar() {
            Console.WriteLine("Bienvenido al juego gratuito " + nombre);
            Console.WriteLine("Listo para jugar!");
        }
    }
}