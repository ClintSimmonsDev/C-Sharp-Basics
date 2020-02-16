using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee newEmployee = new Employee() { firstName = "Sample", lastName = "Student" };
            newEmployee.SayName();


            //Calling Quit() Method on Employee object which inherits from IQuittable
            //Employee Steve = new Employee();
            //Steve.Quit(Steve);
        }


    }
}
