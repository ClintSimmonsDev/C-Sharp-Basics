using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime rightNow = DateTime.Now;
            Console.WriteLine("Right now? Oh, it's "+ rightNow);
            Console.WriteLine("Pardon, but please gimme a number...");
            int userNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Well just so you know, in " + userNum + " hours, it'll be...");
            DateTime newTime = rightNow.AddHours(userNum);
            Console.WriteLine(newTime);
        }
    }
}
