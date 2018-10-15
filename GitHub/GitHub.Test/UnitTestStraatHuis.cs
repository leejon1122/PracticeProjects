using System;
using System.Collections.Generic;
using Xunit;

namespace GitHub.Test
{
    public class UnitTestStraatHuis
    {
        [Fact]
        public void StraatHuisTest()
        {
            Huis mynHuis = new Huis();
            Huis jouwHuis = new Huis();
            mynHuis.Ramen = 10;
            jouwHuis.Ramen = 1;

            Straat straatje = new Straat();
            straatje.Huizen = new List<Huis>();
            straatje.Huizen.Add(mynHuis);
            straatje.Huizen.Add(jouwHuis);
            
            int aantalGeteld = straatje.GetAantalRamen();
            Assert.Equal(11, aantalGeteld);
        }

    }
}
