using System;
using Xunit;

namespace GitHub.Test
{
    public class UnitTestSwap
    {
        [Fact]
        public void SwapTest()
        {
            NummerSwap nummerswap = new NummerSwap();
             string result = nummerswap.SwapNummer("1234");
            Assert.Equal("4321", result);

        }

    }
}
