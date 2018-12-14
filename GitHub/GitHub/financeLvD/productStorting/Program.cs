using System;
using System.Collections.Generic;
using System.Linq;

namespace productStorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int amount;
            string product = null;
            int income = 2000;
            int saldo = income;
            int storting = 0;
            
            IList<int> amounts = new List<int>();
            List<string> products = new List<string>();

            Console.WriteLine("Je hebt " + income + "EURO te besteden!" + "\n");
            
            while (product != "x")
            {
                Console.Write("Geef product op: ");
                product = Console.ReadLine();

                if (product == "x")
                {
                    Console.WriteLine("Stop");
                }
                else if (product == "som")
                {
                    string amountList = string.Join(",", amounts.ToArray());
                    string prodList = string.Join(",", products.ToArray());


                    int totalcost = amounts.Sum();
                    
                    Console.WriteLine(
                                           "Producten: " + prodList + "\n" +
                                           "Prijs per Product: " + amountList + "\n" + "\n" +
                                           "Totaal: " + totalcost + "\n" + "\n" +
                                           "Restsaldo: " + saldo);
                }
                else if (product == "deposit")
                {
                    Console.WriteLine("Hoeveel wil je storten: ");
                    storting = Convert.ToInt32(Console.ReadLine());

                    saldo = saldo + storting;
                                       
                    Console.WriteLine(saldo);
                }
                else
                {
                    Console.WriteLine("Geef een bedrag: ");
                    amount = Convert.ToInt32(Console.ReadLine());

                    saldo = saldo - amount;

                    amounts.Add(amount);
                    products.Add(product);
                }

                Console.WriteLine("--------------");
            }
        }
    }
}