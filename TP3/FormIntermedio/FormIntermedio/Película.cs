namespace FormIntermedio
{
    public class Película
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string genero { get; set; }

        public Película()
        {
            
        }

        public Película(int id, string nombre, string genero)
        {
            this.id = id;
            this.nombre = nombre;
            this.genero = genero;
        }
    }
}