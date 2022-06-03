using System;

namespace Blockbuster
{
    public class Película
    {
        public string code { get; set; }
        public string titulo { get; set; }
        public DateTime estreno { get; set; }
        public double precio { get; set; }
        public int duracion { get; set; }
        public int stock { get; set; }
        public string descripcion { get; set; }
        public string id_genero { get; set; }
        public string id_director { get; set; }
        public string id_usuario { get; set; }

        public Película()
        {
            
        }

        public Película(string code, string titulo, DateTime estreno, double precio, int duracion, int stock, string descripcion, string idGenero, string idDirector, string idUsuario)
        {
            this.code = code;
            this.titulo = titulo;
            this.estreno = estreno;
            this.precio = precio;
            this.duracion = duracion;
            this.stock = stock;
            this.descripcion = descripcion;
            id_genero = idGenero;
            id_director = idDirector;
            id_usuario = idUsuario;
        }
    }
}