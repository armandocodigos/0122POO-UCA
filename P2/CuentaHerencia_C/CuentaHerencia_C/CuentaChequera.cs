namespace CuentaHerencia_C
{
    public class CuentaChequera : CuentaBancaria 
    {
        private int contadorTransacciones;

        public CuentaChequera(double balanceInicial) : base(balanceInicial) {
            contadorTransacciones = 0;
        }

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