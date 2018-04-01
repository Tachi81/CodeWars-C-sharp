using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    //Write a function to convert a name into initials.This kata strictly takes two words with one space in between them.

    //The output should be two capital letters with a dot seperating them.

    //It should look like this:

    //Sam Harris => S.H

namespace Abbreviate_a_Two_Word_Name
{
    class Program
    {
        static void Main()
        {
            AbbrevName("Sam Harris");
            AbbrevName("Patrick Feenan");
            AbbrevName("Evan Cole");
            AbbrevName("P Favuzzi");
            AbbrevName("David Mendieta");

            Console.ReadKey();
        }

        public static string AbbrevName(string name)
        {
            var names = name.ToUpper().Split(' ');
            Console.WriteLine(String.Join(".", names[0][0], names[1][0]));

            return String.Join(".", names[0][0], names[1][0]);
        }
    }
}
