using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bonRegelClass
{
    public class DepositClass
    {
        public void Stortingen()
        {
            IList<int> deposits = new List<int>();
            Console.WriteLine("Hoeveel wil je storten: ");
            int deposit = Convert.ToInt32(Console.ReadLine());
            deposits.Add(deposit);
            
        }
    }
}
