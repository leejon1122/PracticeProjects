using System;
using System.Collections.Generic;
using System.Text;

namespace GitHub
{
    public class Kerstboom
    {
        public void Boom()
        {
            
            Console.Write("Wat wil je printen? ");
            string karakter = Console.ReadLine();

            string result = Boompje(karakter);
            result = " ";
            Console.ReadLine();
        }
        public string Boompje(string karakter)
        {

            int spaties = 15;
            int ster = 1;
            string result = " ";

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < spaties; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < ster; j++)
                {
                    Console.Write(" " + karakter);
                }
                Console.WriteLine(" ");
                ster++;
                spaties--;
                
            }
            return result;    
        }
    }
}

