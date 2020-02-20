using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstChainAndVar
{
    public class Constructors
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Constructors(string name) : this(name, 55)
        {

        }
        public Constructors(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
