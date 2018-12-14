using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace overzichtStortingen
{
    class Program
    {
        static void Main(string[] args)
        {
            int amount;
            string product = null;
            int income = 2000;
            int saldo = income;
            //int storting = 0;
            int deposit;


            IList<int> amounts = new List<int>();
            IList<int> deposits = new List<int>();
            List<string> products = new List<string>();
            var receipt = new List<Bonregel>();
            var regel = new Bonregel();


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
                    string depositList = string.Join(",", deposits.ToArray());


                    int totalcost = amounts.Sum();
                    int totalDeposit = deposits.Sum();

                    Console.WriteLine(
                                           "Producten: " + prodList + "\n" +
                                           "Prijs per Product: " + amountList + "\n" + "\n" +
                                           "Totaal: " + totalcost + "\n" + "\n" +
                                           "Totaal stortingen : " + totalDeposit + "\n" + "\n" +
                                           "Restsaldo: " + regel.Product);


                    Console.WriteLine("{0}", receipt);
                }
                else if (product == "deposit")
                {
                    Console.WriteLine("Hoeveel wil je storten: ");
                    deposit = Convert.ToInt32(Console.ReadLine());
                    deposits.Add(deposit);
                    //storting = Convert.ToInt32(Console.ReadLine());
                    int totalDeposit = deposits.Sum();

                    saldo = saldo + totalDeposit;

                    //saldo = saldo + storting;

                    Console.WriteLine(saldo);
                }
                else
                {
                    Console.WriteLine("Geef een bedrag: ");
                    amount = Convert.ToInt32(Console.ReadLine());

                    saldo = saldo - amount;
                    product = regel.Product;
                    amounts.Add(amount);
                    products.Add(product);
                    
                    receipt.Add(regel);
                    
                }

                Console.WriteLine("--------------");
            }
        }
    }

    public class Bonregel
    {
        public string Product { get; set; }

        public int Bedrag { get; set; }
    }
}
