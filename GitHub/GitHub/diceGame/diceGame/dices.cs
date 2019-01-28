using System;
using System.Collections.Generic;

namespace diceGame
{
    public class Dices
    {
        public int Werp(IList<int>waarde)
        {
            

            Random rnd = new Random();
            int dice1 = rnd.Next(1, 7);
            int dice2 = rnd.Next(5, 7);

            if (dice1 == 1)
            {
                Console.WriteLine("*");
            }
            else if (dice1 == 2)
            {
                Console.WriteLine("*");
                Console.WriteLine("  ");
                Console.WriteLine("  *");
            }

            else if (dice1 == 3)
            {
                Console.WriteLine("*");
                Console.WriteLine(" *");
                Console.WriteLine("  *");
            }
            else if (dice1 == 4)
            {
                Console.WriteLine("* *");
                Console.WriteLine(" ");
                Console.WriteLine("* *");
            }
            else if (dice1 == 5)
            {
                Console.WriteLine("* *");
                Console.WriteLine(" * ");
                Console.WriteLine("* *");
            }
            else if (dice1 == 6)
            {
                Console.WriteLine("* *");
                Console.WriteLine("* *");
                Console.WriteLine("* *");
            }


            if (dice2 == 1)
            {
                Console.WriteLine("");
                Console.WriteLine("*");
                dice2++;
            }
            else if (dice2 == 2)
            {
                Console.WriteLine("");
                Console.WriteLine("*");
                Console.WriteLine("  ");
                Console.WriteLine("  *");
                dice2++;
            }

            else if (dice2 == 3)
            {
                Console.WriteLine("");
                Console.WriteLine("*");
                Console.WriteLine(" *");
                Console.WriteLine("  *");
                dice2++;
            }
            else if (dice2 == 4)
            {
                Console.WriteLine("");
                Console.WriteLine("* *");
                Console.WriteLine(" ");
                Console.WriteLine("* *");
                dice2++;
            }
            else if (dice2 == 5)
            {
                Console.WriteLine("");
                Console.WriteLine("* *");
                Console.WriteLine(" * ");
                Console.WriteLine("* *");
                dice2++;
            }
            else if (dice2 == 6)
            {
                Console.WriteLine("");
                Console.WriteLine("* *");
                Console.WriteLine("* *");
                Console.WriteLine("* *");
                for (int i= 0; dice1 == 20; dice1++)
                {
                    Console.WriteLine("totaal: "+ dice2);
                }
            }

            

            if (dice2 == 20)
            {
                //dice1++;
                Console.WriteLine("tellen: " + dice2);
            }
            
            
            
            return dice1;
        }
    }
}
