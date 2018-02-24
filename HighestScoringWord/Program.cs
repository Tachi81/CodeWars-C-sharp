using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighestScoringWord
{
    class Program

    //Given a string of words, you need to find the highest scoring word.

    //Each letter of a word scores points according to it's position in the alphabet: a = 1, b = 2, c = 3 etc.

    //You need to return the highest scoring word as a string.

    //If two words score the same, return the word that appears earliest in the original string.

    //All letters will be lowercase and all inputs will be valid.

    {
        static void Main()
        {
            Console.WriteLine(High("what time are we climbing up to the volcano"));
            

            Console.ReadKey();
        }
        public static string High(string s)
        {
            var words = s.Split();
            
            var lengths = new List<int>();
            foreach (string word in words)
            {
                int wordScore = 0;
                foreach (char c in word)
                {
                    wordScore += (int)c -'a' +1; // implicit converting char to integer by substracting one from other
                                                    // a - a = 0      b - a = 1 etc
                }
                lengths.Add(wordScore);
            }

           return words[lengths.IndexOf(lengths.Max())];
        }
    }
}
