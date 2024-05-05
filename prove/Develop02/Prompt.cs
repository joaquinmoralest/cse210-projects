public class Prompt()
{
    static Random random = new Random();
    private List<string> _promptOptions = new List<string>();
    public string _currentPrompt = "";

    private void LoadPromps()
    {
        _promptOptions = [
            "What are you grateful today?",
            "What do you learn today?",
            "There was something that made you smile?",
            "How did you feel today?",
            "What new thing did you do today?",
        ];
    }

    public void SelectPromp()
    {
        LoadPromps();
        int index = random.Next(_promptOptions.Count);
        _currentPrompt = _promptOptions[index];
    }
}