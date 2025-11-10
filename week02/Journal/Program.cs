using System;

class Program
{
    static void Main(string[] args)
    {
        JournalEntries journal = new JournalEntries();
        Console.WriteLine("Welcome to the Journal Program!");

        string choices = "";

        while (choices != "5")
        {
            Console.WriteLine();
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            choices = Console.ReadLine();
            Console.WriteLine();

            if (choices == "1")
            {
                Entry entry = new Entry();
                entry.RecordEntry();
                journal.AddEntry(entry);
            }

            else if (choices == "2")
            {
                journal.DisplayAll();
            }

            else if (choices == "3")
            {
                Console.WriteLine("What is the filename? ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }

            else if (choices == "4")
            {
                Console.WriteLine("What is the filename? ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }

            else if (choices == "5")
            {
                Console.Write("Thank you for using the Journal Program.");
            }

            else
            {
                Console.WriteLine("Please choose a valid option.");
            }
        }

    }
}
