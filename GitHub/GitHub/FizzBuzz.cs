using System;
using System.Collections.Generic;
using System.Text;

namespace GitHub
{
    public class FizzBuzz
    {
        public void Execute()
        {
            List<int> nummers = new List<int>();
            for (int i = 1; i < 40; i++)
            {
                nummers.Add(i);
                string a = Fizzy(i);
                Console.WriteLine(a);
            }

            Console.WriteLine(nummers.Count);

            Console.ReadLine();
        }

        public string Fizzy(int i)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                return "FizzBuzz";
            }
            else
            {
                if (i % 3 == 0)
                {
                    return "Fizz";
                }
                else
                {
                    if (i % 5 == 0)
                    {
                        return "Buzz";
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
