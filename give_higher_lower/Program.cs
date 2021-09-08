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
            int limite = 10, numero = 1;

            while (numero <= limite)
            {
                if(numero % 2 == 0)
                {
                    Console.WriteLine(numero + " es par");

                }else if(numero % 2 == 1)
                {
                    Console.WriteLine(numero + " es impar");
                }
                numero++;
            }
            Console.ReadLine();
        }
    }
}
