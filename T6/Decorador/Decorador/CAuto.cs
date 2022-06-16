using System.Net.Configuration;

namespace Decorador
{
    public class CAuto : IComponente
    {
        public string marca { get; set; }
        public string modelo { get; set; }
        public double costo { get; set; }

        public CAuto(string marca, string modelo, double costo)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.costo = costo;
        }

        public double Costo()
        {
            return costo;
        }

        public string Descripción()
        {
            return marca + " " + modelo;
        }
    }
}