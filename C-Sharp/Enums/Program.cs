using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your favorite day of the week: ");
            string favDay = Console.ReadLine();

            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            favDay = textInfo.ToTitleCase(favDay);

            var values = Enum.GetNames(typeof(Weekdays.DaysOfWeek));
            try
            {
                if (values.Contains(favDay))
                {
                    Console.WriteLine(favDay + " is a great day.");
                }
                else
                {
                    throw new ArgumentException();
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            Console.ReadLine();
        }
    }
}
