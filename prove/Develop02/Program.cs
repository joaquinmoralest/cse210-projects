using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        Dictionary<int, string> userOptions = new Dictionary<int, string>();
        userOptions.Add(1, "Write");
        userOptions.Add(2, "Display");
        userOptions.Add(3, "Load");
        userOptions.Add(4, "Save");
        userOptions.Add(5, "Quit");

        int selectedOption = 0;

        while (selectedOption != 5)
        {
            foreach (int key in userOptions.Keys)
            {
                Console.WriteLine($"{key}. {userOptions[key]}");
            }
            Console.Write("What do you like to do?: ");
            selectedOption = int.Parse(Console.ReadLine());

            if (selectedOption == 1)
            {
                Entry newEntry = new Entry().Create();
                journal._entries.Add(newEntry);
            }
            else if (selectedOption == 2)
            {
                journal.Display();
            }
            else if (selectedOption == 3)
            {
                journal.Load();
            }
            else if (selectedOption == 4)
            {
                journal.Save();
            }
            else if (selectedOption == 5)
            {
                Console.WriteLine("Bye!");
            }
            else
            {
                Console.WriteLine("Enter a valid option");
            }
        }
    }
}