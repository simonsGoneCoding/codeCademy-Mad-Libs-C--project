using System;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            This program Mad Libs are short stories with blanks for the player to fill in that represent different parts of speech. The end result is a really hilarious and strange story.
            Author: Szymon Warszawa
            */


            // Let the user know that the program is starting:
            Console.WriteLine("Running...");

            // Give the Mad Lib a title:
            string title = "Games of words";

            Console.WriteLine(title);
            // Define user input and variables:
            Console.Write("Enter a name: ");
            string name = Console.ReadLine();

            Console.Write("Enter first adjective: ");
            string adjOne = Console.ReadLine();

            Console.Write("Enter second adjective: ");
            string adjTwo = Console.ReadLine();

            Console.Write("Enter third adjective: ");
            string adjThree = Console.ReadLine();

            Console.Write("Enter a verb: ");
            string verb = Console.ReadLine();

            Console.Write("Enter first noun: ");
            string nounOne = Console.ReadLine();

            Console.Write("Enter second noun: ");
            string nounTwo = Console.ReadLine();

            Console.Write("Enter an animal: ");
            string animal = Console.ReadLine();

            Console.Write("Enter a name of food: ");
            string food = Console.ReadLine();

            Console.Write("Enter a fruit: ");
            string fruit = Console.ReadLine();
            
            Console.Write("Enter superhero: ");
            string hero = Console.ReadLine();

            Console.Write("Enter country: ");
            string country = Console.ReadLine();

            Console.Write("Enter dessert: ");
            string dessert = Console.ReadLine();

            Console.Write("Enter year: ");
            string year = Console.ReadLine();


            // The template for the story:

            string story = $"This morning {name} woke up feeling {adjOne}. 'It is going to be a {adjTwo} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {nounOne}, which made all the {fruit}s very {adjThree}. Concerned, {name} texted {hero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {nounTwo}s ruled the world.";


            // Print the story:
            Console.WriteLine(story);

        }
    }
}