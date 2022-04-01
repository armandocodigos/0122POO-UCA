using System;

namespace EjemploThrow_B
{
    public static class ClaseA
    {
        public static void generarExcepciones() 
        {
            // Notar que el arreglo "num" tiene más elementos que "denom"
            int[] nums = {4, 8, 16, 32, 64, 128, 256, 512};
            int[] denom = {2, 0, 4, 4, 0, 8};
        
            // Recorrer ambos arreglos
            for (int i = 0; i < nums.Length; i++) {
                try {
                    int division = nums[i] / denom[i];
                    Console.WriteLine(nums[i] + " / " + denom[i] + " es " + division);
                } catch (ArithmeticException exc){
                    // Cuando el denominador es cero...
                    Console.WriteLine("No se puede dividir por cero!.");
                }
                catch (IndexOutOfRangeException exc) {
                    // Eventualmente no habrá denominador (el arreglo es más pequeño)
                    Console.WriteLine("No se encontró ningún elemento.");
                    throw exc; //Relanzando la excepción
                }
            }
        }
    }
}