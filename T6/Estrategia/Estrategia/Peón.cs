namespace Estrategia
{
    public class Peón : IAjedrez
    {
        public string mover()
        {
            return "El Peón se mueve hacia adelante una casilla.";
        }

        public string describir()
        {
            return "El peón simboliza un soldado de infantería.";
        }
    }
}