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
        }
    }
}
