using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMethods
{
    public class MathClass2
    {
        public int Times6(int num1)
        {
            num1 *= 6;
            return num1;
        }
        public decimal Times6(decimal num2)
        {
            num2 *= 250;
            return num2;
        }
        public int Times6(string num3)
        {
            int intNum3 = Convert.ToInt32(num3);
            intNum3 -= 455;
            return intNum3;
        }
    }
}