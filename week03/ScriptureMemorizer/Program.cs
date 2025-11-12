// Exceeding Requirments:
// Program can randomly select from a library of scriptures, not just one fixed verse.
// User can press Enter to hide words OR type 'quit' to stop anytime.
// Program ensures only visible words get hidden (avoiding wasted random choices)

using System;

using System.Collections.Generic;

 class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Scripture Memorizer!");
        Console.WriteLine("Press Enter to hide words, or type 'quit' to exit.\n");
        Console.ReadLine();

        // Library of scriptures
        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture(new Reference("John", 3, 16), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),
            new Scripture(new Reference("Psalm", 23, 1, 4), "The Lord is my shepherd; I shall not want. Yea, though I walk through the valley of the shadow of death, I will fear no evil: for thou art with me; thy rod and thy staff they comfort me."),
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all your thine heart; and lean not unto thine own understanding; in allthy ways acknowledge him, and he wshall direct your paths."),
            new Scripture(new Reference("Philippians", 4, 13), "I can do all things through Christ which strentheneth me."),
            new Scripture(new Reference("Romans", 8, 28), "And we know that all things work together for good to them that love God, to them who are the called according to his purpose.")
        };

        // Pick a random scripture
        Random rand = new Random();
        Scripture scripture = scriptures[rand.Next(scriptures.Count)];

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");

            string input = Console.ReadLine();

            if (input?.ToLower() == "quit")
                break;

            scripture.HideRandomWords(3); // Hide 3 words at a time

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nAll words are hidden. Program ending...");
                break;
            }
        }
    }
}