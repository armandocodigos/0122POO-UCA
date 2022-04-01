using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace CompraVideojuegos
{
    public static class GestorArchivos
    {
        public static string leer(string pArchivo){
            return File.ReadAllText(pArchivo);
        }
        
        public static void anexar(string pArchivo, string frase){
            using (StreamWriter stream = File.AppendText(pArchivo)) {
                stream.WriteLine(frase);
            }
        }
        
        public static void anexar(string pArchivo, Tarjeta pTarjeta){
            using (StreamWriter stream = File.AppendText(pArchivo)) {
                stream.WriteLine(Tarjeta.ToString(pTarjeta));
            }
        }
        
        public static bool buscar(string pArchivo, string frase){
            bool encontrado = false;
            
            using(StreamReader archivo = new StreamReader(pArchivo)) {
                string linea = "";
                while(!encontrado && !archivo.EndOfStream){
                    linea = archivo.ReadLine();
                    
                    if(linea.CompareTo(frase) == 0)
                        encontrado = true;
                }
            }
            return encontrado;
        }
        
        public static Resultado buscar(string pArchivo, Tarjeta pTarjeta, double precio) {
            bool encontrado = false;
            double monto = 0;
            
            using(StreamReader archivo = new StreamReader(pArchivo)) {
                string[] linea;
                while(!encontrado && !archivo.EndOfStream){
                    linea = archivo.ReadLine().Split(',');
                    
                    if(linea[0].CompareTo(pTarjeta.numero) == 0){
                        monto = Convert.ToDouble(linea[1]);
                        encontrado = true;
                    }
                }
            }
            
            if(encontrado){
                if(monto >= precio)
                    return Resultado.ConFondos;
                else
                    return Resultado.SinFondos;
            }
            else
                return Resultado.NoExiste;
        }
        
        public static void pagar(string pArchivo, string numeroTarjeta, double precio) {
            // Pasar de un archivo txt a una lista de objetos
            List<Tarjeta> lista = File.ReadAllLines(pArchivo)
                //.Skip(1) // si tuviera encabezado (ignora la primera linea)
                .Select(v => Tarjeta.FromString(v))
                .ToList();
                
            // En la lista de objetos, descontar el precio del juego
            foreach(Tarjeta unaTarjeta in lista) {
                if(unaTarjeta.numero.CompareTo(numeroTarjeta) == 0) {
                    unaTarjeta.monto -= precio;
                    break;
                }
            }
            
            // Sobreescribir el archivo txt con la lista modificada
            using(StreamWriter archivo = new StreamWriter(pArchivo)) {
                foreach(Tarjeta unaTarjeta in lista) {
                    archivo.WriteLine(Tarjeta.ToString(unaTarjeta));
                }
            }
        }
    }
}