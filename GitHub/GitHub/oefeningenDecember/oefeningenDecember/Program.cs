using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefeningenDecember
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1 = 0;
            int num2 = 2;

            Console.WriteLine("Geef getal op: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            while (num1 != 0)
            {
                

                if (num1 % num2 == 0)
                {
                    Console.WriteLine("Even");
                }
                else
                {
                    Console.WriteLine("Oneven");
                }
                Console.ReadLine();
            }
            
        }

    }
}
