namespace Estrategia
{
    public class Pieza
    {
        /*otras propiedades*/
        public string color { get; set; }
        public string tamaño { get; set; }
        public string material { get; set; }

        public Pieza()
        {
            
        }
        public Pieza(string color, string tamaño, string material)
        {
            this.color = color;
            this.tamaño = tamaño;
            this.material = material;
        }

        /*una variable de tipo IAjedrez*/
        private IAjedrez tipo;

        public void SetTipo(IAjedrez ficha)
        {
            tipo = ficha;
        }

        public string mover()
        {
            return tipo.mover();
        }

        public string describir()
        {
            return tipo.describir();
        }
    }
}