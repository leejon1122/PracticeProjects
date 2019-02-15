using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceClass2019
{
    public class DepositClass
    {
        public decimal Stortingen(IList<decimal> deposits)
        {
            Console.WriteLine("Hoeveel wil je storten: ");
            decimal deposit = decimal.Parse(Console.ReadLine());
            deposits.Add(deposit);
            return deposits.Sum();
        }
    }
}