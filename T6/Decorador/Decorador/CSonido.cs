namespace Decorador
{
    public class CSonido : IComponente
    {
        private IComponente ObjetoDecorando;

        public CSonido(IComponente ObjetoBase)
        {
            ObjetoDecorando = ObjetoBase;
        }

        public double Costo()
        {
            return ObjetoDecorando.Costo() + 250;
        }

        public string Descripción()
        {
            return ObjetoDecorando.Descripción() + " Sistema de Sonido Pro";
        }
    }
}