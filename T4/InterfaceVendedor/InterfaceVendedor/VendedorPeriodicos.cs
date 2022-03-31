namespace InterfaceVendedor
{
    //Implementando interface Vendedor
    public class VendedorPeriodicos : Vendedor 
    {
        // Atributo
        private int periodicosVendidos;
    
        // Constructor 
        public VendedorPeriodicos() {
            periodicosVendidos = 0;
        }
    
        // Metodos que exige la interfaz
        public string ofrecerVenta() {
            return "Periódicos a la venta!";
        }
        public void ejecutarVenta(int unValor) {
            //unValor = cantidad de periódicos
            periodicosVendidos += unValor;
        }
        public string consultarInfo() {
            return "Cantidad de periódicos vendidos: " + periodicosVendidos;
        }
    
        // Otros metodos, en este caso no hay :(
    }
}