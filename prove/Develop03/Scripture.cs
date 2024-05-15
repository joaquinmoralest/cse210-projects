public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        foreach (string word in text.Split(" "))
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        for (int i = 1; i <= numberToHide; i++)
        {
            Random random = new Random();
            int wordIndex = random.Next(0, _words.Count);
            while (_words[wordIndex].IsHidden())
            {
                wordIndex = random.Next(0, _words.Count);
            }
            _words[wordIndex].Hide();
        }

    }

    public string GetDisplayText()
    {
        string fullScripture = "";
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                fullScripture += word.GetDisplayText() + " ";
            } else
            {
                foreach (char letter in word.GetDisplayText())
                {
                    fullScripture += "_";
                }
                fullScripture += " ";
            }
        }

        return $"{_reference.GetDisplayText()} {fullScripture}";
    }

    public bool IsCompletelyHidden()
    {
        int count = 0;

        foreach (Word word in _words)
        {
            if (word.IsHidden())
            {
                count++;
            }    
        }

        if (count == _words.Count)
        {
            return true;
        } else 
        {
            return false;
        }
    }
}