using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
            Find the largest palindrome made from the product of two 3-digit numbers.
            */
            List<int> range = new List<int>();
            int largestPalandrom = 0;
            for (int i = 100; i < 1000; i++) //Populate the list with the range to check i.e. all 3 digit numbers
            {
                range.Add(i);
            }
            foreach (int i in range) //Multiply each number in the list by the same range
            {
                for (int multiplier = 100; multiplier < 1000; multiplier++)
                {
                    int numberToCheck = i * multiplier;
                    if (numberToCheck.ToString() == ReverseString(numberToCheck.ToString())) //Flip the asnwer and compare
                    {
                        if (numberToCheck > largestPalandrom) largestPalandrom = numberToCheck; //Make sure it's the largest
                    }
                }
            }
            Console.WriteLine(largestPalandrom);
            Console.ReadLine();
        }

        static string ReverseString (string input)
        {
            return new string(input.ToCharArray().Reverse().ToArray());
        }
    }
}
