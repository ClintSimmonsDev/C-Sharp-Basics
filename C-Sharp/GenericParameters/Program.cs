using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericParameters
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee<string> Neato = new Employee<string>();
            Neato.Things = new List<string>();
            Neato.Things.Add("Whoa");
            foreach (string i in Neato.Things)
            {
                Console.WriteLine("Generic String: " + i);
            }
            Employee<int> Funky = new Employee<int>();
            Funky.Things = new List<int>();
            Funky.Things.Add(7);
            foreach (int i in Funky.Things)
            {
                Console.WriteLine("Generic Int: " + i);
            }

            Console.ReadLine();

        }
    }
}
