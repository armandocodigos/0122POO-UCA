using System;

namespace CompraVideojuegos
{
    public class Cooperativa : EntidadBancaria
    {
        public string nombre { get; set; }
        private string archivo;
        private static int contador = 0;
    
        public Cooperativa(string pNombre){
            nombre = pNombre;
            archivo = "TarjetasCoop.txt";
        }
    
        public void registrarTarjeta() {
            Console.Write("Número de tarjeta: ");
            string numero = Console.ReadLine();
        
            GestorArchivos.anexar(archivo, new Tarjeta(numero, 15));
        
            Console.WriteLine("Tarjeta creada exitosamente!");
        }
    
        public void consultarTarjetas() {
            Console.WriteLine(GestorArchivos.leer(archivo));
        }
    
        public bool realizarCompras(Tarjeta pTarjeta, double precioJuego) {
            if(contador%100 == 0){
                Console.WriteLine("Compra gratuita cortesía de la cooperativa!");
                contador++;
                return true;
            }
        
            bool operacionExitosa = false;
        
            switch(GestorArchivos.buscar(archivo, pTarjeta, precioJuego)){
                case Resultado.NoExiste:
                    Console.WriteLine("No existe su tarjeta!");
                    break;
                case Resultado.SinFondos:
                    Console.WriteLine("Su tarjeta no tiene fondos suficientes!");
                    break;
                case Resultado.ConFondos:
                    Console.WriteLine("Si se tienen fondos suficientes!");
                    Console.WriteLine("Procediendo con su pago...");
                
                    GestorArchivos.pagar(archivo, pTarjeta.numero, precioJuego);
                    Console.WriteLine("Gracias por comprar el juego!");
                    operacionExitosa = true;
                    break;
            }
            return operacionExitosa;
        }
    }
}