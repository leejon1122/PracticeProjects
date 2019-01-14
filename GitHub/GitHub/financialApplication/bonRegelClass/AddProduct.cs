using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bonRegelClass
{
    public class AddProduct
    {
        public void Addprod()
        {
            var receipt = new List<Bonregel>();

            string product;
            Console.WriteLine("Geeft product op: ");
            product = Console.ReadLine();

            Console.WriteLine("Geef bedrag op: ");
            int bedrag = Convert.ToInt32(Console.ReadLine());
            var regel = new Bonregel();

            regel.Bedrag = bedrag;
            regel.Product = product;
            receipt.Add(regel);
            return;

        }
    }
}
