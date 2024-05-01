using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        int input = -1;
        int sum = 0;
        float average;
        int maxNumber;

        while (input != 0)
        {
            Console.WriteLine("Enter a number: ");
            input = int.Parse(Console.ReadLine());
            numbers.Add(input);
        }

        foreach (int number in numbers)
        {
            sum = sum + number;
        }

        average = sum / numbers.Count;
        maxNumber = numbers.Max();

        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {maxNumber}");
    }
}