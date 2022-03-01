using System;

namespace ManipulacionStrings
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Console.WriteLine("La longitud de la cadena es: " + txt.Length);
    
            txt = "Hola Mundo!";
            Console.WriteLine(txt.ToUpper());
            Console.WriteLine(txt.ToLower());
    
            // Primera letra de la cadena
            Console.WriteLine(txt[0]);
    
            // Segunda letra de la cadena
            Console.WriteLine(txt[1]);
    
            // Obtener el nombre de archivo (sin la extensión)
            txt = "Archivo: ejemplo.txt";
            int inicio = txt.IndexOf(" ") + 1;
            int final = txt.IndexOf(".") - inicio;
            Console.WriteLine("Nombre del archivo: " + txt.Substring(inicio, final));
        }
    }
}