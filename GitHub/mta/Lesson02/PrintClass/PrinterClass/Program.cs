using System;
using System.Collections.Generic;

namespace PrinterClass
{



    class Program
    {
        static void Main(string[] args)
        {
            
            var receipt = new List<Bon>();
            string actie = null;

            Bon bonnetje = new Bon();

            while (actie != "x")
            {
                Console.WriteLine("Wat wil je doen?((p)roduct/(s)om/(x)/(d)eposit/(e)xportsom)");
                actie = Console.ReadLine();


                switch (actie)
                {
                    case "s":
                        {
                            Opsomming(receipt);


                            //SchermPrinter p = new SchermPrinter();
                            //p.Schermprinter();

                            //Console.ReadLine();

                        }
                        break;

                    case "x":
                        {
                            Console.WriteLine("Stop");
                        }
                        break;

                    case "p":
                        {
                            string product;
                            Console.WriteLine("Geeft product op: ");
                            product = Console.ReadLine();


                            Console.WriteLine("Geef beddrag op: ");
                            int bedrag = Convert.ToInt32(Console.ReadLine());
                            var regel = new Bon();
                            //var result = s.Som(5, 5);

                            bonnetje.Product = product;
                            bonnetje.Bedrag = bedrag;
                            receipt.Add(regel);
                        }
                        break;

                    case "d":
                        {

                        }
                        break;


                    case "e":
                        {

                        }
                        break;

                    default:
                        Console.WriteLine("Ongeldige keuze");
                        break;
                }
                Console.WriteLine("---------------------");
            }



            Console.WriteLine("Product: " + bonnetje.Product);
            Console.WriteLine("Bedrag: " + bonnetje.Bedrag);
            receipt.ForEach(Console.WriteLine);
            Console.ReadLine();

            foreach (var regel in receipt)
            {
                Console.Write("Product en bedrag: ");
                Console.WriteLine("{0} {1}", regel.Product, regel.Bedrag);
            }
        }

        private static void Opsomming(List<Bon> receipt)
        {
            Sommeer s = new Sommeer();
            s();
        }
    }
}


class Bon
{
    public int Income { get; set; }
    public string Product { get; set; }
    public int Deposit { get; set; }
    public int Bedrag { get; set; }
    public int Saldo { get; set; }


}