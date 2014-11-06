
using System;
using System.Linq;

namespace FizzBuzz
{
    public class FizzBuzzCalculator
    {
        public static int Translate(int i)
        {
            return i;
        }

        public static string DetermineIfFizzOrBuzzOrNumber(int number)
        {
            if (Enumerable.Range(1, 100).Contains(number))
            {
                if (number % 3 == 0 && number % 5 == 0)
                {
                    return "FizzBuzz";
                }
                else if (number % 3 == 0)
                {
                    return "Fizz";
                }
                else if (number % 5 == 0)
                {
                    return "Buzz";
                }
                else
                {
                    return number.ToString();
                }
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
            
        }
    }
}
