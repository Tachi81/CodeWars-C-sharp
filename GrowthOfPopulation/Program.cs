using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// In a small town the population is p0 = 1000 at the beginning of a year. The population regularly
// increases by 2 percent per year and moreover 50 new inhabitants per year come to live in the 
// town. How many years does the town need to see its population greater or equal to p = 1200 inhabitants?

// More generally given parameters:
// p0, percent, aug(inhabitants coming or leaving each year), p(population to surpass)
//  the function nb_year should return n number of entire years needed to get a population greater or equal to p.

namespace GrowthOfPopulation
{
    class Program
    {
        static void Main()
        {
            YearsNeeded(100, 2, 50, 1200);
            Console.WriteLine();
            Console.WriteLine("Program finished without exceptions");
            Console.ReadKey();

        }

        private static int YearsNeeded(int p0, float? percent, int inhabitants, int desiredPopulation)
        {
            var years = 1;
            percent /= 100;
            while (desiredPopulation >= p0)
            {
                if (percent == null || percent == 0)
                {
                    p0 += inhabitants;
                }
                else
                {
                    p0 = (int)(p0 * (1 + percent) + inhabitants);
                }
                years++;
            }

            Console.WriteLine(years);
            return years;
        }
    }
}
