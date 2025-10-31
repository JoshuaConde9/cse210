using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        Console.Write("Enter number: ");
        string number = Console.ReadLine();
        int numberInt = int.Parse(number);
        int sum = 0;

        while (numberInt != 0)
        {
            sum = sum + numberInt;
            numbers.Add(numberInt);
            Console.Write("Enter number: ");
            number = Console.ReadLine();
            numberInt = int.Parse(number);
        }

        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int largestNumber = numbers[0];
        foreach (int num in numbers)
        {
            if (num > largestNumber)
            {
                largestNumber = num;
            }
        }
        Console.WriteLine($"The largest number is: {largestNumber}");
    }
}