using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concatenate_Convert_Stringbuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            string string1 = "I can't ";
            string string2 = "believe it's ";
            string string3 = "not butter.";
            string oldCommercial = (string1 + string2 + string3);
            string3 = string3.ToUpper();
            Console.WriteLine(oldCommercial);

            StringBuilder sb1 = new StringBuilder("But on the other hand, ");
            sb1.Append("Splenda tastes like sugar, ");
            sb1.Append("because it's *made* from sugar. ");
            sb1.Append("Or so they say, at least.");
            Console.WriteLine(sb1);
            Console.ReadLine();
        }
    }
}
