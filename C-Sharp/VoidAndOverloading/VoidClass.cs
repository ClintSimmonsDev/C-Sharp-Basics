using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidAndOverloading
{
    public class VoidClass
    {
        //Output Method
        public void NumberStuff(out int x)
        {
            int cool = 500000000;
            x = cool;
        }
            //Void method
            public void KoolMethod(int int1)
        {
            int1 /= 2;
            Console.WriteLine(int1);
        }

        //Overloaded methods
        public int FreshInt(int sweetInt1, int sweetInt2 = 400)
        {
            sweetInt1 *= 2;
            return sweetInt1 + sweetInt2;
        }

        public decimal FreshInt(decimal sweetDec1, decimal sweetDec2 = 400m)
        {
            sweetDec1 *= 50;
            return sweetDec1 + sweetDec2;
        }

        //Static method
        public static void CoolString()
        {
            Console.WriteLine("You done did it");
        }
    }
}
