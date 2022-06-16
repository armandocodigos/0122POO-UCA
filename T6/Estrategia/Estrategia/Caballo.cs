namespace Estrategia
{
    public class Caballo : IAjedrez
    {
        public string mover()
        {
            return "El Caballo se mueve en forma de L.";
        }

        public string describir()
        {
            return "El caballo simboliza el arma de caballería.";
        }
    }
}