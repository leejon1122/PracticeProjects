using System;
using System.Collections.Generic;

namespace FinanceClass2019
{
    class ReturnProd
    {
        public string Retrouneer(List<Bonregel> receipt)
        {
            Console.WriteLine("Geef product op: ");
            string retour = Console.ReadLine();
                        
            foreach (var item in receipt)
            {
                if (retour == item.Product)
                {
                    receipt.Remove(item);
                }
            }
            return retour;
        }
    }
}