using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        string option = "";
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");

        while (option != "quit" && !scripture.IsCompletelyHidden())
        {   
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            scripture.HideRandomWords(3);
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            option = Console.ReadLine();
        }
    }
}

// To exceed requirements, I improve the HideRandomWords function to randomly select only those words that are not already hidden