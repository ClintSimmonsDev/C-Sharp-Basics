using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling2
{
    public class WiseGuyException : Exception
    {
        public WiseGuyException() : base() { }
        public WiseGuyException(string message)
            : base(message) { }
    }
}
