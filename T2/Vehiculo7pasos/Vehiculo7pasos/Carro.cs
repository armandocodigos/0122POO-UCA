namespace Vehiculo7pasos
{
    //Un carro que avanza y consume gasolina
    public class Carro
    {
        //Atributos
        private double gasolina;
        private double eficiencia;

        //Constructores
        public Carro(double pEficiencia)
        {
            gasolina = 0;
            eficiencia = pEficiencia;
        }

        public Carro(double gasolina, double eficiencia)
        {
            this.gasolina = gasolina;
            this.eficiencia = eficiencia;
        }

        //Métodos
        public void ponerGasolina(double cantidad)
        {
            gasolina += cantidad;
        }

        public void avanzar(double distancia)
        {
            gasolina -= (distancia / eficiencia);
        }

        public double consultarGasolina()
        {
            return gasolina;
        }
    }
}