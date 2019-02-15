using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FinanceClass2019
{
    public class Parser
    {
        public List<Bonregel> Parse(string filePath)
        {


            List<string> lines = File.ReadAllLines(filePath).ToList();
            List<Bonregel> parseBon = new List<Bonregel>();

            foreach (var line in lines)
            {
                string[] entries = line.Split(',');
                Bonregel newLine = new Bonregel();
                newLine.Product = entries[0];
                newLine.Bedrag = decimal.Parse(entries[1]);

                parseBon.Add(newLine);
            }
            return parseBon;
        }
    }
}
