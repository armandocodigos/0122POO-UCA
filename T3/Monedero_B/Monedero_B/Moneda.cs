using System;

namespace Monedero_B
{
    public class Moneda
    {
        public double valor { get; private set; }
        public String nombre { get; private set; }

        public Moneda(double valor, string nombre)
        {
            this.valor = valor;
            this.nombre = nombre;
        }
        
        //El setter está privado porque una vez ejecutado el constructor,
        //el valor de la moneda no debería de cambiar (ni su nombre)
    }
}