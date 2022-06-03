namespace Blockbuster
{
    public class Género
    {
        public string code { get; set; }
        public string nombre { get; set; }

        public Género()
        {
            
        }

        public Género(string code, string nombre)
        {
            this.code = code;
            this.nombre = nombre;
        }
    }
}