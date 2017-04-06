using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.

Find the sum of all the multiples of 3 or 5 below 1000.
*/

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 1;
            string answer = "";
            while (input <= 1000)
            {
                if (input % 3 == 0 || input % 5 == 0)
                {
                    answer = answer + " " + input.ToString();
                }
                input++;
            }
            Console.WriteLine(answer);
            Console.ReadLine();
        }
    }
}
