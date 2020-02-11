using System;

namespace MathAndAssignment_Tests
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number - I'll multiply it by 50:");
            int multiplyBy50 = Convert.ToInt32(Console.ReadLine());
            multiplyBy50 *= 50;
            Console.WriteLine("That's " + multiplyBy50 + "!");
            Console.ReadLine();

            Console.WriteLine("Give me a number - I'll add 25 to it:");
            int add25 = Convert.ToInt32(Console.ReadLine());
            add25 += 25;
            Console.WriteLine("That's " + add25 + "!");
            Console.ReadLine();

            Console.WriteLine("Give me a number - I'll divide it by 12.5:");
            double divideBy12Point5 = Convert.ToDouble(Console.ReadLine());
            divideBy12Point5 /= 12.5;
            Console.WriteLine("That's " + divideBy12Point5 + "!");
            Console.ReadLine();

            Console.WriteLine("Give me a number - I'll check if it's greater than 50:");
            int greaterThan50 = Convert.ToInt32(Console.ReadLine());
            if (greaterThan50 > 50)
            {
            Console.WriteLine("That's clearly true!");
            Console.ReadLine();
            }
            if (greaterThan50 <= 50)
            {
            Console.WriteLine("That's clearly false!");
            Console.ReadLine();
            }
            Console.WriteLine("Give me a number - I'll divide it by 7 and tell you the remainder:");
            double divideBy7Remainder = Convert.ToDouble(Console.ReadLine());
            divideBy7Remainder %= 7;
            Console.WriteLine("That's " + divideBy7Remainder + "!");
            Console.ReadLine();
        }
    }
}
