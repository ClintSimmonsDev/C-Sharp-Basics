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
            MathClass Multiply = new MathClass();
            Console.WriteLine("Please provide a number so I can do three math operations on it: ");
            int numInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Multiply.Times6(numInput));

            MathClass Divide = new MathClass();
            Console.WriteLine(Divide.Divideby30(numInput));

            MathClass Subtracting = new MathClass();
            Console.WriteLine(Subtracting.Subtract500(numInput));

            Console.WriteLine("See what we did there?");
            Console.ReadLine();
        }
    }
}
