using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumberInt = randomGenerator.Next(1, 100);

        Console.WriteLine("Welcome to the Magic Number Game!");
        Console.Write("What is your guess? ");
        string guess = Console.ReadLine();
        int guessInt = int.Parse(guess);

        while (guessInt != magicNumberInt)
            if (guessInt < magicNumberInt)
            {
                Console.WriteLine("Higher");
                Console.Write("What is your guess? ");
                guess = Console.ReadLine();
                guessInt = int.Parse(guess);
            }
            else if (guessInt > magicNumberInt)
            {
                Console.WriteLine("Lower");
                Console.Write("What is your guess? ");
                guess = Console.ReadLine();
                guessInt = int.Parse(guess);
            }

            Console.Write("Congratulations, you guessed it!");
    }
}