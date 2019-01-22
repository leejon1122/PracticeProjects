﻿using System;
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
            IList<decimal> deposits = new List<decimal>();
            decimal income = 2000;
            decimal saldo = income;

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
                            StopApplicatie stop = new StopApplicatie();
                            var quit = stop.Stop();

                        }
                        break;
                    case "t":
                        {
                            Parser lees = new Parser();
                            var lezen = lees.Parse(deposits,receipt,saldo);
                            //string filePath = File.ReadAllText(@"C:\Users\dvle\Documents\financeSum.txt");
                            

                            //Console.WriteLine("text " + text);
                            //Console.WriteLine("Totaal stortingen inclusief ingeladen text");
                            break;
                        }
                    case "d":
                        {

                            DepositClass dep = new DepositClass();
                            decimal depSum = dep.Stortingen(deposits);
                        }
                        break;
                    case "s":
                        {

                            Sommeer som = new Sommeer();
                            decimal bonSom = som.Sum(deposits,receipt,saldo);
                        }
                        break;
                    case "e":
                        {
                            ExportSom export = new ExportSom();
                            decimal exporter = export.Exporteer(receipt,deposits,saldo);

                        }
                        break;
                    case "r":
                        {
                            ReturnProd ret = new ReturnProd();
                            var retourtje = ret.Retrouneer(receipt);
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
        public decimal Bedrag { get; set; }
    }
}
