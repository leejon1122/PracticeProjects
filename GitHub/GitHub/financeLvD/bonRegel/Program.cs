using System;
using System.Collections.Generic;

class Program

{
    static void Main()
    {
        var receipt = new List<Bonregel>();
        string product = null;

        while (product != "x")
        {
            Console.WriteLine("Wat voor product: ");
            product = Console.ReadLine();

            if (product == "x")
            {
                Console.WriteLine("Stop");
            }
            else if (product == "som")
            {
                foreach (var regel in receipt)
                {
                    Console.WriteLine("{0} {1}", regel.Product, regel.Bedrag);
                }
            }
            else
            {
                Console.WriteLine("Wat voor bedrag: ");
                int bedrag = Convert.ToInt32(Console.ReadLine());
                var regel = new Bonregel();

                regel.Bedrag = bedrag;
                regel.Product = product;
                receipt.Add(regel);
            }
        }
        Console.ReadLine();
    }
}

class Bonregel
{
    public string Product { get; set; }

    public int Bedrag { get; set; }
}