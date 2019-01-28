using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diceGame
{
    class Program
    {
        static void Main(string[] args)
        {

            IList<int> waarde = new List<int>();

            string actie = null;
            while (actie != "n")
            {

                Console.WriteLine("Wil je rollen? j/n");
                actie = Console.ReadLine();

                switch (actie)
                {
                    case "j":
                        Dices dice = new Dices();
                        var roll = dice.Werp(waarde);
                        break;

                    default:
                        break;
                }
            }
        }
    }
    public class Waarderegel
    {
        public string Dice1 { get; set; }
        public decimal Dice2 { get; set; }
    }
}
