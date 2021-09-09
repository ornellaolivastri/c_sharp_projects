using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace give_higher_lower
{
    class Program
    {
        static void Main(string[] args)
        {
            // GIVE HIGHER ----------------------------

            Console.WriteLine("Escribe el numero a: ");
            //int a = Console.ReadLine(); esto no se puede utilizar porque no se puede
            //                            modificar un tipo int a un tipo string
            // Hay que "parcear" el valor, o sea cambiar su tipo para que se adapte
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Escribe el numero b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Escribe el numero c: ");
            int c = int.Parse(Console.ReadLine());

            if(a > b) // a es mayor que b
            {
                if (a > c)
                {
                    Console.WriteLine("a es el mayor");
                }
                else
                {
                    Console.WriteLine("c es el mayor");
                }

            }
            else // b es mayor que a
            {
                if (b > c)
                {
                    Console.WriteLine("b es el mayor");
                }
                else
                {
                    Console.WriteLine("c es el mayor");
                }
                   
            }

            // GIVE LOWER ----------------------------

            if (a < b) // a es menor que b
            {
                if (a < c)
                {
                    Console.WriteLine("a es el menor");
                }
                else
                {
                    Console.WriteLine("c es el menor");
                }

            }
            else // b es menor que a
            {
                if (b < c)
                {
                    Console.WriteLine("b es el menor");
                }
                else
                {
                    Console.WriteLine("c es el menor");
                }

            }

            Console.ReadLine();
        }
    }
}
