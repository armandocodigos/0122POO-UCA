namespace Decorador
{
    public class CNitrogeno: IComponente
    {
        private IComponente ObjetoDecorando;

        public CNitrogeno(IComponente ObjetoBase)
        {
            ObjetoDecorando = ObjetoBase;
        }

        public double Costo()
        {
            return ObjetoDecorando.Costo() + 1000;
        }

        public string Descripción()
        {
            return ObjetoDecorando.Descripción() + " Nitrógeno líquido";
        }
    }
}