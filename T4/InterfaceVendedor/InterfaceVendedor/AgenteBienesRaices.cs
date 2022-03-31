namespace InterfaceVendedor
{
    //Implementando interface Vendedor
    public class AgenteBienesRaices : Vendedor 
    {
        // Atributos
        private int casasVendidas;
        private double comisionTotalGanada, comisionPorcentaje;

        // Constructor
        public AgenteBienesRaices(double unPorcentaje) {
            casasVendidas = 0;
            comisionTotalGanada = 0;
            comisionPorcentaje = unPorcentaje;
        }

        // Metodos que exige la interfaz
        public string ofrecerVenta() {
            return "Casas a la venta!";
        }

        public void ejecutarVenta(int unValor) {
            //unValor = precio de la casa vendida
            casasVendidas++;
            comisionTotalGanada += (unValor * comisionPorcentaje);
        }

        public string consultarInfo() {
            return "Casas vendidas: " + casasVendidas +
                   "\nComisión total ganada: " + comisionTotalGanada +
                   "\nPorcentaje de comisión: " + comisionPorcentaje;
        }
    
        // Otros metodos, en este caso tampoco hay :( x2
    }
}