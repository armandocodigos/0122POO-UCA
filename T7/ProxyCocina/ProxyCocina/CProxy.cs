using System;
using System.Windows.Forms;

namespace ProxyCocina
{
    public class CProxy //Clase externa
    {
        public interface ISujeto
        {
            void Peticion(int opcion);
        }

        public class ProxySencilla : ISujeto //Clase interna
        {
            private RecetasSecretas recetario;
            public void Peticion(int opcion)
            {
                if (recetario == null)
                    recetario = new RecetasSecretas();//Solo sucede 1 vez
                if (opcion == 1)
                    recetario.Receta1();
                else if(opcion == 2)
                    recetario.Receta2();
            }
        }

        private class RecetasSecretas //Clase interna 
            //Clase que queremos proteger o esconder
            //Contiene datos "sensibles"
        {
            public void Receta1()
            {
                MessageBox.Show("La receta 1 consta de...");
            }
            public void Receta2()
            {
                MessageBox.Show("La receta 2 consta de...");
            }
        }
    }
}