using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bonRegelClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var receipt = new List<Bonregel>();
            string product = null;

            while (product != "x")
            {
                Console.WriteLine("Geeft product op: ");
                product = Console.ReadLine();

                if (product == "x")
                {
                    Console.WriteLine("Stop");
                }

                else if (product == "som")
                {
                    
                    foreach (var regel in receipt)
                    {
                        Console.WriteLine("{0} {1}" + regel.Product + regel.Bedrag);
                    }
                }
                else
                {
                    Console.WriteLine("Geef bedrag op: ");
                    int bedrag = Convert.ToInt32(Console.ReadLine());
                    var regel = new Bonregel();

                    regel.Bedrag = bedrag;
                    regel.Product = product;

                    receipt.Add(regel);
                }
            }
        }
    }

    class Bonregel
    {
        public string Product { get; set; }
        public int Bedrag { get; set; }
    }
}
