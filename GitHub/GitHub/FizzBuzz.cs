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
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else
                {
                    if (i % 3 == 0)
                    {
                        Console.WriteLine("Fizz");
                    }
                    else
                    {
                        if (i % 5 == 0)
                        {
                            Console.WriteLine("Buzz");
                        }
                        else
                        {
                            Console.WriteLine(i);
                        }
                    }
                }
            }

            Console.WriteLine(nummers.Count);

            Console.ReadLine();
        }
    }
}
