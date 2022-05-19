using System.Collections.Generic;
using System.Linq;
using BibliotecaUCA.Properties;

namespace BibliotecaUCA
{
    public static class MotorBusqueda
    {
        //En la próxima unidad, aquí jalaremos de la BDD
        public static List<Libro> biblioteca()
        {
            List<Libro> biblioteca = new List<Libro>();
            
            biblioteca.Add(new Libro("El francotirador paciente", "Arturo Pérez-Reverte", 
                "Literatura", "PQ6666", Resources.francotirador) );
            biblioteca.Add(new Libro("Criptografía historia de la escritura cifrada", "Juan Carlos Galende Díaz",
                "Criptografía", "Z103", Resources.cripto));
            biblioteca.Add(new Libro("Visual Basic .NET", "Javier Ceballos Sierra",
                "Programación", "QA76", Resources.visualbasic));
            biblioteca.Add(new Libro("Rules for writers", "Diana Hacker",
                "Inglés", "PE1408", Resources.writers));
            
            return biblioteca;
        }

        public static List<Libro> buscarTitulo(string unTitulo)
        {
            return biblioteca()
                .Where(o => o.Titulo.ToLower().Contains(unTitulo.ToLower()))
                .ToList();
        }

        public static List<Libro> buscarAutor(string unAutor)
        {
            return biblioteca()
                .Where(o => o.Autor.ToLower().Contains(unAutor.ToLower()))
                .ToList();
        }
    }
}