using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambdas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> CurrentEmployees = new List<Employee>();
            CurrentEmployees.Add(new Employee() { fName = "Joe", lName = "Mustarchio", Id = 1 });
            CurrentEmployees.Add(new Employee() { fName = "Briff", lName = "Slappleberry", Id = 2 });
            CurrentEmployees.Add(new Employee() { fName = "Chunk", lName = "Feversworth", Id = 3 });
            CurrentEmployees.Add(new Employee() { fName = "Plork", lName = "Chacklesmith", Id = 4 });
            CurrentEmployees.Add(new Employee() { fName = "Spibble", lName = "Haggarty", Id = 5 });
            CurrentEmployees.Add(new Employee() { fName = "Vipson", lName = "Butterskunk", Id = 6 });
            CurrentEmployees.Add(new Employee() { fName = "Hamber", lName = "Yuddich", Id = 7 });
            CurrentEmployees.Add(new Employee() { fName = "Soirse", lName = "Wipplez", Id = 8 });
            CurrentEmployees.Add(new Employee() { fName = "Klondyke", lName = "Zimosa", Id = 9 });
            CurrentEmployees.Add(new Employee() { fName = "Joe", lName = "Jupimartee", Id = 10 });

            List<Employee> Joes = new List<Employee>();

            //List of "Joes" using foreach loop
            foreach (Employee employee in CurrentEmployees)
            {
                if (employee.fName == "Joe")
                {
                    Joes.Add(employee);
                }
            }
            Console.WriteLine("Employees named Joe: ");
            foreach (var x in Joes)
            {
                Console.WriteLine(x.fName + " " + x.lName + " Id: " + x.Id);
            }

            //List of "Joes" using Lambda expression
            List<Employee> Joes2 = new List<Employee>(CurrentEmployees.Where (x => x.fName == "Joe"));
            Console.WriteLine("Also employees named Joe: ");
            foreach (var i in Joes2)
            {
                Console.WriteLine(i.fName + " " + i.lName + " Id: " + i.Id);
            }

            //List of employees with Id > 5 using Lambda expression
            List<Employee> HigherThan5 = new List<Employee>(CurrentEmployees.Where(x => x.Id > 5));
            Console.WriteLine("Employees with Id# higher than 5: ");
            foreach (var j in HigherThan5)
            {
                Console.WriteLine(j.fName + " " + j.lName + " Id: " + j.Id);
            }
            Console.ReadLine();

        }
    }
}
