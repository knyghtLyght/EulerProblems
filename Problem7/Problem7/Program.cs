using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
            What is the 10001st prime number ?
            */
            Console.WriteLine(primeIndex(10001));
            Console.ReadLine();
        }

        static int primeIndex(int targetNumber)
        {
            int index = 0;
            int numberToCheck = 1;
            while (index < targetNumber)
            {
                numberToCheck++;
                if (isPrime(numberToCheck)) index++;
            }
            return numberToCheck;
        }

        static bool isPrime(int number)
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
