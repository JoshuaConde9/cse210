using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Moroni", 10, 4, 5);
        string text = "And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost. And by the power of the Holy Ghost ye may know the truth of all things.";
        Scripture scripture = new Scripture(reference, text);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue or type 'quit' to finish.");

            string input = Console.ReadLine().ToLower();


            if (input == "quit")
            {
                Console.WriteLine();
                Console.WriteLine("Thank you for using the Scripture Memorizer!");
                break;
            }

            scripture.HideRandomWords(3);

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine();
                Console.WriteLine("All words are now hidden. Thank you for using the Scripture Memorizer!");
                break;
            }
        }
    }
}
