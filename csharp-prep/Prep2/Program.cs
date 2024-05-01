using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.WriteLine("What is your grade percentage? ");
        string percentage = Console.ReadLine();
        int convertedPercentage = int.Parse(percentage);
        string letter;

        if (convertedPercentage >= 90)
        {
            letter = "A";
        }
        else if (convertedPercentage >= 80)
        {
            letter = "B";
        }
        else if (convertedPercentage >= 70)
        {
            letter = "C";
        }
        else if (convertedPercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"You have a {letter}");

        if (convertedPercentage >= 70)
        {
            Console.WriteLine("Congratulation! You passed the class");
        }
        else 
        {
            Console.WriteLine("Sorry, you failed. Try again, you can do it!");
        }
    }
}