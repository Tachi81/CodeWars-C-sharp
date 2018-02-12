using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//    If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.

//    Finish the solution so that it returns the sum of all the multiples of 3 or 5 below the number passed in.

//   Note: If the number is a multiple of both 3 and 5, only count it once.

namespace MultiplesOf3Or5
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution(10);
            Console.ReadKey();
        }

        public static int Solution(int value)
        {
            int sum = 0;
            for (int i = 0; i < value; i++)
            {
                sum += (i % 5 == 0 || i % 3 == 0) ? i : 0;
            }

            Console.WriteLine(sum);
            return sum;
        }
    }
}
