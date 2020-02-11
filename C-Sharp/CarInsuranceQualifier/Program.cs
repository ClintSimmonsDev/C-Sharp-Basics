using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsuranceQualifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Insurance Qualifier\n");
            Console.WriteLine("What is your age?\n");
            byte inputAge = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? Please enter true or false\n");
            bool everDUI = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many speeding tickets do you have?\n");
            byte speedingTickets = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Qualified?\n");

            if (inputAge >= 15 && everDUI == false && speedingTickets <= 3)
            {
                bool qualified = true;
                Console.WriteLine(qualified);
            }
            else
            {
                bool qualified = false;
                Console.WriteLine(qualified);
            }
            Console.ReadLine();




        }
    }
}
