
using FizzBuzz;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FizzBuzzTests
{
    [TestClass]
    public class FizzBuzzCalculatorTests_eriks
    {
        [TestMethod]
        public void When1_ShouldReturn1()
        {
            var actual = FizzBuzzCalculator_eriks.Translate(1);
            Assert.AreEqual("1", actual);
        }

        [TestMethod]
        public void When2_ShouldReturn2()
        {
            var actual = FizzBuzzCalculator_eriks.Translate(2);
            Assert.AreEqual("2", actual);
        }

        [TestMethod]
        public void When3_ShouldReturnFizz()
        {
            var actual = FizzBuzzCalculator_eriks.Translate(3);
            Assert.AreEqual("Fizz", actual);
        }


        [TestMethod]
        public void When6_ShouldReturnFizz()
        {
            var actual = FizzBuzzCalculator_eriks.Translate(6);
            Assert.AreEqual("Fizz", actual);
        }

        [TestMethod]
        public void When5_ShouldReturnBuzz()
        {
            var actual = FizzBuzzCalculator_eriks.Translate(5);
            Assert.AreEqual("Buzz", actual);
        }

        [TestMethod]
        public void When15_ShouldReturnFizzBuzz()
        {
            var actual = FizzBuzzCalculator_eriks.Translate(15);
            Assert.AreEqual("FizzBuzz", actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void When101_ShouldThrowException()
        {
            FizzBuzzCalculator_eriks.Translate(101);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void When0_ShouldThrowException()
        {
            FizzBuzzCalculator_eriks.Translate(0);
        }
    }
}
