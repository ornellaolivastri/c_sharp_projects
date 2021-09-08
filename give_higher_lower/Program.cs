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

            int a = 1, b = 3, c = 2;

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
