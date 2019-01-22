using FizzBuss.Library;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Library.test
{
    [TestFixture]
    public class FizzBuzzerTests
    {
        [Test]
        public void Buzzer_When_returnsDefault(
            [Values(1,2,4,7)] int input)
        {
            

            string output = FizzBuzzer.GetValue(input);

            Assert.AreEqual(input.ToString(), output);
        }
        [Test]
        public void Buzzer_When_returns3(
            [Values(3,6,9,12)] int input)
        {

            string output = FizzBuzzer.GetValue(input);

            Assert.AreEqual("Fizz", output);
        }
        [Test]
        public void Buzzer_When_returns5(
            [Values(5,10)] int input)
        {

            string output = FizzBuzzer.GetValue(input);

            Assert.AreEqual("Buzz", output);
        }

        [Test]
        public void Buzzer_When_returns3and5(
            [Values(15)] int input)
        {

            string output = FizzBuzzer.GetValue(input);

            Assert.AreEqual("FizzBuzz", output);
        }

    }
}
