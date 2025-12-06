using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine();
            Console.Write("Choose an activity: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    new BreathingActivity().Run();
                    break;
                case "2":
                    new ReflectingActivity().Run();
                    break;
                case "3":
                    new ListingActivity().Run();
                    break;
                case "4":
                    running = false;
                    continue;
                default:
                    Console.WriteLine("Invalid option. Press Enter...");
                    Console.ReadLine();
                    continue;
            }

            // Ask user if they want to continue AFTER the activity
            Console.WriteLine();
            Console.Write("Would you like to choose another activity? (y/n): ");
            string again = Console.ReadLine().ToLower();

            if (again != "y")
            {
                running = false;
                Console.WriteLine("\nGoodbye!");
            }
        }
    }
}
