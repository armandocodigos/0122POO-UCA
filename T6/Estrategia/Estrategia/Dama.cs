namespace Estrategia
{
    public class Dama : IAjedrez
    {
        public string mover()
        {
            return "La Dama se mueve en todas las direcciones.";
        }

        public string describir()
        {
            return "La dama simboliza el primer ministro o un alto funcionario.";
        }
    }
}