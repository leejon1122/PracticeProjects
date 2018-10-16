using System;
using System.Collections.Generic;
using System.Text;

namespace GitHub
{
    public class FizzBuzz
    {
        public const string fizz = "Fizz";
        public const string buzz = "Buzz";
        public const string fizzbuzz = "FizzBizz";
        public void Execute()
        {
            List<int> nummers = new List<int>();
            for (int i = 1; i < 40; i++)
            {
                nummers.Add(i);
                string a = Fizzy(i);
                if (a == string.Empty)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(a);
                }
            }

            Console.WriteLine(nummers.Count);

            Console.ReadLine();
        }

        public string Fizzy(int i)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                return fizzbuzz;
            }
            else
            {
                if (i % 3 == 0)
                {
                    return fizz;
                }
                else
                {
                    if (i % 5 == 0)
                    {
                        return buzz;
                    }
                    else
                    {
                        return string.Empty;
                    }
                }
            }
        }
    }
}
