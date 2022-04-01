using System;

namespace CompraVideojuegos
{
    public class Tarjeta
    {
        public string numero { get; set; }
        public double monto { get; set; }
    
        public Tarjeta(String pNumero, double pMonto){
            numero = pNumero;
            monto = pMonto;
        }
    
        public static string ToString(Tarjeta pTarjeta){
            return pTarjeta.numero + "," + pTarjeta.monto;
        }
    
        public static Tarjeta FromString(string linea) {
            string[] valores = linea.Split(',');
        
            string unNumero = valores[0];
            double unMonto = Convert.ToDouble(valores[1]);
        
            return new Tarjeta(unNumero, unMonto);
        }
    }
}