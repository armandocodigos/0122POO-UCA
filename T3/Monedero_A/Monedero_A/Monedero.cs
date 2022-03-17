namespace Monedero_A
{
    //Esta clase NO tiene cohesión (no tiene responsabilidad única)
    public class Monedero
    {
        private double valorCentavo;
        private double valorCora;
        private double valorDolar;
    
        private int cantidadCentavos;
        private int cantidadCoras;
        private int cantidadDolares;
        
        public Monedero() {
            cantidadCentavos = 0;
            cantidadCoras = 0;
            cantidadDolares = 0;
        
            valorCentavo = 0.01;
            valorCora = 0.25;
            valorDolar = 1.00;
        }
        public void agregarCentavos(int cantidad) {
            cantidadCentavos += cantidad;
        }
        public void agregarCoras(int cantidad) {
            cantidadCoras += cantidad;
        }
        public void agregarDolares(int cantidad) {
            cantidadDolares += cantidad;
        }
        public double consultarTotal() {
            return cantidadDolares * valorDolar
                   + cantidadCoras * valorCora
                   + cantidadCentavos * valorCentavo;
        }
    }
}