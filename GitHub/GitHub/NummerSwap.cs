using System;
using System.Collections.Generic;
using System.Text;

namespace GitHub
{
    public class NummerSwap
    {
        public void Swap()
        {
            Console.Write("Voernummers in: ");
            string nummers = Console.ReadLine();
            string result = SwapNummer(nummers);

            result += " ";

            Console.WriteLine("Results: " + result);

            Console.ReadLine();
        }

        public string SwapNummer(string nummers)
        {
            char[] nummersArray = nummers.ToCharArray();
            Array.Reverse(nummersArray);

            string result = "";

            foreach (char item in nummersArray)
            {
                result += item;
            }
            return result;
        }
    }
}
