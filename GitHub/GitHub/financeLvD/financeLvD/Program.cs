using System;
using System.Collections.Generic;
using System.Linq;

namespace financeLvD
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            string input = null;
            IList<int> intList1 = new List<int>();
            IList<int> intList1 = new List<int>();

            Console.WriteLine("Welkom bij onze mooie finance app, ga lekker aan de slag!");

            while (input != "x")
            {
                //Console.WriteLine("Geef inkomen op: ");

                Console.WriteLine(" Geef een product: ");

                Console.WriteLine("Geef een bedrag: ");
                input = Console.ReadLine();

                if (input == "x")
                {
                    Console.WriteLine("Stop");
                }
                else if (input == "som")
                {
                    Console.WriteLine(intList1.Sum());
                }
                 
                else
                {
                    intList1.Add(Convert.ToInt32(input));
                }
            }
        }
    }
}