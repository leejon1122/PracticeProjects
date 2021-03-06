﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bonRegelClass
{
    class Sommeer
    {
        public void Sum()
        {
            var receipt = new List<Bonregel>();
            IList<int> deposits = new List<int>();
            int income = 2000;
            int saldo = income;
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
            Console.WriteLine("Rest saldoo: " + totalSaldo);
        }
    }
}
