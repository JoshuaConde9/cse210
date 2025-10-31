using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int gradeInt = int.Parse(grade);
        string gradeLetter = "A";

        if (gradeInt >= 90)
        {
            gradeLetter = "A";
        }
        else if (gradeInt >= 80)
        {
            gradeLetter = "B";
        }
        else if (gradeInt >= 70)
        {
            gradeLetter = "C";
        }
        else if (gradeInt >= 60)
        {
            gradeLetter = "D";
        }
        else if (gradeInt < 60)
        {
            gradeLetter = "F";
        }


        Console.WriteLine($"Your grade letter is an {gradeLetter}!");


        if (gradeInt >= 70)
        {
            Console.WriteLine("Congratulations, you passed the class!");
        }
        else
        {
            Console.WriteLine("Unfortunately, you did not pass the class, but you can do better next Block!");
        }

    }
}