using System;

namespace CalculoCUM
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Cantidad de materias: ");
            int subjects = Convert.ToInt32(Console.ReadLine());

            double sumUM = 0, sumUV = 0;
            for (int i = 1; i <= subjects; i++)
            {
                Console.WriteLine("Materia #" + i);
                Console.Write("UV's: ");
                int uv = Convert.ToInt32(Console.ReadLine());
                Console.Write("Nota: ");
                double grade = Convert.ToDouble(Console.ReadLine());

                sumUV += uv;
                sumUM += (uv * grade);
            }

            double cum = Math.Round(sumUM / sumUV, 2);
            Console.WriteLine("CUM: " + cum);
        }
    }
}