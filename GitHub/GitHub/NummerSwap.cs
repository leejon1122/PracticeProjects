using System;
using System.Collections.Generic;
using System.Text;

namespace GitHub
{
    class NummerSwap
    {
        public void Swap()
        {
            Console.Write("Voernummers in: ");
            string nummers = Console.ReadLine();

            char[] nummersArray = nummers.ToCharArray();
            Array.Reverse(nummersArray);

            string result = "";

            foreach (char item in nummersArray)
            {
                result += item;
            }

            result += " ";

            Console.WriteLine("Results: " + result);

            Console.ReadLine();
        }
    }
}
