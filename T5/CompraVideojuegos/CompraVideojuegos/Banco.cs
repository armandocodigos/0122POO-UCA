using System;

namespace CompraVideojuegos
{
    public class Banco : EntidadBancaria
    {
        public string nombre { get; set; }
        public double comision { get; set; }
        private string archivo;
    
        public Banco(string pNombre){
            nombre = pNombre;
            comision = 0.10;
            archivo = "TarjetasBanco.txt";
        }
    
        public void registrarTarjeta() {
            Console.Write("Número de tarjeta: ");
            string numero = Console.ReadLine();
        
            GestorArchivos.anexar(archivo, new Tarjeta(numero, 200));
        
            Console.WriteLine("Tarjeta creada exitosamente!");
        }
    
        public void consultarTarjetas() {
            Console.WriteLine(GestorArchivos.leer(archivo));
        }
    
        public bool realizarCompras(Tarjeta pTarjeta, double precioJuego) {
            precioJuego *= (1 + comision);
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
                    Console.WriteLine("Comisión del " + comision + "%");
                    Console.WriteLine("Precio aumentado a $" + precioJuego);
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