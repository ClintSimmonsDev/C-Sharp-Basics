using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    public class Employee
    {
        public string Name { get; set; }
        public int Id { get; set; }

        //Overloader active && Id's the same = true
        //Overloader NOT active || Id's NOT the same = false
        public static bool operator ==(Employee Randy, Employee Gertrude)
        {
            return Randy.Id.Equals(Gertrude.Id);
        }
        public static bool operator !=(Employee Randy, Employee Gertrude)
        {
            return !Randy.Id.Equals(Gertrude.Id);
        }
    }
}
