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
            Console.WriteLine("Give me a number please, it's math time: \n");
            int num1 = Convert.ToInt32(Console.ReadLine());
            MathClass Adding = new MathClass();
            Console.WriteLine(Adding.Add3k(num1));

            MathClass Dividing = new MathClass();
            Console.WriteLine(Dividing.DivideBy8(num1));

            MathClass Multiplying = new MathClass();
            Console.WriteLine(Multiplying.MultiplyBy365(num1));

            Console.WriteLine("See what I did there?");
            Console.ReadLine();


        }
    }
}
