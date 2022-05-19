using System.Drawing;

namespace BibliotecaUCA
{
    public class Libro
    {
        public Bitmap Imagen { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Tema { get; set; }
        public string Clasificación { get; set; }

        public Libro(string titulo, string autor, string tema, string clasificación, Bitmap imagen)
        {
            Titulo = titulo;
            Autor = autor;
            Tema = tema;
            Clasificación = clasificación;
            Imagen = imagen;
        }
    }
}