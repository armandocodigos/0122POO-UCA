namespace Estrategia
{
    public class Torre : IAjedrez
    {
        public string mover()
        {
            return "La Torre se mueve en direcciones ortogonales.";
        }

        public string describir()
        {
            return "La torre simboliza una fortificación.";
        }
    }
}