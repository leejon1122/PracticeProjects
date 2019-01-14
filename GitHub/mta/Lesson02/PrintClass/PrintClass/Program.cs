using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintClass
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
                Console.WriteLine("Wat wil je doen?((p)roduct/(s)om/(x)/(d)eposit/(e)xportsom)");
                actie = Console.ReadLine();

                switch (actie)
                {
                    case "p":
                        {
                            ToevoegenProduct(receipt);
                        }
                        break;
                    case "r":
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
                                Console.ReadLine();
                            }
                        }
                        break;
                    case "x":
                        {
                            Console.WriteLine("Stop");
                        }
                        break;
                    case "d":
                        {
                            Storting(deposits);
                        }
                        break;
                    case "s":
                        {
                            Opsomming(receipt, deposits, saldo);
                        }
                        break;
                    case "e":
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