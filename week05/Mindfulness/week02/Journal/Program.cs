using System;

class Program
{
    static void Main()
    {
        Journal journal = new();
        PromptGenerator promptGen = new();

        while (true)
        {
            Console.WriteLine("Journal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal entries");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string prompt = promptGen.GetRandomPrompt();
                    Console.WriteLine($"\nPrompt: {prompt}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();
                    journal.AddEntry(prompt, response);
                    Console.WriteLine("Entry added!\n");
                    break;

                case "2":
                    Console.WriteLine("\nJournal Entries:");
                    journal.DisplayEntries();
                    break;

                case "3":
                    Console.Write("Enter filename to save journal: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    Console.WriteLine("Journal saved.\n");
                    break;

                case "4":
                    Console.Write("Enter filename to load journal: ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    Console.WriteLine("Journal loaded.\n");
                    break;

                case "5":
                    Console.WriteLine("Exiting program.");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }
}
