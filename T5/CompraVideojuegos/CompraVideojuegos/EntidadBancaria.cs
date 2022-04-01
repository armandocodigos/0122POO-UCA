namespace CompraVideojuegos
{
    public interface EntidadBancaria
    {
        void registrarTarjeta();
        void consultarTarjetas();
        bool realizarCompras(Tarjeta t, double d);
    }
}