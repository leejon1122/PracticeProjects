using System;
using System.Collections.Generic;
using System.Linq;

namespace rebuildFinance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Product");

            var receipt = new List<Bonregel>();
            string actie = null;
            List<string> products = new List<string>();

            while (actie != "x")
            {
                Console.WriteLine("Wat wil je doen: ");
                actie = Console.ReadLine();
                switch (actie)
                {
                    case "p":
                        {
                            Console.WriteLine("Geef product op:");
                            string product = Console.ReadLine();

                            Console.WriteLine("Geef bedrag op:");
                            int bedrag = Convert.ToInt32(Console.ReadLine());

                            var regel = new Bonregel();
                            regel.Bedrag = bedrag;
                            regel.Product = product;
                            receipt.Add(regel);
                        }
                        break;
                    case "d":
                        {
                            Console.WriteLine();
                        }
                        break;
                    case "s":
                        {
                            var groupedProductList = receipt.GroupBy(item => item.Product);
                            foreach (var productregel in receipt)
                            {
                                Console.WriteLine("Product: " + productregel.Product);
                                Console.WriteLine("Bedrag: " + productregel.Bedrag);
                            }

                        }
                        break;
                    case "x":
                        {
                            StopApp stop = new StopApp();
                            var quit = stop.Quit();
                        }
                        break;
                    default:
                        Console.WriteLine("Ongeldige keuze!");
                        break;
                }
                Console.WriteLine("-------------------");
            }
        }
        class Bonregel
        {
            public string Product { get; set; }
            public int Bedrag { get; set; }
        }
    }
}
