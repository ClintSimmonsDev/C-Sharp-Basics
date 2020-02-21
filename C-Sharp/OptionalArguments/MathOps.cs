using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalArguments
{
    public class MathOps
    {
        public int MathStuff(int num1, int num2 = 88)
        {
            return num1 + num2;
        }
    }
}
