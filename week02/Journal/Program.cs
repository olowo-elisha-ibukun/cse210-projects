using System;

/*
Exceeding requirements:
- Added moood and time of day to each journal entry.
- Saved entries in CSV format for Excel compatibility.
*/

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select one of the following options:\n");
        Journal theJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        bool running = true;

        while (running)
        {
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal");
            Console.WriteLine("4. Load journal ");
            Console.WriteLine("5. Quit");
            Console.WriteLine("Choose an option: ");
            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    Entry newEntry = new Entry();
                    newEntry._date = DateTime.Now.ToShortDateString();
                    newEntry._time = DateTime.Now.ToShortTimeString(); // Exceeding requirements: capture time of day
                    newEntry._promptText = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"Prompt: {newEntry._promptText}");
                    Console.Write("Your response: ");
                    newEntry._entryText = Console.ReadLine();
                    Console.Write("Your mood today: "); // Exceeding requirements: capture user mood
                    newEntry._mood = Console.ReadLine();
                    theJournal.AddEntry(newEntry);
                    Console.WriteLine();
                    break;


                case "2":
                    theJournal.DisplayAll();
                    break;

                case "3":
                    Console.Write("Enter the filename to save: ");
                    string saveFile = Console.ReadLine();
                    theJournal.SaveToFile(saveFile);
                    Console.WriteLine("Journal saved successfully!\n");
                    break;
                    
                case "4":
                    Console.Write("Enter the filename to load: ");
                    string loadFile = Console.ReadLine();
                    theJournal.LoadFromFile(loadFile);
                    Console.WriteLine("Journal loaded successfully!\n");
                    break;

                case "5":
                    running = false;
                    Console.WriteLine("Exiting the program. Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Try again.\n");
                    break;
            }
        }

    }
}