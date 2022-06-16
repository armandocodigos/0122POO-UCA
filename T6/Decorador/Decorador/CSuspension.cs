namespace Decorador
{
    public class CSuspension: IComponente
    {
        private IComponente ObjetoDecorando;

        public CSuspension(IComponente ObjetoBase)
        {
            ObjetoDecorando = ObjetoBase;
        }

        public double Costo()
        {
            return ObjetoDecorando.Costo() + 500;
        }

        public string Descripción()
        {
            return ObjetoDecorando.Descripción() + " Suspensión";
        }
    }
}