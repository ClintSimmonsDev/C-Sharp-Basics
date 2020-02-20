using System;
using System.IO;


namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey. Yeah you. I need a number.");
            string userNum = Console.ReadLine();
            File.WriteAllText(@"C:\Users\Transfixed\Documents\GitHub\C-Sharp-Basics\C-Sharp\FileIO\GreatestFile.txt", userNum);
            Console.WriteLine("Cool, I've stored that number somewhere safe. \nWait a sec, let me go get it for you...");
            string output = File.ReadAllText(@"C:\Users\Transfixed\Documents\GitHub\C-Sharp-Basics\C-Sharp\FileIO\GreatestFile.txt");
            Console.WriteLine(output);

        }
    }
}
