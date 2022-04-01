using System.Collections.Generic;
using System.Linq;

namespace CompraVideojuegos
{
    public static class BibliotecaJuegos
    {
        public static Juego buscar(string nombreJuego)
        {
            var listadoJuegos = new List<Juego>()
            {
                new JuegoGratuito("Fornite"),
                new JuegoGratuito("Skyforge"),
                new JuegoGratuito("Warframe"),
                new JuegoGratuito("Apex"),
                new JuegoPagado("Nioh", 20.0),
                new JuegoPagado("HorizonZeroDawn", 15.50),
                new JuegoPagado("Divinity 2", 25.0),
                new JuegoPagado("Spiderman", 40.0)
            };
        
            var juegoBuscado =
                from juego in listadoJuegos
                where nombreJuego.CompareTo(juego.nombre) == 0
                select juego;
        
            if(juegoBuscado.Count() == 0)
                return null;
            else
                return juegoBuscado.ElementAt(0);
        }
    }
}