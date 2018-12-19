using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace bonRegelClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var receipt = new List<Bonregel>();
            string actie = null;
            IList<int> deposits = new List<int>();
            int income = 2000;
            int saldo = income;


            Console.WriteLine("Je hebt " + income + "EURO te besteden");

            //Console.WriteLine("x of productt");

            string actiess = null;

            while (actiess != "x")
            {
                Console.WriteLine("Wat wil je doen?(product/som/x/deposit/exportsom)");
                 actiess = Console.ReadLine();

                switch (actiess)
                {
                    case "product":
                        {
                            ToevoegenProduct(receipt);
                        }
                        break ;
                    case "read":
                        {
                            string teksttest;
                            using (var streamReader = new StreamReader(@"C:\Users\dvle\Documents\test.txt"))
                            {
                                teksttest = streamReader.ReadToEnd();
                            }

                            Console.WriteLine("testje: " + teksttest);

                            foreach (string fileregel in File.ReadLines(@"C:\Users\dvle\Documents\test.txt"))
                            {
                                Console.WriteLine("{0}", fileregel);
                            }
                        }
                        break;
                    case "x":
                        {
                            Console.WriteLine("Stop");
                        }
                        break;
                    case "deposit":
                        {
                            Storting(deposits);
                        }
                        break;
                    case "som":
                        {
                            Opsomming(receipt, deposits, saldo);
                        }
                        break;
                    case "exportsom":
                        {
                            ExporstSom(receipt, deposits, saldo);
                        }
                        break;
                    default:
                        Console.WriteLine("Ongeldige keuze");
                        break;
                }
            }
    

            //while (actie != "x")
            //{

            //    //Console.WriteLine("Wat wil je doen?(product/som/x/deposit/exportsom)");
            //    actie = Console.ReadLine();

            //    if (actie == "product")
            //    {
            //        ToevoegenProduct(receipt);
            //        continue;
            //    }
            //    else if (actie == "read")
            //    {
            //        //Tekst test
            //        string teksttest;
            //        using (var streamReader = new StreamReader(@"C:\Users\dvle\Documents\test.txt"))
            //        {
            //            teksttest = streamReader.ReadToEnd();
            //        }

            //        Console.WriteLine("testje: " + teksttest);

            //        foreach (string fileregel in File.ReadLines(@"C:\Users\dvle\Documents\test.txt"))
            //        {
            //            Console.WriteLine("{0}", fileregel);
            //        }
            //    }
            //    else if (actie == "x")
            //    {
            //        Console.WriteLine("Stop");
            //    }
            //    else if (actie == "deposit")
            //    {
            //        Storting(deposits);
            //    }
            //    else if (actie == "som")
            //    {
            //        //opsomming en schrijft deze weg naar een .txt file
            //        Opsomming(receipt, deposits, saldo);
            //    }
            //    else if (actie == "exportsom")
            //    {
            //        ExporstSom(receipt, deposits, saldo);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Ongeldige keuze");
            //    }
            //    Console.WriteLine("-------------------");
            //}
        }

        private static void ExporstSom(List<Bonregel> receipt, IList<int> deposits, int saldo)
        {
            string documentPath =
    Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(documentPath, "financeSum.txt")))
            {
                int totalDeposit;
                foreach (var regel in receipt)
                {
                    outputFile.WriteLine("{0} {1}", regel.Product, regel.Bedrag);
                }
                var groupedProductList = receipt.GroupBy(item => item.Product);
                foreach (var receiptGroup in groupedProductList)
                {
                    outputFile.WriteLine($"product : {receiptGroup.Key} aantal: {receiptGroup.Count()} totaalbedrag: {receiptGroup.Sum(item => item.Bedrag)}");
                }

                totalDeposit = deposits.Sum();
                int totalExpense = receipt.Sum(item => item.Bedrag);
                int totaalProductGroep = receipt.Where(item => item.Product == item.Product).Sum(item => item.Bedrag);
                int totalSaldo = saldo + totalDeposit - totalExpense;

                outputFile.WriteLine("Totaal stortingen: " + totalDeposit);
                outputFile.WriteLine("Rest saldo: " + totalSaldo);
            }
        }

        private static void Opsomming(List<Bonregel> receipt, IList<int> deposits, int saldo)
        {

            int totalDeposit;

            foreach (var regel in receipt)
            {
                Console.Write("Product en bedrag: ");
                Console.WriteLine("{0} {1}", regel.Product, regel.Bedrag);
            }
            var groupedProductList = receipt.GroupBy(item => item.Product);
            foreach (var receiptGroup in groupedProductList)
            {
                Console.WriteLine($"product : {receiptGroup.Key} aantal: {receiptGroup.Count()} totaalbedrag: {receiptGroup.Sum(item => item.Bedrag)}");
            }

            totalDeposit = deposits.Sum();
            int totalExpense = receipt.Sum(item => item.Bedrag);
            int totaalProductGroep = receipt.Where(item => item.Product == item.Product).Sum(item => item.Bedrag);
            int totalSaldo = saldo + totalDeposit - totalExpense;

            Console.WriteLine("Totaal stortingen: " + totalDeposit);
            Console.WriteLine("Rest saldo: " + totalSaldo);
        }

        private static void Storting(IList<int> deposits)
        {
            Console.WriteLine("Hoeveel wil je storten: ");
            int deposit = Convert.ToInt32(Console.ReadLine());
            deposits.Add(deposit);
        }

        private static void ToevoegenProduct(List<Bonregel> receipt)
        {
            string product;
            Console.WriteLine("Geeft product op: ");
            product = Console.ReadLine();

            Console.WriteLine("Geef bedrag op: ");
            int bedrag = Convert.ToInt32(Console.ReadLine());
            var regel = new Bonregel();

            regel.Bedrag = bedrag;
            regel.Product = product;
            receipt.Add(regel);
            return;
        }
    }

    class Bonregel
    {
        public string Product { get; set; }
        public int Bedrag { get; set; }
    }
}
