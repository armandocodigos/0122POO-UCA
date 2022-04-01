using System;

namespace CompraVideojuegos
{
    public class JuegoPagado : Juego 
    {
        public double precio { get; set; }
    
        public JuegoPagado(string pNombre, double pPrecio) : base(pNombre) {
            precio = pPrecio;
        }
    
        public override void jugar() {
            Console.WriteLine("Gracias por comprar " + nombre + "!");
            Console.WriteLine("Listo para jugar!");
        }
    }
}