﻿using System;
using System.Linq;

// Write a function named sumDigits which takes a number as input and returns the sum of the absolute
// value of each of the number's decimal digits. Let's assume that all numbers in the input will be integer values.

namespace SummaringDigitsOfNumber
{
    class Program
    {
        static void Main()
        {
            SumDigits(-98104);

            Console.WriteLine();
            Console.WriteLine("Program finished without exceptions");
            Console.ReadKey();
        }

        private static int SumDigits(int number)
        {

            int sum = number.ToString().Replace("-", "").Select(x => int.Parse(x.ToString())).Sum();
            Console.WriteLine(sum);
            return sum;


            //int sum = 0;
            //foreach (var digit in numbers.ToString())
            //{
            //    if (digit.ToString() == "-")
            //    {
            //        continue;
            //    }
            //    sum += int.Parse(digit.ToString());
            //}

            //Console.WriteLine(sum);
            //return sum;
        }
    }
}
