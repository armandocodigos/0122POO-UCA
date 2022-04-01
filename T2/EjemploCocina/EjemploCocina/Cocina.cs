using System;

namespace EjemploCocina
{
    public class Cocina
    {
        // Atributos
        private string color;
        private int cantidadOrnillas;
        private bool tieneHorno;
        private string marca;
    
        // Constructores
        public Cocina(string pColor, int pCantOrn, bool pTieneHorno, string pMarca)
        {
            color = pColor;
            cantidadOrnillas = pCantOrn;
            tieneHorno = pTieneHorno;
            marca = pMarca;
        }
    
        // Métodos
        public void encender()
        {
            Console.WriteLine("Encendiendo...");
        }
        public void apagar()
        {
            Console.WriteLine("Apagando...");
        }
        public void hornear()
        {
            if (tieneHorno)
                Console.WriteLine("Hecho...");
            else
                Console.WriteLine("Error...");
        }
    }
}