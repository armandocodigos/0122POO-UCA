using System;

namespace EjemploFinally
{
    public static class UsoFinally
    {
        public static void generateException(int rec) 
        {
            Console.WriteLine("\nRecibiendo: " + rec);
            try {
                switch (rec){
                    case 0:
                        int t=10 /rec; //Genera un error de división entre cero
                        break;
                    case 1:
                        int[] nums = new int[2];
                        nums[4] = 4; //Genera un error de indexación
                        break;
                    case 2:
                        return; //Retorna desde el bloque try
                }
            }
            catch (DivideByZeroException exc){
                //Capturando la excepción
                Console.WriteLine("No se puede dividir por cero!");
                return; //retorna desde catch
            }
            catch (IndexOutOfRangeException exc){
                //Capturando la excepción
                Console.WriteLine("Elemento no encontrado");
            }
            finally {
                //Esto se ejecuta al salir de los bloques try-catch
                Console.WriteLine("Saliendo de try.");
            }
        }
    }
}