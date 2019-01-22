using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FinanceClass2019
{
    public class ExportSom
    {
        public decimal Exporteer(List<Bonregel> receipt, IList<decimal> deposits, decimal saldo)
        {
            string documentPath =
    Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(documentPath, "financeSum.csv")))
            {
                decimal totalDeposit;
                foreach (var regel in receipt)
                {
                    //outputFile.WriteLine(string.Format("{0,-20}  {1,10:C2}", regel.Product, regel.Bedrag));
                    //outputFile.WriteLine("");
                    //outputFile.WriteLine();
                }


                outputFile.WriteLine("LvD B.V.");
                outputFile.WriteLine("Sterremosstraat ");
                outputFile.WriteLine("1441 ");
                outputFile.WriteLine("");
                outputFile.WriteLine("---------------------------------------");
                outputFile.WriteLine("Product            | Aantal |   Bedrag");
                outputFile.WriteLine("---------------------------------------");


                var groupedProductList = receipt.GroupBy(item => item.Product);
                foreach (var receiptGroup in groupedProductList)
                {
                    //outputFile.WriteLine($"product : {receiptGroup.Key} aantal: {receiptGroup.Count()} totaalbedrag: {receiptGroup.Sum(item => item.Bedrag)}");
                    //outputFile.WriteLine(string.Format("product:{0,-20} " + receiptGroup.Key+  "aantal: " + receiptGroup.Count() + "totaalbedrag: {1,10:C2}" + receiptGroup.Sum(item => item.Bedrag)));
                    outputFile.WriteLine(string.Format("{0,-19}|   {1,-4} | {2,8:C2}", receiptGroup.Key, receiptGroup.Count(), receiptGroup.Sum(item => item.Bedrag)));
                }

                decimal totaalBtw = 0;
                foreach (var bonregel in receipt)
                {
                    decimal btwCalc = Math.Round(bonregel.Bedrag * 0.21m, 2);
                    //Console.WriteLine($"totaal BTW per product: {btwCalc}");
                    totaalBtw += btwCalc;
                }

                decimal totaalBtwKorter = 0;
                receipt.Select(bonregel => totaalBtwKorter += Math.Round(bonregel.Bedrag * 0.21m    , 2));


                totalDeposit = deposits.Sum();
                decimal totalExpense = receipt.Sum(item => item.Bedrag);
                decimal totaalProductGroep = receipt.Where(item => item.Product == item.Product).Sum(item => item.Bedrag);
                decimal totalSaldo = saldo + totalDeposit - totalExpense;
                decimal btw = totalExpense * (1.21m / 100m);
                decimal totaal = totalExpense + totaalBtw;

                //outputFile.WriteLine(string.Format("" | "Totaal inc BTW: " + Math.Round(totaal, 2)));
                outputFile.WriteLine("---------------------------------------");
                outputFile.WriteLine(string.Format("Totaal:  {0,29:C2} ", Math.Round(totaal, 2)));
                outputFile.WriteLine("");

                outputFile.WriteLine(string.Format("Subtotaal:  {0,26:C2} ", totalExpense));
                Console.WriteLine("");

                outputFile.WriteLine("BTW:  {0,32:C2}" , totaalBtw);
                outputFile.WriteLine("");
                outputFile.WriteLine("Totaal stortingen:  {0,18:C2}", totalDeposit);
                outputFile.WriteLine("Rest saldo:  {0,25:C2}", totalSaldo);
                    
                return totalSaldo;
            }
        }
    }
}