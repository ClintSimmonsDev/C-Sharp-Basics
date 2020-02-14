using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMethods
{
    public class MathClass
    {
        public int Add3k(int num1)
        {
            num1 += 3000;
            return num1;
        }
        public int DivideBy8(int num2)
        {
            num2 /= 8;
            return num2;
        }
        public int MultiplyBy365(int num3)
        {
            num3 *= 365;
            return num3;
        }
    }
}
