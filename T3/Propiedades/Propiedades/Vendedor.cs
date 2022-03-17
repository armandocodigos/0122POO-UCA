namespace Propiedades
{
    public class Vendedor
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public double ventas { get; set; }
    
        public Vendedor(int pId, string pNombre){
            id = pId;
            nombre = pNombre;
            ventas = 0;
        }
    
        public Vendedor(int pId, string pNombre, double pVentas){
            id = pId;
            nombre = pNombre;
            ventas = pVentas;
        }
    
        public void RealizarVenta(){
            ventas++;
        }
    }
}