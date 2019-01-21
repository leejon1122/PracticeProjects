using System;
using System.Collections.Generic;
using System.Linq;

namespace FinanceClass2019
{
    public class Sommeer
    {
        public decimal Sum(IList<decimal> deposits, List<Bonregel> receipt, decimal saldo)
        {
            decimal income = 2000;
            saldo = income;
            decimal totalDeposit;

            foreach (var regel in receipt)
            {
                Console.Write("Product en bedrag: ");
                Console.WriteLine("{0} {1}", regel.Product, regel.Bedrag);


            }
            var groupedProductList = receipt.GroupBy(item => item.Product);
            foreach (var receiptGroup in groupedProductList)
            {

                Console.WriteLine($"product : {receiptGroup.Key} aantal: {receiptGroup.Count()} totaalbedrag: {receiptGroup.Sum(item => item.Bedrag)}");
                Console.WriteLine("");

            }

            decimal totaalBtw = 0;
            foreach (var bonregel in receipt)
            {
                decimal btwCalc = Math.Round(bonregel.Bedrag * 0.21m, 2);
                //Console.WriteLine($"totaal BTW per product: {btwCalc}");
                totaalBtw += btwCalc;
            }

            //Nog korter opschrijven. ter info
            decimal totaalBtwKorter = 0;
            receipt.Select(bonregel => totaalBtwKorter += Math.Round(bonregel.Bedrag * 0.21m, 2));


            totalDeposit = deposits.Sum();
            decimal totalExpense = receipt.Sum(item => item.Bedrag);
            decimal totaalProductGroep = receipt.Where(item => item.Product == item.Product).Sum(item => item.Bedrag);
            decimal totalSaldo = saldo + totalDeposit - totalExpense;
            decimal btw = totalExpense * 0.21m;
            decimal totaal = totalExpense + totaalBtw;



            Console.WriteLine("Totaal incl BTW: " + Math.Round(totaal, 2));
            Console.WriteLine("");

            Console.WriteLine("Subtotaal excl BTW: " + totalExpense);
            Console.WriteLine("");

            Console.WriteLine("BTW Correct: " + totaalBtw);
            Console.WriteLine("Rest saldo: " + totalSaldo);
            Console.WriteLine("Totaal stortingen: " + totalDeposit);

            return totalSaldo;
        }
    }
}