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
        public int Stortingen(IList<int> deposits)
        {
            Console.WriteLine("Hoeveel wil je storten: ");
            int deposit = Convert.ToInt32(Console.ReadLine());
            deposits.Add(deposit);
            return deposits.Sum();
        }
    }
}
