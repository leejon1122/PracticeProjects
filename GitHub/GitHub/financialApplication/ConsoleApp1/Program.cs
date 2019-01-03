using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

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

            while (actie != "x")
            {
                Console.WriteLine("Wat wil je doen?(product/som/x/deposit/exportsom/read)");
                actie = Console.ReadLine();

                switch (actie)
                {
                    case "product":
                        {
                            ToevoegenProduct(receipt);
                        }
                        break;
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
                                Console.WriteLine($"{fileregel}");
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
                Console.WriteLine("-----------------");
            }
        }

        private static void Sommeren(List<Bonregel> receipt, IList<int> deposits, int saldo)
        {
            int totalDeposit;

            var groupedProductList = receipt.GroupBy(item => item.Product);

            totalDeposit = deposits.Sum();
            int totalExpense = receipt.Sum(item => item.Bedrag);
            int totaalProductGroep = receipt.Where(item => item.Product == item.Product).Sum(item => item.Bedrag);
            int totalSaldo = saldo + totalDeposit - totalExpense;
        }

        private static string GenerateOutput(List<Bonregel> receipt, IList<int> deposits, int saldo)
        {
            StringBuilder builder = new StringBuilder();
            int totalDeposit;

            foreach (var regel in receipt)
            {
                builder.Append("Product en bedrag: ");
                builder.AppendLine($"{regel.Product}, {regel.Bedrag}");
            }
            var groupedProductList = receipt.GroupBy(item => item.Product);
            foreach (var receiptGroup in groupedProductList)
            {
                builder.AppendLine($"product : {receiptGroup.Key} aantal: {receiptGroup.Count()} totaalbedrag: {receiptGroup.Sum(item => item.Bedrag)}");
            }

            totalDeposit = deposits.Sum();
            int totalExpense = receipt.Sum(item => item.Bedrag);
            int totaalProductGroep = receipt.Where(item => item.Product == item.Product).Sum(item => item.Bedrag);
            int totalSaldo = saldo + totalDeposit - totalExpense;

            builder.AppendLine("Totaal stortingen: " + totalDeposit);
            builder.AppendLine("Rest saldo: " + totalSaldo);

            return builder.ToString();
        }

        private static void ExporstSom(List<Bonregel> receipt, IList<int> deposits, int saldo)
        {
            var tekst = GenerateOutput(receipt, deposits, saldo);

            string documentPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);


            using (StreamWriter outputFile = new StreamWriter(Path.Combine(documentPath, "financeSum.txt")))
            {
                outputFile.Write(tekst);
            }
        }

        private static void Opsomming(List<Bonregel> receipt, IList<int> deposits, int saldo)
        {
            var tekst = GenerateOutput(receipt, deposits, saldo);
            Console.WriteLine(tekst);
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
