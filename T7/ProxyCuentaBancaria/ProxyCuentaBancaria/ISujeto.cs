using System.Collections.Generic;

namespace ProxyCuentaBancaria
{
    public interface ISujeto
    {
        object Peticion(int opcion, List<object> parametros);
    }
}