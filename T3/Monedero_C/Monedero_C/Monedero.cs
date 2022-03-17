using System.Collections.Generic;

namespace Monedero_C
{
    public class Monedero
    {
        public List<Moneda> listaMonedas { get; set; }

        public Monedero()
        {
            listaMonedas = new List<Moneda>();
        }
        
        // Método sobrecargado
        public void añadirMoneda(Moneda unaMoneda){
            listaMonedas.Add(unaMoneda);
        }
        // Método sobrecargado
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