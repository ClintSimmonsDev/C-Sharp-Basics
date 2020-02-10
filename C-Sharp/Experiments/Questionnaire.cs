using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiments
{
    static class Questionnaire
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");

            Console.WriteLine("What course are you on?");
            byte currentCourse = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("What page are you on?");
            byte currentPage = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Do you need help with anything? (please answer \"true\" or \"false\").");
            bool needsHelp = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics");
            string positiveExperience = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string otherFeedback = Convert.ToString(Console.ReadLine());
            Console.WriteLine("How many hours did you study today?");
            byte hoursStudied = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Thank you for your answers. \nAn Instructor will respond to this shortly. \nHave a great day!\n");
        }
    }
}
