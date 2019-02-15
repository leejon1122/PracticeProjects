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
                //Console.Write("Product en bedrag: ");
                //Console.WriteLine(string.Format("{0} {1:C2}", regel.Product, regel.Bedrag));

            }

            Console.WriteLine("LvD B.V.");
            Console.WriteLine("Sterremosstraat");
            Console.WriteLine("1441");
            Console.WriteLine("");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Product            | Aantal |   Bedrag");
            Console.WriteLine("---------------------------------------");
            

            var groupedProductList = receipt.GroupBy(item => item.Product);
            foreach (var receiptGroup in groupedProductList)
            {
                //Console.WriteLine($"product : {receiptGroup.Key} aantal: {receiptGroup.Count()} totaalbedrag: {receiptGroup.Sum(item => item.Bedrag)}");
                //Console.WriteLine("");
                Console.WriteLine(string.Format("{0,-19}|   {1,-4} | {2,8:C2}", receiptGroup.Key, receiptGroup.Count(), receiptGroup.Sum(item => item.Bedrag)));
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

            Console.WriteLine("---------------------------------------");
            Console.WriteLine(string.Format("Totaal:  {0,29:C2} ", Math.Round(totaal, 2)));
            Console.WriteLine("");

            Console.WriteLine(string.Format("Subtotaal:  {0,26:C2} ", totalExpense));
            Console.WriteLine("");

            Console.WriteLine("BTW:  {0,32:C2}", totaalBtw);
            Console.WriteLine("");
            Console.WriteLine("Totaal stortingen:  {0,18:C2}", totalDeposit);
            Console.WriteLine("Rest saldo:  {0,25:C2}", totalSaldo);

            return totalSaldo;
        }
    }
}