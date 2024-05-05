public class Entry() 
{
    public string _date = "";
    public string _prompt = "";
    public string _text = "";

    public Entry Create()
    {
        Prompt promptGenerator = new Prompt();
        promptGenerator.SelectPromp();
        _prompt = promptGenerator._currentPrompt;
        Console.WriteLine(_prompt);
        _text = Console.ReadLine();
        SaveDate();

        return this;
    }

    private void SaveDate()
    {
        DateTime currentDate = DateTime.Now;
        _date = currentDate.ToShortDateString();
    }
}