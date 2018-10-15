using System;
using System.Collections.Generic;
using Xunit;

namespace GitHub.Test
{
    public class UnitTestFizz
    {
        [Fact]
        public void FizzTest()
        {
            
            FizzBuzz fizzbuzz = new FizzBuzz();
            string a = fizzbuzz.Fizzy(3);
            Assert.Equal("Fizz", a);

            
        }
        [Fact]
        public void BuzzTest()
        {

            FizzBuzz fizzbuzz = new FizzBuzz();
            string a = fizzbuzz.Fizzy(5);
            Assert.Equal("Buzz", a);


        }
        [Fact]
        public void FizzBuzzTest()
        {

            FizzBuzz fizzbuzz = new FizzBuzz();
            string a = fizzbuzz.Fizzy(15);
            Assert.Equal("FizzBuzz", a);


        }

    }
}
