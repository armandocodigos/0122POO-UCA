namespace CuadrosDialogo
{
    public class Producto
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public double precio { get; set; }
        public string marca { get; set; }

        public Producto()
        {
            
        }

        public Producto(int id, string nombre, double precio, string marca)
        {
            this.id = id;
            this.nombre = nombre;
            this.precio = precio;
            this.marca = marca;
        }
    }
}