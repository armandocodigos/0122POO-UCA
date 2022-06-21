namespace Bridge
{
    public class CAbstracción : IMovimiento
    {
        private IMovimiento tipo_tren;

        public CAbstracción(IMovimiento tipo)
        {
            tipo_tren = tipo;
        }

        public void CambiarTipo(IMovimiento tipo)
        {
            tipo_tren = tipo;
        }

        public string TransportarPersonas()
        {
            return tipo_tren.TransportarPersonas();
        }
    }
}