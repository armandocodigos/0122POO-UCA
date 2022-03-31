using System;

namespace DiferirEvaluación
{
    public static class Decanato
    {
        public static bool solicitarDiferido(Estudiante e)
        {
            Console.WriteLine("Solicitud de " + e.nombre);
            Console.WriteLine("Carné: " + e.carné);
            Console.WriteLine("Carrera: " + e.carrera);
        
            Console.Write("Evidencia (razón del diferido):");
            string evidencia = Console.ReadLine();
        
            bool respuesta = false;
            if(evidencia.Length> 0){
                Tesoreria.pagar(12.45);
                respuesta = true;
            }
            else{
                respuesta = false;
            }
            return respuesta;
        }
    }
}