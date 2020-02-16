using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidAndOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            VoidClass WowFun = new VoidClass();
            Console.WriteLine("It's that time again - give me a number! ");
            int input1 = Convert.ToInt32(Console.ReadLine());
            WowFun.KoolMethod(input1);

            int FunNum = 0;
            WowFun.NumberStuff(out FunNum);
            Console.WriteLine(FunNum);

            Console.WriteLine(WowFun.FreshInt(50));
            Console.WriteLine(WowFun.FreshInt(6.2345678m));

            VoidClass.CoolString();

        }

    }
}
