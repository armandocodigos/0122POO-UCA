namespace CuentaHerencia_B
{
    public class CuentaChequera : CuentaBancaria 
    {
        private int contadorTransacciones;

        public override void depositar(double cantidad) {
            contadorTransacciones++;
            base.depositar(cantidad);
        }

        public override void retirar(double cantidad) {
            contadorTransacciones++;
            base.retirar(cantidad);
        }

        public int getTransacciones() {
            return contadorTransacciones;
        }
    }
}