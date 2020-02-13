using System;
using System.Collections.Generic;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numList = new List<int> { 88, 202, 45, 306, 14, 5000 };
            Console.WriteLine("I have a list of  6 numbers. Give me a number to divide them all by: ");

            try
            {
                int userNumber = Convert.ToInt32(Console.ReadLine());
                foreach (int number in numList)
                {
                    Console.WriteLine(number / userNumber);
                    continue;
                }
            }
            //This exception is not being caught
            catch (FormatException ex)
            {
                Console.WriteLine("Uh oh, Format Exception!\n" + ex.Message);
            }
            //This one IS being caught
            catch (DivideByZeroException divZero)
            {
                Console.WriteLine("Div by zero!\n" + divZero.Message);
            }
            //This is caught as well if the above two are disabled.
            catch (Exception ex)
            {
                Console.WriteLine("Generic exception was caught\n" + ex.Message);
            }
            finally
            {
                Console.WriteLine("We have emerged victorious from a try/catch block!");
                Console.ReadLine();
            }
        }
    }
}
