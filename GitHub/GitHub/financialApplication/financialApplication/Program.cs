using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace financialApplication
{
    class Program
    {
        static void Main(string[] args)
        {



            string product = null;
            int deposit;
            int inkomen = 1000;
            int amount;

            IList<int> amounts = new List<int>();
            IList<int> depositList= new List<int>();
            List<string> products = new List<string>();

            Console.WriteLine("Je hebt " + inkomen + "EURO te besteden.");

            while (product != "x")
            {
                Console.WriteLine("Geeft het product op: ");
                product = Console.ReadLine();
                //products.Add(product);

                if (product == "x")
                {
                    Console.WriteLine("Stop");
                }
                else if (product == "dep")
                {
                    Console.WriteLine("Geef het bedrag op dat je wil storten: ");
                    deposit = Convert.ToInt32(Console.ReadLine());
                    depositList.Add(deposit);
                }
                else if (product == "som")
                {
                    int totalDeposit = depositList.Sum();
                    int totalAmount = amounts.Sum();
                    int saldo = inkomen - totalAmount + totalDeposit;


                    //string prodList = string.Join(",", products.ToArray());

                    Console.Write("Producten: " + string.Join(",", products));
                    Console.WriteLine(string.Join(",", products));
                    Console.Write("Uitgaven: ");
                    Console.WriteLine(string.Join(",", amounts));


                    Console.WriteLine("Totaal uitgaven: " + totalAmount);
                    Console.WriteLine("Totaal stortingen: " + totalDeposit);
                    Console.WriteLine("Saldo: " + saldo );
                    
                }
                else
                {
                    Console.WriteLine("Geeft het bedrag op: ");
                    amount = Convert.ToInt32(Console.ReadLine());

                    amounts.Add(amount);
                    products.Add(product);
                    
                }
            }
            Console.WriteLine("--------------------");
            
        }
    }
}
