using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstChainAndVar
{
    class Program
    {
        static void Main(string[] args)
        {
            const string neverChangin = "This sentence is permanent, sorta.\n";
            var mysterious = "What kinda variable am I?";
            Console.WriteLine(neverChangin + mysterious);

            Constructors soKool = new Constructors("Farnsworth");
            Console.WriteLine(soKool.Name + " is " + soKool.Age + " years old.");

        }
    }
}
