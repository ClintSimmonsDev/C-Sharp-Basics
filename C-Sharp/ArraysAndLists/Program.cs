using System;
using System.Collections.Generic;


    class Program
    {
        static void Main()
        {

        string[] stringArray1 = { "Indubitably", "Splendiferous", "Absofreakinlutely", "Ginormous", "Fantabulous" };
        Console.WriteLine("Hello, please select a Mystery Word, between 0 and 4: ");
        int chosenString = Convert.ToInt32(Console.ReadLine());
        if (chosenString > 4)
        {
            Console.WriteLine("Sorry bub, it's gotta be between 0 and 4! No Mystery Word for you!\n");
        }
        else Console.WriteLine("Wow, your Magic Word is: " + stringArray1[chosenString] + "!\n");

        int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };
        Console.WriteLine("Now, please select a Cash Door to open, between 0 and 6: ");
        int chosenInt = Convert.ToInt32(Console.ReadLine());
        if (chosenInt > 6)
        {
            Console.WriteLine("Bummer, it's gotta be between 0 and 6! No Cash Money for you!\n");
        }
        else Console.WriteLine("Congrats, that door contained $" + numArray2[chosenInt] + "!\n");

        List<string> stringList = new List<string>()
        {
            "Bird",
            "Fox",
            "Whale",
            "Slug",
            "Monkey",
            "Bear"
        };

        Console.WriteLine("Finally, you need to know your Lucky Animal. You just do. \nPick a cage between 0 and 5: ");
        int chosenAnimal = Convert.ToInt32(Console.ReadLine());
        if (chosenAnimal > 5)
        {
            Console.WriteLine("Look, it's gotta be between 0 and 5! I guess you're Unlucky!\n");
        }
        else Console.WriteLine("That cage contains... a " + stringList[chosenAnimal] + "!\nYour lucky animal!");
        Console.ReadLine();
    }
    }

