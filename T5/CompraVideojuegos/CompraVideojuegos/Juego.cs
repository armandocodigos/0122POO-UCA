namespace CompraVideojuegos
{
    public abstract class Juego
    {
        public string nombre { get; set; }
    
        public Juego(string pNombre) {
            nombre = pNombre;
        }
    
        public abstract void jugar();
    }
}