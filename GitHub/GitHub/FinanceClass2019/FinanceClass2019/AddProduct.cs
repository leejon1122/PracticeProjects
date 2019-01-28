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
            decimal bedrag = decimal.Parse(Console.ReadLine());
            var regel = new Bonregel();

            regel.Bedrag = bedrag;
            regel.Product = product;
            receipt.Add(regel);


            return product + bedrag;

            
        }
    }
}
