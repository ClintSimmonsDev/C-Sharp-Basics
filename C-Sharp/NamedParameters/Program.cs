using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamedParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            CoolMethod Neato = new CoolMethod();
            Neato.RadMethod(5, 10);
            Console.ReadLine();
            Neato.RadMethod(int1: 50, int2: 500);
        }
    }
}
