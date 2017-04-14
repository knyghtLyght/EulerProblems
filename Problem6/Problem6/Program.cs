using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            The sum of the squares of the first ten natural numbers is,
            1^2 + 2^2 + ... + 10^2 = 385
            The square of the sum of the first ten natural numbers is,
            (1 + 2 + ... + 10)^2 = 55^2 = 3025
            Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
            Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
            */
            Console.WriteLine(sumOfTheSquares(100));
            Console.WriteLine(squareofTheSumes(100));
            Console.WriteLine(squareofTheSumes(100) - sumOfTheSquares(100));
            Console.ReadLine();
        }

        static int sumOfTheSquares(int range)
        {
            int answer = 0;
            for (int i = 1; i <= range; i++)
            {
                answer += i * i;
            }
            return answer;
        }

        static int squareofTheSumes(int range)
        {
            int answer = 0;
            for (int i = 1; i <= range; i++)
            {
                answer += i;
            }
            answer = answer * answer;
            return answer;
        }
    }
}
