using System;

namespace CompraVideojuegos
{
    public static class ConsolaJuegos
    {
        public static void comprarJuego(EntidadBancaria unaEntidad)
        {
            Console.Write("Nombre del juego: ");
            string nombreJuego = Console.ReadLine();
        
            Juego unJuego = BibliotecaJuegos.buscar(nombreJuego);
        
            if(unJuego == null){
                Console.WriteLine("Juego no encontrado en biblioteca");
                return;
            }
        
            if(unJuego is JuegoGratuito){
                GestorArchivos.anexar("Juegos.txt", unJuego.nombre);
                Console.WriteLine("Juego conseguido exitosamente!");
            }
            else{
                JuegoPagado unJuegoPagado = (JuegoPagado) unJuego;
                Console.WriteLine("Juego cuesta $" + unJuegoPagado.precio);
            
                Console.Write("Número de tarjeta: ");
                string numero = Console.ReadLine();
            
                if(unaEntidad.realizarCompras(new Tarjeta(numero, 0), unJuegoPagado.precio)) {
                    GestorArchivos.anexar("Juegos.txt", unJuegoPagado.nombre);
                    Console.WriteLine("Juego comprado exitosamente!");
                }
                else
                    Console.WriteLine("Operación falló!");
            }
        }
    
        public static void jugar()
        {
            Console.Write("Nombre del juego: ");
            string nombreJuego = Console.ReadLine();
        
            Juego unJuego = BibliotecaJuegos.buscar(nombreJuego);
        
            if(unJuego != null){
                Console.WriteLine("Juego " + unJuego.nombre + " encontrado!");
            
                if(GestorArchivos.buscar("Juegos.txt", unJuego.nombre))
                    unJuego.jugar();
                else
                    Console.WriteLine("Primero debe conseguir el juego :(");
            }
            else
                Console.WriteLine("El juego que Ud. busca no existe!");
        }
    }
}