using System.Collections.Generic;

namespace Monedero_B
{
    public class Monedero
    {
        public List<Moneda> listaMonedas { get; set; }

        public Monedero()
        {
            listaMonedas = new List<Moneda>();
        }
        
        public void añadirMoneda(double pValor, string pNombre){
            Moneda unaMoneda = new Moneda(pValor, pNombre);
        
            listaMonedas.Add(unaMoneda);
        }

        public double consultarTotal(){
            double total = 0;
        
            foreach (Moneda unaMoneda in listaMonedas){
                total += unaMoneda.valor;
            }
        
            return total;
        }
    }
}