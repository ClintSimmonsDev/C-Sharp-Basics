using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_While
{
    class Program
    {
        static void Main(string[] args)
        {
            int funkLevel = 0;
            do
            {
                Console.WriteLine("Your current Funk Level is: {0}", funkLevel);
                funkLevel++;
                Console.ReadLine();
                if (funkLevel >= 10)
                {
                    Console.WriteLine("You've reached Funk Level 10: Maximum Funk!\n*Confetti*\n");
                    break;
                }
            }
            while (funkLevel < 10);

        }
    }
}
