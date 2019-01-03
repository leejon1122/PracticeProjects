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

            int getal;
            Console.WriteLine("Geef getal op: ");
            getal = Convert.ToInt32(Console.ReadLine());

            for (int j = 0; j < getal; j++)
            {
                Console.Write(" " + getal);
            }
        }

    }
}
