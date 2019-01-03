using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program

{
    static void Main()
    {
        var receipt = new List<Bonregel>();
        string product = null;
        int bedrag;

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
            else if (product == "export")
            {
                var exportregel = new Exportbon();

                exportregel.Exportbedrag = product;
                exportregel.Exportprod;
            }
            else
            {
                Console.WriteLine("Wat voor bedrag: ");
                bedrag = Convert.ToInt32(Console.ReadLine());
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
class Exportbon
{
    public string Exportprod { get; set; }
    public int Exportbedrag { get; set; }
}


