using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program\n");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate: ");
            decimal person1Hourly = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Hours worked per week: ");
            byte person1HoursWeekly = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("\nPerson 2");
            Console.WriteLine("Hourly Rate: ");
            decimal person2Hourly = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Hours worked per week: ");
            byte person2HoursWeekly = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("\nThank You");
            var person1Salary = person1Hourly * person1HoursWeekly * 52;
            var person2Salary = person2Hourly * person2HoursWeekly * 52;
            Console.WriteLine("Annual salary of Person 1: " + person1Salary);
            Console.WriteLine("Annual salary of Person 2: " + person2Salary);
            Console.WriteLine("\nDoes Person 1 make more money than Person 2?");
            if (person1Salary > person2Salary)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            Console.ReadLine();




        }
    }
}
