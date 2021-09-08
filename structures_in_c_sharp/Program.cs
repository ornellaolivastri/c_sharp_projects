using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_app
{
    class Program
    {
        static void Main(string[] args)
        {
            // esto genera  un mensaje verdadero o falso

            bool bandera = false;

            if (bandera)
            {
                Console.WriteLine("Variable verdadera");
            }
            else
            {
                Console.WriteLine("Variable falsa");
            }

            // esto genera 2 hi there

            int index = 0;

            while (index < 2)
            {
                Console.WriteLine("hi there");
                index++;
            }

            // esto genera 1 oh hi

            int index2 = 5;

            do
            {
                Console.WriteLine("oh, yeah hi");
                index2++;

            } while (index2 == 5);


            //for

            int tabla = 4, limite = 10;

            for (int num = 1; num <= limite; num++)
            {
                
                Console.WriteLine(tabla + " * " + num + " = " + tabla * num);
            }


            Console.Read();
        }
    }
}
