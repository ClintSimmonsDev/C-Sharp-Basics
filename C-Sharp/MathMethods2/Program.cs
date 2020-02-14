using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            MathClass2 Multiply = new MathClass2();
            Console.WriteLine(Multiply.Times6(5));

            MathClass2 MoreMultiply = new MathClass2();
            Console.WriteLine(Multiply.Times6(14.6538974m));

            MathClass2 Subtracting = new MathClass2();
            Console.WriteLine(Subtracting.Times6("454"));

            Console.WriteLine("Woo Hoo");
            Console.ReadLine();


        }
    }
}
