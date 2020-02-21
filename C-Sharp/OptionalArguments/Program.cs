using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalArguments
{
    public class Program
    {
        static void Main(string[] args)
        {
            MathOps SoFun = new MathOps();
            Console.WriteLine("Hey, give me a number: ");
            int input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Now give me a second number, or just hit enter, whatever...");

            int input2;
            int results;
            if (int.TryParse(Console.ReadLine(), out input2))
            {
                results = SoFun.MathStuff(input1, input2);
            }
            else
            {
                results = SoFun.MathStuff(input1);
            }
            Console.WriteLine(results);
        }
    }
}
