
using System;
namespace FizzBuzz
{
    public class FizzBuzzCalculator_eriks
    {
        public static string Calculate()
        {
            var output = "";
            for (int i = 1; i <= 100; i++)
            {
                output += Translate(i) + "\n";
            }
            return output;
        }

        public static string Translate(int i)
        {
            if (!IsWithinRange(i)) throw new ArgumentException();
            var output = "";
            if (ShouldFizzAndBuzz(i))
            {
                output += "FizzBuzz";
            }
            else if (ShouldFizz(i)) output += "Fizz";
            else if (ShouldBuzz(i)) output += "Buzz";
            if (string.IsNullOrEmpty(output)) output += i.ToString();
            return output;
        }

        private static bool IsWithinRange(int i)
        {
            return i >= 1 && i <= 100;
        }

        private static bool ShouldFizzAndBuzz(int i)
        {
            return (i % 5 == 0 && i % 3 == 0);
        }

        private static bool ShouldFizz(int i)
        {
            return (i % 3 == 0);
        }

        private static bool ShouldBuzz(int i)
        {
            return (i % 5 == 0);
        }
    }
}
