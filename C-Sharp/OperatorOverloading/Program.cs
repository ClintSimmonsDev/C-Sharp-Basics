using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //Operator overloader active && Employee Id's the same = returns true
            //Operator overloader NOT active || Employee Id's not the same = returns false
            Employee Randy = new Employee { Name = "Randy", Id = 7 };
            Employee Gertrude = new Employee { Name = "Gertrude", Id = 7 };

            Console.WriteLine(Randy == Gertrude);
            Console.ReadLine();
        }
    }
}
