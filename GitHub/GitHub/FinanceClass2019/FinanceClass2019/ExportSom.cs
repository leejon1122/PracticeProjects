using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FinanceClass2019
{
    public class ExportSom
    {
        public int Exporteer(List<Bonregel> receipt, IList<int> deposits, int saldo)
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
                return totalSaldo;
            }
        }
    }
}
