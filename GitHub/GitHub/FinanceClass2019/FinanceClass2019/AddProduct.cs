using System;
using System.Collections.Generic;

namespace FinanceClass2019
{
    public class AddProduct
    {
        public string Addprod(List<Bonregel> receipt)
        {
            string product;
            Console.WriteLine("Geeft product op: ");
            product = Console.ReadLine();

            Console.WriteLine("Geef bedrag op: ");
            int bedrag = Convert.ToInt32(Console.ReadLine());
            var regel = new Bonregel();

            regel.Bedrag = bedrag;
            regel.Product = product;
            receipt.Add(regel);

            return product + bedrag;
        }
    }
}
