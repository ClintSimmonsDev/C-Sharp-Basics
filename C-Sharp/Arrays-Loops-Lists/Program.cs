using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Loops_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray1 = new string[5] { "Blargon ", "Framille ", "Polskad ", "Vermquist ", "Harnsforth " };
            Console.WriteLine("Please enter a weird last name.");
            string lastName = Console.ReadLine();
            Console.WriteLine("You've created this beautiful family. Meet: ");
            foreach (string name in stringArray1)
            {
                Console.WriteLine(name + lastName);
            }

            //This "fixed" infinite loop is also my solution to Part 4 of the assignment.
            int x = 0;
            while (x < 5)
            {
                Console.WriteLine(x + "!");
                x++;
            }
            Console.ReadLine();

            int j = 0;
            while (j <= 10)
            {
                Console.WriteLine(j + ": You'll never get to 11!");
                j++;
                Console.ReadLine();
            }

            List<string> stringList = new List<string> { "bill", "john", "steve", "joe", "matt", "eric" };
            Console.WriteLine("Guess a common male name: ");
            string nameGuess = Console.ReadLine();
            foreach (string name in stringList)
            {
                if (nameGuess == name)

                {
                    int nameIndex = stringList.IndexOf(nameGuess);
                    Console.WriteLine("\nThat name is on the Secret List, at index " + nameIndex);
                    break;
                }

                if (!stringList.Contains(nameGuess))
                {
                    Console.WriteLine("\nThat name's not on the Secret List. Bummer");
                    break;
                }
            }
            List<string> colorList = new List<string> { "fuchsia", "silver", "maroon", "beige", "cyan", "taupe", "silver" };
            Console.WriteLine("Guess an interesting color name: ");
            string colorGuess = Console.ReadLine();
            if (!colorList.Contains(colorGuess))
            {
                Console.WriteLine("\nThat color's not on the Cool Color List. Bummer");
            }
            int counter = 0;
            foreach (string color in colorList)
            {
                if (color == colorGuess)
                {
                    int colorIndex = counter;
                    Console.WriteLine("\nThat color is on the Cool Color List, at index " + colorIndex);
                    counter++;
                }
                else counter++;
            }
            Console.ReadLine();

            List<string> letterList = new List<string> { "a", "b", "c", "d", "e", "f", "c" };
            List<string> finalList = new List<string> { };
            foreach (string letter in letterList)
            {
                if (finalList.Contains(letter))
                {
                    finalList.Add(letter);
                    Console.WriteLine(letter + ": This one IS already in the list!");
                }
                else
                {
                    finalList.Add(letter);
                    Console.WriteLine(letter + ": This letter isn't yet in the list.");
                }
            }
        }
    }
}
