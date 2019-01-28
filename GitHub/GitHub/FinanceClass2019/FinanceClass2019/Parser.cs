using System.Collections.Generic;
using System.IO;

namespace FinanceClass2019
{
    public class Parser
    {
        public string Parse(IList<decimal> deposits, List<Bonregel> receipt, decimal saldo)
        {
            var regel = new Bonregel();

            using (var reader = new StreamReader(@"C:\Users\dvle\Documents\input.txt"))
            {

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var temp = line.Split(" ");
                    receipt.Add(new Bonregel
                    {
                        Bedrag = decimal.Parse(temp[0]),
                        Product = temp[1],

                    });
                }
                return line;
            }
        }
    }
}