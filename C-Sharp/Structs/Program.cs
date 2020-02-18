using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {

            Number KoolNum = new Number();
            KoolNum.Amount = 88.50m;
            Console.WriteLine("The best amount to have is: $" + KoolNum.Amount);
            Console.ReadLine();
        }
    }
}
