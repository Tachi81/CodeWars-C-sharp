using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouOnlyNeedOne

//You will be given an array(a) and a value(x). All you need to do is check whether the provided array contains the value.

//Array can contain numbers or strings.X can be either. Return true if the array contains the value, false if not.

{
    class Program
    {
        static void Main()
        {
            Check(new object[] { 66, 101 }, 66);
            Check(new object[] { 80, 117, 115, 104, 45, 85, 112, 115 }, 45);
            Check(new object[] { 't', 'e', 's', 't' }, 'e');
            Check(new object[] {"what", "a", "great", "kata"}, "kat");
        }

        public static bool Check(object[] a, object x)
        {
            return a.Contains(x);
        }
    }
}
