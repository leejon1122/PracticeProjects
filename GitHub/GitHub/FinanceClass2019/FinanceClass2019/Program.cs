using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FinanceClass2019
{
    public class Program
    {

        static void Main(string[] args)
        {
            var receipt = new List<Bonregel>();
            string actie = null;
            IList<int> deposits = new List<int>();
            int income = 2000;
            int saldo = income;

            Console.WriteLine("Je hebt " + income + "EURO te besteden");

            while (actie != "x")
            {
                Console.WriteLine("Wat wil je doen?((p)roduct/(s)om/(x)/(d)eposit/(e)xportsom)");
                actie = Console.ReadLine();

                switch (actie)
                {
                    case "p":
                        {
                            AddProduct add = new AddProduct();
                            var adder = add.Addprod(receipt);
                        }
                        break;
                    case "x":
                        {
                            Console.WriteLine("Stop");
                        }
                        break;
                    case "d":
                        {

                            DepositClass dep = new DepositClass();
                            int depSum = dep.Stortingen(deposits);
                        }
                        break;
                    case "s":
                        {

                            Sommeer som = new Sommeer();
                            int bonSom = som.Sum(deposits,receipt,saldo);
                        }
                        break;
                    case "e":
                        {
                            ExportSom export = new ExportSom();
                            int exporter = export.Exporteer(receipt,deposits,saldo);

                        }
                        break;
                    default:
                        Console.WriteLine("Ongeldige keuze");
                        break;
                }
                Console.WriteLine("-----------------");
            }
        }
    }

    public class Bonregel
    {
        public string Product { get; set; }
        public int Bedrag { get; set; }
    }
}
