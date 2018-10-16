using System;
using Xunit;

namespace GitHub.Test
{
    public class KerstBoomTest
    {
        [Fact]
        public void BoomTest()
        {

            Kerstboom kerstboom = new Kerstboom();
            string karakter = kerstboom.Boompje("5");
            Assert.Contains("5", karakter);

        }

    }
}
