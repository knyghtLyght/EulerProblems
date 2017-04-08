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
            Console.WriteLine(GetLargestFactor(600851475143));
            Console.ReadLine();
        }

        static long GetLargestFactor(long numberToCheck)
        {
            //List<long> factorsListBase = new List<long>(); //List to hold thed first set of factors
            long goldenFactor = 0;
            int sqrt = (int)Math.Floor(Math.Sqrt(numberToCheck));
            for (int i = sqrt; i > 0; i--)
            {
                if(numberToCheck % i == 0)
                {
                    long pair = numberToCheck / i;
                    if (isPrime(i) && i > goldenFactor) goldenFactor = i;
                    if (isPrime(pair) && i > goldenFactor) goldenFactor = pair;
                }
            }
            /*
            {
                if (numberToCheck % i == 0) //check if i is a factor of numberToCheck.
                {
                    if (isPrime(i)) //Check if the factor is prime.
                    {
                        //factorsListBase.Add(i); //Add the factor to the list
                    }
                }
            }
            */
            /*
            foreach (long i in factorsListBase) //Check the list to see what we have
            {
                Console.WriteLine(i);
            }
            List<long> factorsListPairs = new List<long>(); //List to hold the factors we derive fromt he first set
            foreach (int i in factorsListBase)
            {
                long factorPair = numberToCheck / i; //Find the pair to the factor we found
                if (isPrime(factorPair)) factorsListPairs.Add(factorPair);
            }
            foreach (long i in factorsListPairs) //Check the list to see what we have
            {
                Console.WriteLine(i);
            }
            var allPrimeFactors = factorsListBase.Concat(factorsListPairs); //Combine the lists
            long goldenFactor = allPrimeFactors.Max(); //Grab the largest in the combined list.
            */
            return goldenFactor; //Our goal
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
