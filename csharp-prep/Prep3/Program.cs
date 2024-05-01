using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 11);
        int guess = 0;

        Console.WriteLine("Guess the number!");

        while (guess != magicNumber)
        {
            Console.WriteLine("What is your guess? ");
            string guessAnswer = Console.ReadLine();
            guess = int.Parse(guessAnswer);

            if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else 
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}