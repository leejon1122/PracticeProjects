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
            Console.WriteLine(result);
            Console.ReadLine();
        }
        public string Boompje(string karakter)
        {

            int spaties = 15;
            int ster = 1;
            string result = "";

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < spaties; j++)
                {
                    result = result + " ";
                }

                for (int j = 0; j < ster; j++)
                {
                    result = result + " " + karakter;
                }

                result = result + " " + Environment.NewLine;
                ster++;
                spaties--;
                
            }
            return result;    
        }
    }
}

