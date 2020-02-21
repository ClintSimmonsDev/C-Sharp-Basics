using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Oh hey. How old are you?");
                int validAge = Convert.ToInt32(Console.ReadLine());
                if (validAge < 1 || validAge > 120)
                {
                    throw new WiseGuyException();
                }
                DateTime rightNow = DateTime.Now;
                DateTime yearBorn = rightNow.AddYears(-validAge);
   
                Console.WriteLine("Cool, well you must've been born in either " + yearBorn.Year + ", or " + (yearBorn.Year -1) + "!");
            }
            catch (WiseGuyException)
            {
                Console.WriteLine("Oh we got a funny guy over here, eh?");
                Console.ReadLine();
            }
            catch (Exception)
            {
                
                Console.WriteLine("System errors have occurred. Try again later.");
                Console.ReadLine();
            }
        }
    }
}
