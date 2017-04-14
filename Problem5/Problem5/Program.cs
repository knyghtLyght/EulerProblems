using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
            What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
            */

            Console.WriteLine(targetNumber());
            //Console.WriteLine(DivisableByAll20(1536));
            Console.ReadLine();
        }

        static bool DivisableByAll20(int numberToCheck)
        {
            for (int i = 1; i < 21; i++)
            {
                if (numberToCheck % i != 0) return false;
            }
            return true;
        }

        static int targetNumber()
        {
            bool flag = true;
            int baseValuei = 1;
            while (flag)
            {
                if (DivisableByAll20(baseValuei))
                {
                    flag = false;
                    return baseValuei;
                }
                baseValuei++;
            }
            return 0;
        }
    }
}
