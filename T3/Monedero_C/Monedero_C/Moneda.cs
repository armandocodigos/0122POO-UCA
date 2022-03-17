using System;

namespace Monedero_C
{
    public class Moneda
    {
        //El setter está privado porque una vez ejecutado el constructor,
        //el valor de la moneda no debería de cambiar (ni su nombre)
        public double valor { get; private set; }
        public String nombre { get; private set; }

        // Constructor sobrecargado
        public Moneda(double pValor, string pNombre){
            valor = pValor;
            nombre = pNombre;
        }
        // Constructor sobrecargado
        public Moneda() : this(1, "Un dólar") {// Llamada al otro constructor
            //Otras sentencias, opcional
            Console.WriteLine("Utilizando el otro constructor");
        }
    }
}