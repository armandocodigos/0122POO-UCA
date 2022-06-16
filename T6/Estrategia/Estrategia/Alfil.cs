namespace Estrategia
{
    public class Alfil : IAjedrez
    {
        public string mover()
        {
            return "El Alfil se mueve en direcciones diagonales.";
        }

        public string describir()
        {
            return "El alfil simboliza un oficial del ejército o un funcionario medio.";
        }
    }
}