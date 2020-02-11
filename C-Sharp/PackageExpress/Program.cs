using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.\n");
            Console.WriteLine("Please enter package WEIGHT to the nearest pound:");
            int packageWeight = Convert.ToInt32(Console.ReadLine());
            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                System.Environment.Exit(0);
            }
            Console.WriteLine("Please enter package WIDTH in inches:");
            int packageWidth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter package HEIGHT in inches:");
            int packageHeight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter package LENGTH in inches:");
            int packageLength = Convert.ToInt32(Console.ReadLine());
            if (packageHeight + packageLength + packageWeight > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                System.Environment.Exit(0);
            }
            decimal totalCost = (packageWeight * packageLength * packageHeight * packageWidth) / 100;
            Console.WriteLine("Your estimated total for shipping this package is: $" + totalCost +"\nThank you!");
            Console.ReadLine();



        }
    }
}
