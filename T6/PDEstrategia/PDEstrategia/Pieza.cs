using System.Windows.Forms;

namespace PDEstrategia
{
    public class Pieza
    {
        public string color;
        public string posicion; 
        private IMovimiento _movimiento;

        public void SetMovimientoEstrategia( IMovimiento movimiento)
        {
            _movimiento = movimiento;
        }

        public void mover()
        {
            _movimiento.mover();
        }
    }
}
