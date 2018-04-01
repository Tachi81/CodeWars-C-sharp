using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method smash that takes an array of words and smashes them together into a sentence and 
//returns the sentence.You can ignore any need to sanitize words or add punctuation, but you should
//add spaces between each word.Be careful, there shouldn't be a space at the beginning or the end of the sentence!

namespace SentenceSmash
{
    class Program
    {
        static void Main(string[] args)
        {
            Smash(new string[] { "this", "is", "a", "really", "long", "sentence" });
            Console.ReadKey();
        }

        private static string Smash(string[] words)
        {
            return String.Join(" ", words);
        }
    }
}
