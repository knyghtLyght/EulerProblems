using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            The prime factors of 13195 are 5, 7, 13 and 29.
            What is the largest prime factor of the number 600851475143?
            */
        }

        static int GetLargestFactor(long numberToCheck)
        {
            int sqrt = (int)Math.Ceiling(Math.Sqrt(numberToCheck)); //Check how big our factors can get and maybe get lucky.
            if (sqrt * sqrt == numberToCheck)
            {
                if (isPrime(sqrt)) return sqrt;
            }
            for (int i = sqrt - 1; i > 0; i--)
            {
                if (sqrt % i == 0)
                {
                    if (isPrime(i)) return i;
                }
            }
            return 0;
        }
        static bool isPrime(long number)
        {
            if (number == 1) return false;
            if (number == 2) return true;

            var boundry = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 2; i <= boundry; i++)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
    }
}
