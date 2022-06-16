using System.Windows.Forms;

namespace PDEstrategia
{
    public class MovAlfil: IMovimiento
    {
        public void mover()
        {
            MessageBox.Show("El Alfil se mueve el linea recta");
        }
    }
}