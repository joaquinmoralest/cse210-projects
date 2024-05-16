using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Joaquin Morales", "Programming");
        MathAssignment mathAssignment = new MathAssignment("Juan Perez", "Fractions", "7.3", "8-19");
        WrittingAssignment writtingAssignment = new WrittingAssignment("Elba Lazo", "English", "A great book");

        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());
        Console.WriteLine(writtingAssignment.GetSummary());
        Console.WriteLine(writtingAssignment.GetWrittingInformation());
    }
}