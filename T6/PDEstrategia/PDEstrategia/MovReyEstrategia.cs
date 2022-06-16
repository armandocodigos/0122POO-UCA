using System.Windows.Forms;

namespace PDEstrategia
{
    public class MovRey:IMovimiento
    {
        public void mover()
        {
            MessageBox.Show("El rey se puede mover una casilla en cualquier dirección: horizontal, vertical o diagonal. No se puede mover a una casilla ocupada por otra pieza del mismo color.");
        }
    }
}