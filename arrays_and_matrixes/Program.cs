using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays_and_matrixes
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numeros = new int[10];

            numeros[0] = 75;
            numeros[1] = 45;

            for (int i = 2; i < 5; i++)
            {
                numeros[i] = i + 1;
            }

            Console.WriteLine(numeros[0]);
            Console.WriteLine(numeros[1]);

            for (int i = 2; i < 10; i++)
            {
                numeros[i] = i + 1;
                Console.Write(numeros[i] + " - ");
            }

            Console.WriteLine();

            //--------------------------------------------------

            int[] numeros2 = { 4, 8, 7, 2, 1 };
            int resultado = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                resultado += numeros[i];                       // suma y asignacion al mismo tiempo
            }

            Console.WriteLine("La suma del array es " + resultado);
            Console.WriteLine();

            // MATRICES -------------------------------------------------

            int[,] numeros3 = new int[10, 8];
            Random randomNumber = new Random();

            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    numeros3[x, y] = randomNumber.Next(0, 9);
                    Console.Write(numeros3[x, y] + "  ");
                }
                Console.WriteLine();
            }

            //suma de cada columna -------------------

            int[] resultado2 = new int[10]; // cada elemento sera la sumatoria de cada columna       

            for (int a = 0; a < 8; a++)
            {
                resultado2[a] = 0;

                for (int b = 0; b < 10; b++) {
                    resultado2[a] += numeros3[b, a];
                }

                Console.Write(resultado2[a] + " ");
            }

            Console.Read();
        }   
    }
}
