﻿using System;
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
            string product = null;
            IList<int> deposits = new List<int>();
            int income = 2000;
            int saldo = income;


            Console.WriteLine("Je hebt " + income + "EURO te besteden");

            while (product != "x")
            {

                Console.WriteLine("Wat wil je doen?( product/som/x/deposit)");
                product = Console.ReadLine();

                if (product == "product")
                {
                    ToevoegenProduct(receipt);
                    continue;
                }
                else if (product == "x")
                {
                    Console.WriteLine("Stop");
                }
                else if (product == "deposit")
                {
                    Storting(deposits);
                }
                else if (product == "som")
                {
                    //opsomming en schrijft deze weg naar een .txt file
                    Opsomming(receipt, deposits, saldo);
                }
                else if (product == "exportsom")
                {
                    
                }
                else
                {
                    Console.WriteLine("Ongeldige keuze");
                }
                Console.WriteLine("-------------------");
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

            //Schrijft naar .txt file
            //string documentPath =
            //Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            //using (StreamWriter outputFile = new StreamWriter(Path.Combine(documentPath, "financeSum.txt")))
            //{
            //    foreach (var regel in receipt)
            //    {
            //        outputFile.WriteLine("{0} {1}", regel.Product, regel.Bedrag);

            //    }
            //    foreach (var receiptGroup in groupedProductList)

            //    {
            //        outputFile.WriteLine($"product: {receiptGroup.Key} aantal: {receiptGroup.Count()} totaalbedrag: {receiptGroup.Sum(item => item.Bedrag)}");
            //    }
            //    outputFile.WriteLine("Totaal stortingen: " + totalDeposit);
            //    outputFile.WriteLine("Rest saldo: " + totalSaldo);
            //}
            //return;
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
        }
    }

    class Bonregel
    {
        public string Product { get; set; }
        public int Bedrag { get; set; }
    }
    class Totaalregel
    {
        public string Naam { get; set; }
        public int Bedrag { get; set; }
    }
}
