using System;
using System.Linq;

//Write a function that rearranges an integer into its largest possible value.

//SuperSize(123456) //654321
//SuperSize(105) // 510
//SuperSize(12) // 21
//If the argument passed through is single digit or is already the maximum possible integer, your function 
//should simply return it.

namespace SupersizeDigits
{
    class Program
    {
        static void Main()
        {
            SuperSize(123456);
            SuperSize(105);
            SuperSize(1);

            Console.ReadKey();
        }

        private static long SuperSize(int number)
        {
            var superSizedNumber = long.Parse(String.Join("", number.ToString().OrderByDescending(w => w).ToArray()));
            
            Console.WriteLine(superSizedNumber);
            return superSizedNumber;
        }
    }
}
