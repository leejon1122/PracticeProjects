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

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(documentPath, "financeSum.txt")))
            {
                decimal totalDeposit;
                foreach (var regel in receipt)
                {
                    outputFile.WriteLine("{0} {1}", regel.Product, regel.Bedrag);
                }
                var groupedProductList = receipt.GroupBy(item => item.Product);
                foreach (var receiptGroup in groupedProductList)
                {
                    outputFile.WriteLine($"product : {receiptGroup.Key} aantal: {receiptGroup.Count()} totaalbedrag: {receiptGroup.Sum(item => item.Bedrag)}");
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

                outputFile.WriteLine("Totaal inc BTW: " + Math.Round(totaal, 2));
                Console.WriteLine("");

                outputFile.WriteLine("Subtotaal " + totalExpense);
                Console.WriteLine("");

                outputFile.WriteLine("BTW: " + totaalBtw);
                outputFile.WriteLine("Rest saldo: " + totalSaldo);
                outputFile.WriteLine("Totaal stortingen: " + totalDeposit);
                    
                return totalSaldo;
            }
        }
    }
}