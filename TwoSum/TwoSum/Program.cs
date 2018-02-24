using System;
using System.Collections.Generic;

class TwoSum
{
    public static Tuple<int, int> FindTwoSum(IList<int> list, int sum)
    {

        // Write a function that, given a list and a target sum, returns zero - based indices of any two distinct 
        // elements whose sum is equal to the target sum.If there are no such elements, the function should return null.

        //    For example, FindTwoSum(new List<int>() { 1, 3, 5, 7, 9 }, 12) should return a Tuple<int, int> 
        // containing any of the following pairs of indices:

        // 1 and 4(3 + 9 = 12)
        // 2 and 3(5 + 7 = 12)
        // 3 and 2(7 + 5 = 12)
        // 4 and 1(9 + 3 = 12)


        for (int i = 0; i < list.Count; i++)
        {
            for (int j = i + 1; i < list.Count; i++)
            {
                if (list[i] + list[j] == sum)
                {
                    Tuple<int, int> result = new Tuple<int, int>(list[i], list[j]);
                    return result;
                }
            }
        }
        return null;

    }

    public static void Main(string[] args)
    {
        Tuple<int, int> indices = FindTwoSum(new List<int>() { 1, 3, 5, 7, 9 }, 12);
        Console.WriteLine(indices.Item1 + " " + indices.Item2);
    }
}