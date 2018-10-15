using System;
using System.Collections.Generic;

public class StraatHuis
{
    public void Straat(string v)
    {
        Huis mynHuis = new Huis();
        Huis jouwHuis = new Huis();
        Huis ramonHuis = new Huis();

        mynHuis.HuisNummer = 1;
        mynHuis.Deuren = 5;
        mynHuis.Ramen = 10;

        jouwHuis.HuisNummer = 2;
        jouwHuis.Deuren = 2;
        jouwHuis.Ramen = 7;

        ramonHuis.HuisNummer = 3;
        ramonHuis.Deuren = 1;
        ramonHuis.Ramen = 50;


        Straat onzeStraat = new Straat();
        onzeStraat.Huizen = new List<Huis>();
        onzeStraat.Huizen.Add(mynHuis);
        onzeStraat.Huizen.Add(jouwHuis);
        onzeStraat.Huizen.Add(ramonHuis);

        Console.WriteLine(onzeStraat.GetAantalRamen());
        Console.ReadLine();
    }
}

public class Huis
{
    public int HuisNummer { get; set; }
    public int Deuren { get; set; }
    public int Ramen { get; set; }

}

public class Straat
{
    public List<Huis> Huizen { get; set; }

    public int GetAantalRamen()

    {

        int aantalGeteld = 0;
        List<int> huisNummersGehad = new List<int>();
        foreach (Huis huis in Huizen)
        {
            if (huisNummersGehad.Contains(huis.HuisNummer))
            {
                Console.WriteLine(huisNummersGehad);
            }
            else
            {
                aantalGeteld = aantalGeteld + huis.Ramen;
            }

        }
        return aantalGeteld;
    }
}
