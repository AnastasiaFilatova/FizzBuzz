
using FizzBuzz;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace FizzBuzzTests
{
    [TestClass]
    public class FizzBuzzCalculatorTests
    {    
        [TestMethod]
        public void ShouldCheckIfNumberIsInRange()
        {
            int result = FizzBuzzCalculator.Translate(1);
            Assert.AreEqual(true, Enumerable.Range(1, 100).Contains(result));
        }

        [TestMethod]
        public void WhenDividableByThreeShouldReturnFizz()
        {
            string result = FizzBuzzCalculator.DetermineIfFizzOrBuzzOrNumber(3);
            Assert.AreEqual("Fizz", result);
        }

        [TestMethod]
        public void WhenDividableByFiveShouldReturnBuzz()
        {
            string result = FizzBuzzCalculator.DetermineIfFizzOrBuzzOrNumber(5);
            Assert.AreEqual("Buzz", result);
        }

        [TestMethod]
        public void WhenDividableByThreeAndFiveShouldReturnFizzBuzz()
        {
            string result = FizzBuzzCalculator.DetermineIfFizzOrBuzzOrNumber(15);
            Assert.AreEqual("FizzBuzz", result);
        }

    }
}
